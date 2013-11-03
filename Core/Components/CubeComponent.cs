using System;
using Sce.PlayStation.Core;

namespace Core
{
	public class CubeComponent : ModelComponent
	{
		public CubeComponent (int width, int height, Vector3 color) : base("/Application/resources/Cube.mdx")
		{
			this.scale = new Vector3(width/2, height/2, 5.0f);
			this.model.Materials[0].Diffuse = color;
			this.model.Materials[0].Ambient = color;
			this.model.Materials[0].Emission = color;
			
		}
	}
}

