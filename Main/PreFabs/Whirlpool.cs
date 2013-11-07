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
		
			
			var m = ent.attachComponent(new SpriteComponent("/Application/Assets/Whirpoolsmall.png"));
			//m.scale = new Vector3(100, 100, 100);
			RigidBody rb = new RigidBody( 10 );
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

