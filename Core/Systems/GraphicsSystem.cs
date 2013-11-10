using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment ;
using Sce.PlayStation.HighLevel.Model ;
using System.Threading ;
using System.Diagnostics ;
namespace Core
{
	public class GraphicsSystem : Core.CoreSystem
	{
		
		private List<ModelComponent> models = new List<ModelComponent>();
		private List<SpriteComponent> sprites = new List<SpriteComponent>();
		private List<WaterComponent> waters = new List<WaterComponent>();
		public GraphicsContext graphics;
		public BasicProgram program;
		
		
		//private Dictionary<String, Texture2D> textures = new Dictionary<String, Texture2D>();
		//BasicModel model;
		public GraphicsSystem ()
		{
			graphics = new GraphicsContext();
			program = new BasicProgram();
			//model = new BasicModel(	"/Application/resources/Cube.mdx" , 0); 	
		}
		
		public override void Update() // Render here
		{
			Matrix4 proj = Matrix4.Perspective( FMath.Radians( 45.0f ), graphics.Screen.AspectRatio, 1.0f, 1000000.0f ) ;
			Matrix4 view = Matrix4.LookAt( new Vector3( 960.0f/2.0f, 544.0f/2.0f, (960.0f/2.0f)/ (1.77f * FMath.Tan(FMath.Radians(45.0f/2.0f)) )),
											new Vector3( 960.0f/2.0f, 544.0f/2.0f, 0.0f ),
											new Vector3( 0.0f, 1.0f, 0.0f ) ) ;
			Vector3 litDirection = new Vector3( 0.0f, 0.0f, -1.0f ).Normalize() ;
			Vector3 litDirection2 = new Vector3( 0.0f, 1.0f, 0.0f ).Normalize() ;
			Vector3 litColor = new Vector3( 1.0f, 1.0f, 1.0f ) ;
			Vector3 litColor2 = new Vector3( 0.0f, 0.0f, 0.0f ) ;
			Vector3 litAmbient = new Vector3( 0.1f, 0.1f, 0.1f ) ;
			Vector3 fogColor = new Vector3( 0.0f, 0.5f, 1.0f ) ;
	
			BasicParameters parameters = program.Parameters ;
			parameters.Enable( BasicEnableMode.Lighting, true ) ;
			parameters.Enable( BasicEnableMode.Fog, true ) ;
	
			parameters.SetProjectionMatrix( ref proj ) ;
			parameters.SetViewMatrix( ref view ) ;
			parameters.SetLightCount( 2 ) ;
			parameters.SetLightDirection( 0, ref litDirection ) ;
			parameters.SetLightDiffuse( 0, ref litColor ) ;
			parameters.SetLightSpecular( 0, ref litColor ) ;
			parameters.SetLightDirection( 1, ref litDirection2 ) ;
			parameters.SetLightDiffuse( 1, ref litColor2 ) ;
			parameters.SetLightSpecular( 1, ref litColor2 ) ;
			parameters.SetLightAmbient( ref litAmbient ) ;
			parameters.SetFogRange( -1.0f, 5000.0f ) ;
			parameters.SetFogColor( ref fogColor ) ;
	
			graphics.SetViewport( 0, 0, graphics.Screen.Width, graphics.Screen.Height ) ;
			graphics.SetClearColor( 0.0f, 0.5f, 1.0f, 0.0f ) ;
			graphics.Clear() ;
	
			graphics.Enable( EnableMode.Blend ) ;
			graphics.SetBlendFunc( BlendFuncMode.Add, BlendFuncFactor.SrcAlpha, BlendFuncFactor.OneMinusSrcAlpha ) ;
			graphics.Enable( EnableMode.CullFace ) ;
			graphics.SetCullFace( CullFaceMode.Back, CullFaceDirection.Ccw ) ;
			graphics.Enable( EnableMode.DepthTest ) ;
			graphics.SetDepthFunc( DepthFuncMode.LEqual, true ) ;
	
			
			foreach(var water in waters)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(1,1,1);
					
				Vector3 pos = new Vector3(water.parent.Transform.Position.X, water.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				
				graphics.SetVertexBuffer(0, water.vb);
				graphics.SetShaderProgram(water.shaderProgram);
				//graphics.SetTexture(0, sprite.texture);
				

				var world_view_proj = proj * view * world;
				//program.Parameters.SetWorldMatrix(0, ref world);
				water.shaderProgram.SetUniformValue(0, ref world_view_proj);	
			
				graphics.DrawArrays(DrawMode.Triangles, 0, 486);
			}

			
			//  adjust position
			
			foreach(var model in models)
			{
				Matrix4 world = Matrix4.Identity ;
				
				if ( model.model.BoundingSphere.W != 0.0f ) {
					Vector3 scale = model.scale;
					
					Vector3 pos = new Vector3(model.parent.Transform.Position.X, model.parent.Transform.Position.Y, model.parent.Transform.Z);
					
					//Console.WriteLine( model.parent.Name+"--" + pos );
					world *= Matrix4.Translation(pos) ;
					world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
					world *= Matrix4.RotationX(FMath.Radians(90.0f));
				}
				
				model.model.SetWorldMatrix( ref world ) ;
				//model.Animate( SampleTimer.DeltaTime ) ;
				model.model.Update() ;
				model.model.Draw(graphics, program) ;
			}
			
			foreach(var sprite in sprites)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(1,1,1);
					
				Vector3 pos = new Vector3(sprite.parent.Transform.Position.X, sprite.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				
				graphics.SetVertexBuffer(0, sprite.vb);
				graphics.SetShaderProgram(sprite.shaderProgram);
				graphics.SetTexture(0, sprite.texture);
				

				var world_view_proj = proj * view * world;
				program.Parameters.SetWorldMatrix(0, ref world);
				sprite.shaderProgram.SetUniformValue(0, ref world_view_proj);	
			
				graphics.DrawArrays(DrawMode.TriangleStrip, 0, 4);
			}
			
			//  select motion
			/*
			if ( model.Motions.Length > 1 ) {
				if ( SampleTimer.FrameCount % 120 == 0 ) {
					int next = ( model.CurrentMotion + 1 ) % model.Motions.Length ;
					model.SetCurrentMotion( next, 0.1f ) ;
				}
			}
			*/
			//  draw model
	
			
			
			graphics.Disable( EnableMode.CullFace ) ;
			graphics.Disable( EnableMode.DepthTest ) ;
			//SampleDraw.DrawText( "BasicModel Sample", 0xffffffff, 0, 0 ) ;
	
			graphics.SwapBuffers() ;
		}
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is ModelComponent)
			{
				models.Add((ModelComponent)comp);
			}
			
			if(comp is SpriteComponent)
			{
				sprites.Add((SpriteComponent)comp);
			}
			if(comp is WaterComponent)
			{
				waters.Add((WaterComponent)comp);
			}
		}
		
		public override void destroyComponent (IComponent comp)
		{
			if ( comp is ModelComponent)
			{
				models.Remove( (ModelComponent) comp);	
			}
			if ( comp is SpriteComponent )
			{
				sprites.Remove((SpriteComponent)comp);
			}
			
			//base.destroyComponent (comp);
		}
		
	}
}

