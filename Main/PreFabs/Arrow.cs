using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;

namespace Main
{
	public class Arrow
	{
		public Arrow ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag( "pushable");
			
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			SpriteComponent m = ent.attachComponent(new SpriteComponent("/Application/Assets/arrow.png"));
			m.scale = new Vector2(width * .003f, height * .005f);
		}
	}
}

