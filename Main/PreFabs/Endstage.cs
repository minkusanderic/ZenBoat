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
		
		public static void create (Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "EndStage";
			ent.tag ("endstage");
			
			//var m = ent.attachComponent (new SpriteComponent ("/Application/Assets/Untitled.png"));
			//m.scale = new Vector2 (5.0f, 5.0f);
			
			RigidBody rb = new RigidBody (1f, 272f);
			//rb.body = new PhysicsBody ();
			rb.is_static = true;
			
			ent.attachComponent (rb);
			var targets = SceneManager.Instance.Select("boat");
			//ent.attachComponent (new ToriiGateTrigger (targets));
			ent.attachComponent (new SimpleTrigger (targets,
			                                       	(t) => {
														Console.WriteLine ("You've reached the end of the stage!");		
														Respawner r = t.FindComponent<Respawner> ();
														if (r != null) {
															RigidBody rib = t.FindComponent<RigidBody> ();
															r.ResetPosition ();	
															//rib.updateTransformData ();	
															rib.Velocity = new Vector2 (0f, 0f);
														}
														if(options.ContainsKey("NextLevel") && (options["NextLevel"] != ""))
														{
															SceneManager.Instance.DestroyAll ();
															LevelLoader.Load("/Application/Levels/" + options["NextLevel"]);
														}
														}
													)	
			                    );
		}
	}
}

