using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Core;

namespace Menu
{
    public partial class HUD : Scene
    {
        public HUD()
        {
            InitializeWidget();
			Button_1.ButtonAction += HandleButton_1ButtonAction;
        }

        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
        	SceneManager.Instance.currentState = GameState.STOPPED;
			Console.WriteLine("GO BACK WILLIE");
        }
    }
}
