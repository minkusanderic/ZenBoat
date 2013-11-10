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
		private Sound 			sound;
        private SoundPlayer 	soundPlayer;
		
		public SFXComponent ()	{}
		public SFXComponent (	string file_path	)
		{
			SetSoundFromFile(file_path);
			soundPlayer = sound.CreatePlayer();
		}
		
		public void PlaySound()
		{
			soundPlayer.Play();
		}
		
		public void SetSoundFromFile(	string file_name	)
		{
			Console.WriteLine("Initing SFX music component");
			if ( file_name != null && file_name != "" )
				sound = new Sound( file_name );
			else
				throw new Exception( "No Audiopath Specified :(" );
			
			
			
		}
		
	}
}

