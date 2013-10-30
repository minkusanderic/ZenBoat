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
			LevelLoader.Load("/Application/Levels/Test.oel");
			
			while(true)
			{
				SceneManager.Instance.Update();
			}
		}

	}
}
