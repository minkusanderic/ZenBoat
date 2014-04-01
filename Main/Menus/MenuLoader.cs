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
		public static bool loadStory = false;
		public static bool loadStart = false;
		public static bool loadLevel = false;
		public static bool loadCredit = false;
		public static bool loadStore = false;
		
		public MenuLoader ()
		{
		}
		
		public static void Load ( )
		{
			// Set up the graphics system
			GraphicsContext graphics = ((GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem))).graphics;
			// Initialize the UI Toolkit
			UISystem.Initialize(graphics);
			
			// Create the scenes
			var start = new Menu.StartMenu();
			var instr = new Menu.Instructions();
			var story = new Menu.Story();
			var level = new Menu.Levels();
			var credit = new Menu.Credits();
			var store = new Menu.Store();
			
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
				
				if (loadStory)
				{
					UISystem.SetScene(story,null);
					loadStory = false;
				}
				
				if (loadStart)
				{
					UISystem.SetScene(start,null);
					loadStart = false;
				}
				
				if (loadLevel)
				{
					UISystem.SetScene(level,null);
					loadLevel = false;
				}
				
				if (loadCredit)
				{
					UISystem.SetScene(credit,null);
					loadCredit = false;
				}
				
				if(loadStore)
				{
					UISystem.SetScene(store,null);
					loadStore = false;
				}
				
				UISystem.Render();
				graphics.SwapBuffers();
				SystemEvents.CheckEvents();
			}
			UISystem.SetScene(null,null);
			isPlay = true;
		}
	}
}

