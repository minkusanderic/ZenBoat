using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Main
{
	public class Driftwood
	{
		public Driftwood ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Driftwood";
			ent.tag("driftwood", "pushable");
			
			var m = ent.attachComponent(new ModelComponent("/Application/assets/TestLog.mdx"));
			m.scale = new Vector3(7f, 7f, 7f);
			
			RigidBody rb = new RigidBody(50, 15);
			ent.attachComponent(rb);
			ent.attachComponent( new Respawner( ent.Transform.Position ) );
		}
	}
}

