using System;
using System.Xml.Serialization;

namespace Core
{
	public class IComponent
	{
		[XmlIgnore]
		public Entity parent;
		
		public virtual void attach(Entity ent)
		{
		}
		public virtual void Destroy()
		{
		}
	}
}

