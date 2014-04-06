using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    public partial class End6 : Panel
    {
        public End6()
        {
            InitializeWidget();
			
			continueButton.ButtonAction += HandleContinueButtonButtonAction;
        }

        void HandleContinueButtonButtonAction (object sender, TouchEventArgs e)
        {
			UISystem.PopScene();
			Main.MenuLoader.loadSelect = true;
			
        }
    }
}
