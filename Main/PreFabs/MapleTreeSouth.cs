using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class MapleTreeSouth
	{
		public MapleTreeSouth ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			//use MapleSb for colored leaves or MapleSa for sticklike tree			    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/MapleSb.mdx"));
			
			m.scale = new Vector3(8 , 8, 8);
			
		}
	}
}







