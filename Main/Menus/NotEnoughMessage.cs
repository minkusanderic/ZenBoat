using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Core;
using Main;

namespace Menu
{
    public partial class NotEnoughMessage : Dialog
    {
        public NotEnoughMessage()
            : base(null, null)
        {
            InitializeWidget();
			
			okButton.ButtonAction += HandleOkButtonButtonAction;
			cancelButton.ButtonAction += HandleCancelButtonButtonAction;
        }

        void HandleOkButtonButtonAction (object sender, TouchEventArgs e)
        {
			this.Hide();
			MenuLoader.loadStore = true;
        }

        void HandleCancelButtonButtonAction (object sender, TouchEventArgs e)
        {
			this.Hide();
        }
    }
}
