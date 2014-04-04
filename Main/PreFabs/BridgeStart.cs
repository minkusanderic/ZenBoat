using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class BridgeStart
	{
		public BridgeStart ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
					    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Bridge.mdx"));
			
			m.scale = new Vector3 (25.0f, 28.0f, 30.0f);
			ent.Transform.Rotation = new Vector2(0, -1);
		}
	}
}
