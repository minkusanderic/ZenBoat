using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		public CollectibleTrigger (Entity ent) : base(new List<Entity>(){ent})
		{
		}
		
		public override void onCollide(Entity target)
		{
			CollectibleManager.CollectItem( this.parent.Name );
			this.parent.Destroy();
		}
	}
}

