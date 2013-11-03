using System;
using Sce.PlayStation.Core.Input;

namespace Core
{
	public class Controller : Component<ControllerSystem>
	{
		public Controller ()
		{
			
		}
		
		public virtual void Update()
		{ 
					
		}
		public override void destroy ()
		{
			base.destroy ();
		}
	}
}

