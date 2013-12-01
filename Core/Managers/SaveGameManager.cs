using Sce;
using Sce.PlayStation.Core.Environment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;



namespace Core
{
	
	/*
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
		private static Dictionary<string , string> strings;
		//---------------------//
		private static string currentLevel;
		private static string lastTimePlayed;
		//private static List<string> strings = new List<string>();
		
		//private static List<Level> levels = new List<Level>();
		//---------------------//
		
		public static bool getInit()
		{
			return _init;
		}
		
		/// <summary>
		/// Init this instance.
		/// </summary>
		public static bool init()
		{
			_init = true;
			strings = new Dictionary<string, string>();
			
			const string DATA = 
				"<SaveGame>" +
				"\n\r\t<Strings>" +
				"\n\r\t</Strings>" +
				"</SaveGame>";
			
			FileStream fs = File.Open(save_game_file_path	,FileMode.OpenOrCreate);
			xml_doc = new XmlDocument();
			//xml_doc.Load( fs );
			bool fileExists  = fs.Length != 0;
			if ( !fileExists )
			{
				xml_doc.LoadXml( DATA );
				xml_doc.Save(save_game_file_path);
			}
			else
			{
				xml_doc.Load( fs );
				if ( xml_doc.FirstChild.FirstChild.Name == "Strings" )
				{
					foreach( XmlNode str in xml_doc.FirstChild.FirstChild.ChildNodes )
					{
						Console.WriteLine( str.Name );
						string key,val;
						key = val = "";
						foreach( XmlNode node in str.ChildNodes )
						{
							if ( node.Name == "Key" )
								key = node.InnerText;
							else 
							{
								val = node.InnerText;
							}
						}
						//Console.WriteLine("K:" + key + "\tV:" + val);
						if ( key != "" && val != "" )
						{
							strings.Add(key , val);	
						}
					}
				}	
			}
			fs.Close();	 
			//SetString( "Poop" , "Pants" );
			//xml_doc.Save( save_game_file_path );
			return _init;
		}
		
		public static bool ContainsSaveString( string key )
		{
			return strings.ContainsKey(key);	
		}
		
		public static void SetString( string key , string val )
		{
			if ( !strings.ContainsKey( key ) )
			{
				strings[key] = val;
			}
			XmlNode new_string = xml_doc.CreateNode( XmlNodeType.Element , "String" , "" );
			XmlNode new_key = xml_doc.CreateNode( XmlNodeType.Element , "Key" , "" );
			XmlNode new_val = xml_doc.CreateNode( XmlNodeType.Element , "Value" , "" );
			
			new_key.InnerText = key;
			new_val.InnerText = val;
			new_string.AppendChild( new_key );
			new_string.AppendChild( new_val );
			
			xml_doc.FirstChild.FirstChild.AppendChild( new_string );
		}
		
		public static bool loadGame()
		{
			if ( _init )
			{
				return true;
			}	
			return false;
		}
		
		public static bool saveGame()
		{
			if ( _init )
			{
				xml_doc.Save( save_game_file_path );
				return true;
			}
			return false;
		}

		
	}
}

