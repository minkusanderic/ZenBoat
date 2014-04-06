using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Main;

namespace Menu
{
    public partial class Loading : Scene
    {
        public Loading()
        {
            InitializeWidget();
			
			Label_1.Font = Core.Globals.big_font;
        }
    }
}
