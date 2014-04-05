using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Core;
using Main;
namespace Core
{
	public static class LevelUIManager
	{
		public class StarsUI
		{
			//  this represents the graphical stars
			
		}
		private static bool init = false;
		public static bool GetInit()
		{
			return init;
		}
		public static void Init()
		{
			init = true;
		}
		public static int GetStars( string level_name )
		{
			string completed_level = SaveGameManager.GetValueFromKey(Globals.completedLevelPrefix + level_name);
			if ( completed_level != Globals.true_) return 0; // you have not completed the lvl so how can you have any stars!?
			int star_count = 0;
			// return how many stars the player has gotten on the level
			
			String total_cranes_got_string = SaveGameManager.GetValueFromKey( Globals.craneTotalForLevelPrefix + level_name );
			String max_crances_got_string  = SaveGameManager.GetValueFromKey( Globals.craneMaxForLevelPrefix + level_name );
			int total_crane_count= 0;
			int max_crane_count= 0; /* for the level */
			if ( total_cranes_got_string != null )
			{
				int.TryParse( total_cranes_got_string , out total_crane_count  );
			}
			if ( max_crances_got_string != null )
			{
				int.TryParse( max_crances_got_string , out max_crane_count  );
			}
			if ( total_crane_count == 0 ) return 0; // it is possible that the player has not visited the level being viewed on the level select (the level is locked)
			
			float c_got = (float)max_crane_count;
			float tot = (float)total_crane_count;
			float ratio = c_got/tot;
			if ( ratio == 1 ) return 3;
			if ( ratio > .33) return 2;
			if ( ratio <=.33) return 1;
			else return 0;
			return star_count;
		}
		public static void FilterStars(ImageBox image_box1 , ImageBox image_box2 , ImageBox image_box3 , int number_of_stars )
		{
			ImageAsset fullStar = new ImageAsset("/Application/assets/FullStar.png" , true);
			ImageAsset emptyStar = new ImageAsset("/Application/assets/EmptyStar.png" , true);
			image_box1.Image = fullStar;
			image_box2.Image = fullStar;
			image_box3.Image = fullStar;
			if ( number_of_stars < 3 )
			{
				image_box3.Image = emptyStar;
			}
			if ( number_of_stars < 2 )
			{
				image_box2.Image = emptyStar;
			}
			if ( number_of_stars < 1 )
			{
				image_box1.Image = emptyStar;
			}	
		}
	}
}

