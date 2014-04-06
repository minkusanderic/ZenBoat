using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    public partial class HUD : Scene
    {
        public HUD()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }
    }
}
