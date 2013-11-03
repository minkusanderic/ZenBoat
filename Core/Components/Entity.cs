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
		public String Name;
		
		public List<IComponent> components;
		
		public Entity()
		{
			this.components = new List<IComponent>();
			this.Transform = new Transform();
			this.Name = "";
		}
		
		public Entity (String Name)
		{
			this.components = new List<IComponent>();
			this.Transform = new Transform();
			this.Name = Name;
		}
		
		public IComponent attachComponent(IComponent comp)
		{
			SceneManager.Instance.attachComponent(this, comp);
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

