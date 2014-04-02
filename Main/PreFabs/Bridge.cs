using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
using System.Linq;
namespace Main
{
	public class Bridge
	{
		public Bridge ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{

			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Bridge.mdx"));
			ent.Name = "Bridge";
			ent.tag ("bridge");
			
		
			m.scale = new Vector3 (20.0f, 50.0f, 20.0f);
			ent.Transform.Rotation = new Vector2(0, -1);
			
			RigidBody rb = new RigidBody (544f,25f );
			rb.body = new PhysicsBody ();
			rb.is_static = true;
			
			ent.attachComponent (rb);
			var targets = SceneManager.Instance.Select("boat");
			//SFXComponent sound = ent.attachComponent( new SFXComponent("/Application/assets/Sound/SFX/LevelEnd.wav" ) );
			//ent.attachComponent (new ToriiGateTrigger (targets));
			ent.attachComponent (new SimpleTrigger (targets,
			                                       	(t) => {
														Console.WriteLine ( SceneManager.Instance.GetCurrentLevelName() );
														if ( Globals.current_level == "/Application/Levels/016.oel" )
														{
															// do something cos the game is over
															// go to credits/menu
															SceneManager.Instance.currentState = GameState.STOPPED;
															return;
														}
														Console.WriteLine ("You've reached the Torii Gate - Level Over!");	
														SaveGameManager.SaveString( Globals.completedLevelPrefix + Globals.current_level , Globals.true_ );
														//SFXComponent sound = ent.attachComponent( new SFXComponent("/Application/assets/Sound/SFX/LevelEnd.wav" ) );
														//sound.PlaySound();
														((AudioSystem)(SceneManager.Instance.getSystem(typeof(AudioSystem)))).PlaySound("/Application/assets/Sound/SFX/LevelEnd.wav");	
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
															Globals.current_level = "/Application/Levels/" + options["NextLevel"];
															AppMain.current_state = AppState.LOADING;
														}
														}
													)	
			                    );
		}
}
}

