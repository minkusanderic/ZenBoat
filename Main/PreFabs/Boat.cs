using System;

using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.UI;
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
			
			String chosenBoat = SaveGameManager.GetValueFromKey("ChosenBoat");
			if ( chosenBoat == null || chosenBoat == "" ) chosenBoat = "RedBoat"; 
			
			ModelComponent m = ent.attachComponent(new ModelComponent("/Application/assets/" + chosenBoat + ".mdx"));
			m.scale = new Vector3(.5f, .5f, .5f);
			m.model.Materials[0].Emission = new Vector3( 0f , 0f , 0f);
			//m.model.Materials[0].Ambient = new Vector3( 1f , .5f , 5f );
			//m.model.Materials[0].Shininess = 1f;
			//m.model.Materials[0].Diffuse = new Vector3( 1f , 1f , 1f );
			
			//m.model.Materials[0].Specular = new Vector3( .1f , .1f , 1f );//
			//m.scale = new Vector3(50, 50, 50);
			//m.scale = new Vector3(5, 5, 5);
			
			ent.attachComponent( new RigidBody(m.model.BoundingSphere.W *.25f) );
			ent.attachComponent( new FrictionController(.05f) );
			ent.attachComponent( new SimpleController(() => {
			ent.FindComponent<RigidBody>().applyForce(new Vector2(10.0f, 0.0f));
			}));
			//ent.attachComponent( new RadialSplash());
			
			ent.attachComponent( new Respawner( ent.Transform.Position ) );
			//ent.attachComponent( new SimpleAction(move_initial));
			
			var rockSpawner = SceneManager.Instance.createEntity("RockSpawner");
			RockSpawner.create(rockSpawner, new Dictionary<String,String>());
			
			//var drag = SceneManager.Instance.createEntity("Drag");
			//Drag.create(drag, new Dictionary<String,String>());
			
			var water = SceneManager.Instance.createEntity("Water");	// add script to follow camera
			water.attachComponent(new WaterComponent());
			water.attachComponent(new FollowCameraComponent() );
			
			// Tiling the bank
			for (int i=0; i<4; i++)
			{
				var bank = SceneManager.Instance.createEntity("Bank" + i.ToString());
				bank.Transform.Position = new Vector2(((3220*i)+1610), 544/2 + 100);
				bank.attachComponent(new ModelComponent("/Application/assets/BankStraightTxtr.mdx")).scale = new Vector3(2.0f, 1.3f, 1.0f);
				ModelComponent bank_model = bank.FindComponent<ModelComponent>();
				bank_model.scale.Y *= 1.2f;
				bank_model.scale.X *= 1.2f;
				bank_model.layer = "under_water";
			}
		
			int size_of_level = 10000;
			// bottom
			var b1 = SceneManager.Instance.createEntity("b1");
			b1.Transform.Position = new Vector2(size_of_level/2 , 50 + -544/2 ); 
			b1.attachComponent(new RigidBody(size_of_level, 544/2)).is_static = true;

			// left
			var b2 = SceneManager.Instance.createEntity("b2");
			//b2.Transform.Position = new Vector2( size_of_level/2 , 544/2 );
			b2.Transform.Position = new Vector2( -960/2 , 544/2 );
			//b2.attachComponent(new RigidBody( size_of_level , 10 ) ).is_static = true;
			b2.attachComponent(new RigidBody(960/2, 544/2)).is_static = true;
			
			//top
			var b3 = SceneManager.Instance.createEntity("b3");
			b3.Transform.Position = new Vector2(size_of_level/2, 3 * 544/2 - 30);
			b3.attachComponent(new RigidBody(size_of_level, 544/2)).is_static = true;
			
			// right
			var b4 = SceneManager.Instance.createEntity("b4");
			b4.Transform.Position = new Vector2( size_of_level , 544/2 );
			//b4.Transform.Position = new Vector2(3 * 960/2  ,  544/2);
			b4.attachComponent(new RigidBody(100 , 544)).is_static = true;
			//b4.attachComponent(new RigidBody(960/2  , 544/2)).is_static = true;
			
			// Crane Counter
			var counter = SceneManager.Instance.createEntity("counter");
			var counterLabel = counter.attachComponent(new LabelComponent("Count: "));
			counter.Transform.Position.X = 1.0f;
			counter.Transform.Position.Y = 1.0f;
			
			counter.attachComponent(new SimpleController(
					() => {
						int sum = CollectibleManager.levelScore + CollectibleManager.stageScore;
						counterLabel.label.Text = "Score: " + sum;
			}));
			
			// Multiplier
			var multi = SceneManager.Instance.createEntity("multi");
			multi.Transform.Position.X = 832.0f;
			multi.Transform.Position.Y = 1.0f;
			//var multiLabel = multi.attachComponent(new LabelComponent("Muliplier: x"));
			
			multi.attachComponent(new SimpleController(
					() => {
						//multiLabel.label.Text = "Muliplier: x" + CollectibleManager.multiplier;
						//label.label.Text = "Count: " + CollectibleManager.m_iScore;
			}));
			
//			SceneManager.Instance.createEntity("ReturnToBoot")
//				.attachComponent(new SimpleController(
//					() => {
//						if ((GamePad.GetData(0).Buttons & GamePadButtons.Start) != 0)
//					{
//							SceneManager.Instance.currentState = GameState.PAUSED;
//							var graphics = (GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem));
//							
//							var pause = new Menu.Pause();
//							pause.Show();
//							//SceneManager.Instance.DestroyAll();
//							//LevelLoader.BootStrap()
//					}
//				}));
//			
//			SceneManager.Instance.createEntity("Reset")
//				.attachComponent(new SimpleController(
//					() => {
//						if ((GamePad.GetData(0).Buttons & GamePadButtons.Cross) != 0)
//					{
//							SceneManager.Instance.currentState = GameState.STOPPED;
//					}
//				}));
			
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

