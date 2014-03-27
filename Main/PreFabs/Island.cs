using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Island
	{
		public Island ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			//use MapleNb for colored leaves or MapleNa for sticklike tree			    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Island.mdx"));
			m.scale = new Vector3(3f, 3f, 3f);
			m.layer="under_water";
			RigidBody rb = new RigidBody(90, 90);
			ent.attachComponent(rb);
			rb.is_static=true;
		}
	}
}



