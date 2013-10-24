using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;

namespace Core
{
	public class RigidBody : Component<PhysicsSystem>
	{
		public PhysicsShape shape;
		public PhysicsBody body;
		
		public int id;
		public float Mass = 1.0f;
		
		public bool is_static {get;set;}
		
		public Vector2 Velocity
		{
			get { return this.body.Velocity;}
			set { this.body.Velocity = value;}
		}
		
		
		public RigidBody ()
		{
			this.shape = new PhysicsShape(50.0f);
	
		}
		
		public RigidBody (float radius)
		{
			this.shape = new PhysicsShape(radius);
		}
		
		public RigidBody (float width, float height)
		{
			this.shape = PhysicsShape.CreateConvexHull(new Vector2[] {new Vector2(-width/2, height/2),
																	  new Vector2(width/2, height/2),
																	  new Vector2(width/2, -height/2),
																	  new Vector2(-width/2, -height/2)}, 4);
			//this.shape = new PhysicsShape(new Vector2(width, height));
		}
		
		public void makeStatic()
		{
			this.body.SetBodyStatic();
		}
		
		public void makeTrigger()
		{
			this.body.SetBodyTrigger();
		}
		
		public void applyForce(Vector2 vect)
		{
			this.body.ApplyForce(this.body.Force + vect);
		}
		
		public void applyTorque(float power)
		{
			this.body.ApplyTorque(this.body.Torque + power);
		}
		
		public void updateTransformData()
		{
		
			body.Position = this.parent.Transform.Position;
			body.Rotation = Vector2.Angle(Vector2.UnitX, this.parent.Transform.Rotation);
			
			
		}
		
		
	}
}

