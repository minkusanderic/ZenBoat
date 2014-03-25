using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using System.Collections;
using System.Collections.Generic;


namespace Core
{
	public class WaterSystem : CoreSystem
	{
		private List<WaterComponent> waters = new List<WaterComponent>();
		private List<RadialSplash> radials = new List<RadialSplash>();
		private List<CurrentModifier> modifiers = new List<CurrentModifier>();
		
		private Vector2[,] force_vects;
		
		public WaterSystem ()
		{
			force_vects = new Vector2[60,34];
			
			
			//flow_map = new Texture2D(100, 100, false, PixelFormat.Rgba, PixelBufferOption.Renderable);
			
			
		}
		
		public void SetCurrentData(int[,] down, int[,] up, int[,] left, int[,] right)
		{
			for (int i = 0; i < 60; i++)
			{
				for (int j = 0; j < 34; j++)
				{
					Vector2 down_vect = new Vector2(0, -down[i,j]);
					Vector2 up_vect = new Vector2(0, up[i,j]);
					Vector2 right_vect = new Vector2(right[i,j], 0);
					Vector2 left_vect = new Vector2(-left[i,j], 0);
					force_vects[i,j] = down_vect + up_vect + right_vect + left_vect;
					force_vects[i,j].Normalize();
					
					
				}
			}
		}
		
		public override void Update()
		{
			
			foreach(var push in SceneManager.Instance.FindEntitiesByTag("pushable"))
			{
				for(var i = 0; i < force_vects.GetLength(0); i++)
				{
					for(var j = 0; j < force_vects.GetLength(1); j++)
					{
						Vector2 pos = new Vector2(i * 16,544 - j * 16);
						if((pos - push.Transform.Position).Length() < 50.0f)
						{
							Vector2 a = 100 * force_vects[i,j];
							if(a.Length() > 0.0f)
							{
								var r = push.FindComponent<RigidBody>();
								if(r != null)
								{
									r.applyForce(5 * force_vects[i,j]);
								}
							}
						}
					}
				}
			}
		}
		
		private Texture2D stars = new Texture2D("/Application/Assets/Skymidday.png", false);
		private float time = 0.0f;
		//private Texture2D height_map = new Texture2D("/Application/resources/test.png", false);
		private Texture2D normal_map = new Texture2D("/Application/Assets/water_normal.png", false);
		//private Texture2D swirl_map = new Texture2D("/Application/Assets/vectorswirl.png", false);
		private Vector3[] v = new Vector3[5];
		private int circular_buffer_index = 0;
		public void Render(GraphicsSystem g, Matrix4 proj, Matrix4 view, Vector3 Eye)
		{
			
			foreach(var water in waters)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				Profiler.Begin("Rendering Flow Map");
				var flow_map = RenderFlowMap(g);
				Profiler.End();
				
				
				
			    Vector3 scale = new Vector3(1,1,1);
					
				Vector3 pos = new Vector3(water.parent.Transform.Position.X, water.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				
				
				//graphics.SetTexture(0, sprite.texture);
				

				var world_view_proj = proj * view * world;
				

				//program.Parameters.SetWorldMatrix(0, ref world);
			
				
				Profiler.Begin("Setting Radials");
				for(int i = 0; i < v.Length; i++)
				{
					v[i] = new Vector3(0.0f, 0.0f, 1000.0f);
				}
				for(int i = 0; i < this.radials.Count && i < 5; i++)
				{
					var rad = this.radials[this.radials.Count - 1 - i]; //only deal with the most recent radials. ignore the rest
					
					Vector3 radial_vec = new Vector3(rad.parent.Transform.Position.X, rad.parent.Transform.Position.Y, rad.time);
					rad.time += rad.speed;
					v[i] = radial_vec;
					
				}
				Profiler.End();
				
			

				water.shaderProgram.SetAttributeBinding(0, "a_Position");
				water.shaderProgram.SetAttributeBinding(1, "a_TexCoord");
				water.shaderProgram.SetAttributeBinding(2, "a_Normal");
				
				//water.shaderProgram.SetAttributeBinding(3, "v_Position");
				//water.shaderProgram.SetAttributeBinding(4, "v_Color");
				//water.shaderProgram.SetAttributeBinding(5, "v_TexCoord");
				//water.shaderProgram.SetAttributeBinding(6, "v_Normal");
				//water.shaderProgram.SetAttributeBinding(7, "v_Eye");
				
				water.shaderProgram.SetUniformBinding(0, "WorldViewProj");
				water.shaderProgram.SetUniformBinding(1, "EyePosition");
				water.shaderProgram.SetUniformBinding(2, "time");
				water.shaderProgram.SetUniformBinding(3, "World");
				water.shaderProgram.SetUniformBinding(4, "Splashes");
				
				water.shaderProgram.SetUniformValue(0, ref world_view_proj);
				water.shaderProgram.SetUniformValue(1, ref Eye);
				water.shaderProgram.SetUniformValue(2, time);
				
				water.shaderProgram.SetUniformValue(3, ref world );
				
				water.shaderProgram.SetUniformValue(4, v, 0, 0, v.Length);
				time += .01f;
				if(time > 1.0f)
					time = 0.0f;
				//g.graphics.SetTexture(0, height_map);
				
				Profiler.Begin("Setting Textures");
				g.graphics.SetTexture(0, stars);
				g.graphics.SetTexture(1, normal_map);
				g.graphics.SetTexture(2, flow_map);
				Profiler.End();
				
				Profiler.Begin("Setting Buffers");
				g.graphics.SetVertexBuffer(0, water.vb);
				g.graphics.SetShaderProgram(water.shaderProgram);
				Profiler.End();
				
				Profiler.Begin("Drawing Water");
				g.graphics.DrawArrays(DrawMode.Triangles, 0, water.vb.IndexCount);
				Profiler.End();
				//flow_map.Dispose();
				//height_map.Dispose();
			}
		}
		
