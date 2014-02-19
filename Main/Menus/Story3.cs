using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class Story3 : Scene
    {
        public Story3()
        {
            InitializeWidget();
			continueButton.ButtonAction += HandleContinueButtonButtonAction;
        }

        void HandleContinueButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.isPlay = false;
        }
    }
}
