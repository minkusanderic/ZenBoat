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
			levelButton.ButtonAction += HandleLevelButtonButtonAction;
			storeButton.ButtonAction += HandleStoreButtonButtonAction;
			creditButton.ButtonAction += HandleCreditButtonButtonAction;
			
			playButton.TextFont = Core.Globals.medium_font;
			levelButton.TextFont = Core.Globals.medium_font;
			storeButton.TextFont = Core.Globals.medium_font;
			creditButton.TextFont = Core.Globals.medium_font;
			
			
        }
		
		void HandlePlayButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.loadStory = true;
        }
		
        void HandleLevelButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.loadLevel = true;
        } 

		void HandleStoreButtonButtonAction(object sender, TouchEventArgs e)
		{
			MenuLoader.loadSelect = true;	
		}
		
		void HandleCreditButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.loadCredit = true;
        }
		
    }
}
