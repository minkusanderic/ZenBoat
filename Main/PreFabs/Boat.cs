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
			
			int width = 200;
			int height = 100;
			
		    
			var m = (ModelComponent)ent.attachComponent(new CubeComponent(100,50, new Vector3(1.0f, 0.0f,0.0f)));
			Console.WriteLine(((ModelComponent)m).model.BoundingSphere.W.ToString());
			//m.scale = new Vector3(50, 50, 50);
			ent.attachComponent( new RigidBody(m.scale.X) );
			ent.attachComponent( new FrictionController(.25f) );
		}
	}
}

