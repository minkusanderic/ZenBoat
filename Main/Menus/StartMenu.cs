using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class StartMenu : Scene
    {
        public StartMenu()
        {
            InitializeWidget();
			Action();
        }
		
		private void Action()
		{
			bool quit = false;
			
			while (!quit)
			{
				if ((quitButton.ButtonAction) != 0)
					quit = true;
				if ((startButton.ButtonAction) != 0)
					LevelLoader.BootStrap();
			}
		}
    }
}
