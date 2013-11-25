using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
	
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class TriggerComponent : Component<PhysicsSystem>
	{
		public Selector targets;
		
		public TriggerComponent (Selector targets)
		{
			this.targets = targets;
		}
		
		public override void Update()
		{
			var physics = (PhysicsSystem)SceneManager.Instance.getSystem(typeof(PhysicsSystem));
			foreach(var target in this.targets.get()){
			if (physics.isColliding(this.require<RigidBody>(), target.FindComponent<RigidBody>()))
			{
				this.onCollide(target);
			}
			}
		}
		
		public virtual void onCollide(Entity target) {}
		
	}
}

