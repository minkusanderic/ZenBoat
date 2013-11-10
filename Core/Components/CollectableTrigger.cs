using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectableTrigger : TriggerComponent
	{
		public CollectableTrigger (Entity ent) : base(new List<Entity>(){ent})
		{
		}
		
		public override void onCollide(Entity target)
		{
			Console.WriteLine("collided");
			this.parent.Destroy();
		}
	}
}

