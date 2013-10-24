using System;
using Core;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Input;

namespace Main
{
	public class ResetController : Controller
	{
		
		private Transform t;
		public ResetController (Transform t)
		{
			this.t = t;
		}
		
		public override void Update()
		{
			var gamePadData = GamePad.GetData(0);
			
			 if((gamePadData.Buttons & GamePadButtons.Cross) != 0)
	        {
				this.parent.Transform.Position = new Vector2(0.0f, 544/2);
				//EntityManager.Instance.GetComponent<RigidBody>(this.parent).body.Position = this.parent.Transform.Position;
				SceneManager.Instance.GetComponent<RigidBody>(this.parent).updateTransformData();
        	}
		}
	}
}

