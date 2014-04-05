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
			
			button1.ButtonAction += HandleButton1ButtonAction;
        }

        void HandleButton1ButtonAction (object sender, TouchEventArgs e)
        {
			String boat = "black";
			int boat_value;
			if(!int.TryParse(Globals.boats[boat], out boat_value))
			{
				Console.WriteLine("Could not convert boat value");
			}
			//Case 1: I have the boat, and I want to select
			if(Globals.boats[boat] == "0")
			{
				Globals.chosenBoat = boat;	
			}
			
			//Case 2: I don't have the boat, I want to buy it and I have enough cranes
			
			//Case 3: I don't have the boat, I want to buy it but I don't have enough cranes
        }
    }
}
