using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

using Main;

namespace Menu
{
    public partial class Select : Scene
    {
        public Select()
        {
            InitializeWidget();
			backButton.ButtonAction += HandleBackButtonButtonAction;
			
		
        }

        void HandleBackButtonButtonAction (object sender, TouchEventArgs e)
        {
        	UISystem.PopScene();
			MenuLoader.loadStart = true;
        }
    }
}
