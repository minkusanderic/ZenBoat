using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class TulipNorth
	{
		public TulipNorth ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.Transform.Rotation = new Vector2(0f, 1f);
			//ent.Transform.SetAngle(0f);
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/RotatedTulipBunch2.mdx"));
		
			m.scale = new Vector3(2.5f , 2.5f, 2.5f);
			
		}
	}
}


