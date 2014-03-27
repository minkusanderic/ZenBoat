using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Lantern
	{
		public Lantern ()
		{
		}
		static Entity entity;
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			entity = ent;
			ent.tag("lantern", "pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Lantern.mdx"));
			
			m.scale = new Vector3(.5f	, .5f, .5f);
			/*var body = ent.attachComponent(new RigidBody(10f, 10f));
			body.is_static = true;
			*/
			RigidBody rb = new RigidBody(10, 10);
			ent.attachComponent(rb);
			ent.attachComponent( new Respawner( ent.Transform.Position ) );
			
		}
	}
}



