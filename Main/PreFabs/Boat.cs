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
						    
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/BoatFBX.mdx"));
			
			//m.scale = new Vector3(50, 50, 50);
			//m.scale = new Vector3(5, 5, 5);
			
			ent.attachComponent( RigidBody.CreateFromModel(m) );
			ent.attachComponent( new FrictionController(.25f) );
			//ent.attachComponent( new Core.SimpleAction(get_done));
		}
		
		
		private static IEnumerable<bool> get_done()
		{
			for(var i = 0; i < 5; i++)
			{
				Console.WriteLine("Hello");
				yield return true;
			}
		
		}
	}
	
	
}

