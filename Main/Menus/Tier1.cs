using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

using Core;

namespace Menu
{
    public partial class Tier1 : Panel
    {
        public Tier1()
        {
            InitializeWidget();
			
			make_boat("BoatBlack", 500);
			make_boat("BoatBlue", 500);
			make_boat("BoatGreen", 500);
			make_boat("BoatPurple", 500);
			make_boat("BoatRed", 500);
			make_boat("BoatTeal", 500);
			make_boat("BoatWhite", 500);
			make_boat("BoatYellow", 500);			
			
			button1.ButtonAction += HandleButton1ButtonAction;
			button2.ButtonAction += HandleButton1ButtonAction;
			button3.ButtonAction += HandleButton1ButtonAction;
			button4.ButtonAction += HandleButton1ButtonAction;
			button5.ButtonAction += HandleButton1ButtonAction;
			button6.ButtonAction += HandleButton1ButtonAction;
			button7.ButtonAction += HandleButton1ButtonAction;
			button8.ButtonAction += HandleButton1ButtonAction;
			
			label1.Font = Globals.small_font;
			label2.Font = Globals.small_font;
			label3.Font = Globals.small_font;
			label4.Font = Globals.small_font;
			label5.Font = Globals.small_font;
			label6.Font = Globals.small_font;
			label7.Font = Globals.small_font;
			label8.Font = Globals.small_font;
			
			
        }
		
		private void make_boat(String boat,int price)
		{
			if(SaveGameManager.GetValueFromKey(boat) == null)
			{
				SaveGameManager.SaveString(boat, price.ToString());
			}
		}
		
		void HandleButton1ButtonAction (object sender, TouchEventArgs e)
		{
			if(sender.Equals(button1))
			{
				ProcessBoat("BoatBlack");
			}
			if(sender.Equals(button2))
			{
				ProcessBoat("BoatBlue");
			}
			if(sender.Equals(button3))
			{
				ProcessBoat("BoatGreen");
			}
			if(sender.Equals(button4))
			{
				ProcessBoat("BoatPurple");
			}
			if(sender.Equals(button5))
			{
				ProcessBoat("BoatRed");
			}
			if(sender.Equals(button6))
			{
				ProcessBoat("BoatTeal");
			}
			if(sender.Equals(button7))
			{
				ProcessBoat("BoatWhite");
			}
			if(sender.Equals(button8))
			{
				ProcessBoat("BoatYellow");
			}
			
		}
		
        void ProcessBoat(String boat)
        {
			int boat_value;
			int crane_count;
			
			if(!int.TryParse(SaveGameManager.GetValueFromKey("crane_value"), out crane_count))
			{
				Console.WriteLine("Could not convert crane value");
				crane_count = 0;
			}
			
			if(!int.TryParse(SaveGameManager.GetValueFromKey(boat), out boat_value))
			{
				Console.WriteLine("Could not convert boat value");
			}
			//Case 1: I have the boat, and I want to select
			if(SaveGameManager.GetValueFromKey(boat) == "0")
			{
				Globals.chosenBoat = boat;
				Console.WriteLine("Selected Boat");
			}
			
			//Case 2: I don't have the boat, I want to buy it and I have enough cranes
			else if(boat_value < crane_count)
			{
				var why_dont_you_just_buy_the_boat = new Menu.StoreMessage("Would you like to buy this boat?",
				                                                           (sender, e) => {
					//if(e.Result == DialogResult.Ok){
					SaveGameManager.SaveString(boat, "0");
					crane_count -= boat_value;
					SaveGameManager.SaveString("crane_value", crane_count.ToString());
					Console.WriteLine("Buying Boat");
					Globals.chosenBoat = boat;
					Console.WriteLine("Selected Boat");	
					//}
				});
			}
			//Case 3: I don't have the boat, I want to buy it but I don't have enough cranes
			else
			{
				var the_world_is_not_enough = new Menu.NotEnoughMessage();
				the_world_is_not_enough.Show();
			}
        }
    }
}
