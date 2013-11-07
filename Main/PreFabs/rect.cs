using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Main
{
	public class rect
	{
		public rect ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			
			
			var w = Convert.ToInt32(options["w"]);
			var h = Convert.ToInt32(options["h"]);
			ent.Transform.Position += new Sce.PlayStation.Core.Vector2(w/2, h/2);
			ent.attachComponent(new RigidBody(w, h)).is_static = true;
			ent.attachComponent(new ModelComponent("/Application/resources/bank1.5.mdx"));
			
			
		}
	}
}

