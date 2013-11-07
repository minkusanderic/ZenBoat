using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Core;

namespace Main
{
	public class Rock
	{
		public Rock ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			
			ent.tag("rock");
			
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			
			
			
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/RockFBX.mdx"));
			
			var scale_x = width / m.model.BoundingSphere.W;
			var scale_y = height / m.model.BoundingSphere.W;
			m.scale = new Vector3(scale_x, scale_y, scale_x);
			
			var body = ent.attachComponent(new RigidBody(Math.Max(width,height)/2));
			body.is_static = true;
			//body.makeStatic();
			
			
			
			//m.scale = new Vector3(100, 100, 100);
		}
	}
}

