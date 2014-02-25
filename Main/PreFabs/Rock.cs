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
			ent.Transform.Position += new Vector2(width/2, -height/2);
			var m = ent.attachComponent(new ModelComponent("/Application/Assets/GreyRockA.mdx"));
			m.layer = "under_water";
			//var scale_x = width * .01f;
			//var scale_y = height * .01f;
			var scale_x = width * .04f;
			var scale_y = height * .04f;
			m.scale = new Vector3(scale_x, scale_y, Math.Min(scale_x, scale_y));
			
			var body = ent.attachComponent(new RigidBody(Math.Max(width,height)/2));
			body.is_static = true;
			//ent.attachComponent( new RockTouchResponder( ) );
			//body.is_static = true;
			//body.makeStatic();
			//m.scale = new Vector3(100, 100, 100);
		}
		
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

