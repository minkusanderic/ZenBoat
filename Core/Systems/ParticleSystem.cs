using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel;
using Sce.PlayStation.HighLevel.Physics2D;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Environment;
namespace Core
{
	public abstract class ParticleSystem
	{
		protected List<Particle> particles = new List<Particle>();
		protected bool regenerate = false;
		protected Vector3 position;
		/// <summary>
		/// Generates a single particle.
		/// </summary>
		/// <returns>
		/// The particle.
		/// </returns>
		protected abstract Particle GenerateParticle();
		
		/// <summary>
		/// Update all the particles
		/// </summary>
		protected abstract void Update ();
		
		protected virtual void Draw( GraphicsContext gc ) 
		{
			// draw ALL of the particles
			foreach( Particle p in particles )
			{
				// TODO: DRAW	
			}
		}
		public Particle this[int index]
		{
			get
			{
				return (Particle)particles[index];
			}
		}
		public int CountParticles
		{
			get { return particles.Count; }
		}
		

	}
}

