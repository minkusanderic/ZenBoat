using System;
using Sce.PlayStation.Core;
namespace Core
{
	public class Ripple 	: Controller
	{
		float force = 250.0f;
		public Ripple ()
		{
						
		}
		
		public void DoRipple()
		{
			//Entity rock = SceneManager.Instance.createEntity("Rock");
			//parent.attachComponent( new ModelComponent("\\Application\\resources\\Cube.mdx") );
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
			Console.WriteLine("HEHREKRKJEH");
			for ( int i = 0 ; i < 360; i += num_particles )
			{
				Entity particle = SceneManager.Instance.createEntity( "particle" + i );
				particle.attachComponent( new RippleParticlePusher( i , parent.Transform.Position.X , parent.Transform.Position.Y		) );
				particle.attachComponent( new ModelComponent(	"\\Application\\resources\\Cube.mdx" ) );
				particle.attachComponent( new SuicideController( 50 ) );
			}	
			Entity sfx = SceneManager.Instance.FindEntity("SFX_Music");
			SFXComponent sfx_comp = sfx.FindComponent<SFXComponent>();
			sfx_comp.PlaySound();
		}
	}
}

