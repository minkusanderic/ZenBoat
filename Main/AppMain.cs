using System;
using System.Collections.Generic;

using Core;

namespace Main
{
	public class AppMain
	{
	
		public static void Main (string[] args)
		{
			Console.WriteLine("Hello, World");
			var ent = SceneManager.Instance.createEntity("Hello");
			ent.attachComponent(new SuicideController(2000));
			SceneManager.Instance.Update();
			
			LevelLoader.Load("/Application/Levels/Test.oel");
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
		}

	}
}
