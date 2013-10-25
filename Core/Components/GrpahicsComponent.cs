using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using System.Xml.Serialization;

namespace Core
{
	public class GraphicsComponent : Component<GraphicsSystem>
	{
		
		public GraphicsComponent ()
		{
			
		}
		
		
		[XmlIgnore]
		public SpriteUV sprite {get; set;}
	}
}

