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
        }

        void HandleContinueButtonButtonAction (object sender, TouchEventArgs e)
        {
        	Core.SceneManager.Instance.currentState = GameState.RUNNING;
			this.Hide();
        }
    }
}