		private Texture2D flow_map = null; 
		private FrameBuffer off_screen = null;
		private Texture2D RenderFlowMap(GraphicsSystem g)
		{
			    float water_width = 960f + (300f * 2);
				float water_height = 544f + (168.75f * 2);
			
				
			 	
				
			
				if ( flow_map == null )
				{
					Profiler.Begin("Creating Framebuffer");
					off_screen = new FrameBuffer();
					Profiler.End();
					Profiler.Begin("Create Off Screen Texture");
					flow_map = new Texture2D(512, 512, false, PixelFormat.Rgba, PixelBufferOption.Renderable);
					Profiler.End();
				
					Profiler.Begin("Setting Color Target");
					off_screen.SetColorTarget(flow_map, 0);
					Profiler.End();
			    }
				else
				{
				}
				
				//height_map.SetPixels(0, p, PixelFormat.Rgba);
				
				//var cel_shading = new Texture2D(new byte[] {}, false);
				
				Matrix4 proj = Matrix4.Ortho(-water_width/2 ,water_width/2, -water_height/2, water_height/2, 1, 1000);
			//Matrix4 proj = Matrix4.Perspective( FMath.Radians( 45.0f ), graphics.Screen.AspectRatio, 1.0f, 1000000.0f ) ;
			 //Matrix4 view = Matrix4.LookAt(new Vector3(0.0f, 0.0f, 3.0f), Vector3.Zero, Vector3.UnitY);
			Matrix4 view = Matrix4.LookAt(  new Vector3(g.camera_pos.X, 544/2, 3.0f),
											new Vector3(g.camera_eye.X, 544/2, 0.0f),
											new Vector3( 0.0f, 1.0f, 0.0f ) ) ;
			Profiler.Begin("Setting Viewport");
				off_screen.SetDepthTarget(null);
				
				g.graphics.SetFrameBuffer(off_screen);
				g.graphics.SetClearColor( .55f, 0.5f, 0.0f, 1.0f ) ;
				g.graphics.Clear() ;
				g.graphics.SetViewport(0,0,512,512);
				//Sample.SampleDraw.Init(g.graphics);
///
				//Sample.SampleDraw.FillCircle(0xFFFFFFFF, 100, 100, 1000);
				//SampleDraw.DrawText("Touch Sample", 0xffffffff, 0, 0);
				//this.drawCircle(g.graphics, 100.0f, 100.0f, 1000.0f, 1000.5f);
			Profiler.End();
			
			foreach(var sprite in modifiers)
			{
				Profiler.Begin("Render Water Modifier");
				if ( !sprite.parent.Enabled ) continue;
				if ( Math.Abs(sprite.parent.Transform.Position.X - g.camera_pos.X) > 1000) continue;
				Matrix4 world = Matrix4.Identity ;
				
				
			    Vector3 scale = new Vector3(sprite.scale.X, sprite.scale.Y, 1f);
					
				Vector3 pos = new Vector3(sprite.parent.Transform.Position.X -128, // I don't know why I subtract 128, but it just works! ARGGGGHH
				                          sprite.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				world *= Matrix4.RotationZ (-sprite.parent.Transform.Rotation.Angle(Vector2.UnitX));
				
				
				g.graphics.SetVertexBuffer(0, sprite.vb);
				g.graphics.SetShaderProgram(sprite.shaderProgram);
				g.graphics.SetTexture(0, sprite.texture);
							

				var world_view_proj = proj * view * world;
				//program.Parameters.SetWorldMatrix(0, ref world);
				sprite.shaderProgram.SetUniformValue(0, ref world_view_proj);	
			
				g.graphics.DrawArrays(DrawMode.TriangleStrip, 0, 4);
				Profiler.End();
			}
			

			
///				
				Profiler.Begin("Disposing Frame Buffer");
				//off_screen.Dispose();
				
			
				g.graphics.SetFrameBuffer(null);
			
			Profiler.End();
			g.graphics.SetViewport( 0, 0, g.graphics.Screen.Width, g.graphics.Screen.Height ) ;
			return flow_map;
		}
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is WaterComponent)
			{
				waters.Add((WaterComponent)comp);
			}
			if(comp is RadialSplash)
			{
				radials.Add((RadialSplash)comp);
			}
			if(comp is CurrentModifier)
			{
				modifiers.Add((CurrentModifier)comp);
			}
		}
		
