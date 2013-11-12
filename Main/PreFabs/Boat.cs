using System;

using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;

using Core;
namespace Main
{
	public class Boat
	{
		public Boat ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Boat";
			ent.tag("boat", "pushable");
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/BoatFBX.mdx"));
			m.scale = new Vector3(.5f, .5f, .5f);
			
			//m.scale = new Vector3(50, 50, 50);
			//m.scale = new Vector3(5, 5, 5);
			
			ent.attachComponent( new RigidBody(m.model.BoundingSphere.W *.5f) );
			ent.attachComponent( new FrictionController(.05f) );
		}
		
		
		private static IEnumerable<bool> get_done()
		{
			for(var i = 0; i < 5; i++)
			{
				yield return true;
			}
		
		}
	}
	
	
}

