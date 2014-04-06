using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    public partial class StoreMessage : Dialog
    {
        public StoreMessage(string text, EventHandler<DialogEventArgs> onClose = null)
            : base(null, null)
        {
            InitializeWidget();
        

            Button_1.ButtonAction += (sender, e)=>{ Hide(); };
            if (onClose != null) Hiding += onClose;

            Label_1.Text = text;
            Show();
			this.Result = DialogResult.Cancel;
			
			Button_1.ButtonAction += HandleButton_1ButtonAction;
			cancelButton.ButtonAction += HandleCancelButtonButtonAction;
        }

        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
			this.Hide();			
        }

        void HandleCancelButtonButtonAction (object sender, TouchEventArgs e)
        {
			this.Hide();
        }

        //  Constructor ( with exception, close handler )

        public StoreMessage(Exception e, EventHandler<DialogEventArgs> onClose = null)
            : this(e.GetType().ToString() + "\n\n" + e.Message, onClose)
        {
        }
    }
}
