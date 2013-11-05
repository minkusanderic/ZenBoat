using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class ControllerSystem : Core.System
	{
		private List<Controller> controllers = new List<Controller>();
		
		public ControllerSystem ()
		{
		}
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is Controller){
				controllers.Add((Controller)comp);
			}
		}
		
		public override void Update()
		{
			foreach(var cont in this.controllers)
			{
				cont.Update();
			}
		}
		
		public override void destroyComponent(IComponent comp)
		{
			if(comp is Controller)
			{
				controllers.Remove((Controller)comp);
			}
		}
	}
}

