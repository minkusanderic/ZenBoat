using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class bar
	{
		public bar ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/bar.mdx"));
			
			//m.scale = new Vector3(200	, 200, 200);
			m.model.Animate(0);
			m.model.SetCurrentMotion( 0, 0.1f ) ;
			
		}
	}
}