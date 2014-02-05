using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		int collectibleScore;
		SFXComponent sound;
		public CollectibleTrigger (int worth) : base(SceneManager.Instance.Select("boat"))
		{
			collectibleScore = worth;
		}
		
		public override void onCollide(Entity target)
		{
			CollectibleManager.CollectItem(this.parent,  this.parent.Name , collectibleScore );
			this.parent.Enabled = false;
			if ( sound == null )
				sound = this.parent.attachComponent( new SFXComponent("/Application/Assets/menuUp.wav" ) );
			sound.PlaySound();
		}
	}
}

