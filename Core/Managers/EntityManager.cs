using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class EntityManager
	{
		private EntityManager ()
		{
			systems = new Dictionary<Type, System>();
			systems[typeof(GraphicsSystem)] = new GraphicsSystem();
			systems[typeof(ControllerSystem)] = new ControllerSystem();
			systems[typeof(PhysicsSystem)] = new PhysicsSystem();
			entity_comp = new Dictionary<Entity, List<IComponent>>();
		}
	
	public static EntityManager _instance;
		
	public static EntityManager Instance
	   {
    	  get 
      	{
        	 if (_instance == null)
         	{
           	 _instance = new EntityManager();
         	}
         	return _instance;
      	}
   	}
		
	private Dictionary<Type, System> systems;
	public System getSystem(Type comp_type)
		{
			return systems[comp_type];
		}
		
		
	private Dictionary<Entity, List<IComponent> > entity_comp;
	
	public Entity createEntity(String name)
		{
			Entity ent = new Entity(name);
			entity_comp[ent] = new List<IComponent>();
			return ent;
		}
		
	private List<IComponent> to_be_attached = new List<IComponent>();
	public void attachComponent(Entity ent, IComponent comp)
		{
			comp.parent = ent;
			entity_comp[ent].Add(comp);
			comp.attach (ent);
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
}
}

