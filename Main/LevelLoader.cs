using System;
using System.Xml;
using System.IO;

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.Core.Environment;

using Core;


namespace Main
{
	public class LevelLoader
	{
		public LevelLoader ()
		{
		}
		
		public static bool isLevelSelected = false;
		public static String selected_filename = "";
		public static String searchPath = "/Application/Levels/";
		public static void HandleButton(object sender, TouchEventArgs e)
			{
				isLevelSelected = true;
				Console.WriteLine(((Button)sender).Text);
				selected_filename = searchPath + ((Button)sender).Text;
			}
		
		public static void BootStrap()
		{
			var graphics = new GraphicsContext();
			UISystem.Initialize(graphics);
			
			// Create scene
			Scene scene = new Sce.PlayStation.HighLevel.UI.Scene();
			float pos_y = 5.0f;
			float pos_x = 10.0f;
			foreach(var file in Directory.EnumerateFiles(searchPath))
			{
				var short_file = file.Split('/')[file.Split('/').Length -1];
				Button button = new Button();
				button.Text = short_file;
				button.ButtonAction += HandleButton;
				
				if(pos_y > 480.0f)
				{
					pos_y = 5.0f;
					pos_x += 250.0f;
				}
				button.X = pos_x;
				button.Y = pos_y;
				pos_y += 70.0f;
				
				scene.RootWidget.AddChildLast(button);
			}
			
			
			// Set scene
			UISystem.SetScene(scene, null);
			
			while(!isLevelSelected)
			{
				UISystem.Update(Touch.GetData(0));
				graphics.SetClearColor(new Sce.PlayStation.Core.Vector4(0.0f, 0.0f, 0.0f, 1.0f));
				graphics.Clear();
				UISystem.Render();
				graphics.SwapBuffers();
				SystemEvents.CheckEvents();
			
			}
			graphics.Dispose();
			
			Load (selected_filename);
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
						case "BankGrid":
							using (var r = reader.ReadSubtree())
							{
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
					case "BankGrid":
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
							int y = 544 - Convert.ToInt32(options["y"]);
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

