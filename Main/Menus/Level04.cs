using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Core;
using Main;
namespace Menu
{
    public partial class Level04 : Panel
    {
        public Level04()
        {
            InitializeWidget();
			Button_1.ButtonAction += HandleButton_1ButtonAction;
			Button_2.ButtonAction += HandleButton_2ButtonAction;
			Button_3.ButtonAction += HandleButton_3ButtonAction;
			Button_4.ButtonAction += HandleButton_4ButtonAction;
			int l1 = LevelUIManager.GetStars(LevelLoader.searchPath + Button_1.Text + ".oel");
			int l2 = LevelUIManager.GetStars(LevelLoader.searchPath + Button_2.Text + ".oel");
			int l3 = LevelUIManager.GetStars(LevelLoader.searchPath + Button_3.Text + ".oel");
			int l4 = LevelUIManager.GetStars(LevelLoader.searchPath + Button_4.Text + ".oel");
			LevelUIManager.FilterStars( ImageBox_1_1 , ImageBox_1_2 , ImageBox_1_3 , l1 );
			LevelUIManager.FilterStars( ImageBox_2_1 , ImageBox_2_2 , ImageBox_2_3 , l2 );
			LevelUIManager.FilterStars( ImageBox_3_1 , ImageBox_3_2 , ImageBox_3_3 , l3 );
			LevelUIManager.FilterStars( ImageBox_4_1 , ImageBox_4_2 , ImageBox_4_3 , l4 );
			if ( SaveGameManager.GetValueFromKey( 
			      Globals.unlockedLevelPrefix + LevelLoader.searchPath + LevelLabel_1.Text + ".oel" ) != "unlocked" )
			{
				Button_1.Alpha = .5f;
				Button_1.Enabled = false;	
			}else { Button_1.Enabled = true; }
			
			if ( SaveGameManager.GetValueFromKey( 
			      Globals.unlockedLevelPrefix + LevelLoader.searchPath + LevelLabel_2.Text + ".oel" ) != "unlocked" )
			{
				Button_2.Alpha = .5f;
				Button_2.Enabled = false;	
			}else { Button_2.Enabled = true; }
			
			if ( SaveGameManager.GetValueFromKey( 
			      Globals.unlockedLevelPrefix + LevelLoader.searchPath + LevelLabel_3.Text + ".oel" ) != "unlocked" )
			{
				Button_3.Alpha = .5f;
				Button_3.Enabled = false;	
			}else { Button_3.Enabled = true; }
			
			if ( SaveGameManager.GetValueFromKey( 
			      Globals.unlockedLevelPrefix + LevelLoader.searchPath + LevelLabel_4.Text + ".oel" ) != "unlocked" )
			{
				Button_4.Alpha = .5f;
				Button_4.Enabled = false;	
			}else { Button_4.Enabled = true; }
        }
		
        void HandleButton_4ButtonAction (object sender, TouchEventArgs e)
        {
        	Globals.current_level = LevelLoader.searchPath + LevelLabel_4.Text + ".oel";
			MenuLoader.isPlay = false;
        }

        void HandleButton_3ButtonAction (object sender, TouchEventArgs e)
        {
        	Globals.current_level = LevelLoader.searchPath + LevelLabel_3.Text + ".oel";
			MenuLoader.isPlay = false;
        }

        void HandleButton_2ButtonAction (object sender, TouchEventArgs e)
        {
        	Globals.current_level = LevelLoader.searchPath + LevelLabel_2.Text + ".oel";
			MenuLoader.isPlay = false;
        }

        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
			Globals.current_level = LevelLoader.searchPath + LevelLabel_1.Text + ".oel";
			MenuLoader.isPlay = false;
        }	
    }
}
