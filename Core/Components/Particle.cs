using System;
using Core;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace Core
{
	public class Particle : Controller
	{
		Particles particles;
		public Particle ()
		{
			//Scene scene = new Scene();
			Console.WriteLine("here");
			particles = new Particles(2000);
			//var pinwheel = particles.ParticleSystem;
			//pinwheel.TextureInfo = new TextureInfo(new Texture2D("Application/WaterDrop.png",false));
		}
		public override void Update ()
		{
			
			base.Update ();
		}
	}
}

