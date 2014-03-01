using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Tulip
	{
		public Tulip ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.Transform.Rotation = new Vector2(0f, 1f);
			//ent.Transform.SetAngle(0f);
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/MoreColorsTulips.mdx"));
		
			m.scale = new Vector3(2f , 2f, 2f);
			
		}
	}
}


