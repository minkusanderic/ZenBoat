using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Environment;

using System.Collections;
using System.Collections.Generic;



// Include 2D Physics Framework
using Sce.PlayStation.HighLevel.Physics2D;


namespace Core
{
	public class PhysicsSystem : Core.CoreSystem
	{
		public PhysicsScene physics;
		public List<RigidBody> bodies;
		private List<TriggerComponent> triggers = new List<TriggerComponent>();
		
		public PhysicsSystem ()
		{
			physics = new PhysicsScene();
			physics.InitScene();
			physics.gravity = new Vector2(0.0f, 0.0f);
			physics.SceneMin = new Vector2(-50000, -50000);
			physics.SceneMax = new Vector2(50000, 50000);
			bodies = new List<RigidBody>();
			physics.numBody = 0;
		}
		
		private int next_id = 0;
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is RigidBody)
			{
				var rigid_body = (RigidBody)comp;
				PhysicsShape shape;
				if(rigid_body.dimentions.Y == 0.0f)
				{
					shape = physics.AddSphereShape(rigid_body.dimentions.X);
				}
				else
				{
					shape = physics.AddBoxShape(rigid_body.dimentions);
					//shape = physics.AddSphereShape(rigid_body.dimentions.X);
				}
				bodies.Add(rigid_body);
				
				rigid_body.body = physics.AddBody(shape, rigid_body.Mass);
		
				//rigid_body.body = physics.sceneBodies[next_id];
				rigid_body.body.position = rigid_body.parent.Transform.Position;
				rigid_body.body.Rotation = Vector2.Angle(Vector2.UnitX, rigid_body.parent.Transform.Rotation);
				
				if(rigid_body.is_static)
				{
					rigid_body.body.SetBodyStatic();
				}
				//physics.numShape++;
				//physics.numBody++;
				next_id++;
			}
			if(comp is TriggerComponent)
			{
				((TriggerComponent)comp).require<RigidBody>().body.SetBodyTrigger();
				triggers.Add((TriggerComponent)comp);
			}
			
		}
		
		public override void Update()
		{
			foreach(var body in this.bodies)
			{
				if ( !body.parent.Enabled ) 
				{
					body.body.Sleep = true;
					
					continue;
				}
				else
				{
					body.body.Sleep = false;
				}
				body.body.position = body.parent.Transform.Position;
				body.body.Rotation = Vector2.Angle(Vector2.UnitX, body.parent.Transform.Rotation);
			}
			
			physics.SimDt = Timer.DeltaTime;
			physics.Simulate();
#if !DEBUG
			physics.Simulate(); //Uncomment if running on PS Vita
#endif
			foreach(var body in this.bodies)
			{
				if ( !body.parent.Enabled ) continue;
				
				body.parent.Transform.Position = body.body.position;
				body.parent.Transform.Rotation = Vector2.UnitX.Rotate(body.body.Rotation);
			}
			foreach(var trigger in this.triggers)
			{
				if ( !trigger.parent.Enabled ) continue;
				trigger.Update();
			}
			
		}
		
		public bool isColliding(RigidBody body1, RigidBody body2)
		{
			return physics.QueryContact(body1.body, body2.body);
		}
		public override void destroyComponent (IComponent comp)
		{
			if(comp is RigidBody)
			{
				physics.DeleteBody(((RigidBody)comp).body);
				physics.numShape = 0;
				bodies.Remove((RigidBody)comp);
			}
			if(comp is TriggerComponent)
			{
				triggers.Remove((TriggerComponent)comp);
			}
			base.destroyComponent (comp);
		}
	}
}

