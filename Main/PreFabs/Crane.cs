using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Main
{
	public class Crane
	{
		public Crane ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Crane";
			ent.tag("crane", "collectable");
			
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/Crane01.mdx"));
			//m.scale = new Vector2(.25f, .25f);
			
			RigidBody rb = new RigidBody(75);
			rb.body = new PhysicsBody();
			rb.body.SetBodyTrigger();
			ent.attachComponent(rb);
			
			ent.attachComponent(new CollectibleTrigger());
		}
	}
}

