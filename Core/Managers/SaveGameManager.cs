using Sce;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Sce.PlayStation.HighLevel.Physics2D;
using Core;

namespace Core
{
	
	/*		<!--	PROPOSED XML PROFILE LAYOUT	-->
	 * 		<SaveGame>
	 * 			<CurrentLevel>
	 * 			</CurrentLevel>
	 * 			<LastTimePlayed>
	 * 			</LastTimePlayed>
	 * 			<Levels>
	 * 				<LevelName> </LevelName>
	 * 				<Cranes>
	 * 				</Cranes>
	 * 			</Levels>
	 * 			<Strings>
	 * 				<String>
	 * 					<Key>KeyName</Key>
	 * 					<Value>val</Value>
	 * 				</String>
	 * 			</Strings>
	 * 		</SaveGame>
	 * 
	 */
	public static class SaveGameManager
	{
		
		private static bool _init = false;
		private static XmlDocument xml_doc;
		
		private static string save_game_file_path = @"/Documents/saveGame.xml";
		private static string save_game_temp_path = @"/Documents/tempGame.xml";
		private static Dictionary<string , string> strings;
		private static List<string> cranes_to_save = new List<string>();
		//private static List<string> strings;
		public 	static List<Entity> toRespawn;
		
		/// <summary>
		/// Gets the init.
		/// </summary>
		/// <returns>
		/// The init.
		/// </returns>
		public static bool getInit()
		{
			return _init;
		}
		const string DATA = 
				"<SaveGame>" +
				"\n\r\t<Strings>" +
				"\n\r\t</Strings>" +
				"</SaveGame>";
		/// <summary>
		/// Init this instance.
		/// </summary>
		public static bool init()
		{
			_init = true;
			strings = new Dictionary< string , string >();
			toRespawn = new List<Entity>();

			
			if(File.Exists(save_game_temp_path))
			{
				//Recover from a previously corrupted state when the temp file is not moved over
				if(File.Exists(save_game_file_path))
						File.Delete(save_game_file_path);
				File.Move(save_game_temp_path, save_game_file_path);
				File.Delete(save_game_temp_path);
			}
			FileStream fs = File.Open(save_game_file_path	,FileMode.OpenOrCreate);
			xml_doc = new XmlDocument();
			bool fileExists  = fs.Length != 0;
			if ( !fileExists )
			{
				xml_doc.LoadXml( DATA );
				saveGame();
				//xml_doc.Save(save_game_file_path);
			}
			else
			{
				xml_doc.Load( fs );
				if ( xml_doc.FirstChild.FirstChild.Name == "Strings" )
				{
					foreach( XmlNode str in xml_doc.FirstChild.FirstChild.ChildNodes )
					{
						string key,val;	key = val = "";
						foreach( XmlNode node in str.ChildNodes )
						{
							if ( node.Name == "Key" )
							{
								//if ( node.InnerText != "GotCrane" ) continue;
								key = node.InnerText;
							}
							else 
								val = node.InnerText;
						}
						//Console.WriteLine("K:" + key + "\tV:" + val);
						if ( key != "" && val != "" )
						{
							if ( key == "GotCrane" ) // this is in the XML doc for the saveGame (saveGame.xml)
							{
								cranes_to_save.Add( val );
							}else{
								strings[key] = val;	
							}
						}
					}
				}	
			}
			fs.Close();	 
			return _init;
		}
		
		public static List<string> GetCranes()
		{
			Console.WriteLine("In Get Cranes");
			return cranes_to_save;
		}
		
		/// <summary>
		/// Contains the save string.
		/// </summary>
		/// <returns>
		/// The save string.
		/// </returns>
		/// <param name='key'>
		/// If set to <c>true</c> key.
		/// </param>
		public static bool ContainsSaveString( string key )
		{
			return false; //strings.con(key);	
		}
		
