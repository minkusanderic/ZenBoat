using System;
using Core;
using System.Collections;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.HighLevel.Model;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace Core
{
	public class Particle : Component<ParticleSystem> 
	{	
		public VertexBuffer vb;
		public Texture2D texture;
		public ShaderProgram shaderProgram;
			
		private Vector3 position;
		private Vector3 velocity;
		private int life;		// age
		private SpriteComponent sprite;
		private Vector3 originalPosition;
		#region
		public Vector3 Position
		{
			get { return position; }
		}
		public Vector3 Velocity
		{
			get { return velocity; }
		}
		public int Life
		{
			get { return life; }
		}
		public SpriteComponent Sprite
		{
			get { return sprite; }	
		}
		#endregion

		GraphicsSystem graphics_system;
		GraphicsContext graphics;
		public Particle( Vector3 pos , Vector3 vel , int _life , SpriteComponent sp )
		{
			
			graphics_system =	(GraphicsSystem) SceneManager.Instance.getSystem(typeof(GraphicsSystem));	
			graphics = graphics_system.graphics;
			this.originalPosition = pos;
			this.position = pos;
			this.velocity = vel;
			if ( _life < 0 ) _life = 0;
			else this.life = _life;
			sprite = sp;
		}
		
		public override void Update ()
		{
			//this.velocity -=  new Vector3(0f , 0f , 0.01f );
			this.position += this.velocity;
			this.life++;
		}
		public void ResetParticle()
		{
			this.Sprite.scale = new Vector2( 1f , 1f );
			this.position = this.originalPosition;
			this.life = 0;
		}
	}
}

