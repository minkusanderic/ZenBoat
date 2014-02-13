using System;
using Core;

using Sce.PlayStation.Core;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Main
{
	public class Current
	{
		public Current ()
		{
		}
		
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			Console.WriteLine("CURRENT CREATE FUNCTION CALLED");	
			ent.tag("current");
			//SpriteComponent sprite = new SpriteComponent("/Application/Assets/whirlpool.png");
			//sprite.scale.X = width/50;
			//sprite.scale.Y = height/50;
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
			double angle =Convert.ToDouble(options["angle"]);
			ent.Transform.Rotation = new Vector2( (float)Math.Cos(angle) , -(float)Math.Sin( angle ) );
			SpriteComponent sc = new SpriteComponent("/Application/Assets/Arrow.png");
			sc.scale.X = width/250f;
			sc.scale.Y = height/250f;
			//CurrentModifier current_mod = new CurrentModifier("/Application/Assets/Current.png");
			//current_mod.scale.X = width/50;//Math.Cos(width)*;
			//current_mod.scale.Y = height/50;
			var m = ent.attachComponent(sc);
			//var n = ent.attachComponent(new CurrentModifier("/Application/Assets/Current.png")).scale = new Vector2(2f, 2f);
			//m.scale = new Vector2(.5f, .5f);
			RigidBody rb = new RigidBody( width/2 , height/2 );
			ent.attachComponent(rb);
			/*
			Core.SimpleController controller = new Core.SimpleController(() => {
				List<Entity> targets = SceneManager.Instance.FindEntitiesByTag("pushable").ToList();
				foreach(var obj in targets)
				{
					Console.WriteLine("Current Push: " + obj.Name);
					
						obj.FindComponent<RigidBody>().applyForce(new Vector2( 2f , 0f));
					
				}
			});
			*/
			SimpleTrigger trigger = new SimpleTrigger( SceneManager.Instance.Select("pushable"),
			                                          (t) =>
			{
				Console.WriteLine("TRIGGER");
				Entity pushable = t;
				pushable.FindComponent<RigidBody>().applyForce(200*new Vector2((float)Math.Cos(angle),-(float)Math.Sin(angle)));
				
			});
			ent.attachComponent( trigger );
		}
	}
}

