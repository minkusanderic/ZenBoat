using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
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
			ent.tag("rock");
		
			var m = ent.attachComponent(new CubeComponent("/Application/Assets/Boat.png"));
			//m.scale = new Vector3(100, 100, 100);
		}
	}
}

