using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment ;
using Sce.PlayStation.HighLevel.Model ;
using System.Threading ;
using System.Diagnostics ;
namespace Main
{
	public class BasicEmitter : ParticleSystem
	{
		private Random rand;
		private Vector3 Gravity = new Vector3(0f , 0f , 0f );
				
		public BasicEmitter ()
		{
			rand = new Random();
			SpriteComponent sc = new SpriteComponent( "/Application/assets/smoke.png" );
			ParticleSystem ps = (ParticleSystem) SceneManager.Instance.getSystem(typeof( ParticleSystem) );
			int life = 100; 
			
			
			for( int i = 0 ; i < 100; i++ )
			{
				float rX = 2 * ((float)rand.NextDouble() - 0.5f );
				float rY = 2 * ((float)rand.NextDouble() - 0.5f );
				float rZ = 2 * ((float)rand.NextDouble()  );
				int 	rL = rand.Next( 0 , 100 );
				ps.attachComponent( new Particle( new Vector3 ( 200f , 200f , 0f ) , new Vector3( rX , rY , rZ ) , rL , sc ));
				//ps.attachComponent( GenerateParticle(sc) );
				//particles.Add( GenerateParticle(sc) );
			}
			
		}
		GraphicsSystem gs;
		BasicProgram program;
		protected override Particle GenerateParticle (SpriteComponent sc)
		{
			float rX = 2 * ((float)rand.NextDouble() - 0.5f );
			float rY = 2 * ((float)rand.NextDouble() - 0.5f );
			float rZ = 2 * ((float)rand.NextDouble() - 0.5f );
			//SpriteComponent sc = new SpriteComponent( "/Application/assets/Whirpoolsmall.png" );
			Particle part = new Particle( new Vector3(0f , 0f ,0f) , 
			                             new Vector3( rX , rY , rZ ) , 10000 , sc );
			//program = ((GraphicsSystem) (SceneManager.Instance.getSystem( typeof(GraphicsSystem) ))).program;
			//gs = (GraphicsSystem) (SceneManager.Instance.getSystem( typeof(GraphicsSystem) )); 
			//GraphicsSystem gs = (GraphicsSystem) SceneManager.Instance.getSystem(typeof(GraphicsSystem));
			//gs.attachComponent( sc );
			//gs.sprites.Add( sc );
			return part;
		}

	}
}

