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
		private static Entity entity;
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			ent.Name = "Boat";
			ent.tag("boat", "pushable");
			entity = ent;
						    
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/Assets/BoatFBX.mdx"));
			m.scale = new Vector3(.5f, .5f, .5f);
			
			//m.scale = new Vector3(50, 50, 50);
			//m.scale = new Vector3(5, 5, 5);
			
			ent.attachComponent( new RigidBody(m.model.BoundingSphere.W *.5f) );
			ent.attachComponent( new FrictionController(.05f) );
			ent.attachComponent( new RadialSplash());
			
			ent.attachComponent( new Respawner( ent.Transform.Position ) );
			//ent.attachComponent( new SimpleAction(move_initial));
		}
		
		
		private static IEnumerable<bool> move_initial()
		{
			for(var i = 0; i < 5; i++)
			{
				entity.FindComponent<RigidBody>().applyForce(new Vector2(.25f, 0.0f));
				yield return true;
			}
		
		}
	}
	
	
}

