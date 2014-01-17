using System;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;
using System.Collections;
using System.Collections.Generic;
using Core;

namespace Core
{
	public class TouchController : Core.Controller
	{
		public TouchController ()
		{
			Console.WriteLine("Creating TouchController");
		}
		
		public override void Update ()
		{
			RigidBody rb = this.require<RigidBody>();
			foreach(	TouchData td in Touch.GetData(	0	)	)
			{
				Vector2 vec = new Vector2( td.X , td.Y );
				GraphicsSystem gs = ( GraphicsSystem) EntityManager.Instance.getSystem( typeof( GraphicsSystem ) );
				Vector2	startPos = gs.GetWorldToPoint( 2*vec );
				//Console.WriteLine( "StartPos: " + startPos + "\t\tPos: " + this.parent.Transform.Position );
				if ( Vector2.Distance( this.parent.Transform.Position , startPos ) > 20f )
				{
					this.parent.Destroy();	
				}
			}
			base.Update ();
		}
	}
}

