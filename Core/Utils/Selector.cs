using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
	public class Selector
	{
		private String tag;
		public Selector (String tag)
		{
			this.tag = tag;
		}
		
		public List<Entity> get()
		{
			return SceneManager.Instance.FindEntitiesByTag(tag).ToList();
		}
	}
}

