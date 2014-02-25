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
					    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/Pagoda.mdx"));
			m.scale = new Vector3(8f , 8f, 8f);
			
		}
	}
}



