using System;

using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;

using Core;

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
			
			
			var m = ent.attachComponent(new ModelComponent("/Application/resources/Cube.mdx"));
			m.scale = new Vector3(20f, 20f, 20f);
			
			ent.attachComponent(RigidBody.CreateFromModel(m));
			RigidBody rb = ent.FindComponent<RigidBody>();
			rb.body = new Sce.PlayStation.HighLevel.Physics2D.PhysicsBody();
			rb.Mass = 0.001f;
			rb.body.SetBodyTrigger();
			ent.attachComponent(new CollectibleTrigger(SceneManager.Instance.FindEntity("Boat")));
		}
	}
}