		public override void destroyComponent (IComponent comp)
		{
			if(comp is WaterComponent)
			{
				waters.Remove((WaterComponent)comp);
			}
			if(comp is RadialSplash)
			{
				radials.Remove((RadialSplash)comp);
			}
			if(comp is CurrentModifier)
			{
				modifiers.Remove((CurrentModifier)comp);
			}
			//base.destroyComponent (comp);
		}
		
		private void drawCircle(GraphicsContext graphics, float positionX, float positionY, float scaleX, float scaleY)
		{
			
			//Matrix4 proj = Matrix4.Perspective( FMath.Radians( 45.0f ), graphics.Screen.AspectRatio, 1.0f, 1000000.0f ) ;
			//Matrix4 view = Matrix4.LookAt(  camera_pos,
			//								camera_eye,
			//								new Vector3( 0.0f, 1.0f, 0.0f ) ) ;
			
			var screenMatrix = new Matrix4(
         2.0f/100.0f, 0.0f,       0.0f, 0.0f,
         0.0f,   -2.0f/100.0f,   0.0f, 0.0f,
         0.0f,   0.0f, 1.0f, 0.0f,
         -1.0f,  1.0f, 0.0f, 1.0f
    );
			var projectionMatrix = Matrix4.Ortho(0, 100,
                                         0, 100,
                                         0.0f, 32768.0f);

        var viewMatrix = Matrix4.LookAt(new Vector3(0, 100, 0),
                                    new Vector3(0, 100, 1),
                                    new Vector3(0, -1, 0));
			
				var circleVertices =  new VertexBuffer(36, VertexFormat.Float3);
       			 float[] circleVertex = new float[3 * 36];
       			 for (int i = 0; i < 36; i++) {
       			     float radian = ((i * 10) / 180.0f * FMath.PI);
        		    circleVertex[3 * i + 0] = FMath.Cos(radian);
        		    circleVertex[3 * i + 1] = FMath.Sin(radian);
        		    circleVertex[3 * i + 2] = 0.0f;
       			 }
       			 circleVertices.SetVertices(0, circleVertex);
				
				 var transMatrix = Matrix4.Translation(new Vector3(positionX, positionY, 0.0f));
        var scaleMatrix = Matrix4.Scale(new Vector3(scaleX, scaleY, 1.0f));
        var modelMatrix = transMatrix * scaleMatrix;

        var worldViewProj = projectionMatrix * viewMatrix * modelMatrix;
		ShaderProgram colorShaderProgram = new ShaderProgram("/Application/shaders/simple.cgx");
        colorShaderProgram.SetUniformValue(0, ref worldViewProj);

        Vector4 color = new Vector4(0.0f, 1.0f, 0.0f, .5f);
        colorShaderProgram.SetUniformValue(colorShaderProgram.FindUniform("MaterialColor"), ref color);

        graphics.SetShaderProgram(colorShaderProgram);
        graphics.SetVertexBuffer(0, circleVertices);

        graphics.DrawArrays(DrawMode.TriangleFan, 0, circleVertices.VertexCount);

		}
	}
}

