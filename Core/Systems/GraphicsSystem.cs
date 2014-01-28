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
		
		public GraphicsContext graphics;
		public BasicProgram program;
		
		public Vector3 camera_pos = new Vector3();
		public Vector3 camera_eye = new Vector3();
		
		private float time = 0.0f;
		
		//private Dictionary<String, Texture2D> textures = new Dictionary<String, Texture2D>();
		//BasicModel model;
		public GraphicsSystem ()
		{
			graphics = new GraphicsContext();
			program = new BasicProgram();
			Timer.Init();
		
			//model = new BasicModel(	"/Application/resources/Cube.mdx" , 0); 	
		}
		float cameraOffset = 0f;
		float eps = 400f;
		Vector3 cameraLastPosition;
		Vector3 UpdateCameraPosition()
		{
			Vector2 boatPosition = SceneManager.Instance.FindEntity("Boat").Transform.Position;
			//Console.WriteLine( boatPosition );
			// HAndle first-left edge
			if ( boatPosition.X > 960.0f/2.0f )
			{
				// camera pos + half screen width
				
				if ( eps + cameraOffset < boatPosition.X - eps )
					cameraOffset = boatPosition.X - 2*eps ;
				if ( cameraOffset  > boatPosition.X - eps/2 )
					cameraOffset = boatPosition.X - eps/2;
				//if ( (this.camera_pos.X- 480f ) > boatPosition.X )
				//	cameraOffset = boatPosition.X - 960.0f/2.0f;
			}
			else
			{
				if ( cameraOffset  > boatPosition.X - eps/2  )
					cameraOffset = boatPosition.X - eps/2  ;
				if ( cameraOffset <= 0f ) cameraOffset = 0f;
			}
			
			//cameraOffset += 1f;
			return new Vector3(960.0f/2.0f + cameraOffset,   0f  , (960.0f/2.0f)/ (1.77f * FMath.Tan(FMath.Radians(45.0f/2.0f)) ));
		}
		bool b = false;
		Entity boat;
		BasicProgram basic_program;
		BasicParameters basic_parameters;
		BasicProgramContainer basic_program_container;
		ModelComponent model_component;
		Texture2D texToon;
		BasicTexture basic_texture;
		BasicTextureContainer basic_texture_container;

		public override void Update() // Render here
		{
			Timer.StartFrame();
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
			
			
			//  adjust position
			
			foreach(var model in models)
			{
				if ( model.parent.Name == "Boat" )
				{
					continue;
				}
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
					
			    //  draw model, animate model
				model.model.SetWorldMatrix( ref world ) ;
				model.model.Animate( .01f ) ;
				model.model.Update() ;
				model.model.Draw(graphics, program) ;
			}
			
			#region
			// boat init 
			
			if ( !b )
			{
				b = true;
				boat = SceneManager.Instance.FindEntity("Boat");
				model_component = (ModelComponent)boat.FindComponent<ModelComponent>();
				

				basic_program = new BasicProgram("/Application/shaders/Basic.cgx" , null , null );
								//basic_parameters = new BasicParameters();
				BasicParameters bparameters = basic_program.Parameters ;
				bparameters.Enable( BasicEnableMode.Lighting, true ) ;
				bparameters.Enable( BasicEnableMode.Fog, true ) ;
	
				bparameters.SetProjectionMatrix( ref proj ) ;
				bparameters.SetViewMatrix( ref view ) ;
				bparameters.SetLightCount( 2 ) ;
				bparameters.SetLightDirection( 0, ref litDirection ) ;
				bparameters.SetLightDiffuse( 0, ref litColor ) ;
				bparameters.SetLightSpecular( 0, ref litColor ) ;
				bparameters.SetLightDirection( 1, ref litDirection2 ) ;
				bparameters.SetLightDiffuse( 1, ref litColor2 ) ;
				bparameters.SetLightSpecular( 1, ref litColor2 ) ;
				bparameters.SetLightAmbient( ref litAmbient ) ;
				bparameters.SetFogRange( -1.0f, 5000.0f ) ;
				bparameters.SetFogColor( ref fogColor ) ;
				//basic_program.SetAttributeBinding( 0 , "a_Position" );
				//basic_program.SetAttributeBinding( 1 , "a_Normal" );
				basic_program_container = new BasicProgramContainer( bparameters );
				basic_program_container.Add( "Basic" , basic_program );
				model_component.model.BindPrograms( basic_program_container );
				
				texToon = new Texture2D( "/Application/Assets/toon.png", false ) ;
        		//texToon.SetFilter( Sce.PlayStation.Core.Graphics.TextureFilterMode.Nearest,
                          // Sce.PlayStation.Core.Graphics.TextureFilterMode.Nearest,
                          // Sce.PlayStation.Core.Graphics.TextureFilterMode.Disabled );
				//texToon.
				basic_texture_container = new BasicTextureContainer();
				basic_texture_container.Add("ToonTex" , texToon );
				model_component.model.BindTextures( basic_texture_container );
				
				//Console.WriteLine("tex[0]" +	model_component.model.Textures[0].Texture. );
			}
			#endregion	// Boat Init
			// boat every frame
			{	// declare new scope
			if ( basic_program == null )
				Console.WriteLine("Que?");
			Matrix4 world = Matrix4.Identity ;
			if (model_component .model.BoundingSphere.W != 0.0f ) {
				Vector3 scale = model_component.scale;
					
				Vector3 pos = new Vector3(model_component.parent.Transform.Position.X, model_component.parent.Transform.Position.Y, model_component.parent.Transform.Z);
					
				//Console.WriteLine( model.parent.Name+"--" + pos );
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				world *= Matrix4.RotationX(FMath.Radians(90.0f));
				world *= Matrix4.RotationY (-model_component.parent.Transform.Rotation.Angle(Vector2.UnitX));
					
			}	
			basic_program.Parameters.SetProjectionMatrix( ref proj );//					bparameters.SetProjectionMatrix( ref proj ) ;
			basic_program.Parameters.SetViewMatrix( ref view );//	bparameters.SetViewMatrix( ref view ) ;
			model_component.model.SetWorldMatrix( ref world );
			model_component.model.Update() ;
			//Vector3 localLightDir = new Vector3( 0f , 1f , 0f );
			//basic_program.SetUniformValue( basic_program.FindUniform("LocalLightDirection") , ref localLightDir );
				
			//Matrix4 worldInverse = world.Inverse();
			//Vector4 localEye4 = worldInverse * (new Vector4( camera_pos, 1.0f ));
        	//Vector3 localEye = new Vector3( localEye4.X, localEye4.Y, localEye4.Z);
			//basic_program .SetUniformValue( basic_program.FindUniform( "EyePosition" ), ref localEye );
				
			//model_component.model.SetWorldMatrix( ref world ) ;
			//model_component.model.Animate( .01f ) ;
			//model_component.model.Update() ;
			//Vector4 poss = new Vector4(model_component.parent.Transform.Position.X, model_component.parent.Transform.Position.Y, model_component.parent.Transform.Z, 1f);
			
			//basic_program.SetUniformValue( basic_program.FindUniform("a_Position") , ref poss );
			
			model_component.model.Draw( graphics , basic_program );
				
			}
			// End boat every frame
			
			foreach(var sprite in sprites)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(sprite.scale.X, sprite.scale.Y, 1f);
					
				Vector3 pos = new Vector3(sprite.parent.Transform.Position.X, sprite.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
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
			
			
	
			((WaterSystem)SceneManager.Instance.getSystem(typeof(WaterSystem))).Render(this, proj, view, this.camera_eye);
			((ParticleSystem)SceneManager.Instance.getSystem(typeof(ParticleSystem))).Render(this, proj, view);
			graphics.Disable( EnableMode.CullFace ) ;
			graphics.Disable( EnableMode.DepthTest ) ;
			//SampleDraw.DrawText( "BasicModel Sample", 0xffffffff, 0, 0 ) ;
	
			graphics.SwapBuffers() ;
			Timer.EndFrame();
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

