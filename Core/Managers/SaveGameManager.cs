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
		
		//---------------------//
		private static string currentLevel;
		private static string lastTimePlayed;
		private static List<string> strings = new List<string>();
		
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
			
			const string DATA = "This is some data";
 
			byte[] persistentData = PersistentMemory.Read();
				 
			byte[] restoredData = persistentData.Take(DATA.Length * 2).ToArray();
			string restoredString = System.Text.Encoding.Unicode.GetString(restoredData);
				 
			byte[] stringAsBytes = System.Text.Encoding.Unicode.GetBytes(DATA);
				 
			for(int i = 0; i < stringAsBytes.Length; i++)
				persistentData[i] = stringAsBytes[i];
			PersistentMemory.Write (persistentData);
				 
			using(FileStream fs = File.Open(save_game_file_path	,FileMode.OpenOrCreate))
			{
				if(fs.Length == 0)
				{
					fs.Write(stringAsBytes,0,stringAsBytes.Length);
				}
				else
				{
					byte[] fileContents = new byte[fs.Length];	
					fs.Read(fileContents,0,(int)fs.Length);
				}
			}
			return _init;
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
				
				
				return true;
			}
			return false;
		}

		
	}
}

