using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Lillypad
	{
		public Lillypad ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag( "pushable");
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/lilypad.mdx"));
			var scale_x = width / m.model.BoundingSphere.W;
			var scale_y = height / m.model.BoundingSphere.W;
			m.scale = new Vector3(scale_x, scale_y, scale_x);
		}
	}
}

