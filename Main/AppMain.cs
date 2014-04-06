using System;
using System.Collections.Generic;

using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Graphics;

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
					
					var background_music = SceneManager.Instance.createEntity("BG_Music");
					BackgroundMusicComponent bgmc = background_music.attachComponent( new BackgroundMusicComponent("/Application/assets/Sound/gameBackground.mp3") );
					bgmc.setVolume(1f);
					bgmc.loop(true);
					
					break;
					
				case AppState.MENU:
					
					
					MenuLoader.Load(); //Will block until the player picks the play button
					current_state = AppState.LOADING;
					break;
					
				case AppState.LOADING:
					var loading = new Menu.Loading();
					GraphicsContext graphics = ((GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem))).graphics;
					UISystem.SetScene(loading,null);
					UISystem.Render();
					graphics.SwapBuffers();
					LevelLoader.Load(Globals.current_level);
					SceneManager.Instance.currentState = GameState.RUNNING;
					current_state = AppState.GAME;
					UISystem.SetScene(new Menu.HUD());
					break;
					
				case AppState.GAME:
					
					Core.Timer.StartFrame();
					Core.Profiler.StartFrame();
					Core.Profiler.Begin("Update");
					bool game_end = SceneManager.Instance.Update();	
					Core.Profiler.End();
					Core.Profiler.EndFrame();
					Core.Timer.EndFrame();
					
					//Console.WriteLine("FPS:" + Core.Timer.AverageFrameRate.ToString());
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
