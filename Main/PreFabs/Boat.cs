using System;

using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;

using Sce.PlayStation.Core.Input;

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
			
			ent.attachComponent( new RigidBody(m.model.BoundingSphere.W *.25f) );
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
			
			var b1 = SceneManager.Instance.createEntity("b1");
			b1.Transform.Position = new Vector2(960/2, 50 + -544/2);
			b1.attachComponent(new RigidBody(960/2, 544/2)).is_static = true;
			
			var b2 = SceneManager.Instance.createEntity("b2");
			b2.Transform.Position = new Vector2(-960/2,544/2);
			b2.attachComponent(new RigidBody(960/2, 544/2)).is_static = true;
			
			//top
			var b3 = SceneManager.Instance.createEntity("b3");
			b3.Transform.Position = new Vector2(960/2,3 * 544/2 - 30);
			b3.attachComponent(new RigidBody(960/2, 544/2)).is_static = true;
			
			var b4 = SceneManager.Instance.createEntity("b4");
			b4.Transform.Position = new Vector2(3 * 960/2 ,544/2);
			b4.attachComponent(new RigidBody(960/2, 544/2)).is_static = true;
			
			SceneManager.Instance.createEntity("ReturnToBoot")
				.attachComponent(new SimpleController(
					() => {
						if ((GamePad.GetData(0).Buttons & GamePadButtons.Start) != 0)
					{
							SceneManager.Instance.DestroyAll();
							//LevelLoader.BootStrap()
					}
				}));
			
			SceneManager.Instance.createEntity("Reset")
				.attachComponent(new SimpleController(
					() => {
						if ((GamePad.GetData(0).Buttons & GamePadButtons.Cross) != 0)
					{
							SceneManager.Instance.DestroyAll();
							LevelLoader.Load(LevelLoader.selected_filename);
					}
				}));
			
			
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

