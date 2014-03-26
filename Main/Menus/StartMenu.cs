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
			playButton.ButtonAction += HandlePlayButtonButtonAction;
			creditButton.ButtonAction += HandleCreditButtonButtonAction;
			quitButton.ButtonAction += HandleStoreButtonButtonAction;
			
        }

        void HandleCreditButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.loadCredit = true;
        }

        void HandleQuitButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Environment.Exit(0);
        }

        void HandlePlayButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.loadStory = true;
        }
		
		void HandleStoreButtonButtonAction(object sender, TouchEventArgs e)
		{
			MenuLoader.loadStore = true;	
		}
		
		
    }
}
