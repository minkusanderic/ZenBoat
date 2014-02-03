using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class MapleTree
	{
		public MapleTree ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/MapleTree.mdx"));
			
			m.scale = new Vector3(8 , 8, 8);
			
		}
	}
}







