using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.Core.Audio;
using Main;

namespace Menu
{
    public partial class StartMenu : Scene
    {
		BgmPlayer player;
        public StartMenu()
        {
            InitializeWidget();
			startButton.ButtonAction += HandleStartButtonButtonAction;
			instrButton.ButtonAction += HandleInstrButtonButtonAction;
			quitButton.ButtonAction += HandleQuitButtonButtonAction;
			
        }

        void HandleInstrButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.loadInstr = true;
        }

        void HandleQuitButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Environment.Exit(0);
        }

        void HandleStartButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.isPlay = false;
        }
		
    }
}
