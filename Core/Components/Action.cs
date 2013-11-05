using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class Action : Component<ControllerSystem>
	{
		public Action ()
		{
		}
		
		public virtual IEnumerable<bool> Do()
		{
			yield return false;
			yield break;
		}
	}
}

