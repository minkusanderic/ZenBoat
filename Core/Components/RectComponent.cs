using System;

namespace Core
{
	public class RectComponent : GraphicsComponent
	{
		public RectComponent ()
		{
			this.width = 1;
			this.height = 1;
		}
		public RectComponent (int width, int height) 
		{
			this.width = width;
			this.height = height;
		}
		
		public int width, height;
	}
}

