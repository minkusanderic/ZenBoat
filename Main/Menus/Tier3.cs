using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

using Core;

namespace Menu
{
    public partial class Tier3 : Panel
    {
        public Tier3()
        {
            InitializeWidget();
			
			make_boat("BoatPat1", 5000);
			make_boat("BoatPat2", 5000);
			make_boat("BoatPat3", 5000);
			make_boat("BoatPat4", 5000);
			make_boat("BoatPat5", 5000);
			make_boat("BoatPat6", 5000);
			make_boat("BoatPat7", 5000);
			
			button1.ButtonAction += HandleButtonAction;
			button2.ButtonAction += HandleButtonAction;
			button3.ButtonAction += HandleButtonAction;
			button4.ButtonAction += HandleButtonAction;
			button5.ButtonAction += HandleButtonAction;
			button6.ButtonAction += HandleButtonAction;
			button7.ButtonAction += HandleButtonAction;
			
			label1.Font = Globals.medium_font;
			label2.Font = Globals.medium_font;
			label3.Font = Globals.medium_font;
			label4.Font = Globals.medium_font;
			label5.Font = Globals.medium_font;
			label6.Font = Globals.medium_font;
			label7.Font = Globals.medium_font;
        }
		
		private void make_boat(String boat,int price)
		{
			if(SaveGameManager.GetValueFromKey(boat) == null)
			{
				SaveGameManager.SaveString(boat, price.ToString());
			}
		}
		
        void HandleButtonAction (object sender, TouchEventArgs e)
        {
			if(sender.Equals(button1))
			{
				ProcessBoat("BoatPat1");
			}
			if(sender.Equals(button2))
			{
				ProcessBoat("BoatPat2");
			}
			if(sender.Equals(button3))
			{
				ProcessBoat("BoatPat3");
			}
			if(sender.Equals(button4))
			{
				ProcessBoat("BoatPat4");
			}
			if(sender.Equals(button5))
			{
				ProcessBoat("BoatPat5");
			}
			if(sender.Equals(button6))
			{
				ProcessBoat("BoatPat6");
			}
			if(sender.Equals(button7))
			{
				ProcessBoat("BoatPat7");
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
