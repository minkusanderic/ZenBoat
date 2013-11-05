using System;
using System.Xml.Serialization;

namespace Core
{
	public class Component<T> : IComponent where T:Core.CoreSystem
	{
		

		public Component ()
		{
			this.system = (T)SceneManager.Instance.getSystem(typeof(T));
		}
		
		[XmlIgnore]
		public T system {get; private set;}
		
		public virtual void Update(){}
		
		public override void attach(Entity ent)
		{
			this.system.attachComponent(this);
		}
		
		public override void Destroy()
		{
			this.system.destroyComponent(this);
		}
		
		public U require<U>()
		{
			return this.parent.FindComponent<U>();
		}
	}
}

