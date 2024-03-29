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
			
			craneCount.Font = Core.Globals.medium_font;
			String cc = Core.SaveGameManager.GetValueFromKey("crane_value");
			craneCount.Text = (cc != null) ? cc : "0";
			
			buyButton.ButtonAction += HandleBuyButtonButtonAction;
			
			buyButton.TextFont = Core.Globals.medium_font;
			backButton.TextFont = Core.Globals.medium_font;
			
        }

        void HandleBuyButtonButtonAction (object sender, TouchEventArgs e)
        {
        	UISystem.PopScene();
			MenuLoader.loadStore = true;
        }

        void HandleBackButtonButtonAction (object sender, TouchEventArgs e)
        {
        	UISystem.PopScene();
			MenuLoader.loadStart = true;
        }
		protected override void OnUpdate (float elapsedTime)
		{
			base.OnUpdate (elapsedTime);
			String cc = Core.SaveGameManager.GetValueFromKey("crane_value");
			craneCount.Text = (cc != null) ? cc : "0";
		}
    }
}
