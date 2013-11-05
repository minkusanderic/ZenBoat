using System;

namespace Core
{
	public class FrictionController : Core.Controller
	{
	
		public FrictionController (float coefficent)
		{
			this.coefficent = coefficent;
		}
		
		private float coefficent = 0.0f;
		
		public override void Update()
		{
			var body = this.require<RigidBody>();
			body.applyForce(-body.Velocity * coefficent);
		}

	}
}

