using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class BridgeDeco
	{
		public BridgeDeco ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
					    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Bridge.mdx"));
			
			m.scale = new Vector3 (20.0f, 50.0f, 20.0f);
			ent.Transform.Rotation = new Vector2(0, -1);
		}
	}
}
