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
			
			pauseLabel.Font = Core.Globals.medium_font;
			
			continueButton.TextFont = Core.Globals.medium_font;
			restartButton.TextFont = Core.Globals.medium_font;
			levelButton.TextFont = Core.Globals.medium_font;
			mainmenuButton.TextFont = Core.Globals.medium_font;
			
			continueButton.ButtonAction += HandleContinueButtonButtonAction;
			restartButton.ButtonAction += HandleRestartButtonButtonAction;
			levelButton.ButtonAction += HandleLevelButtonButtonAction;
			mainmenuButton.ButtonAction += HandleMainmenuButtonButtonAction;
			
        }

        void HandleMainmenuButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Core.SceneManager.Instance.currentState = GameState.STOPPED;
        }

        void HandleRestartButtonButtonAction (object sender, TouchEventArgs e)
        {
			
        }
		
		 void HandleLevelButtonButtonAction (object sender, TouchEventArgs e)
        {
			
        }
        void HandleContinueButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Core.SceneManager.Instance.currentState = GameState.RUNNING;
			this.Hide();
        }
    }
}
