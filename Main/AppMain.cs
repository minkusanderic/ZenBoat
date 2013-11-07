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
			LevelLoader.Load("/Application/Levels/Level1.oel");
			
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
		}

	}
}
