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
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			int width = 75;
			int height = 75;
		
			ent.attachComponent(new RectComponent(width, height));
			ent.attachComponent(new ModelComponent("/Application/resources/Cube.mdx"));
		}
	}
}

