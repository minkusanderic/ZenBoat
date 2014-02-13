using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model ;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class ModelComponent : GraphicsComponent
	{
		public BasicModel model;
		public Vector3 scale = new Vector3(1.0f, 1.0f, 1.0f);
		
		public static Dictionary<String, BasicModel> model_cache = new Dictionary<String, BasicModel>();
		
		public ModelComponent (	string file_name	/* , int index */	)
		{
			if(model_cache.ContainsKey(file_name))
			{
				model = model_cache[file_name];
			}
			else{
				model_cache[file_name] = new BasicModel( file_name , 0 ); // use index here
				model = model_cache[file_name];
				foreach(var texture in model.Textures){
					Console.WriteLine("Loading Texture: " + texture.FileName + " (" + texture.Texture.Height * texture.Texture.Width * 4 + " bytes)");		
				}
				Console.WriteLine("Total Memory: " + GC.GetTotalMemory(false));
			}
		}

	}
}
