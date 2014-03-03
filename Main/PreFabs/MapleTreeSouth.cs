using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.UI ;
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
			//use MapleNb for colored leaves or MapleNa for sticklike tree			    
			//ModelComponent m2 = ent.attachComponent(new ModelComponent("/Application/Assets/MapleTreeSouthBranches.mdx"));
			
			ModelComponent m2 = ent.attachComponent(new ModelComponent("/Application/Assets/MapleMED.mdx"));

			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/MapleTreeSouthLeaves.mdx"));
			m.layer = "trees";
			m.scale = new Vector3(8f , 8f, 8f);
			//m2.scale = new Vector3(8f, 8f, 8f);
			ent.tag("tree");
		}
	}
}


