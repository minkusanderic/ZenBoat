using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		int collectibleScore;
		SFXComponent 	sound;
		SFXComponent[] 	sounds = new SFXComponent[5];
		
		public CollectibleTrigger (int worth) : base(SceneManager.Instance.Select("boat"))
		{
			collectibleScore = worth;
			sounds[0] = new SFXComponent("/Application/Assets/Sound/SFX/Crane" + 1 + ".wav");
			sounds[1] = new SFXComponent("/Application/Assets/Sound/SFX/Crane" + 2 + ".wav");
			sounds[2] = new SFXComponent("/Application/Assets/Sound/SFX/Crane" + 3 + ".wav");
			sounds[3] = new SFXComponent("/Application/Assets/Sound/SFX/Crane" + 4 + ".wav");
			sounds[4] = new SFXComponent("/Application/Assets/Sound/SFX/Crane" + 5 + ".wav");
			//= sound.SetSoundFromFile("/Application/Assets/Sound/SFX/Crane" + i + ".wav");
			
		}
		
		public override void onCollide(Entity target)
		{
			CollectibleManager.CollectItem(this.parent,  this.parent.Name , collectibleScore );
			this.parent.Enabled = false;
			if ( sound == null )
				sound = this.parent.attachComponent( new SFXComponent("/Application/Assets/WaterDrop.wav") ) ;
			int i = CollectibleManager.multiplier;
			if ( i < 1 || i > 5 ) i = 1;	// some crappy error checking..
			sound = sounds[i-1];
			//sound.SetSoundFromFile("/Application/Assets/Sound/SFX/Crane" + i + ".wav");
			sound.PlaySound();
		}
	}
}

