using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class CherryBlossomSouth
	{
		public CherryBlossomSouth ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			//use MapleNb for colored leaves or MapleNa for sticklike tree			    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/CherryBlossomS.mdx"));
			m.layer = "trees";
			m.scale = new Vector3(8f, 8f, 8f);
			ent.tag("tree");
		}
	}
}