		/// <summary>
		/// Sets the string. Checks if the Key Exists, if it does, it overrides the old value of the key
		/// </summary>
		/// <param name='key'>
		/// Key.
		/// </param>
		/// <param name='val'>
		/// Value.
		/// </param>
		public static void SaveString( string key , string val )
		{
			strings[key] = val;	// ok to override
			/*
			XmlNode new_string = xml_doc.CreateNode( XmlNodeType.Element , "String" , "" );
			XmlNode new_key = xml_doc.CreateNode( XmlNodeType.Element , "Key" , "" );
			XmlNode new_val = xml_doc.CreateNode( XmlNodeType.Element , "Value" , "" );
			
			XmlNode parent_node = null;
			
			if ( xml_doc != null && xml_doc.FirstChild != null && xml_doc.FirstChild.FirstChild != null 
			    && xml_doc.FirstChild.FirstChild != null && xml_doc.FirstChild.FirstChild.FirstChild != null
			    && xml_doc.FirstChild.FirstChild.FirstChild.ChildNodes != null ) // uber hack
			{
				
				foreach( XmlNode node in xml_doc.FirstChild.FirstChild.FirstChild.ChildNodes )
				{
					if ( node.Name == "Key" )
					{
						Console.WriteLine("name: " + node.InnerText);
						if ( node.InnerText == key )
						{
							parent_node = node.ParentNode;
							foreach( XmlNode child in parent_node.ChildNodes )
							{
								if ( child.Name == "Value" )
								{
									child.InnerText = val;	
								}
							}
						}
					}
				}
			}
			
			
			new_key.InnerText = key;
			new_val.InnerText = val;
			new_string.AppendChild( new_key );
			new_string.AppendChild( new_val );
			if ( parent_node == null )
				xml_doc.FirstChild.FirstChild.AppendChild( new_string );
			else 
				*/
				//xml_doc.FirstChild.FirstChild.ReplaceChild( parent_node , new_string );
			saveGame(); // todo or not to do this is the question
		}

		/// <summary>
		/// Saves the game.
		/// </summary>
		/// <returns>
		/// The game.
		/// </returns>
		public static bool saveGame()
		{
			if ( _init )
			{
				try{
					xml_doc.LoadXml ( DATA );
					foreach( KeyValuePair<string, string> entry in strings )
					{
						XmlNode new_string	= xml_doc.CreateNode( XmlNodeType.Element , "String", "" );
						XmlNode new_key 	= xml_doc.CreateNode( XmlNodeType.Element , "Key" 	, "" );	
						XmlNode new_val 	= xml_doc.CreateNode( XmlNodeType.Element , "Value" , "" );
						
						new_key.InnerText = entry.Key;
						new_val.InnerText = entry.Value;
						new_string.AppendChild( new_key );
						new_string.AppendChild( new_val );
						xml_doc.FirstChild.FirstChild.AppendChild( new_string );
					}
					xml_doc.Save( save_game_temp_path ); // Need to save to temp file first per PSM guidelines
					File.Move(save_game_temp_path, save_game_file_path);
					File.Delete(save_game_temp_path);
				}catch (IOException e)
				{
					Console.WriteLine("Not enough space to write the save file");
					return false;
				}
				return true;
			}
			return false;
		}

		public static void RespawnEntities()
		{
			foreach( Entity e in toRespawn )
			{
				/*
				
				RigidBody rigid_body = (RigidBody)e.FindComponent<RigidBody>();
				PhysicsSystem ps = (PhysicsSystem)SceneManager.Instance.getSystem(typeof(PhysicsSystem));
				PhysicsShape shape;
				if(rigid_body.dimentions.Y == 0.0f)
				{
					shape = ps.physics.AddSphereShape(rigid_body.dimentions.X);
				}
				else
				{
					shape = ps.physics.AddBoxShape(rigid_body.dimentions);
					//shape = physics.AddSphereShape(rigid_body.dimentions.X);
				}
				ps.bodies.Add(rigid_body);
				
				rigid_body.body = ps.physics.AddBody(shape, rigid_body.Mass);
		
				//rigid_body.body = physics.sceneBodies[next_id];
				rigid_body.body.position = rigid_body.parent.Transform.Position;
				rigid_body.body.Rotation = Vector2.Angle(Vector2.UnitX, rigid_body.parent.Transform.Rotation);
				
				if(rigid_body.is_static)
				{
					rigid_body.body.SetBodyStatic();
				}
				*/
				Respawner r = (Respawner)e.FindComponent<Respawner>();
				if ( r != null ) 
				{
					r.ResetPosition();
				}
				e.Enabled = true; // wake them back up
			}
			toRespawn.Clear();
			CollectibleManager.ClearStageScore();
		}
		
		public static string GetValueFromKey( string key )
		{
			if ( !_init) init();
			if ( strings.ContainsKey( key ) )
				return  strings[key];	
			else return null;
		}
	}
}

