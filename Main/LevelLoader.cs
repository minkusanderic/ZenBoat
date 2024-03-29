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
				//Console.WriteLine(((Button)sender).Text);
				selected_filename = searchPath + ((Button)sender).Text;
			}
		
		public static void BootStrap()
		{
			var graphics = ((GraphicsSystem)SceneManager.Instance.getSystem(typeof(GraphicsSystem))).graphics;
			
			UISystem.Initialize(graphics);
			
			// Create scene
			Scene scene = new Sce.PlayStation.HighLevel.UI.Scene();
			float pos_y = 30.0f;
			float pos_x = 10.0f;
			foreach(var file in Directory.EnumerateFiles(searchPath))
			{
				var short_file = file.Split('/')[file.Split('/').Length -1];
				Button button = new Button();
				button.Text = short_file;
				button.ButtonAction += HandleButton;
				
				if(pos_y > 480.0f)
				{
					pos_y = 30.0f;
					pos_x += 250.0f;
				}
				button.X = pos_x;
				button.Y = pos_y;
				pos_y += 70.0f;
				
				scene.RootWidget.AddChildLast(button);
			}
			
			Label version = new Label();
			version.Text = "Project Origami Kami Version: 0.3.0 (ALPHA)";
			version.X = 1.0f;
			version.Y = 1.0f;
			version.Width = 900;
			scene.RootWidget.AddChildLast(version);
			
			ImageBox background = new ImageBox();
			background.Image = new ImageAsset("/Application/resources/Origami Kami.png", false);
			background.ImageScaleType = ImageScaleType.AspectInside;
			background.X = 0.0f;
			background.Y = 0.0f;
			background.Width = 960.0f;
			background.Height = 544.0f;
			scene.RootWidget.AddChildFirst(background);
			
			// Set scene
			UISystem.SetScene(scene, null);
			
			while(!isLevelSelected)
			{
				if ((GamePad.GetData(0).Buttons & GamePadButtons.Triangle) != 0)
					{
							Environment.Exit(0);
					}
				UISystem.Update(Touch.GetData(0));
				graphics.SetClearColor(new Sce.PlayStation.Core.Vector4(0.0f, 0.0f, 0.0f, 1.0f));
				graphics.Clear();
				UISystem.Render();
				graphics.SwapBuffers();
				SystemEvents.CheckEvents();
			
			}
			//graphics.Dispose();
			SceneManager.Instance.SetCurrentLevelName( selected_filename );
			Load (selected_filename)	;
			isLevelSelected = false;
		}
		
		public static void Load(String filename)
		{
			SceneManager.Instance.SetCurrentLevelName( filename );
			CollectibleManager.ClearStageScore();
			int[,] down = new int[60,34];
			int[,] up = new int[60,34];
			int[,] right = new int[60,34];
			int[,] left = new int[60,34];
			
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
						case "Down":
							using (var r = reader.ReadSubtree())
							{
								down = parseBitstring(r);
							}
							break;
						case "Up":
							using (var r = reader.ReadSubtree())
							{
								up = parseBitstring(r);
							}
							break;
						case "Back":
							using (var r = reader.ReadSubtree())
							{
								left = parseBitstring(r);
							}
							break;
						case "Forward":
							using (var r = reader.ReadSubtree())
							{
								right = parseBitstring(r);
							}
							break;
						case "Art":
							using (var r = reader.ReadSubtree()){
								parseEntities(r);
							}
							break;
					}
				}
				}
				((WaterSystem)SceneManager.Instance.getSystem(typeof(WaterSystem))).SetCurrentData(down, up, left, right);
				// for the Level Select Screens-> cache out the number of cranes TOTAL on this level.
				
			}
		} 
		
		private static void parseEntities(XmlReader reader)
		{
			while(reader.Read())
			{
				if(reader.IsStartElement())
				{
					switch(reader.Name)
					{
						case "Entities":
							break;
						case "BankGrid":
							break;
						case "Art":
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
							ent.SetID( reader["id"] );
						   	//Console.WriteLine("readerID: " + reader["id"] );
							ent.Transform.Position = new Sce.PlayStation.Core.Vector2(x,y);
							if(options.ContainsKey("angle"))
								ent.Transform.SetAngle(Convert.ToSingle(options["angle"]));
							
							//Console.WriteLine(name);
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
		
		private static int[,] parseBitstring(XmlReader reader)
		{
			int[,] bitArray = new int[60,34];

			while(reader.Read())
			{
				switch(reader.Name)
				{
				case "Down":
					break;
				case "Up":
					break;
				case "Back":
					break;
				case "Forward":
					break;
				default:
					String raw = reader.Value;
					string[] lines = raw.Split(new char[] { '\n' });
					for(int y = 0; y < lines.Length; y++)
					{
						for(int x = 0; x < lines[y].Length; x++)
						{
							//bitArray[x,y] = lines[y][x] - 48;
						}
					}
					break;
				}
						
			}
			
			//Console.WriteLine(bitArray);
			return bitArray;
		}
		
	}
}

