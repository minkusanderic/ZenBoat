using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    public partial class NotEnoughMessage : Dialog
    {
        public NotEnoughMessage()
            : base(null, null)
        {
            InitializeWidget();
        }
    }
}