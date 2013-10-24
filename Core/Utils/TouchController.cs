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
		bool b = false;
		public override void Update ()
		{
			b = false;
			RigidBody rb = this.require<RigidBody>();
			foreach(	TouchData td in Touch.GetData(	0	)	)
			{
				Vector2 vec = new Vector2( td.X , td.Y );
				GraphicsSystem gs = ( GraphicsSystem) SceneManager.Instance.getSystem( typeof( GraphicsSystem ) );
				Vector2	startPos = gs.GetWorldToPoint( 2*vec );
				startPos = new Vector2( startPos.X , 544f-startPos.Y );
				//Console.WriteLine( "StartPos: " + startPos + "\t\tPos: " + this.parent.Transform.Position );
				if ( Vector2.Distance( this.parent.Transform.Position , startPos ) < 20f )
				{
					b = true;
					this.parent.Destroy();	
				}
			}
			if ( b )
			{
				Console.WriteLine( "CLEARING" );
				Touch.GetData(0).Clear();
			}
			base.Update ();
		}
	}
}

