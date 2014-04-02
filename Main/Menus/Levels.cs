using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;
using Core;
namespace Menu
{
    public partial class Levels : Scene
    {
        public Levels()
        {
            InitializeWidget();
			backButton.ButtonAction += HandleBackButtonButtonAction;
        }

        void HandleBackButtonButtonAction (object sender, TouchEventArgs e)
        {
			MenuLoader.loadStart = true;
        }
    }
}
