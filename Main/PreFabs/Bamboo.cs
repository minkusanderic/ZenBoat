using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Bamboo
	{
		public Bamboo ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/Bamboo.mdx"));
			
			m.scale = new Vector3(3	, 3, 3);
			
		}
	}
}


