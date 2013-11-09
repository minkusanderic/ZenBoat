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
		static Entity entity;
		delegate void HandleRockTouch();
		public static void create(Entity ent, Dictionary<String, String> options)
		{
			entity = ent;
			ent.tag("rock");
			
			int width = Convert.ToInt32(options["width"]);
			int height = Convert.ToInt32(options["height"]);
		
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/RockFBX.mdx"));
			
			var scale_x = width / m.model.BoundingSphere.W;
			var scale_y = height / m.model.BoundingSphere.W;
			m.scale = new Vector3(scale_x, scale_y, scale_x);
			
			var body = ent.attachComponent(new RigidBody(Math.Max(width,height)/2));
			
			ent.attachComponent( new TouchResponder( RockBeenTouched ) );
			//body.is_static = true;
			//body.makeStatic();
			//m.scale = new Vector3(100, 100, 100);
		}
		
		bool RockBeingHeld = false;
		static void RockBeenTouched()
		{
			
			entity.attachComponent( new RockFollowTouchController() );
			entity.Transform.Z = 100f;
			entity.FindComponent<RigidBody>().Destroy();
			
		}
		/*
		 * //Entity rock = SceneManager.Instance.createEntity("Rock");
			parent.attachComponent( new ModelComponent("\\Application\\resources\\Cube.mdx") );
			parent.attachComponent( new SuicideController( 50 ) );
			
			Entity boat = SceneManager.Instance.FindEntity("Boat");
			if ( Vector2.Distance(
					parent.Transform.Position , boat.Transform.Position	)
					< 100f )
			{
				RigidBody rb = boat.FindComponent<RigidBody>();
				rb.applyForce( force*new Vector2(	
					        rb.parent.Transform.Position.X - parent.Transform.Position.X , 
					     	rb.parent.Transform.Position.Y - parent.Transform.Position.Y) );
			}
							
			int num_particles = 20;
			for ( int i = 0 ; i < 360; i += num_particles )
			{
				Entity particle = SceneManager.Instance.createEntity( "particle" + i );
				//particle.attachComponent( new RippleParticlePusher( i , parent.Transform.Position.X , parent.Transform.Position.Y		) );
				particle.attachComponent( new ModelComponent(	"\\Application\\resources\\Cube.mdx" ) );
				particle.attachComponent( new SuicideController( 50 ) );
			}
		 */
	}
}

