using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		public CollectibleTrigger () : base(SceneManager.Instance.Select("boat"))
		{
		}
		
		public override void onCollide(Entity target)
		{
			CollectibleManager.CollectItem( this.parent.Name );
			this.parent.Destroy();
		}
	}
}

