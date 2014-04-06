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
			Label_1.Font = new UIFont("/Application/Menus/Zen_Sketch.ttf", 36, FontStyle.Bold);
			Button_1.TextFont = new UIFont("/Application/Menus/Zen_Sketch.ttf", 36, FontStyle.Bold);
			Button_1.ButtonAction += HandleButton_1ButtonAction;
			
        }
		
		protected override void OnUpdate(float elapsedTime)
		{
			Label_1.Text = SaveGameManager.GetValueFromKey("crane_value");
		}
        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
			SceneManager.Instance.currentState = GameState.PAUSED;
        	var pause_menu = new Menu.Pause();
			pause_menu.Show();
        }
    }
}
