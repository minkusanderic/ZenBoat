using System;

namespace Core
{
	public class CoreSystem
	{
		public CoreSystem ()
		{
		}
		
		public virtual void Update() {}
		
		public virtual void attachComponent(IComponent comp)
		{
			throw new InvalidOperationException("Invalid Attach"); 
		}
		
		public virtual void destroyComponent(IComponent comp)
		{
			//throw new InvalidOperationException("Cannot destroy base System");
		}
	}
}

