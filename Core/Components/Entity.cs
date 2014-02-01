using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

using Sce.PlayStation.Core;

namespace Core
{
	[Serializable]
	public class Entity
	{
		public String Name
		{get;set;}
		
		public bool Enabled = true;	// by default an Entity is Enabled
		
		private HashSet<String> tags = new HashSet<String>();
		
		private List<IComponent> components;
		
		public Entity()
		{
			this.components = new List<IComponent>();
			this.Transform = new Transform();
			this.Name = "<unknown>";
		}
		
		public Entity (String Name)
		{
			this.components = new List<IComponent>();
			this.Transform = new Transform();
			this.Name = Name;
		}
		
		public T FindComponent<T>() 
		{
			foreach(var comp in this.components)
			{
				if(comp is T)
				{
					return (T)Convert.ChangeType(comp, typeof(T));
				}
			}
			throw new Exception("Component Not Found!!");
			
		}
				
		public IEnumerable<IComponent> GetComponents()
		{
			foreach(var comp in components)
			{
				yield return comp;
			}
		}
		
		public Entity tag(params String[] tags)
		{
			foreach(var tag in tags)
			{
				this.tags.Add(tag);
			}
			return this;
		}
		
		public bool HasTag(String tag)
		{
			return tags.Contains(tag);
		}
		
		public T attachComponent<T>(T comp) where T:IComponent
		{
			SceneManager.Instance.attachComponent(this, (IComponent)comp);
			this.components.Add(comp);
			return comp;
		}
		
		
		public void Destroy()
		{
			SceneManager.Instance.DestroyEntity( this );
			/*
			this.Transform.Position = new Sce.PlayStation.Core.Vector2(-10000, 10000);
			try{
				var body = (RigidBody)SceneManager.Instance.GetComponent<RigidBody>(this);
				body.body.Position = new Sce.PlayStation.Core.Vector2(-10000, 10000);
				
			}
			catch{}
			*/
		}
	
		
		public Transform Transform
		{get;set;}
	}
}

