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
			
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			
			
			var water = SceneManager.Instance.createEntity("Water");
			water.attachComponent(new WaterComponent());
			
			var bank = SceneManager.Instance.createEntity("Bank");
			bank.Transform.Position = new Vector2(960/2, 544/2 + 100);
			bank.attachComponent(new ModelComponent("/Application/Assets/SimpleBank01.mdx")).scale = new Vector3(2.0f, 1.3f, 1.0f);
			ModelComponent bank_model = bank.FindComponent<ModelComponent>();
			bank_model.scale.Y *= 1.2f;
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

