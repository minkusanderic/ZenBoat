// AUTOMATICALLY GENERATED CODE


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;


namespace Preview
{
    class __DummyProgram
    {
        static GraphicsContext graphics;

        static void Main(string[] args)
        { 
            graphics = new GraphicsContext(960,544,PixelFormat.Rgba,PixelFormat.Depth16,MultiSampleMode.None);
            UISystem.Initialize(graphics);

            Story scene = new Story();
            SetupListNum(scene.RootWidget);
            scene.SetWidgetLayout(LayoutOrientation.Horizontal);
            UISystem.SetScene(scene);
            for (; ; )
            {
                SystemEvents.CheckEvents();

                // update
                {
                    List<TouchData> touchDataList = Touch.GetData(0);
                    var gamePad = GamePad.GetData (0);
                    UISystem.Update(touchDataList, ref gamePad);
                }

                // draw
                {
                    graphics.SetViewport(0, 0, graphics.Screen.Width, graphics.Screen.Height);
                    graphics.SetClearColor(
                        0xFF, 
                        0xFF, 
                        0xFF, 
                        0xff);
                    graphics.Clear();

                    UISystem.Render();
                    graphics.SwapBuffers();
                }
            }
        }

        private static void SetupListNum(ContainerWidget container)
        {
            foreach (var child in container.Children)
            {
                if (child is ListPanel)
                {
                    (child as ListPanel).Sections = section;
                }

                if (child is GridListPanel)
                {
                    (child as GridListPanel).ItemCount = 100;
                    (child as GridListPanel).StartItemRequest();
                }

                if (child is LiveListPanel)
                {
                    (child as LiveListPanel).ItemCount = 100;
                    (child as LiveListPanel).StartItemRequest();
                }

                if (child is ContainerWidget)
                {
                    SetupListNum(child as ContainerWidget);
                }
                else if (child is PagePanel)
				{
					var pagePanel = (PagePanel)child;
					for (int i = 0; i < pagePanel.PageCount; i++) {
						SetupListNum (pagePanel.GetPage (i));
					}
				}
				else if (child is LiveFlipPanel)
				{
					var liveFlip = (LiveFlipPanel)child;
					SetupListNum(liveFlip.FrontPanel);
					SetupListNum(liveFlip.BackPanel);
				}

            }
        }

        private static ListSectionCollection section = new ListSectionCollection {
            new ListSection("Section1", 10),
            new ListSection("Section2", 3),
            new ListSection("Section3", 30),
            new ListSection("Section4", 27),
            new ListSection("Section5", 10),
            new ListSection("Section6", 20),
        };
    }

	public class __UicCustomClassBase__ : Label
	{
        public __UicCustomClassBase__()
        {
            BackgroundColor = new UIColor(0.3f, 0.3f, 0.3f, 1.0f);
            VerticalAlignment = VerticalAlignment.Middle;
            HorizontalAlignment = HorizontalAlignment.Center;
        }
        bool update;
        protected override void OnUpdate(float elapsedTime)
        {
            if (!update)
            {
                Text = this.ToString();
                update = true;
            }
            base.OnUpdate(elapsedTime);
        }
	}
}


