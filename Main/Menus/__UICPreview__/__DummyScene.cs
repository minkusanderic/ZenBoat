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
        Level03 item = new Level03();

        public __DummyScene()
        {
            this.RootWidget.AddChildLast(item);
        }
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            item.SetWidgetLayout(orientation);
        }
    }
}
