using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core;


namespace Core
{
	public class GraphicsSystem : Core.System
	{
		
		private List<GraphicsComponent> sprites;
		
		private Dictionary<RectComponent, SpriteUV> rects;
		
		public GraphicsContext graphics;
		public Camera camera;
		
		private Dictionary<String, Texture2D> textures = new Dictionary<String, Texture2D>();

		
		public Scene scene;
		
		public GraphicsSystem ()
		{
			this.sprites = new List<GraphicsComponent>();
			this.rects = new Dictionary<RectComponent, SpriteUV>();
			graphics = new GraphicsContext();
			this.setClearColor(0.0f, 0.0f, 0.0f);
			
			Director.Initialize( 500, 400, graphics);
			scene = new Scene();
			/////
			scene.Camera.SetViewFromViewport();

   
			
   			
			
			///
			Director.Instance.RunWithScene( scene, true );
		

		}
		
		public override void Update()
		{
			updateSprites();
			if(this.camera != null)
				this.camera.Update();
			Sce.PlayStation.Core.Environment.SystemEvents.CheckEvents();				 
				Director.Instance.Update ();
    			Director.Instance.Render();
				Director.Instance.GL.Context.SwapBuffers();
			    Director.Instance.PostSwap();
		}
		
		private void updateSprites()
		{
			foreach(var sprite in this.sprites)
			{
				sprite.sprite.Position = sprite.parent.Transform.Position;
				sprite.sprite.Rotation = sprite.parent.Transform.Rotation;
			}
		}
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is GraphicsComponent)
			{
				this.sprites.Add((GraphicsComponent)comp);
				this.load_sprite((GraphicsComponent)comp);
			}
			if(comp is Camera)
			{
				this.camera = (Camera)comp;
			}
		
		}
		
		private void load_sprite(GraphicsComponent comp)
		{
   			SpriteUV sprite = null;
			if(comp is RectComponent)
			{
				var width = ((RectComponent)comp).width;
				var height = ((RectComponent)comp).height;
  				Image img = new Image(ImageMode.Rgba, new ImageSize(width,height),	
                         new ImageColor(255,0,0,0));
				img.DrawRectangle(new ImageColor(255, 0, 0, 255), new ImageRect(0, 0, width, height));
				
  
   				Texture2D texture = new Texture2D(width,height,false,
                                     PixelFormat.Rgba);
  				texture.SetPixels(0,img.ToBuffer());
   				img.Dispose();                                  
   
   				TextureInfo ti = new TextureInfo();
   				ti.Texture = texture;
   
   				sprite = new SpriteUV();
   				sprite.TextureInfo = ti;
				sprite.Quad.S = ti.TextureSizef;
   				sprite.CenterSprite();
			}
			else if (comp is Sprite2d)
			{			
				String filename = ((Sprite2d)comp).fileName;
				Texture2D texture = null;
				if(textures.ContainsKey(filename))
				{
					texture = textures[filename];
				}
				else
				{
					texture = new Texture2D(filename, false);
					textures[filename] = texture;
				}
				   
   
   				TextureInfo ti = new TextureInfo();
   				ti.Texture = texture;
   
   				sprite = new SpriteUV();
   				sprite.TextureInfo = ti;
				sprite.Quad.S = ti.TextureSizef;
   				sprite.CenterSprite();
				
	
			}
			if(sprite == null)
			{
				throw new ArgumentException("Component not supported");
			}
   			
   			sprite.Position = comp.parent.Transform.Position;
			sprite.Rotation = comp.parent.Transform.Rotation;
   			scene.AddChild(sprite);
			comp.sprite = sprite;
			
   
		}
		
		private void addRectangle(RectComponent comp)
		{
			var width = comp.width;
   			var height = comp.height;
   
  			Image img = new Image(ImageMode.Rgba, new ImageSize(width,height),
                         new ImageColor(255,0,0,0));
			img.DrawRectangle(new ImageColor(255, 0, 0, 255), new ImageRect(0, 0, width, height));
			
  
   			Texture2D texture = new Texture2D(width,height,false,
                                     PixelFormat.Rgba);
  			texture.SetPixels(0,img.ToBuffer());
   			img.Dispose();                                  
   
   			TextureInfo ti = new TextureInfo();
   			ti.Texture = texture;
   
   			SpriteUV sprite = new SpriteUV();
   			sprite.TextureInfo = ti;
   
   			sprite.Quad.S = ti.TextureSizef;
   			sprite.CenterSprite();
   			sprite.Position = scene.Camera.CalcBounds().Center;
   			scene.AddChild(sprite);
			rects[comp] = sprite;
   
		}
	
		
		public void setClearColor(float r, float g, float b)
		{
			graphics.SetClearColor(r, g, b, 0.0f);
		}
		
		public Vector2 GetWorldToPoint(Vector2 screen_point)
		{
			return camera.cam.NormalizedToWorld(	screen_point );
		}
		
	}
}

