using System;
using System.Xml.Serialization;

namespace Core
{
	public class Component<T> : IComponent where T:Core.System
	{
		

		public Component ()
		{
			this.system = (T)EntityManager.Instance.getSystem(typeof(T));
		}
		
		[XmlIgnore]
		public T system {get; private set;}
		
		public virtual void Update(){}
		
		public override void attach(Entity ent)
		{
			this.system.attachComponent(this);
		}
		
		public U require<U>()
		{
			return EntityManager.Instance.GetComponent<U>(this.parent);
		}
	}
}

