using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.Physics2D;
	
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class TriggerComponent : Component<PhysicsSystem>
	{
		public List<Entity> targets;
		
		public TriggerComponent (List<Entity> targets)
		{
			this.targets = targets;
		}
		
		public override void Update()
		{
			var physics = (PhysicsSystem)SceneManager.Instance.getSystem(typeof(PhysicsSystem));
			foreach(var target in this.targets){
			if (physics.isColliding(this.require<RigidBody>(), SceneManager.Instance.GetComponent<RigidBody>(target)))
			{
				this.onCollide(target);
			}
			}
		}
		
		public void addTarget(Entity target){this.targets.Add(target);}
		
		public virtual void onCollide(Entity target) {}
		
	}
}

