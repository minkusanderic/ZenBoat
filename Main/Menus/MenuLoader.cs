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
		public static bool loadInstr = false;
		public static bool loadStory1 = false;
		public static bool loadStory2 = false;
		public static bool loadStory3 = false;
		public static bool loadStart = false;
		
		public MenuLoader ()
		{
		}
		
		public static void Load ()
		{
			// Set up the graphics system
			GraphicsContext graphics = new GraphicsContext();
			
			// Initialize the UI Toolkit
			UISystem.Initialize(graphics);
			
			// Create the scenes
			var start = new Menu.StartMenu();
			var instr = new Menu.Instructions();
			var story1 = new Menu.Story1();
			var story2 = new Menu.Story2();
			var story3 = new Menu.Story3();
			
			// Set the scene for the Start menu
			UISystem.SetScene(start, null);
			
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			
			while (isPlay) {
				graphics.Clear();
				UISystem.Update(Touch.GetData(0));
				 
				if (loadInstr)
				{
					UISystem.SetScene(instr,null);
					loadInstr = false;
				}
				
				if (loadStory1)
				{
					UISystem.SetScene(story1,null);
					loadStory1 = false;
				}
				
				if (loadStory2)
				{
					UISystem.SetScene(story2,null);
					loadStory2 = false;
				}
				
				if (loadStory3)
				{
					UISystem.SetScene(story3,null);
					loadStory3 = false;
				}
				
				if (loadStart)
				{
					UISystem.SetScene(start,null);
					loadStart = false;
				}
				UISystem.Render();
				graphics.SwapBuffers();
				SystemEvents.CheckEvents();
			}
			UISystem.Terminate();
			graphics.Dispose();
		}
	}
}

