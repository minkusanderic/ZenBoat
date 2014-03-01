using System;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Core;
namespace Main
{
	public class LooseBlossoms
	{
		public LooseBlossoms ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			//ent.tag("pushable");
			//use MapleNb for colored leaves or MapleNa for sticklike tree			    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/LooseBlossomsC.mdx"));
			
			m.scale = new Vector3(10f , 10f, 10f);
			
		}
	}
}

