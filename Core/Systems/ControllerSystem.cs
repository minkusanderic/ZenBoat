using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class ControllerSystem : Core.System
	{
		private List<Controller> controllers;
		private List<Controller> to_be_attached = new List<Controller>();
		
		public ControllerSystem ()
		{
			controllers = new List<Controller>();
		}
		
		public override void attachComponent(IComponent comp)
		{
				if(comp is Controller){
				to_be_attached.Add((Controller)comp);
			}
		}
		
		public override void Update()
		{
			foreach(var cont in this.controllers)
			{
				cont.Update();
			}
			foreach(var cont in this.to_be_attached)
			{
				this.controllers.Add(cont);
			}
			this.to_be_attached.Clear();
		}
		public override void destroyComponent (IComponent comp)
		{
			base.destroyComponent (comp);
		}
	}
}

