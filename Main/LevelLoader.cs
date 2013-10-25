using System;
using System.Xml;
using System.IO;

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

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
						case "EntityLayer":
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
						case "EntityLayer":
							break;
						default:
							String name = reader.Name;
							Dictionary<String,String> options = new Dictionary<String, String>();
							for(var i = 0; i < reader.AttributeCount; i++)
							{
								reader.MoveToAttribute(i);
								options[reader.Name] = reader.Value;
							}
							var t = Type.GetType("Main." + name);
							MethodInfo method = t.GetMethod("create", BindingFlags.Static | BindingFlags.Public);
							method.Invoke(null, new object[]{reader["id"], options});
							break;
					}
				}
			}
		}
	}
}

