using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model ;
namespace Core
{
	public class ModelComponent : GraphicsComponent
	{
		public BasicModel model;
		public Vector3 scale = new Vector3(1.0f, 1.0f, 1.0f);
		public ModelComponent (	string file_name	/* , int index */	)
		{
			model = new BasicModel( file_name , 0 ); // use index here
		}

	}
}

