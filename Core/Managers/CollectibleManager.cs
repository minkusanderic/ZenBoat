using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Core
{
	public static class CollectibleManager
	{
		static bool 		m_bInitialized 		= false;
		static string 		m_sFilPath 			= "SavedGame";
		static string 		m_sCurrentLevel		= ""; // main menu?
		public static int 			m_iScore 			= 0;
		
		
		static Dictionary<string /*Entity*/, string/*Saved Info*/> m_dDictionary;
		
		
		public static void Init()
		{
			m_bInitialized 	= true;
			m_dDictionary 	= new Dictionary<string, string>();

			// Readin saved game data.
			LoadSavedGame(); // High level things, like last login, total score
			
			// Modify the Level ( Check the ID's of the Entities )
			
		}
		
		public static bool SaveGame()
		{
			return false;
		}
		
		public static bool LoadSavedGame()
		{
			return false;
		}
		
		public static void CollectItem(	string id )
		{
			m_iScore ++;
			Console.WriteLine("Crane Score: " + m_iScore);
		}
	}
}

