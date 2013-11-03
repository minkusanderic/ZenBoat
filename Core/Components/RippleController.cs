using System;
using Sce.PlayStation.Core;
using System.Collections.Generic;
namespace Core
{
	public class RippleController : Core.Controller
	{
		float radius		=	300f; 	// The radius goes up
		float force 		= 	20f;	// the force goes down over time
		float radius_lerp 	= 	2f;
		float force_lerp 	= 	2f;
		
		public RippleController ()
		{
		}
		float f = 500;
		public override void Update ()
		{
			// if near another object that is pushable
			//foreach( KeyValuePair<string, Entity> kvp in SceneManager.Instance.
			//this.parent.Transform.Position = new Vector2( f++ , 200f ); 
			//Entity boat = SceneManager.Instance.GetEntity("Boaty");
			RigidBody rb =  require<RigidBody>();
			rb.applyForce( 	new Vector2( 0f , 0f )	);
			//Console.WriteLine(parent.Name + "\t" + parent.Transform.Position);
			//
			base.Update ();
		}
		
	}
}

