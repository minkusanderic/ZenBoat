using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class LooseBlossoms
	{
		public LooseBlossoms ()
		{
		}
		//static Entity entity;
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			
			//entity = ent;
			//ent.tag("looseblossom", "pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/LooseBlossomsC.mdx"));
			
			m.scale = new Vector3(10f , 10f, 10f);
			
			//RigidBody rb = new RigidBody(10, 10);
			//ent.attachComponent(rb);
			//ent.attachComponent( new Respawner( ent.Transform.Position ) );
		}
	}
}

