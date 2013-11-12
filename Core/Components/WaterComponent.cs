using System;
using Sce.PlayStation.Core.Graphics;

namespace Core
{
	public class WaterComponent : GraphicsComponent
	{
		
		public VertexBuffer vb;
		public Texture2D texture;
		public ShaderProgram shaderProgram;
		
		public WaterComponent ()
		{
			//texture = new Texture2D(filename, false);
			shaderProgram = new ShaderProgram("/Application/shaders/water.cgx");
			
			 shaderProgram.SetUniformBinding(0, "WorldViewProj");
			
			 int W = 100;
			 int H = 100;
			 
			 float[] vertices = new float[W * H * 3];
			
			for(var i = 0; i < W; i++)
			{
				for(var j = 0;j < H; j++)
				{
					int offset = 3*((i * W) + j);
					vertices[offset + 0] = i * 10.0f - 10.0f;   // x0
   			  		vertices[offset + 1] = j * 10.0f - 10.0f;   // y0
              		vertices[offset + 2] = 0.0f;   // z0
				}
			}
			
			ushort[] indices;
			indices = new ushort[(H-1) * (W-1) * 2 * 3];
			
			for(int i = 0; i < W - 1; i++)
			{
				for(int j = 0; j < H - 1; j++)
				{
					int offset = 6 * ((i * (W - 1)) + j);
					indices[offset + 0] = (ushort)(j*(W) + i);
					indices[offset + 1] = (ushort)((j*(W) + i) + (W));
					indices[offset + 2] = (ushort)((j*(W) +i) + 1);
					
					indices[offset + 3] = (ushort)((j*(W) + i) + (W) + 1);
					indices[offset + 4] = (ushort)((j*(W) + i) + 1);
					indices[offset + 5] = (ushort)((j*(W) + i) + (W));
					
				}
			}
			
   			 

     		
			
			 vb = new VertexBuffer(W * H, (W-1) * (H-1) * 6, VertexFormat.Float3);
			 
 
 	   		vb.SetVertices(0, vertices);
    		//vb.SetVertices(1, texcoords);
  	  		//vb.SetVertices(2, colors);

  	  		vb.SetIndices(indices);


		}
	}
}
