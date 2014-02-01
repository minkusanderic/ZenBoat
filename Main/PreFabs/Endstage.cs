using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
using System.Linq;

namespace Main
{
	public class Endstage
	{
		public Endstage ()
		{
		}
		
		static bool beenBumped;
		
		public static void create (Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "EndStage";
			ent.tag ("endstage");
			
			//var m = ent.attachComponent (new SpriteComponent ("/Application/Assets/Untitled.png"));
			//m.scale = new Vector2 (5.0f, 5.0f);
			
			RigidBody rb = new RigidBody (1f, 272f);

			
			ent.attachComponent (rb);
			var targets = SceneManager.Instance.Select("boat");
			//ent.attachComponent (new ToriiGateTrigger (targets));
			ent.attachComponent (new SimpleTrigger (targets,
			                                       	(t) => {
														if ( !beenBumped )
														{
															beenBumped = true;
															Console.WriteLine ("You've reached a checkpoint!");
															SaveGameManager.toRespawn.Clear(); 
															CollectibleManager.SetLevelScore();
															if ( t.HasTag("boat" ) )
															{
																Respawner r = (Respawner)t.FindComponent<Respawner>();
																Vector2 v = new Vector2( ent.Transform.Position.X + 20f , ent.Transform.Position.Y );
																r.SetOriginalPosition( v );
																
																ent.Transform.Position = new Vector2( ent.Transform.Position.X - 60f , ent.Transform.Position.Y );
																rb = new RigidBody( 1f , 272f );
																rb.is_static = true;
																ent.attachComponent( rb );
															}
															// clears the list of things that need to be respawned
															// this also leaves the entites "UnEnabled"
														}
														}
													)	
			                    );
		}
	}
}

