using System;
using Core;
using Sce.PlayStation.Core.Input;
namespace Core
{
	public class RockFollowTouchController : Core.Controller
	{
		static float width	= 960; 
		static float height = 544;
		Sce.PlayStation.Core.Vector2 lastVec = new Sce.PlayStation.Core.Vector2(0f , 0f );
		public RockFollowTouchController () 
		{
			
		}
		public override void Update ()
		{
			if ( Touch.GetData(0).Count == 0 ) 
			{
				Console.WriteLine("Here");
			 	Entity ent	=	SceneManager.Instance.createEntity("Ripple");
				Ripple ripple = ent.attachComponent( new Ripple() ); 
				ent.Transform.Position = new Sce.PlayStation.Core.Vector2(lastVec.X , lastVec.Y);
				ripple.DoRipple();
				this.parent.Destroy();	
			}
			foreach( TouchData td in Touch.GetData(0) )
			{
				float interp_x =  td.X + .5f;
				float interp_y = -td.Y + .5f;
						
				float X = (interp_x * width);
				float Y = (interp_y * height);
				
				RigidBody rb = require<RigidBody>();
				this.parent.Transform.Position = new Sce.PlayStation.Core.Vector2( X , Y );
				rb.updateTransformData();
				lastVec = this.parent.Transform.Position;
			}

		}
	}
}

