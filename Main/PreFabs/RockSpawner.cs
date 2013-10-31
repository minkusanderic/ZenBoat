using System;
using System.Collections.Generic;
using Core;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;


namespace Main
{
	public class RockSpawner 
	{
		class RockSpawnerLogic : Core.Controller
		{
			bool touchDown = false;
			TouchController touchController;
			public RockSpawnerLogic( TouchController tc )
			{
				Console.WriteLine("Making RockSpawner");
				touchController = tc;
			}
			public override void Update ()
			{
				if ( touchController.getTouchData().Count > 0 )
				{
					foreach( TouchData td in touchController.getTouchData() )
					{
						if ( !touchDown )
						{
							touchDown = true;
							float interp_x =  td.X + .5f;
							float interp_y = -td.Y + .5f;
							
							Console.WriteLine("x: " + (interp_x * width) + "\t\ty: " + interp_y * height );
							Entity rock = SceneManager.Instance.createEntity("Rock");
							rock.attachComponent( new ModelComponent("\\Application\\resources\\Cube.mdx") );
							rock.Transform.Position = 2 * new Vector2( (interp_x * width)  , interp_y * height );
							break;
						}
					}
				} 
				else
				{
					touchDown = false;	
				}
				base.Update ();
			}
		}
		static float width	= 960; 
		static float height = 544;
		static TouchController touchController;
		
		
		public RockSpawner ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			touchController = (TouchController)ent.attachComponent(	new TouchController()	);
			
			ent.attachComponent( new RockSpawnerLogic( touchController ) );
		}
	}
}

