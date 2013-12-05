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
	public class Particle : Controller
	{
		private Vector3 position;
		private Vector3 velocity;	
		private int life;		// age

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
		#endregion
		
		public Particle () : this (Vector3.Zero , Vector3.Zero , 0 )
		{
		}
		
		public Particle( Vector3 pos , Vector3 vel , int _life )
		{
			this.position = pos;
			this.velocity = vel;
			if ( _life < 0 ) life = 0;
			else this.life = _life;
		}
		
		public override void Update ()
		{
			
		}
		public void Draw(){}
	}
}

