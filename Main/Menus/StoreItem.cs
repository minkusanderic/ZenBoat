using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    public partial class StoreItem : ListPanelItem
    {
        public StoreItem(EventHandler<TouchEventArgs> onCheck = null)
        {
            InitializeWidget();
			if (onCheck != null) CheckBox_1.CheckedChanged += onCheck;
        }
		public bool ItemCheck
        {
            get { return CheckBox_1.Checked; }
            set { CheckBox_1.Checked = value; }
        }
        public string ItemIndex
        {
            get { return Label_1.Text; }
            set { Label_1.Text = value; }
        }
        public string ItemName
        {
            get { return Label_2.Text; }
            set { Label_2.Text = value; }
        }
        public string ItemPrice
        {
            get { return Label_3.Text; }
            set { Label_3.Text = value; }
        }
        public string ItemTicket
        {
            get { return Label_4.Text; }
            set { Label_4.Text = value; }
        }
    }
}
