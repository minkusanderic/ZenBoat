using System;
using System.Collections.Generic;
using System.Threading;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Audio;

namespace Core
{
	public class SFXComponent : SoundComponent
	{
		private Sound sound;
        private SoundPlayer soundPlayer;
		
		public SFXComponent (){}
		public SFXComponent (string file_path)
		{
			Console.WriteLine("Initing SFX music component");
			if ( file_path != null && file_path != "" )
				sound = new Sound( file_path );
			else
				throw new Exception( "No Audiopath Specified :(" );
			
			soundPlayer = sound.CreatePlayer();
			//soundPlayer.Play();
		}
		
		public void PlaySound()
		{
			soundPlayer.Play();
		}
	}
}

