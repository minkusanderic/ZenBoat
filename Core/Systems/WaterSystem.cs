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
		
		private Vector2[,] force_vects;
		
		public WaterSystem ()
		{
			force_vects = new Vector2[60,34];
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
		
		private Texture2D stars = new Texture2D("/Application/Assets/Skymidday.png", true);
		private float time = 0.0f;
		private Texture2D height_map = new Texture2D("/Application/resources/test.png", false);
		private Texture2D normal_map = new Texture2D("/Application/Assets/water_normal.png", false);
		private Vector3[] v = new Vector3[30];
		private int circular_buffer_index = 0;
		public void Render(GraphicsSystem g, Matrix4 proj, Matrix4 view, Vector3 Eye)
		{
			
			foreach(var water in waters)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				//				FrameBuffer off_screen = new FrameBuffer();
				height_map = new Texture2D(100, 100, false, PixelFormat.Rgba, PixelBufferOption.Renderable); 
//				off_screen.SetColorTarget(height_map, 0);
//				
				uint[,] p = new uint[100,100];
				for(int i = 0; i < 100; i++)
				{
					for(int j = 0; j < 100; j++)
					{
						p[i,j] = 0x77770000 + 5 *(uint)i;
					}
				}
				
				height_map.SetPixels(0, p, PixelFormat.Rgba);
				
				//var cel_shading = new Texture2D(new byte[] {}, false);
				
				//off_screen.SetDepthTarget(null);
				
			//	g.graphics.SetFrameBuffer(off_screen);
				//g.graphics.SetClearColor( 1.0f, 0.5f, 0.0f, 1.0f ) ;
				//g.graphics.Clear() ;
				//g.graphics.SetViewport(0,0,1000,1000);
				//Sample.SampleDraw.Init(g.graphics);
///
				//Sample.SampleDraw.FillCircle(0xFFFFFFFF, 100, 100, 1000);
				//SampleDraw.DrawText("Touch Sample", 0xffffffff, 0, 0);
				//this.drawCircle(g.graphics, 100.0f, 100.0f, 1000.0f, 1000.5f);
				
///				
				
			//	g.graphics.SetFrameBuffer(null);
				
				
			    Vector3 scale = new Vector3(1,1,1);
					
				Vector3 pos = new Vector3(water.parent.Transform.Position.X, water.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation(pos) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				
				g.graphics.SetVertexBuffer(0, water.vb);
				g.graphics.SetShaderProgram(water.shaderProgram);
				//graphics.SetTexture(0, sprite.texture);
				

				var world_view_proj = proj * view * world;
				

				//program.Parameters.SetWorldMatrix(0, ref world);
				water.shaderProgram.SetUniformValue(0, ref world_view_proj);
				water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("EyePosition"), ref Eye);
				water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("time"), time);
				

				
				foreach(var rad in this.radials)
				{
					Vector3 radial_vec = new Vector3(rad.parent.Transform.Position.X, rad.parent.Transform.Position.Y, rad.time);
					water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("Radial"),
					                                    ref radial_vec);
					rad.time += .01f;
					v[circular_buffer_index] = radial_vec;
					v[circular_buffer_index].Z = 20.0f;
					circular_buffer_index++;
					if(circular_buffer_index >= v.Length)
					{
						circular_buffer_index = 0;
					}
					
				}
				for(int i = 0; i < v.Length; i++)
					{
						if(v[i].Z < 2.0f){
							v[i].Z = 0.0f;}
						else{
							v[i].Z -= 2.0f;}
					}
				
				
				water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("Splashes"), v, 0, 0, v.Length);
				time += .001f;
				if(time > 1.0f)
					time = 0.0f;
				g.graphics.SetTexture(0, height_map);
				g.graphics.SetTexture(0, stars);
				g.graphics.SetTexture(1, normal_map);
				
				g.graphics.DrawArrays(DrawMode.Triangles, 0, water.vb.IndexCount);
				height_map.Dispose();
			}
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

