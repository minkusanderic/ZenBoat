using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class Pagoda
	{
		public Pagoda ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
					    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/Pagoda.mdx"));
			m.scale = new Vector3(4f , 4f, 4f);
			ent.Transform.Position = new Vector2( ent.Transform.Position.X - 30f , ent.Transform.Position.Y + 10f );
			
		}
	}
}



