// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    class __DummyScene : Scene
    {
        Pause item = new Pause();

        public __DummyScene()
        {
        }
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            item.SetWidgetLayout(orientation);
            item.Show();
        }
    }
}
