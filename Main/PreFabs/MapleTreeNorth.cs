using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class MapleTreeNorth
	{
		public MapleTreeNorth ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			//use MapleNb for colored leaves or MapleNa for sticklike tree	
			
			ModelComponent m2 = ent.attachComponent(new ModelComponent("/Application/Assets/MapleTreeNorthBranches.mdx"));
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/MapleTreeNorthLeaves.mdx"));
			m2.scale = new Vector3(8f, 8f, 8f);
			m.scale = new Vector3(8f , 8f, 8f);
			
		}
	}
}




