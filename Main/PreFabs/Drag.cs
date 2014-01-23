using System;
using System.Collections.Generic;
using Core;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;


namespace Main
{
	public class Drag 
	{
		
		class DragLogic : Core.Controller
		{
			float force = 3f;
			bool touchDown = false;
			TouchController touchController;
			int count = 0;
			
			public DragLogic( TouchController tc )
			{
				Console.WriteLine("Making RockSpawner");
				touchController = tc;
				rock.attachComponent(new RadialSplash());
			}
			bool b = true;
			
			private Selector pushables = new Selector("pushable");
			private Entity rock = SceneManager.Instance.createEntity("Rock");
			public override void Update ()
			{
				var boat = SceneManager.Instance.FindEntity("Boat");
				if ( ((TouchSystem)SceneManager.Instance.getSystem(typeof(TouchSystem))).getTouchData().Count > 0 )
				{
					foreach( TouchData td in touchController.getTouchData() )
					{
						//touchDown = true;
						float interp_x =  td.X + .5f;
						float interp_y = -td.Y + .5f;
						
						//Console.WriteLine("x: " + (interp_x * width) + "\t\ty: " + interp_y * height );
						
						//rock.attachComponent( new ModelComponent("\\Application\\resources\\Cube.mdx") );
						
						var graphics = (GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem));
						Vector3 pos = graphics.camera_pos;
						Vector3 dir = (graphics.camera_eye - pos).Normalize();
						
						Vector3 right = dir.Cross(Vector3.UnitY).Normalize();
						Vector3 up = right.Cross(dir).Normalize();
						
						float ratio = (float)width/(float)height;
						
						Vector3 rel_right = td.X * (float)Math.Tan(FMath.Radians(45.0f/2.0f)) * 2 * 1.77f * right;
						Vector3 rel_up = -td.Y * (float)Math.Tan(FMath.Radians(45.0f/2.0f)) * 2 * 1.77f * (1/ratio) * up;
						
						rock.Transform.Position = TouchSystem.RayCastOntoPlane(pos, dir + rel_right + rel_up).Xy;
						//rock.attachComponent( new SuicideController( 50 ) );
						
						
						count ++;
						if ( true )
						{
							//Console.WriteLine( "dist: " + Vector2.Distance(
							//	rock.Transform.Position , boat.Transform.Position	) );
							foreach( var pushable in pushables.get())
							{
								if ( Vector2.Distance(
									rock.Transform.Position , pushable.Transform.Position	)
									< 150f )
								{
									RigidBody rb = pushable.FindComponent<RigidBody>();
									rb.applyForce( force*new Vector2(	
									               rb.parent.Transform.Position.X - rock.Transform.Position.X , 
									               rb.parent.Transform.Position.Y - rock.Transform.Position.Y) );
								}
							}
							touchDown = false;
							count = 0;
						}
						int num_particles = 20;
						for ( int i = 0 ; i < 360; i += num_particles )
						{
							
							Entity particle = SceneManager.Instance.createEntity( "particle" + i );
							particle.attachComponent( new RippleParticlePusher( i , rock.Transform.Position.X , rock.Transform.Position.Y		) );
							//particle.attachComponent( new ModelComponent(	"\\Application\\resources\\Cube.mdx" ) );
							particle.attachComponent( new SuicideController( 50 ) );
						}
						
							break;
						}
					}
				base.Update ();
			}
		}
		static float width	= 960; 
		static float height = 544;
		static TouchController touchController;
		
		
		public Drag ()
		{
		}
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			touchController = ent.attachComponent(	new TouchController()	);
			
			ent.attachComponent( new DragLogic( touchController ) );
		}
	}
}

