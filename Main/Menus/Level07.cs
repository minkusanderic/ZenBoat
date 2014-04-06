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
    public partial class Level07 : Panel
    {
        public Level07()
        {
            InitializeWidget();
			Button_1.ButtonAction += HandleButton_1ButtonAction;
			int l1 = LevelUIManager.GetStars(LevelLoader.searchPath + LevelLabel_1.Text + ".oel");
			LevelUIManager.FilterStars( ImageBox_1_1 , ImageBox_1_2 , ImageBox_1_3 , l1 );
			Label_1.Font = new UIFont("/Application/Menus/Zen_Sketch.ttf", 36, FontStyle.Bold);
			if ( SaveGameManager.GetValueFromKey( 
			      Globals.unlockedLevelPrefix + LevelLoader.searchPath + LevelLabel_1.Text + ".oel" ) != "unlocked" )
			{
				Button_1.Alpha = .5f;
				Button_1.Enabled = false;	
			}else { Button_1.Enabled = true; }
        }

        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
			Globals.current_level = LevelLoader.searchPath + LevelLabel_1.Text + ".oel";
			MenuLoader.isPlay = false;
        }
    }
}
