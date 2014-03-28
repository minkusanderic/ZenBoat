using System;
using Core;

using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class CollectibleTrigger : TriggerComponent
	{
		int collectibleScore;
		//SFXComponent 	sound;
		//static SFXComponent[] 	sounds = null; //= new SFXComponent[5];
		
		bool is_animating = false;
		
		public CollectibleTrigger (int worth) : base(SceneManager.Instance.Select("boat"))
		{
			collectibleScore = worth;
			/*
			if ( sounds == null )
			{
				sounds = new SFXComponent[5];
				sounds[0] = new SFXComponent("/Application/assets/Sound/SFX/Crane" + 1 + ".wav");
				sounds[1] = new SFXComponent("/Application/assets/Sound/SFX/Crane" + 2 + ".wav");
				sounds[2] = new SFXComponent("/Application/assets/Sound/SFX/Crane" + 3 + ".wav");
				sounds[3] = new SFXComponent("/Application/assets/Sound/SFX/Crane" + 4 + ".wav");
				sounds[4] = new SFXComponent("/Application/assets/Sound/SFX/Crane" + 5 + ".wav");
			}
			*/
			//= sound.SetSoundFromFile("/Application/assets/Sound/SFX/Crane" + i + ".wav");
			
		}
		
		public override void onCollide(Entity target)
		{
			if(!is_animating)
			{
				CollectibleManager.CollectItem(this.parent,  this.parent.Name , collectibleScore );
				is_animating = true;
			
			//this.parent.Enabled = false;
			//if ( sound == null )
				//sound = this.parent.attachComponent( new SFXComponent("/Application/assets/WaterDrop.wav") ) ;
			int i = CollectibleManager.multiplier;
			if ( i < 1 || i > 5 ) i = 1;	// some crappy error checking..
				
			((AudioSystem)(SceneManager.Instance.getSystem(typeof(AudioSystem)))).PlaySound("/Application/assets/Sound/SFX/Crane" + i + ".wav");
			//sound = sounds[i-1];
			//sound.SetSoundFromFile("/Application/assets/Sound/SFX/Crane" + i + ".wav");
			//sound.PlaySound();
			SaveGameManager.SaveString("GotCrane" , SceneManager.Instance.GetCurrentLevelName() + this.parent.GetID() ); 
			this.parent.attachComponent(new SimpleController( () => {
				if(this.parent.Transform.Z < 600.0f)
				{
					this.parent.Transform.Z = this.parent.Transform.Z + 20.0f;
				}
				else
				{
					this.parent.Enabled = false;
					this.is_animating = false;
				}
			}));
			}
		}
	}
}

