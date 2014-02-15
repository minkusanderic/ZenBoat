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
		private Sound 			sound = null;
        private SoundPlayer 	soundPlayer = null;
		
		public SFXComponent ()	{}
		public SFXComponent (	string file_path	)
		{
			SetSoundFromFile(file_path);
			soundPlayer = sound.CreatePlayer();
		}
		
		public void PlaySound()
		{
			soundPlayer.Stop();
			soundPlayer.Play();
		}
		
		public void SetSoundFromFile(	string file_name	)
		{
			//Console.WriteLine("Initing SFX music component");
			if ( file_name != null && file_name != "" )
				sound = new Sound( file_name );
			else
				throw new Exception( "No Audiopath Specified :(" );
			if ( soundPlayer == null )
				soundPlayer = sound.CreatePlayer();
		}
		
		/// <summary>
		/// Determines whether this sound instance is playing.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is playing; otherwise, <c>false</c>.
		/// </returns>
		public bool IsPlaying()
		{
			return false;
			//return soundPlayer.
		}
		
	}
}

