using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;

using Core;

namespace Main
{
	public class MenuLoader
	{
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
			
			while (true) {
				graphics.Clear();
				UISystem.Update(Touch.GetData(0));
				UISystem.Render();
				graphics.SwapBuffers();
			}
		}
	}
}

