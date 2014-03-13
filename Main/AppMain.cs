using System;
using System.Collections.Generic;

using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;

using System.Threading;

using Core;

namespace Main
{
	public enum AppState { INITIALIZE, MENU, LOADING, GAME};
	
	
		
	public class AppMain
	{
		public static bool isStart = false;
	
		public static AppState current_state;
		
		public static void Main (string[] args)
		{			
			current_state = AppState.INITIALIZE;
			while (true)
			{
				//Depending on which state the application is in, do different stuff. 
				switch(current_state)
				{
				case AppState.INITIALIZE:
					Core.Timer.Init();
					SaveGameManager.init();
					CollectibleManager.Init();
					current_state = AppState.MENU;
					break;
					
				case AppState.MENU:
					var background_music = SceneManager.Instance.createEntity("BG_Music");
					BackgroundMusicComponent bgmc = background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/Sound/gameBackground.mp3") );
					bgmc.setVolume(1f);
					bgmc.loop(true);
					
					MenuLoader.Load(); //Will block until the player picks the play button
					current_state = AppState.LOADING;
					break;
					
				case AppState.LOADING:					
					LevelLoader.Load(Globals.staring_level);
					SceneManager.Instance.currentState = GameState.RUNNING;
					current_state = AppState.GAME;
					break;
					
				case AppState.GAME:
					Core.Timer.StartFrame();
					bool game_end = SceneManager.Instance.Update();	
					Core.Timer.EndFrame();
					if(!game_end)
					{
						//if the level is over, then load the bootstrapper again	
						SceneManager.Instance.DestroyAll();
						SceneManager.Instance.Update();
						current_state = AppState.MENU;
					}
					break;
					
				default:
					Console.WriteLine("What are you doing here! Get back to Work!");
					break;
				}
			}
			
		}

	}
}
