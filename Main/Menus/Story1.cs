using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class Story1 : Scene
    {
        public Story1()
        {
            InitializeWidget();
			nextButton.ButtonAction += HandleNextButtonButtonAction;
        }

        void HandleNextButtonButtonAction (object sender, TouchEventArgs e)
        {
        	MenuLoader.loadStory2 = true;
        }
    }
}
