using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
using System.Linq;


namespace Main
{
	public class Torii
	{
		public Torii ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Torii";
			ent.tag("torii");
			
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/Torii2.mdx"));
			m.scale = new Vector3(5.0f, 5.0f, 5.0f);
			
			RigidBody rb = new RigidBody( 10 );
			rb.body = new PhysicsBody();
			rb.is_static = true;
			
			ent.attachComponent( rb );
			List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("pushable").ToList();
			ent.attachComponent( new ToriiGateTrigger( targets ) );
		}
	}
}
