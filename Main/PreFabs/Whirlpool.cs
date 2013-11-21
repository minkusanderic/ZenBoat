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
			ent.tag("whirlpool");
		
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			int strength = Convert.ToInt32(options["strength"]);
			
			var m = ent.attachComponent(new SpriteComponent("/Application/Assets/Whirpoolsmall.png"));
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
					if(dir.Length() < (Math.Min(width, height) * 2.5f))
					{
						obj.FindComponent<RigidBody>().applyForce(dir * magnitude);
					}
				}
			}));
			
			ent.attachComponent(new SimpleTrigger(SceneManager.Instance.FindEntitiesByTag("pushable").ToList(), 
			                                      (t) => {
														Respawner r = t.FindComponent<Respawner>();
														if ( r != null )
														{
															RigidBody rib = t.FindComponent<RigidBody>();
															
															rib.is_static = true;
															rib.body.SetBodyTrigger();
															r.ResetPosition();
															//t.Transform.Position = new Vector2( 0f , 0f );
															//t.attachComponent( new RigidBody(t.FindComponent<ModelComponent>().model.BoundingSphere.W *.5f) );
															//rb.body.position = t.Transform.Position;
														}
														//t.Destroy();
													}));
			//ent.attachComponent( new WhirlpoolTrigger( targets ) );
		}
	}
}

