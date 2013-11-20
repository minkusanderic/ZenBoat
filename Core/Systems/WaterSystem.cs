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
		
		public WaterSystem ()
		{
		}
		
		public override void Update()
		{
			
			
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
		}
	}
}

