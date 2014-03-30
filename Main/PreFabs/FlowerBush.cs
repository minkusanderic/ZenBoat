using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class FlowerBush
	{
		public FlowerBush ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");		    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/FlowerBush.mdx"));
			m.layer = "trees";
			m.scale = new Vector3(4f , 4f, 4f);
			ent.tag("tree");
		}
	}
}
