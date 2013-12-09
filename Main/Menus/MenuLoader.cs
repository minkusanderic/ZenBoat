using System;

namespace Main
{
	public class MenuLoader
	{
		public MenuLoader ()
		{
			var graphics = new GraphicsContext ();
			DemoScene.Demo demo = new DemoScene.Demo();
			
			UISystem.Initialize(graphics);
			UISystem.SetScene(demo);
			
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			while (true) {
				graphics.Clear ();
				UISystem.Update(Touch.GetData(0));
				UISystem.Render();
				graphics.SwapBuffers ();
			}
			
		}
	}
}

