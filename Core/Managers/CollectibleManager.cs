using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sce.PlayStation.HighLevel.GameEngine2D;

namespace Core
{
	public static class CollectibleManager
	{
		static bool 		initialized 		= false;
		static string 		filePath 			= "SavedGame";
		static string 		currentLevel		= ""; // main menu?
		static int 			score 				= 0;
		static float 		multiplier 			= 1f;
		
		static Dictionary<string /*Entity*/, string/*Saved Info*/> m_dDictionary;
		
		
		public static void Init()
		{
			initialized 	= true;
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
			score ++;
			Console.WriteLine("Crane Score: " + score);
			
		}
	}
}

