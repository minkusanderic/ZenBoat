using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class Globals
	{
		public Globals ()
		{
		}
		
		public static float frames_per_second = 30.0f;
		public static bool use_mipmaps = true;

		public static String current_level = "/Application/Levels/001.oel";

		public static String chosenBoat = "";
		public static String craneTotalForLevelPrefix = "TotalCranes";
		public static String craneMaxForLevelPrefix = "Max";
		public static String completedLevelPrefix = "Completed";
		public static String unlockedLevelPrefix = "Unlocked";
		public static String true_ = "true";
		
		public static float Max_Speed_Of_Boat = 500.0f;
		public static int currentCraneCountOnLevel = 0;
		public static Sce.PlayStation.HighLevel.UI.UIFont medium_font = 
			new Sce.PlayStation.HighLevel.UI.UIFont("/Application/Menus/Zen_Sketch.ttf", 
			                                        36, 
			                                        Sce.PlayStation.Core.Imaging.FontStyle.Bold);
		
		public static Dictionary<String, String> boats = new Dictionary<String, String>();
	}
}

