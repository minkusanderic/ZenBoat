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
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			
			int width = 200;
			int height = 100;
		
		    //ent.attachComponent(new RectComponent(width, height));
			ent.attachComponent(new ModelComponent("/Application/resources/Cube.mdx"));
			
		}
	}
}

