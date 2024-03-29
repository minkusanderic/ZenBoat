using System;
using Sce.PlayStation.Core.Graphics;

namespace Core
{
	public class WaterComponent : Component<WaterSystem>
	{
		
		public VertexBuffer vb;
		public Texture2D texture;
		public ShaderProgram shaderProgram;
		
		public WaterComponent ()
		{
			//texture = new Texture2D(filename, false);
			shaderProgram = new ShaderProgram("/Application/shaders/Water.cgx");
			
			 shaderProgram.SetUniformBinding(0, "WorldViewProj");
			
			 int W = 25;
			 int H = 25;
			 
			 float[] vertices = new float[W * H * 3];
			
			for(var i = 0; i < W; i++)
			{
				for(var j = 0;j < H; j++)
				{
					int offset = 3*((i * W) + j);
					vertices[offset + 0] = i * (1560f/(float)W) - 300.0f;   // x0
   			  		vertices[offset + 1] = j * (881.5f/(float)H) - 168.75f;   // y0
              		vertices[offset + 2] = -0.1f;   // z0
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
			
   			 

     		
			
			 vb = new VertexBuffer(W * H, (W-1) * (H-1) * 6, VertexFormat.Float3, VertexFormat.Float2, VertexFormat.Float3);
 
 	   		vb.SetVertices(0, vertices);
			
			float[] texcoords = new float[W * H * 2];
			for(int i = 0; i < W; i++)
			{
				for(int j = 0; j < H; j++)
				{
					int offset = 2*((i * W) + j);
					texcoords[offset + 0] = 1.0f - ((float)i)/((float)W);   // x0
   			  		texcoords[offset + 1] = 1.0f - ((float)j)/((float)H);   // y0
              		
				}
			}
    		vb.SetVertices(1, texcoords);
  	  		//vb.SetVertices(2, colors);
			
			float[] normals = new float[W * H * 3];
			
			for(var i = 0; i < W; i++)
			{
				for(var j = 0;j < H; j++)
				{
					int offset = 3*((i * W) + j);
					normals[offset + 0] = 0.0f; //z0
   			  		normals[offset + 1] = 0.0f; //y0
              		normals[offset + 2] = 1.0f;   // z0
				}
			}
			
			vb.SetVertices(2, normals);

  	  		vb.SetIndices(indices);


		}
	}
}

