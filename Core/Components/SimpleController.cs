using System;

namespace Core
{
	public class SimpleController : Core.Controller
	{
		private System.Action controller;
		public SimpleController (System.Action controller)
		{
			this.controller = controller;
		}
		
		public override void Update()
		{
			this.controller();
		}
	}
}

