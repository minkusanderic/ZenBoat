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
								push.FindComponent<RigidBody>().applyForce(5 * force_vects[i,j]);
							}
						}
					}
				}
			}
		}
		
		
		private float time = 0.0f;
		
		public void Render(GraphicsSystem g, Matrix4 proj, Matrix4 view)
		{
			
			foreach(var water in waters)
			{
							
				Matrix4 world = Matrix4.Identity ;
				
				
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
				water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("time"), time);
				
				foreach(var rad in this.radials)
				{
					Vector3 radial_vec = new Vector3(rad.parent.Transform.Position.X, rad.parent.Transform.Position.Y, rad.time);
					water.shaderProgram.SetUniformValue(water.shaderProgram.FindUniform("Radial"),
					                                    ref radial_vec);
					rad.time += .01f;
				}

				time += .1f;
				
				g.graphics.DrawArrays(DrawMode.Triangles, 0, water.vb.IndexCount);
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
	}
}

