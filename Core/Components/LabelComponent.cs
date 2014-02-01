using System;

using Sce.PlayStation;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.UI;

namespace Core
{
	public class LabelComponent : GraphicsComponent
	{
		public Label label;
		
		public LabelComponent (string title)
		{
			label = new Label();
			label.Text = title;
		}
	}
}

