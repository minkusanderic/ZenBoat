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
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/CherryBlossomS.mdx"));
			
			m.scale = new Vector3(8 , 8, 8);
			
		}
	}
}

