using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;

public enum GameState {PAUSED, RUNNING, STOPPED};

namespace Core
{
	public class SceneManager
	{
		
		public List<Entity> entities = new List<Entity>();
		public GameState currentState = GameState.STOPPED;
		
		private string currentLevelName = "";
		public string GetCurrentLevelName()
		{
			return currentLevelName;	
		}
		public void SetCurrentLevelName( string name )
		{
			currentLevelName = name;	
		}
		private SceneManager ()
		{
			systems = new Dictionary<Type, CoreSystem>();
			systems[typeof(TouchSystem)] = new TouchSystem();
			systems[typeof(GraphicsSystem)] = new GraphicsSystem();
			systems[typeof(ControllerSystem)] = new ControllerSystem();
			systems[typeof(PhysicsSystem)] = new PhysicsSystem();
			systems[typeof(AudioSystem)] = new AudioSystem();
			systems[typeof(WaterSystem)] = new WaterSystem();
			systems[typeof(ParticleSystem)] = new ParticleSystem();
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
		
	public bool Update()
		{
			SystemEvents.CheckEvents();
			foreach(var comp in to_be_destroyed)
			{
				//entity_comp[comp.parent].Remove(comp);
				comp.Destroy();
			}
			to_be_destroyed.Clear();
			
			foreach(var ent in ents_to_be_destroyed)
			{
				entities.Remove(ent);
			}
			ents_to_be_destroyed.Clear();
			
			foreach(var comp in to_be_attached)
			{
				comp.attach(comp.parent);
				//entity_comp[comp.parent].Add(comp);
			}
			to_be_attached.Clear();
			
			if(entities.Count == 0)
			{
				//THere are no entities, kick back to main loop
				return false;
			}
			
			switch (this.currentState)
			{
			case GameState.RUNNING:
				systems[typeof(TouchSystem)].Update();
				systems[typeof(ControllerSystem)].Update();
				systems[typeof(PhysicsSystem)].Update();
				systems[typeof(WaterSystem)].Update();
				systems[typeof(GraphicsSystem)].Update();
				systems[typeof(ParticleSystem)].Update();
				return true;
			case GameState.PAUSED:
				systems[typeof(GraphicsSystem)].Update();
				return true;
			case GameState.STOPPED:
				return false;
			default:
				return false;
			}
			return false;
		}
		
	public Dictionary<Type, CoreSystem> systems;
	public CoreSystem getSystem(Type comp_type)
		{
			return systems[comp_type];
		}
		
		
	//private Dictionary<Entity, List<IComponent> > entity_comp;
	//private Dictionary<String, Entity> entities = new Dictionary<String, Entity>();
	public Entity createEntity(String name)
		{
			Entity ent = new Entity(name);
			entities.Add(ent);
			return ent;
		}
		
	private List<IComponent> to_be_attached = new List<IComponent>();
	public void attachComponent(Entity ent, IComponent comp)
		{
			comp.parent = ent;
			to_be_attached.Add(comp);
		}
		
	private List<IComponent> to_be_destroyed = new List<IComponent>();
	private List<Entity> ents_to_be_destroyed = new List<Entity>();
	public void DestroyEntity(Entity ent)
		{
			foreach(var comp in ent.GetComponents())
			{
				to_be_destroyed.Add(comp);
			}
			ents_to_be_destroyed.Add(ent);
		}
		
	public Entity FindEntity(String name)
		{
			foreach(var ent in entities)
			{
				if(ent.Name == name)
				{
					return ent;
				}
			}
			throw new InvalidOperationException("Unable to find entity '" + name + "'");
		}
	public Entity FindEntityByTag(String tag)
		{
			foreach(var ent in entities)
			{
				if(ent.HasTag(tag))
				{
					return ent;
				}
			}
			throw new InvalidOperationException("Unable to find entity with tag '" + tag + "'");
		}
		
	public IEnumerable<Entity> FindEntitiesByTag(String tag)
		{
			foreach(var ent in entities)
			{
				if(ent.HasTag(tag))
				{
					yield return ent;
				}
			}
		}
		
	public Selector Select(String tag)
		{
			return new Selector(tag);
		}
		
	public void DestroyAll()
		{
			foreach(var ent in entities.ToArray())
			{
				ent.Destroy();
			}
		}
		
}
}

