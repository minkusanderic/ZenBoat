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
			float force = 100f;
			bool touchDown = false;
			TouchController touchController;
			public RockSpawnerLogic( TouchController tc )
			{
				Console.WriteLine("Making RockSpawner");
				touchController = tc;
			}
			bool b = true;
			public override void Update ()
			{
				var boat = SceneManager.Instance.FindEntity("Boat");
				if ( touchController.getTouchData().Count > 0 )
				{
					foreach( TouchData td in touchController.getTouchData() )
					{
						if ( !touchDown )
						{
							touchDown = true;
							float interp_x =  td.X + .5f;
							float interp_y = -td.Y + .5f;
							
							//Console.WriteLine("x: " + (interp_x * width) + "\t\ty: " + interp_y * height );
							Entity rock = SceneManager.Instance.createEntity("Rock");
							rock.attachComponent( new ModelComponent("\\Application\\resources\\Cube.mdx") );
							rock.Transform.Position = new Vector2( (interp_x * width)  , interp_y * height );
							rock.attachComponent( new SuicideController( 50 ) );
							
							if ( b )
							{
								Console.WriteLine( "dist: " + Vector2.Distance(
									rock.Transform.Position , boat.Transform.Position	) );
								if ( Vector2.Distance(
									rock.Transform.Position , boat.Transform.Position	)
									< 100f )
								{
									RigidBody rb = boat.FindComponent<RigidBody>();
									rb.applyForce( force*new Vector2(	
									               rb.parent.Transform.Position.X - rock.Transform.Position.X , 
									               rb.parent.Transform.Position.Y - rock.Transform.Position.Y) );
								}
							} 
							int num_particles = 20;
							for ( int i = 0 ; i < 360; i += num_particles )
							{
								Entity particle = SceneManager.Instance.createEntity( "particle" + i );
								particle.attachComponent( new RippleParticlePusher( i , rock.Transform.Position.X , rock.Transform.Position.Y		) );
								particle.attachComponent( new ModelComponent(	"\\Application\\resources\\Cube.mdx" ) );
								particle.attachComponent( new SuicideController( 50 ) );
							}
							
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
			touchController = ent.attachComponent(	new TouchController()	);
			
			ent.attachComponent( new RockSpawnerLogic( touchController ) );
		}
	}
}

