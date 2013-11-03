using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
namespace Main
{
	public class Whirlpool
	{
		public Whirlpool (  )
		{
			
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			int width = 75;
			int height = 75;
		
			//ent.attachComponent(new RectComponent(width, height));
			var m = (ModelComponent)ent.attachComponent(new ModelComponent("/Application/resources/Rock.mdx"));
			m.scale = new Vector3(100, 100, 100);
			RigidBody rb = new RigidBody( m.scale.X / 5f );
			rb.body = new PhysicsBody();
			rb.is_static = true;
			

			//rb.makeTrigger();
			ent.attachComponent( rb );
			
			//rb.makeTrigger();
			
			
			List<Entity> targets = new List<Entity>();
			targets.Add( SceneManager.Instance.GetEntity("0") );
			ent.attachComponent( new WhirlpoolTrigger( targets ) );
		}
	}
}

