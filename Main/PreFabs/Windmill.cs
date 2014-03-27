using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Windmill
	{
		public Windmill ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Windmill.mdx"));
			
			m.scale = new Vector3(10 , 10, 10);
			
		}
	}
}


