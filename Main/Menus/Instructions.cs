using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class Instructions : Scene
    {
        public Instructions()
        {
			InitializeWidget();
			backButton.ButtonAction += HandleBackButtonAction;
			playButton.ButtonAction += HandlePlayButtonButtonAction;
        }

        void HandlePlayButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.isPlay = false;
        }
		
		void HandleBackButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.loadStart = true;
        }
    }
}
