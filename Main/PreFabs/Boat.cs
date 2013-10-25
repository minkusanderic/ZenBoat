using System;

using System.Collections;
using System.Collections.Generic;

using Core;
namespace Main
{
	public class Boat
	{
		public Boat ()
		{
		}
		public static void create(String name, Dictionary<String, String> options)
		{
			
			int x = Convert.ToInt32(options["x"]);
			int y = Convert.ToInt32(options["y"]);
			
			int width = 200;
			int height = 100;
		
			var ent = SceneManager.Instance.createEntity(name);
			ent.Transform.Position = new Sce.PlayStation.Core.Vector2(x,y);
			ent.attachComponent(new RectComponent(width, height));
			ent.attachComponent(new Camera(ent));
		}
	}
}

