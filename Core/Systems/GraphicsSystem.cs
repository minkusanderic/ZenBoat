using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment ;
using Sce.PlayStation.HighLevel.Model ;
using Sce.PlayStation.HighLevel.UI;
using System.Threading ;
using System.Diagnostics ;

using Sce.PlayStation.Core.Input;
namespace Core
{
	public class GraphicsSystem : Core.System
	{
		
		private List<ModelComponent> models = new List<ModelComponent>();
		private List<SpriteComponent> cubes = new List<SpriteComponent>();
		public GraphicsContext graphics;
		public BasicProgram program;
		
		
		//private Dictionary<String, Texture2D> textures = new Dictionary<String, Texture2D>();
		//BasicModel model;
		public GraphicsSystem ()
		{
			graphics = new GraphicsContext();
			program = new BasicProgram();
			
			UISystem.Initialize(graphics);
			
			Scene scene = new Sce.PlayStation.HighLevel.UI.Scene();
			 Label label = new Label();
            label.X = 10.0f;
            label.Y = 50.0f;
            label.Text = "Hello World!";
            scene.RootWidget.AddChildLast(label);
			
			Button textButton = new Button();
			textButton.Text = "OK";
			textButton.ButtonAction += HandleButtonAction;
			scene.RootWidget.AddChildLast(textButton);
            // Set scene
            UISystem.SetScene(scene, null);
			//model = new BasicModel(	"/Application/resources/Cube.mdx" , 0); 	
		}
		
		private void HandleButtonAction(object sender, TouchEventArgs e)
		{
			Console.WriteLine("Shiver Me Timbers...");	
		}
		
		public override void Update() // Render here
		{
			Matrix4 proj = Matrix4.Perspective( FMath.Radians( 45.0f ), graphics.Screen.AspectRatio, 1.0f, 1000000.0f ) ;
			Matrix4 view = Matrix4.LookAt( new Vector3( 960.0f/2.0f, 544.0f/2.0f, (960.0f/2.0f)/ (1.77f * FMath.Tan(FMath.Radians(45.0f/2.0f)) )),
											new Vector3( 960.0f/2.0f, 544.0f/2.0f, 0.0f ),
											new Vector3( 0.0f, 1.0f, 0.0f ) ) ;
			Vector3 litDirection = new Vector3( 1.0f, -1.0f, -1.0f ).Normalize() ;
			Vector3 litDirection2 = new Vector3( 0.0f, 1.0f, 0.0f ).Normalize() ;
			Vector3 litColor = new Vector3( 1.0f, 1.0f, 1.0f ) ;
			Vector3 litColor2 = new Vector3( 1.0f, 0.0f, 0.0f ) ;
			Vector3 litAmbient = new Vector3( 0.3f, 0.3f, 0.3f ) ;
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
			parameters.SetFogRange( 10.0f, 5000.0f ) ;
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
	
			
			//  adjust position
			
			foreach(var model in models)
			{
				Matrix4 world = Matrix4.Identity ;
				
				if ( model.model.BoundingSphere.W != 0.0f ) {
					Vector3 scale = model.scale;
					
					Vector3 pos = new Vector3(model.parent.Transform.Position.X, model.parent.Transform.Position.Y, 0);
					
					//Console.WriteLine( model.parent.Name+"--" + pos );
					world *= Matrix4.Translation(pos) ;
					world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				}
				
				model.model.SetWorldMatrix( ref world ) ;
				//model.Animate( SampleTimer.DeltaTime ) ;
				model.model.Update() ;
				model.model.Draw(graphics, program) ;
			}
			
			foreach(var cube in cubes)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(1,1,1);
					
				Vector3 pos = new Vector3(cube.parent.Transform.Position.X, cube.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				
				graphics.SetVertexBuffer(0, cube.vb);
				graphics.SetShaderProgram(cube.shaderProgram);
				graphics.SetTexture(0, cube.texture);
				

				var world_view_proj = proj * view * world;
				program.Parameters.SetWorldMatrix(0, ref world);
				cube.shaderProgram.SetUniformValue(0, ref world_view_proj);	
			
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
			UISystem.Update(Touch.GetData(0));
			UISystem.Render();
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
				cubes.Add((SpriteComponent)comp);
			}
		}
		
		public override void destroyComponent (IComponent comp)
		{
			if ( comp is ModelComponent)
			{
				models.Remove( (ModelComponent) comp);	
			}
			
			//base.destroyComponent (comp);
		}
		
	}
}

