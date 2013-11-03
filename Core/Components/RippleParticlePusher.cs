using System;
using System.Collections.Generic;
using Core;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;
namespace Core
{
	public class RippleParticlePusher : Core.Controller
	{
		float radius = 0f;
		float X,Y;
		int i;
		public RippleParticlePusher ( int index , float starting_x , float starting_y )
		{
			X = starting_x;
			Y = starting_y;
			i = index;
		}
		public override void Update ()
		{
			radius++;
			Vector3 pos = new Vector3(radius *  FMath.Cos(FMath.DegToRad * i), radius * FMath.Sin(FMath.DegToRad * i), 0);
			this.parent.Transform.Position = new Vector2( pos.X + X , pos.Y + Y );
			base.Update();
		}
	}
}

