using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;

namespace Core
{
	public class SceneManager
	{
		private SceneManager ()
		{
			systems = new Dictionary<Type, System>();
			systems[typeof(GraphicsSystem)] = new GraphicsSystem();
			systems[typeof(ControllerSystem)] = new ControllerSystem();
			systems[typeof(PhysicsSystem)] = new PhysicsSystem();
			entity_comp = new Dictionary<Entity, List<IComponent>>();
		}

	public static SceneManager _instance;
		
	public static SceneManager Instance
	   {
    	  get 
      	{
        	 if (_instance == null)
         	{
           	 _instance = new SceneManager();
         	}
         	return _instance;
      	}
   	}
		
	public void Update()
		{
			SystemEvents.CheckEvents();
			foreach(var comp in to_be_destroyed)
			{
				entity_comp[comp.parent].Remove(comp);
				comp.destroy();				
			}
			to_be_destroyed.Clear();
			foreach(var comp in to_be_attached)
			{
				comp.attach(comp.parent);
				entity_comp[comp.parent].Add(comp);
			}
			to_be_attached.Clear();
			
			systems[typeof(ControllerSystem)].Update();
			systems[typeof(PhysicsSystem)].Update();
			systems[typeof(GraphicsSystem)].Update();
		}
		
	public Dictionary<Type, System> systems;
	public System getSystem(Type comp_type)
		{
			return systems[comp_type];
		}
		
		
	private Dictionary<Entity, List<IComponent> > entity_comp;
	private Dictionary<String, Entity> entities = new Dictionary<String, Entity>();
	public Entity createEntity(String name)
		{
			Entity ent = new Entity(name);
			entities[name] = ent;
			entity_comp[ent] = new List<IComponent>();
			return ent;
		}
		
	private List<IComponent> to_be_attached = new List<IComponent>();
	public void attachComponent(Entity ent, IComponent comp)
		{
			comp.parent = ent;
			to_be_attached.Add(comp);
		}
		
		
		
	public T GetComponent<T>(Entity parent) 
		{
			foreach(var comp in this.entity_comp[parent])
			{
				if(comp is T)
				{
					return (T)Convert.ChangeType(comp, typeof(T));
				}
			}
			throw new Exception("Component Not Found!!");
			
		}
	private List<IComponent> to_be_destroyed = new List<IComponent>();
	public void DestroyEntity(Entity ent)
		{
			foreach(var comp in entity_comp[ent])
			{
				to_be_destroyed.Add(comp);
			}
		}
		
	public Entity GetEntity(String name)
		{
			return entities[name];          
		}
}
}

