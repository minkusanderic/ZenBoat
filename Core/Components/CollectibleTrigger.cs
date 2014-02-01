using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		int collectibleScore;
		public CollectibleTrigger (int worth) : base(SceneManager.Instance.Select("boat"))
		{
			collectibleScore = worth;
		}
		
		public override void onCollide(Entity target)
		{
			CollectibleManager.CollectItem( this.parent.Name , collectibleScore );
			this.parent.Destroy();
		}
	}
}

