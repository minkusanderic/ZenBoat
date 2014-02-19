using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class Story2 : Scene
    {
        public Story2()
        {
            InitializeWidget();
			nextButton.ButtonAction += HandleNextButtonButtonAction;
        }

        void HandleNextButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.loadStory3 = true;
        }
    }
}
