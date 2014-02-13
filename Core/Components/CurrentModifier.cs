using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CurrentModifier : Component<WaterSystem>
	{
		
		public VertexBuffer vb;
		public Texture2D texture;
		public ShaderProgram shaderProgram;
		public Vector2 scale = new Vector2(1.0f, 1.0f);
		
		
		private static Dictionary<String, Texture2D> texture_cache = new Dictionary<String, Texture2D>();
		
		public CurrentModifier (int width, int height, Vector3 color)
		{
		
			
		}
		public void SetTextureScale(string file_name, Vector2 _scale)
		{
			//texture_cache[file_name]
		}
		
		public CurrentModifier (String filename)
		{
			if(texture_cache.ContainsKey(filename))
			{
				texture = texture_cache[filename];
			}
			else{
				texture_cache[filename] = new Texture2D(filename, false); // use index here
				texture = texture_cache[filename];
			}
			shaderProgram = new ShaderProgram("/Application/shaders/Sprite.cgx");
			
			 shaderProgram.SetUniformBinding(0, "u_ScreenMatrix");
			 //shaderProgram.SetUniformBinding(1, "u_Rotation");
				
			 float[] vertices = new float[12];
			
			
   			  float[] texcoords = {
       				 0.0f, 0.0f, // 0 top left.
       				 0.0f, 1.0f, // 1 bottom left.
        		     1.0f, 0.0f, // 2 top right.
       				 1.0f, 1.0f, // 3 bottom right.
   				 };

    		 float[] colors = {
       			 1.0f,   1.0f,   1.0f,   1.0f,   // 0 top left.
        		 1.0f,   1.0f,   1.0f,   1.0f,   // 1 bottom left.
        		 1.0f,   1.0f,   1.0f,   1.0f,   // 2 top right.
       			 1.0f,   1.0f,   1.0f,   1.0f,   // 3 bottom right.
    			};

     		int indexSize = 4;
   			ushort[] indices;
			indices = new ushort[indexSize];
			indices[0] = 3;
			indices[1] = 2;
			indices[2] = 1;
			indices[3] = 0;
			
			  vertices[0]=-texture.Width/2;   // x0
   			  vertices[1]=texture.Height/2;   // y0
              vertices[2]=0.0f;   // z0

              vertices[3]=-texture.Width/2;   // x1
              vertices[4]=-texture.Height/2; // y1
              vertices[5]=0.0f;   // z1

              vertices[6]=texture.Width/2;  // x2
              vertices[7]=texture.Height/2;   // y2
              vertices[8]=0.0f;   // z2
			  
              vertices[9]=texture.Width/2;  // x3
              vertices[10]=-texture.Height/2;    // y3
              vertices[11]=0.0f;  // z3
			
			 vb = new VertexBuffer(4, indexSize, VertexFormat.Float3, VertexFormat.Float2, VertexFormat.Float4);
 			
 	   		vb.SetVertices(0, vertices);
    		vb.SetVertices(1, texcoords);
  	  		vb.SetVertices(2, colors);

  	  		vb.SetIndices(indices);

		}
		public void GetValue(Vector2 position)
		{
			
		}
	}
}

