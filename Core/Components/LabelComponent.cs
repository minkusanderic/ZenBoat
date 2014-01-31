using System;

using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.UI;

namespace Core
{
	public class LabelComponent : GraphicsComponent
	{
		private GraphicsContext graphics = new GraphicsContext();
		private Label l;
		
		public LabelComponent ()
		{
			l = new Label();
			l.Text = "Hello";
			l.X = 0;
			l.Y = 0;
		}
	}
}

