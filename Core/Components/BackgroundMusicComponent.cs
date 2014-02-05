using System;
using System.Collections.Generic;
using System.Threading;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Audio;
namespace Core
{
	public class BackgroundMusicComponent : SoundComponent
	{
		
		Bgm background_music;
		BgmPlayer background_music_player;
		public BackgroundMusicComponent (){}
		public BackgroundMusicComponent (string file_path)
		{
			Console.WriteLine("Initing background music component");
			if ( file_path != null && file_path != "" )
				background_music = new Bgm( file_path ); 
			else
				throw new Exception( "No Audiopath Specified :(" );
			
			// Check if there is already a background music playing
			background_music_player = background_music.CreatePlayer();
			background_music_player.Play();
		}
		
		public void setVolume(float volume) 
		{
			background_music_player.Volume = volume;
		}
		
		public void loop(bool isLooping) 
		{
			background_music_player.Loop = isLooping; 
		}
		
	}
}

