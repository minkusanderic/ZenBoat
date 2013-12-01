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
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			
			var background_music = SceneManager.Instance.createEntity("BG_Music");
			BackgroundMusicComponent bgmc = background_music.attachComponent( new BackgroundMusicComponent("/Application/Assets/LondonsSong.mp3") );
			bgmc.setVolume(1);
			bgmc.loop();
			
			var soundeffect_music = SceneManager.Instance.createEntity("SFX_Music");
			soundeffect_music.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") );
			
			var water = SceneManager.Instance.createEntity("Water");
			water.attachComponent(new WaterComponent());
			
			var bank = SceneManager.Instance.createEntity("Bank");
			bank.Transform.Position = new Vector2(960/2, 544/2 + 100);
			bank.attachComponent(new ModelComponent("/Application/Assets/SimpleBank01.mdx")).scale = new Vector3(2.0f, 1.3f, 1.0f);
			ModelComponent bank_model = bank.FindComponent<ModelComponent>();
			bank_model.scale.Y *= 1.2f;
			
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
			
		}

	}
}
