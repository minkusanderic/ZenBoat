using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Koi
	{
		public Koi ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/Koifish.mdx"));
			
			m.scale = new Vector3(5	, 5, 5);
			
		}
	}
}

