using System;
using System.Collections.Generic;
using System.Threading;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Audio;

namespace Core
{
	public class AudioSystem : Core.CoreSystem
	{
		List<BackgroundMusicComponent> bmgs = new List<BackgroundMusicComponent>();
		public AudioSystem ()
		{
		}
		
		public override void attachComponent (IComponent comp)
		{
			if(comp is BackgroundMusicComponent)
			{
				bmgs.Add( (BackgroundMusicComponent)comp );
			}
		}
		public override void destroyComponent (IComponent comp)
		{
			base.destroyComponent (comp);
		}
		
		public override void Update ()
		{
			//base.Update ();
		}
	}
}

