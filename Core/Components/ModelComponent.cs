using System;
using Sce.PlayStation.HighLevel.Model ;
namespace Core
{
	public class ModelComponent : GraphicsComponent
	{
		public BasicModel model;
		public ModelComponent (	string file_name	/* , int index */	)
		{
			model = new BasicModel( file_name , 0 ); // use index here
		}

	}
}

