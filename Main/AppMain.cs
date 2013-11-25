using System;
using System.Collections.Generic;
using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Model;
using Core;

namespace Main
{
	public class AppMain
	{
	
		public static void Main (string[] args)
		{
			SaveGameManager.init();
			
			LevelLoader.BootStrap();
			CollectibleManager.Init();
			
			
			
			var background_music = SceneManager.Instance.createEntity("BG_Music");
			BackgroundMusicComponent bgmc = background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/LondonsSong.mp3") );
			bgmc.setVolume(1);
			bgmc.loop();
			
			var soundeffect_music = SceneManager.Instance.createEntity("SFX_Music");
			soundeffect_music.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") );
			
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
			
		}

	}
}
