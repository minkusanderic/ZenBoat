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
		static string 		currentLevel		= ""; 	// main menu?
		static int 			score 				= 0;	// Running total for the crane score
		static int 			multiplier 			= 1;
		static bool 		touched 			= false;
		static int 			maxMultiplier 		= 5;
		
		static Dictionary<string /*Entity*/, string/*Saved Info*/> dictionary;	// load this from the SaveGame Manager
		
		
		public static void Init()
		{
			initialized 	= true;
			dictionary 		= new Dictionary<string, string>();

			// Readin saved game data.
			LoadSavedGame(); // High level things, like last login, total score
			
			// Modify the Level ( Check the ID's of the Entities )
		}
		
		public static bool Touched
		{
			get{ return touched;}
			set{ touched = value;}
		}
		
		public static bool SaveGame()
		{
			return false;
		}
		
		public static bool LoadSavedGame()
		{
			return false;
		}
		
		
		public static void CollectItem(	string id , int worth)
		{
			// check if the screen has been touched.
			if ( touched )
			{
				touched = false;
				multiplier = 1;
			}
			score += (worth * multiplier++);	// take the crane value
			Console.WriteLine("Crane Score: " + score /*+ "\t" + multiplier */ );
			if ( multiplier > maxMultiplier )
				multiplier = maxMultiplier;
		
		}
	}
}

