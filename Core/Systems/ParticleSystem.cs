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
using System.Threading ;
using System.Diagnostics ;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.HighLevel.Model ;

namespace Core
{
	public class ParticleSystem : CoreSystem
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
		protected virtual Particle GenerateParticle(SpriteComponent sc){return null;}
		Particle original_particle;
		List<Particle> toRemove = new List<Particle>();
		/// <summary>
		/// Update all the particles
		/// </summary>
		public override void Update ()
		{
			foreach( Particle p in toRemove )
			{
				p.ResetParticle();
			}
			toRemove.Clear();
			Particle part;
			int count = particles.Count;
			for( int i = 0; i < count ; i ++ )
			{
				part = particles[i];
				//Console.WriteLine(part.Life);
				part.Update();
				if ( part.Life > 100 )
				{
					toRemove.Add(part);
					//particles.RemoveAt(i--);	
				}
			}
			
			
		}
		
		/*
		protected virtual void Draw( GraphicsContext gc ) 
		{
			// draw ALL of the particles
			foreach( Particle p in particles )
			{
				// TODO: DRAW	
			}
		}
		*/
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
		
	
		
		public virtual void Render(	GraphicsSystem g, Matrix4 proj, Matrix4 view	)
		{
			int i = 0;
			
			particles.Sort(delegate(Particle x, Particle y)
	        {
	            if 		(x.Position.Z > y.Position.Z) return 1;
	            else if (x.Position.Z < y.Position.Z) return -1;
	            else return 0;
	        });
			foreach(var part in particles)
			{
				part.Sprite.scale *= .9999f;
				Matrix4 world = Matrix4.Identity ;
			    Vector3 scale = new Vector3(part.Sprite.scale.X, part.Sprite.scale.Y, 0f);
					
				Vector3 pos = part.Position;//new Vector3(part.Sprite.parent.Transform.Position.X, part.Sprite.parent.Transform.Position.Y, 0);
								
				world *= Matrix4.Translation( pos ) ;
				world *= Matrix4.Scale( scale.X, scale.Y, scale.Z ) ;
				world *= Matrix4.RotationX( FMath.Radians( -20 ) );
				// TODO fade out the particle texture with life? - proved a nice fade out functionality
				g.graphics.SetVertexBuffer(0, part.Sprite.vb);
				g.graphics.SetShaderProgram(part.Sprite.shaderProgram);
				g.graphics.SetTexture(0, part.Sprite.texture);
				
				//g.graphics.SetBlendFunc( BlendFuncMode.Add, BlendFuncFactor.SrcAlpha, BlendFuncFactor.OneMinusSrcAlpha);
				g.graphics.SetBlendFuncAlpha( BlendFuncMode.Add , BlendFuncFactor.SrcAlpha , BlendFuncFactor.OneMinusSrcAlpha );
				
				var world_view_proj = proj * view * world;
				g.program.Parameters.SetWorldMatrix(0, ref world);
				part.Sprite.shaderProgram.SetUniformValue(0, ref world_view_proj);	
				g.graphics.DrawArrays(DrawMode.TriangleStrip, 0, 4);
			}
		}
		
		public override void attachComponent (IComponent comp)
		{
			if ( comp is Particle )
			{
				particles.Add( (Particle) comp );	
			}
			//base.attachComponent (comp);
		}

	}
}

