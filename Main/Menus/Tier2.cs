using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

using Core;

namespace Menu
{
    public partial class Tier2 : Panel
    {
        public Tier2()
        {
            InitializeWidget();
			
			make_boat("BoatOrg1", 1000);
			make_boat("BoatOrg2", 1000);
			make_boat("BoatOrg3", 1000);
			make_boat("BoatOrg4", 1000);
			make_boat("BoatOrg5", 1000);
			make_boat("BoatOrg6", 1000);
        }
		
		private void make_boat(String boat,int price)
		{
			if(SaveGameManager.GetValueFromKey(boat) == null)
			{
				SaveGameManager.SaveString(boat, price.ToString());
			}
		}
    }
}
