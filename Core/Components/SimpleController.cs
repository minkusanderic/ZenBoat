using System;

namespace Core
{
	public class SimpleController : Core.Controller
	{
		private Action controller;
		public SimpleController (Action controller)
		{
			this.controller = controller;
		}
		
		public override void Update()
		{
			controller();
		}
	}
}

