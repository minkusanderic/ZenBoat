using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

using Core;

namespace Menu
{
    public partial class Tier4 : Panel
    {
        public Tier4()
        {
            InitializeWidget();
			
			make_boat("BoatPirate", 10000);
			make_boat("BoatDuckie", 10000);
			
			button1.ButtonAction += HandleButtonAction;
			button2.ButtonAction += HandleButtonAction;
			
			label1.Font = Globals.medium_font;
			label2.Font = Globals.medium_font;
			
			ImageBox_1.Visible = false;
			ImageBox_2.Visible = false;
			
			if(SaveGameManager.GetValueFromKey("BoatPirate") == "0")
			{
				label1.Visible = false;
			}
			if(SaveGameManager.GetValueFromKey("BoatDuckie") == "0")
			{
				label2.Visible = false;
			}
        }
		protected override void OnUpdate (float elapsedTime)
		{
			base.OnUpdate (elapsedTime);
			ImageBox_1.Visible = (Globals.chosenBoat == "BoatPirate");
			ImageBox_2.Visible = (Globals.chosenBoat == "BoatDuckie");

			
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
				ProcessBoat("BoatPirate");
				ImageBox_1.Visible = true;
				ImageBox_2.Visible = false;
			}
			if(sender.Equals(button2))
			{
				ProcessBoat("BoatDuckie");
				ImageBox_1.Visible = false;
				ImageBox_2.Visible = true;
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
			else if(boat_value <= crane_count)
			{
				var why_dont_you_just_buy_the_boat = new Menu.StoreMessage("Would you like to buy this boat?",
				                                                           (sender, e) => {
					if(e.Result == DialogResult.Ok){
					SaveGameManager.SaveString(boat, "0");
					crane_count -= boat_value;
					SaveGameManager.SaveString("crane_value", crane_count.ToString());
					Console.WriteLine("Buying Boat");
					Globals.chosenBoat = boat;
					Console.WriteLine("Selected Boat");	
						if(SaveGameManager.GetValueFromKey("BoatPirate") == "0")
						{
							label1.Visible = false;
						}
						if(SaveGameManager.GetValueFromKey("BoatDuckie") == "0")
						{
							label2.Visible = false;
						}
					}
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
