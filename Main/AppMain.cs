using System;
using System.Collections.Generic;
using Sce.PlayStation;
using Sce.PlayStation.HighLevel.Model;
using Core;

namespace Main
{
	public class AppMain
	{
	
		public static void Main (string[] args)
		{
			CollectibleManager.Init();
			LevelLoader.Load("/Application/Levels/Level1.oel");
			
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			//RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			
			var background_music = SceneManager.Instance.createEntity("BG_Music");
			//background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/Rings.mp3") );
			
			var soundeffect_music = SceneManager.Instance.createEntity("SFX_Music");
			soundeffect_music.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") );

			
			while(true)
			{
				SceneManager.Instance.Update();
			}
		}

	}
}
