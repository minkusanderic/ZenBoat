using System;
using Core;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
using System.Linq;

namespace Main
{
	public class Geyser
	{
		public Geyser ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.tag("geyser");
		
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			int strength = Convert.ToInt32(options["strength"]);
			
			var m = ent.attachComponent(new SpriteComponent("/Application/Assets/Geyser.png"));
			//m.scale = new Vector2(.5f, .5f);
			RigidBody rb = new RigidBody( Math.Min(width, height)/2 );
			ent.attachComponent(rb);
			rb.is_static = true;
			
			ent.attachComponent(new Core.SimpleController(() => {
				List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("pushable").ToList();
				foreach(var obj in targets)
				{
					Vector2 dir = ent.Transform.Position - obj.Transform.Position;
					float magnitude = ((float)strength)/dir.Length();
					if(dir.Length() < (Math.Min(width, height) * 3)) // orig:*2.5 elli5:*2.5
					{
						obj.FindComponent<RigidBody>().applyForce(dir * -magnitude *1.5f); // orig:*1 elli5:*4
					}
				}
			}));
			
		}
		
	}
}

