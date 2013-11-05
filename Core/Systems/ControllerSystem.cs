using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class ControllerSystem : Core.CoreSystem
	{
		private List<Controller> controllers = new List<Controller>();
		private Dictionary<Core.Action, IEnumerator<bool> > actions = new Dictionary<Core.Action, IEnumerator<bool>>();
		
		public ControllerSystem ()
		{
		}
		
		public override void attachComponent(IComponent comp)
		{
			if(comp is Controller){
				controllers.Add((Controller)comp);
			}
			if(comp is Core.Action)
			{
				actions[(Core.Action)comp] = ((Core.Action)comp).Do().GetEnumerator();
			}
		}
		
		public override void Update()
		{
			foreach(var cont in this.controllers)
			{
				cont.Update();
			}
			
			var done_actions = new List<Core.Action>();
			foreach(var action in this.actions)
			{
				if(action.Value.MoveNext() && action.Value.Current)
				{
					//The Action is still going. Do nothing.
				}
				else
				{
					done_actions.Add(action.Key);
				}
			}
			
			//Remove any done actions
			foreach(var action in done_actions)
			{
				this.actions.Remove(action);
				action.Destroy();
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

