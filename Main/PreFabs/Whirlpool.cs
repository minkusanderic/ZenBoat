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
			
			//var m = ent.attachComponent(new SpriteComponent("/Application/assets/shader2.png"));
			var m = ent.attachComponent (new ModelComponent ("/Application/assets/whirlpool3.mdx"));
			m.scale = new Vector3 (100f, 100f, 100f);
			
			m.layer = "under_water";

			//m.scale = new Vector2(1.2f, 1.2f);
			RigidBody rb = new RigidBody( Math.Min(width, height) /10f ); // orig:/2f elli5:/4f
			ent.attachComponent(rb);
			rb.is_static = true;
			
			ent.attachComponent(new CurrentModifier("/Application/assets/vectorswirl.png")).scale = new Vector2(2f, 2f);
			
			ent.attachComponent(new Core.SimpleController(() => {
				List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("pushable").ToList();
				foreach(var obj in targets)
				{
					Vector2 dir = ent.Transform.Position - obj.Transform.Position;
					float magnitude = ((float)strength)/dir.Length();
					if(dir.Length() < (Math.Min(width, height) * 3.5f))  // orig:*2.5f elli5:*3.5f
					{
						//obj.FindComponent<RigidBody>().applyForce(dir * magnitude); // ellis removed
						obj.FindComponent<RigidBody>().applyForce((dir * magnitude * .8f)); // orig:*1 elli5:*2
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
							/*
																SFXComponent sound = ent.attachComponent( 
							                                           new SFXComponent("/Application/assets/Sound/SFX/BoatDeath.wav") );
																sound.PlaySound();
							*/
																((AudioSystem)(SceneManager.Instance.getSystem(typeof(AudioSystem)))).PlaySound("/Application/assets/Sound/SFX/BoatDeath.wav");
															}
															if ( r.parent.HasTag("driftwood") )
															{
																/*
																RigidBody rib = ent.FindComponent<RigidBody>();
																rib.body.Type = BodyType.Trigger;
																PhysicsSystem ps = (PhysicsSystem) SceneManager.Instance.getSystem(typeof(PhysicsSystem));
																ps.physics.DeleteBody( rib.body );
																ps.bodies.Remove( rib );
																SaveGameManager.toRespawn.Add( ent );
																*/
																//ent.Enabled = false;
																Random rand = new Random();
																ent.Transform.Position = new Vector2( -100f * rand.Next(500)  , 600f * rand.Next(500) );
																SaveGameManager.toRespawn.Add( ent );
																//rib.is_static = false;
																//rib.makeTrigger();
																//ent.Destroy();
																//RigidBody wood_body = t.FindComponent<RigidBody>();
																//wood_body.body.Type = BodyType.Trigger;
																
																//ps.physics.DeleteBody( wood_body.body );
																//ps.bodies.Remove( wood_body );
																t.Transform.Position = new Vector2( -100f * rand.Next(500) , -600f * rand.Next(500) );
																SaveGameManager.toRespawn.Add( t );
																//t.Enabled = false;
							/*
																ent.Enabled = false;
																
																r.parent.Enabled = false;
																RigidBody rib = t.FindComponent<RigidBody>();
																
																RigidBody rig = r.parent.FindComponent<RigidBody>();
																rig.Destroy();
																//r.parent.Destroy();
																SaveGameManager.toRespawn.Add( r.parent );
							*/
															}
															//RigidBody rib = t.FindComponent<RigidBody>();
															//r.ResetPosition();
															//rib.updateTransformData();	
															//rib.Velocity = new Vector2( 0f , 0f );
														}
												} catch(Exception e) 
												{
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
				//ent.Transform.Rotation = ent.Transform.Rotation.Rotate(-0.1f);
			}));
			respawner = (Respawner)	ent.attachComponent( new Respawner( ent.Transform.Position ) ); // adds a respawer component to the whirlpool entity
		}
		static Respawner respawner;
	}
}

