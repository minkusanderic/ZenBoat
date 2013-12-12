using System;

using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Environment;

using Core;

namespace Main
{
	public class MenuLoader
	{
		public static bool isPlay = true;
		
		public MenuLoader ()
		{
		}
		
		public static void Load ()
		{
			// Set up the graphics system
			GraphicsContext graphics = new GraphicsContext();
			
			// Initialize the UT Toolkit
			UISystem.Initialize(graphics);
			
			// Create the scene
			var start = new Menu.StartMenu();
			// Set the scene
			UISystem.SetScene(start, null);
			
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			
			while (isPlay) {
				graphics.Clear();
				UISystem.Update(Touch.GetData(0));
				UISystem.Render();
				graphics.SwapBuffers();
				SystemEvents.CheckEvents();
			}
			UISystem.Terminate();
			graphics.Dispose();
		}
	}
}

