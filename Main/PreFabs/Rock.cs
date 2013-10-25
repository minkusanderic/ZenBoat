using System;
using System.Collections;
using System.Collections.Generic;

using Core;

namespace Main
{
	public class Rock
	{
		public Rock ()
		{
		}
		
		public static void create(String name, Dictionary<String, String> options)
		{
			int x = Convert.ToInt32(options["x"]);
			int y = Convert.ToInt32(options["y"]);
			
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			
			var ent = SceneManager.Instance.createEntity(name);
			ent.Transform.Position = new Sce.PlayStation.Core.Vector2(x,y);
			ent.attachComponent(new RectComponent(width, height));
		}
	}
}

