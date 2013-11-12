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
			LevelLoader.BootStrap();
			
			
			CollectibleManager.Init();
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			//RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			
			var background_music = SceneManager.Instance.createEntity("BG_Music");
			//background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/Rings.mp3") );
			
			var soundeffect_music = SceneManager.Instance.createEntity("SFX_Music");
			soundeffect_music.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") );
			
			var water = SceneManager.Instance.createEntity("Water");
			water.attachComponent(new WaterComponent());
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
		}

	}
}
