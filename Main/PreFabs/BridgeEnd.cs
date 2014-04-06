using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
using System.Linq;
namespace Main
{
	public class BridgeEnd
	{
		public BridgeEnd ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{

			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Bridge.mdx"));
			ent.Name = "Bridge";
			ent.tag ("bridge");
			
		
			m.scale = new Vector3 (25.0f, 28.0f, 30.0f);
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
				// calc max cranes to curretn cranes
				int current_max_crane_count = 0;
				if ( !SaveGameManager.ContainsSaveString(Globals.craneTotalForLevelPrefix + Globals.current_level) );
				{
					SaveGameManager.SaveString( Globals.craneMaxForLevelPrefix + Globals.current_level, Globals.currentCraneCountOnLevel.ToString() );	
				}
				String current_max_crane_count_string = SaveGameManager.GetValueFromKey( Globals.craneTotalForLevelPrefix + Globals.current_level );
				int.TryParse( current_max_crane_count_string , out current_max_crane_count );
				if ( Globals.currentCraneCountOnLevel >= current_max_crane_count )
				{
					SaveGameManager.SaveString( Globals.craneMaxForLevelPrefix + Globals.current_level, Globals.currentCraneCountOnLevel.ToString() );
					Console.WriteLine( "Saved new" );
				}
				Globals.currentCraneCountOnLevel = 0;
				
				// unlock new Level.
				
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
															SaveGameManager.SaveString(Globals.unlockedLevelPrefix + Globals.current_level , "unlocked" );
															AppMain.current_state = AppState.LOADING;
														}
														}
													)	
			                    );
		}
}
}

