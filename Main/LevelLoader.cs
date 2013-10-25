using System;
using System.Xml;
using System.IO;

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using Core;


namespace Main
{
	public class LevelLoader
	{
		public LevelLoader ()
		{
		}
		
		public static void Load(String filename)
		{
			
			
			using (XmlReader reader = XmlReader.Create(filename))
			{
				while(reader.Read()){
				if(reader.IsStartElement()){
					switch(reader.Name)
					{
						case "level":
							break;
						case "Entities":
							using (var r = reader.ReadSubtree()){
								parseEntities(r);
							}
							break;
					}
				}
				}
			
			}
		} 
		
		private static void parseEntities(XmlReader reader)
		{
			while(reader.Read())
			{
				if(reader.IsStartElement()){
					switch(reader.Name)
					{
						case "Entities":
							break;
						default:
							String name = reader.Name;
							Dictionary<String,String> options = new Dictionary<String, String>();
							for(var i = 0; i < reader.AttributeCount; i++)
							{
								reader.MoveToAttribute(i);
								options[reader.Name] = reader.Value;
							}
							int x = Convert.ToInt32(options["x"]);
							int y = Convert.ToInt32(options["y"]);
							var ent = SceneManager.Instance.createEntity(reader["id"]);
							ent.Transform.Position = new Sce.PlayStation.Core.Vector2(x,y);
							if(options.ContainsKey("angle"))
								ent.Transform.SetAngle(Convert.ToSingle(options["angle"]));
							
							
							var t = Type.GetType("Main." + name);
							if(t == null){
								Console.WriteLine("ERROR: Could not find Prefab '" + name + "'");
								break;
							}
							MethodInfo method = t.GetMethod("create", BindingFlags.Static | BindingFlags.Public);
							if(method == null){
								Console.WriteLine("ERROR: '" + name + "' does not have a valid create function\n Expected: public static void create(Entity, Dictionary<String,String>)");
								break;
							}
							method.Invoke(null, new object[]{ent, options});
							break;
					}
				}
			}
		}
	}
}

