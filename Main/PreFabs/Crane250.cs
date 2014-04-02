using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Main
{
	public class Crane250
	{
		static int craneScore = 250;		// this is the basic value of a 'regular' crane
		public Crane250 (int worth = 250)	// defaults to 1
		{
			craneScore = worth;
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Crane";
			ent.tag("crane", "collectable");
			
			ent.Transform.Rotation = new Vector2(0.5f, 1f);
			ent.Transform.SetAngle(1f);
			var m = ent.attachComponent(new ModelComponent("/Application/assets/Rainbow.mdx"));

			m.scale = new Vector3(2f, 2f, 2f);
			
			//m.model.Animate(Timer.DeltaTime);
		    //m.model.SetCurrentMotion( 0, 0.1f ) ;
			
			RigidBody rb = new RigidBody(75);
			//rb.body = new PhysicsBody();
			ent.attachComponent(rb);
			//rb.body.SetBodyTrigger();
			
			ent.attachComponent(new CollectibleTrigger(craneScore));
			ent.attachComponent(new Respawner( ent.Transform.Position ) );
			
			
		}
	}
}

