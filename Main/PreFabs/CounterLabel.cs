using System;
using Core;
using Sce.PlayStation.HighLevel.UI;
using System.Collections.Generic;

namespace Main
{
	public class CounterLabel
	{
		public CounterLabel ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "CounterLabel";
			//ent.tag("crane", "collectable");
			
			var m = ent.attachComponent(new LabelComponent("Count: "));
			ent.Transform.Position.X = 1.0f;
			ent.Transform.Position.Y = 1.0f;
			m.label.Text += CollectibleManager.m_iScore;
		}
	}
}

