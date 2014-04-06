using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    public partial class StoreMessage : Dialog
    {
        public StoreMessage()
            : base(null, null)
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }
    }
}
