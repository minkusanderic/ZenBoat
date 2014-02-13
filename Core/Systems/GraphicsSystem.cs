using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment ;
using Sce.PlayStation.HighLevel.Model ;
using Sce.PlayStation.HighLevel.UI ;
using System.Threading ;
using System.Diagnostics ;

namespace Core
{
	public class GraphicsSystem : Core.CoreSystem
	{
		
		private List<ModelComponent> models = new List<ModelComponent>();
		private List<SpriteComponent> sprites = new List<SpriteComponent>();
		private List<LabelComponent> labels = new List<LabelComponent>();
		
		public GraphicsContext graphics;
		public BasicProgram program;
		private BasicParameters parameters;
		public Scene scene;
		public Label count;
		
		public Vector3 camera_pos = new Vector3();
		public Vector3 camera_eye = new Vector3();
		
		private Texture2D toon;
		
		private List<Texture2D> tex_list = new List<Texture2D>();
		
		private float time = 0.0f;
		
		//private Dictionary<String, Texture2D> textures = new Dictionary<String, Texture2D>();
		//BasicModel model;
		public GraphicsSystem ()
		{
			graphics = new GraphicsContext();
			program = new BasicProgram();
			parameters = program.Parameters;
		 	program = new BasicProgram("/Application/shaders/Basic.cgx" , null , parameters );
			scene = new Scene();
			//Timer.Init();
			
			UISystem.Initialize(graphics);
			UISystem.SetScene(scene, null);
		
			toon = new Texture2D("/Application/Assets/toon.png", false);
			
			//model = new BasicModel(	"/Application/resources/Cube.mdx" , 0); 	
		}
		float cameraOffset = 0f;
		float eps = 300f;
		Vector3 cameraLastPosition;
		Vector3 UpdateCameraPosition()
		{
			Vector2 boatPosition = SceneManager.Instance.FindEntity("Boat").Transform.Position;
			//Console.WriteLine( boatPosition );

			// HAndle first-left edgef
			// Handle first-left edge
			if ( boatPosition.X > 960.0f/2.0f )
			{
				// camera pos + half screen width
				
				if ( eps + cameraOffset < boatPosition.X - eps)
					cameraOffset = boatPosition.X - 2*eps;
				if ( cameraOffset  > boatPosition.X - eps/2)
					cameraOffset = boatPosition.X - eps/2;
				//if ( (this.camera_pos.X- 480f ) > boatPosition.X )
				//	cameraOffset = boatPosition.X - 960.0f/2.0f;
			}
			else
			{
				if ( cameraOffset  > boatPosition.X - eps/2)
					cameraOffset = boatPosition.X - eps/2;
				if ( cameraOffset <= 0f ) cameraOffset = 0f; // remove this to get a nice buffer on the left most edge of the level
			}
			
			//cameraOffset += 1f;
			return new Vector3(960.0f/2.0f + cameraOffset, 0f , (960.0f/2.0f)/ (1.77f * FMath.Tan(FMath.Radians(45.0f/2.0f)) ));
		}
		
		
		public override void Update() // Render here
		{	
			UISystem.SetScene(scene, null);
			//Timer.StartFrame();
			this.camera_pos = UpdateCameraPosition();
			cameraLastPosition = this.camera_pos;
			this.camera_eye = new Vector3( 960f/2f + cameraOffset , 544f/2f  , 0f  );//new Vector3( 960.0f/2.0f, 544.0f/2.0f , 0.0f + 100f );
			Matrix4 proj = Matrix4.Perspective( FMath.Radians( 45.0f ), graphics.Screen.AspectRatio, 1.0f, 1000000.0f ) ;
			Matrix4 view = Matrix4.LookAt(  camera_pos,
											camera_eye,
											new Vector3( 0.0f, 1.0f, 0.0f ) ) ;
			Vector3 litDirection = new Vector3( 0.0f, 0.0f, -1.0f ).Normalize() ;
			Vector3 litDirection2 = new Vector3( 0.0f, 1.0f, 0.0f ).Normalize() ;
			Vector3 litColor = new Vector3( 1.0f, 1.0f, .8f ) ;
			Vector3 litColor2 = new Vector3( 0.0f, 0.0f, 0.0f ) ;
			Vector3 litAmbient = new Vector3( 0.1f, 0.1f, 0.1f ) ;
			Vector3 fogColor = new Vector3( 0.0f, 0.5f, 1.0f ) ;
	
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
	
			
			//adjust position
			
			//Setup Model Shader
			//var basic_parameters = new BasicParameters();
			//var basic_program = new BasicProgram("/Application/shaders/Basic.cgx" , null , parameters );
			//var basic_program_container = new BasicProgramContainer( basic_parameters );
			//basic_program_container.Add("SIMPLE", basic_program);
			
			
			foreach(var model in models)
			{
				if ( !model.parent.Enabled ) continue;
				if ( Math.Abs(model.parent.Transform.Position.X - camera_pos.X) > (960 + model.model.BoundingSphere.W)) continue; // do not render if off screen
				Matrix4 world = Matrix4.Identity ;
				
				if ( model.model.BoundingSphere.W != 0.0f ) {
					Vector3 scale = model.scale;
					
					Vector3 pos = new Vector3(model.parent.Transform.Position.X, model.parent.Transform.Position.Y, model.parent.Transform.Z);
					
					//Console.WriteLine( model.parent.Name+"--" + pos );
					world *= Matrix4.Translation(pos) ;
					world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
					world *= Matrix4.RotationX(FMath.Radians(90.0f));
					world *= Matrix4.RotationY (-model.parent.Transform.Rotation.Angle(Vector2.UnitX));
					
				}
				
				//model.model.BindPrograms( basic_program_container );
			    //  draw model, animate model
				model.model.SetWorldMatrix( ref world ) ;
				model.model.Animate( .01f ) ;
				model.model.Update() ;
				graphics.SetTexture(1, toon);
				model.model.Draw(graphics, program) ;
			}
			
			foreach(var sprite in sprites)
			{
				if ( !sprite.parent.Enabled ) continue;
				if ( Math.Abs(sprite.parent.Transform.Position.X - camera_pos.X) > (544 + 300)) continue; // do not render if off screen
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(sprite.scale.X, sprite.scale.Y, 1f);
					
				Vector3 pos = new Vector3(sprite.parent.Transform.Position.X, sprite.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos);
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				world *= Matrix4.RotationZ (-sprite.parent.Transform.Rotation.Angle(Vector2.UnitX));
				
				
				graphics.SetVertexBuffer(0, sprite.vb);
				graphics.SetShaderProgram(sprite.shaderProgram);
				graphics.SetTexture(0, sprite.texture);
							

				var world_view_proj = proj * view * world;
				program.Parameters.SetWorldMatrix(0, ref world);
				sprite.shaderProgram.SetUniformValue(0, ref world_view_proj);	
			
				graphics.DrawArrays(DrawMode.TriangleStrip, 0, 4);
			}
			
//			foreach(var l in labels)
//			{
//				l.label.Text = l.title + l.number;
//			}
			
	
			((WaterSystem)SceneManager.Instance.getSystem(typeof(WaterSystem))).Render(this, proj, view, this.camera_eye);
			((ParticleSystem)SceneManager.Instance.getSystem(typeof(ParticleSystem))).Render(this, proj, view);
			graphics.Disable( EnableMode.CullFace ) ;
			graphics.Disable( EnableMode.DepthTest ) ;
			//SampleDraw.DrawText( "BasicModel Sample", 0xffffffff, 0, 0 ) ;
			UISystem.Render();
			graphics.SwapBuffers() ;
			//Timer.EndFrame();
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
			
			if(comp is LabelComponent)
			{
				labels.Add((LabelComponent)comp);
				scene.RootWidget.AddChildFirst(((LabelComponent)comp).label);
				((LabelComponent)comp).label.X = comp.parent.Transform.Position.X;
				((LabelComponent)comp).label.Y = comp.parent.Transform.Position.Y;
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
			
			if ( comp is LabelComponent )
			{
				labels.Remove((LabelComponent)comp);
				scene.RootWidget.RemoveChild(((LabelComponent)comp).label);
			}
			//base.destroyComponent (comp);
		}
		
	}
}

