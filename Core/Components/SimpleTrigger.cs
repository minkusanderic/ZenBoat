using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class SimpleTrigger : TriggerComponent
	{
		private Action<Entity> on_collide;
		public SimpleTrigger (List<Entity> ents, Action<Entity> on_collide) : base(ents)
		{
			this.on_collide = on_collide;
		}
		
		public override void onCollide (Entity target)
		{
			this.on_collide(target);
		}
	}
}

