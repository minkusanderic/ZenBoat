using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class SimpleAction : Core.Action
	{
		
		private Func<IEnumerable<bool> > function;
		public SimpleAction (Func<IEnumerable<bool> > action)
		{
			this.function = action;
		}
		
		public override IEnumerable<bool> Do ()
		{
			return this.function();
		}
	}
}

