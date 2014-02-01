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
			
			var m = ent.attachComponent(new SpriteComponent("/Application/Assets/whirlpool.png"));
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
			
			ent.attachComponent(new SimpleTrigger(SceneManager.Instance.Select("pushable"), 
			                                      (t) => {
													try {
														Respawner r = t.FindComponent<Respawner>();
														// Logs now have Respawner components
														if ( r != null )
														{
															if ( r.parent.HasTag("boat") )
															{
																// set boat last checkpoint position
																r.ResetPosition();
																// reload all the saved Entities that were hidden
																SaveGameManager.RespawnEntities();
																CollectibleManager.PrintScore();
															}
															RigidBody rib = t.FindComponent<RigidBody>();
															r.ResetPosition();
															//rib.updateTransformData();	
															rib.Velocity = new Vector2( 0f , 0f );
														}
												} catch(Exception e) {
														SaveGameManager.toRespawn.Add( t );
														t.Enabled = false; // t is any "pushable"
														if(t.HasTag("driftwood"))
														{
															SaveGameManager.toRespawn.Add( ent ); // adds the Whirlpool to the respawn list
															ent.Enabled = false;	// hides the Whirlpool
														}
												}
													}));
			
			ent.attachComponent(new SimpleController(() => {
				ent.Transform.Rotation = ent.Transform.Rotation.Rotate(-0.1f);
			}));
			respawner = (Respawner)	ent.attachComponent( new Respawner( ent.Transform.Position ) ); // adds a respawer component to the whirlpool entity
		}
		static Respawner respawner;
	}
}

