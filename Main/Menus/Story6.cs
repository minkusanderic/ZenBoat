using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Core;
using Main;

namespace Menu
{
    public partial class Story6 : Panel
    {
        public Story6()
        {
            InitializeWidget();
			
			playButton.TextFont = Globals.medium_font;
			
			playButton.ButtonAction += HandlePlayButtonButtonAction;
        }

        void HandlePlayButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.isPlay = false;
        }
    }
}
