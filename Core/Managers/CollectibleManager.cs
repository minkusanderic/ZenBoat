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
		static int 			levelScore 			= 0;	
		static int 			stageScore 			= 0;	// Running total for the crane score, level total?
		public static int 	multiplier 			= 1;
		static bool 		touched 			= false;
		static int 			maxMultiplier 		= 5;
		static Dictionary<string , string> 		dictionary;
		
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
		
		
		public static void CollectItem( Entity ent,	string id , int worth )
		{
			// check if the screen has been touched.
			if ( touched )
			{
				touched = false;
				//multiplier = 1;
			}
			stageScore += ( worth * multiplier++ );	// take the crane value
			PrintScore();
			
			if ( multiplier > maxMultiplier )
				multiplier = maxMultiplier;
			SaveGameManager.toRespawn.Add( ent );
		
		}
		
		public static void SetLevelScore()
		{
			levelScore += stageScore;
			stageScore = 0;
		}
		/// <summary>
		/// Clears the stage score which is inbetween each checkpoint
		/// </summary>
		public static void ClearStageScore()
		{
			stageScore = 0; // because you died and need to respawn the cranes
		}
		public static void PrintScore()
		{
			Console.WriteLine("Level Score: " + levelScore + "\tStage Score: " + stageScore);	
		}
	}
}

