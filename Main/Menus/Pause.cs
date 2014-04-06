using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    public partial class Pause : Dialog
    {
        public Pause()
            : base(null, null)
        {
            InitializeWidget();
			continueButton.ButtonAction += HandleContinueButtonButtonAction;
			
			pauseLabel.Font = Core.Globals.big_font;
			Button_1.TextFont = Core.Globals.medium_font;
			Button_2.TextFont = Core.Globals.medium_font;
			Button_3.TextFont = Core.Globals.medium_font;
			
			
			
			continueButton.TextFont = Core.Globals.medium_font;
			//restartButton.TextFont = Core.Globals.medium_font;
			//levelButton.TextFont = Core.Globals.medium_font;
			//mainmenuButton.TextFont = Core.Globals.medium_font;
			
			continueButton.ButtonAction += HandleContinueButtonButtonAction;
			Button_1.ButtonAction += HandleRestartButtonButtonAction;
			Button_2.ButtonAction += HandleLevelButtonButtonAction;
			Button_3.ButtonAction += HandleMainmenuButtonButtonAction;
			//restartButton.ButtonAction += HandleRestartButtonButtonAction;
			//levelButton.ButtonAction += HandleLevelButtonButtonAction;
			//mainmenuButton.ButtonAction += HandleMainmenuButtonButtonAction;
			
        }

        void HandleMainmenuButtonButtonAction (object sender, TouchEventArgs e)
        {
			Core.SceneManager.Instance.DestroyAll();
			Core.SceneManager.Instance.Update();
        	Core.SceneManager.Instance.currentState = GameState.STOPPED;
			this.Hide();
        }

        void HandleRestartButtonButtonAction (object sender, TouchEventArgs e)
        {
			Core.SceneManager.Instance.DestroyAll();
			Core.SceneManager.Instance.Update();
        	Main.AppMain.current_state = Main.AppState.LOADING;
			this.Hide();
        }
		
		 void HandleLevelButtonButtonAction (object sender, TouchEventArgs e)
        {
			Core.SceneManager.Instance.DestroyAll();
			Core.SceneManager.Instance.Update();
        	Core.SceneManager.Instance.currentState = GameState.STOPPED;
			Main.AppMain.current_state = Main.AppState.MENU;
			Main.MenuLoader.loadLevel = true;
			this.Hide();
        }
        void HandleContinueButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Core.SceneManager.Instance.currentState = GameState.RUNNING;
			this.Hide();
        }
    }
}
