using System;

using System.Collections;
using System.Collections.Generic;

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
			
			int width = 200;
			int height = 100;
			
		    
			var m = (ModelComponent)ent.attachComponent(new ModelComponent("/Application/resources/Rock.mdx"));
			Console.WriteLine(((ModelComponent)m).model.BoundingSphere.W.ToString());
			m.scale = 50;
			ent.attachComponent( new RigidBody(m.scale) );
			ent.attachComponent( new FrictionController(.25f) );
		}
	}
}

