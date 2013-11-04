using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

using System.Linq;
namespace Main
{
	public class Whirlpool
	{
		public Whirlpool (  )
		{
			
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.tag("whirlpool", "cube");
		
			//ent.attachComponent(new RectComponent(width, height));
			var m = ent.attachComponent(new ModelComponent("/Application/resources/WhirlCube2.mdx"));
			m.scale = new Vector3(100, 100, 100);
			RigidBody rb = new RigidBody( m.scale.X / 5f );
			rb.body = new PhysicsBody();
			rb.is_static = true;
			

			//rb.makeTrigger();
			ent.attachComponent( rb );
			
			//rb.makeTrigger();
			
			
			List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("pushable").ToList();
			ent.attachComponent( new WhirlpoolTrigger( targets ) );
		}
	}
}

