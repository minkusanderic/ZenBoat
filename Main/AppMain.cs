using System;
using System.Collections.Generic;

using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;

using Core;

namespace Main
{
	public class AppMain
	{
		public static bool isStart = false;
	
		public static void Main (string[] args)
		{
			SaveGameManager.init();
			
			MenuLoader.Load();
			
			//LevelLoader.BootStrap();
			LevelLoader.Load("/Application/Levels/1.02.01.oel");
			CollectibleManager.Init();
			
			
			/// NOTE: any entites created here will not be created again when a new level is loaded after the first level, but they will be destroy!
			/// For any entities that need to be created each level, make them in the Boat prefab, since every level is gaurenteed to have a boat
			var background_music = SceneManager.Instance.createEntity("BG_Music");
			BackgroundMusicComponent bgmc = background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/LondonsSong.mp3") );
			bgmc.setVolume(1);
			bgmc.loop();
			
			var soundeffect_music = SceneManager.Instance.createEntity("SFX_Music");
			soundeffect_music.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") );
			
			//BasicEmitter be = new BasicEmitter();
			while(true)
			{
				//be.Update();
				if(!SceneManager.Instance.Update())
				{
					//if the level is over, then load the bootstrapper again
					LevelLoader.BootStrap();	
				}
			}
			
		}

	}
}
