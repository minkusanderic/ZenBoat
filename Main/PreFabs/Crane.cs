using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Main
{
	public class Crane
	{
		static int craneScore = 1;		// this is the basic value of a 'regular' crane
		public Crane (int worth = 1)	// defaults to 1
		{
			craneScore = worth;
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Crane";
			ent.tag("crane", "collectable");
			
			ent.Transform.Rotation = new Vector2(0.5f, 1f);
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/Crane02.mdx"));
			
			m.scale = new Vector3(2f, 2f, 2f);
			
			
			RigidBody rb = new RigidBody(75);
			//rb.body = new PhysicsBody();
			
			ent.attachComponent(rb);
			//rb.body.SetBodyTrigger();
			
			ent.attachComponent(new CollectibleTrigger(craneScore));
			ent.attachComponent(new Respawner( ent.Transform.Position ) );
		}
	}
}

