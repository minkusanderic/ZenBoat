using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Services;
using Sce.PlayStation.HighLevel.UI;
using Main;
using Core;

namespace Menu
{
    public partial class Store : Scene
    {
		
        private static InAppPurchaseDialog dialog = new InAppPurchaseDialog();
        private bool dialogIsBusy;
        private int selectedItem;

        private enum DialogSequence { Stop, Start, Ready, Action };
        private DialogSequence dialogSequence;

        private InAppPurchaseCommand actionCommand;
        private string actionLabel;
        private bool actionTicketIsOK;
        private int actionTicketCount;

        public delegate void PurchaseHandler(InAppPurchaseProduct product);
        public delegate void ConsumeHandler(InAppPurchaseProduct product, int count);
        public /*event*/ PurchaseHandler Purchased;
        public /*event*/ ConsumeHandler Consumed;		
		
        public Store(PurchaseHandler onPurchased = null, ConsumeHandler onConsumed = null)
        {
            InitializeWidget();
			
           // PurchaseButton.ButtonAction += OnPurchase;
			BackButton.ButtonAction += OnClose;

           // ListPanel_1.SetListItemCreator(OnCreateItem);
           // ListPanel_1.SetListItemUpdater(OnUpdateItem);
           // ListPanel_1.Sections = new ListSectionCollection { new ListSection("Section", 0) };//

            if (onPurchased != null) Purchased = onPurchased;
            if (onConsumed != null) Consumed = onConsumed;
			InitializeDialog();
			
			Button_1.ButtonAction += HandleButton_1ButtonAction;
			Button_2.ButtonAction += HandleButton_1ButtonAction;
			Button_3.ButtonAction += HandleButton_1ButtonAction;
			Button_4.ButtonAction += HandleButton_1ButtonAction;
			Button_5.ButtonAction += HandleButton_1ButtonAction;
			Button_6.ButtonAction += HandleButton_1ButtonAction;
			
			Purchased += Handle_Purchase;
			//Consumed += Handle_Consume;
			
			Label_1.Font = Globals.medium_font;
			Label_2.Font = Globals.medium_font;
			Label_3.Font = Globals.medium_font;
			Label_4.Font = Globals.medium_font;
			Label_5.Font = Globals.medium_font;
			Label_6.Font = Globals.medium_font;
			//We need updated fonts with the '$'
			//Label_7.Font = Globals.medium_font;
			//Label_8.Font = Globals.medium_font;
			//Label_9.Font = Globals.medium_font;
			//Label_10.Font = Globals.medium_font;
			//Label_11.Font = Globals.medium_font;
			//Label_12.Font = Globals.medium_font;
			
			BackButton.TextFont = Globals.medium_font;
			Button_1.TextFont = Globals.medium_font;
			Button_2.TextFont = Globals.medium_font;
			Button_3.TextFont = Globals.medium_font;
			Button_4.TextFont = Globals.medium_font;
			Button_5.TextFont = Globals.medium_font;
			Button_6.TextFont = Globals.medium_font;
            
        }
				
		void Handle_Purchase(InAppPurchaseProduct product)
		{
			Console.WriteLine("Handling Product " + product.Label);
			Console.WriteLine("Num of Packs: " + product.ConsumableTicketCount);
			ProductConsume(product);
			
			switch(product.Label)
			{
			case "CRANE1":
				increment_crane_count(1000);
				break;
			case "CRANE2":
				increment_crane_count(3000);
				break;
			case "CRANE3":
				increment_crane_count(5000);
				break;
			case "CRANE4":
				increment_crane_count(10000);
				break;
			case "CRANE5":
				increment_crane_count(20000);
				break;
			case "CRANE6":
				increment_crane_count(50000);
				break;
			}
			//increment crane count
		}
		
		void increment_crane_count(int num)
		{
			if(Core.SaveGameManager.GetValueFromKey("crane_value") == null)
			{
				Core.SaveGameManager.SaveString("crane_value", "0");
			}
			int cc;
			if(!int.TryParse(Core.SaveGameManager.GetValueFromKey("crane_value"), out cc))
			{
				Console.WriteLine("ERROR in geting crane value");
			}
			Core.SaveGameManager.SaveString("crane_value", (cc + num).ToString());
		}
		void Handle_Consume(InAppPurchaseProduct product, int count)
		{
			Console.WriteLine("Handling Consume " + product.Label);
			Console.WriteLine("Increment Crane Count");
		}

        void HandleButton_1ButtonAction (object sender, TouchEventArgs e)
        {
			if(sender.Equals(Button_1))
			{
				Console.WriteLine("BUTTON 1");
				selectedItem = 0;
			}
			
			if(sender.Equals(Button_2))
			{
				Console.WriteLine("BUTTON 2");
				selectedItem = 1;
			}
			if(sender.Equals(Button_3))
			{
				Console.WriteLine("BUTTON 3");
				selectedItem = 2;
			}
			if(sender.Equals(Button_4))
			{
				Console.WriteLine("BUTTON 4");
				selectedItem = 3;
			}
			if(sender.Equals(Button_5))
			{
				Console.WriteLine("BUTTON 5");
				selectedItem = 4;
			}
			if(sender.Equals(Button_6))
			{
				Console.WriteLine("BUTTON 6");
				selectedItem = 5;
				
			}
			ProductPurchase(dialog.ProductList[selectedItem]);
        	//ProductPurchase(dialog.
			//dialog.Consume("CRANES");
        }
		
		 protected override void OnUpdate(float elapsedTime)
        {
            base.OnUpdate(elapsedTime);
			UpdateDialog();
			update_prices();
        }
		///
		void update_prices()
		{
			if(dialog.IsProductInfoComplete)
			{
				Label_7.Text = find_price("CRANE1");
				Label_8.Text = find_price("CRANE2");
				Label_9.Text = find_price("CRANE3");
				Label_10.Text = find_price("CRANE4");
				Label_11.Text = find_price("CRANE5");
				Label_12.Text = find_price("CRANE6");				
			}
		}
		String find_price(String id)
		{
			foreach(var p in dialog.ProductList)
			{
				if(p.Label == id)
				{
					return p.Price;
				}
			}
			return "";
		}
		//  Public methods

        public void SetItemCount(int count)
        {
			Console.WriteLine("Count: " + count);
           // var listSection = ListPanel_1.Sections[0];//
           // if (listSection.ItemCount != count) listSection.ItemCount = count;
        }
        public void UpdateItems()
        {
           // ListPanel_1.UpdateItems();
            SwitchButtons();
        }

        //  Override events

       
        protected override void OnShown()
        {
            base.OnShown();
            dialogSequence = DialogSequence.Start;
            dialogIsBusy = false;
        }

        //  Dialog functions

        private void InitializeDialog()
        {
			
            //dialog = new InAppPurchaseDialog();
            dialogSequence = DialogSequence.Stop;
            dialogIsBusy = false;
            selectedItem = 0;

            SetItemCount(dialog.ProductList.Count);
            UpdateItems();
        }
        private void UpdateDialog()
        {
            bool finished = false;
            if (dialogIsBusy) {
                if (dialog.State == CommonDialogState.Running) return;
                if (dialog.Result == CommonDialogResult.OK) {
                    SetItemCount(dialog.ProductList.Count);
                    UpdateItems();
                }
                dialogIsBusy = false;
                finished = true;
            }
            switch (dialogSequence) {
                case DialogSequence.Stop:
                    break;
                case DialogSequence.Start:
                    if (finished) {
                        if (dialog.Result != CommonDialogResult.OK) {
                            new StoreMessage("Sorry. We cannot access the store now.", OnClose);
                            dialogSequence = DialogSequence.Stop;
                            break;
                        }
                    }
                    if (!dialog.IsProductInfoComplete) {
                        dialog.GetProductInfo(null);
                        dialogIsBusy = true;
                    } else if (!dialog.IsTicketInfoComplete) {
                        dialog.GetTicketInfo();
                        dialogIsBusy = true;
                    } else {
                        //  confirm the result of previous action ( if exists )
                        CheckActionResult();
                        dialogSequence = DialogSequence.Ready;
                    }
                    break;
                case DialogSequence.Ready:
                    break;
                case DialogSequence.Action:
                    if (finished) {
                        if (dialog.IsTicketInfoComplete) {
                            //  confirm the result
                            CheckActionResult();
                            dialogSequence = DialogSequence.Ready;
                        } else {
                            //  cannot confirm the result until followup query
                            dialogSequence = DialogSequence.Start;
                        }
                    }
                    break;
            }
        }

        //  Button events
		public void ProductPurchase(InAppPurchaseProduct product)
        {
            try {
                if (selectedItem < 0) return;
                CheckActionStart(InAppPurchaseCommand.Purchase);
                dialog.Purchase(product.Label);
                dialogSequence = DialogSequence.Action;
                dialogIsBusy = true;
            } catch (Exception exception) {
                new StoreMessage(exception);
            }
        }
		
        public void ProductConsume(InAppPurchaseProduct product)
        {
            try {
                if (selectedItem < 0) return;
                CheckActionStart(InAppPurchaseCommand.Consume);
                dialog.Consume(product.Label);
                dialogSequence = DialogSequence.Action;
                dialogIsBusy = true;
            } catch (Exception exception) {
                new StoreMessage(exception);
            }
        }
		/// <summary>
		/// Raises the purchase event.
		/// </summary>
		/// <param name='sender'>
		/// Sender.
		/// </param>
		/// <param name='e'>
		/// E.
		/// </param>
		/// 

        public void OnPurchase(object sender, EventArgs e)
        {
            try {
                if (selectedItem < 0) return;
                CheckActionStart(InAppPurchaseCommand.Purchase);
                dialog.Purchase(dialog.ProductList[selectedItem].Label);
                dialogSequence = DialogSequence.Action;
                dialogIsBusy = true;
            } catch (Exception exception) {
                new StoreMessage(exception);
            }
        }
		
        public void OnConsume(object sender, EventArgs e)
        {
            try {
                if (selectedItem < 0) return;
                CheckActionStart(InAppPurchaseCommand.Consume);
                dialog.Consume(dialog.ProductList[selectedItem].Label);
                dialogSequence = DialogSequence.Action;
                dialogIsBusy = true;
            } catch (Exception exception) {
                new StoreMessage(exception);
            }
        }
        public void OnClose(object sender, EventArgs e)
        {
            UISystem.PopScene();
			MenuLoader.loadSelect = true;
        }

        //  Item events

        public ListPanelItem OnCreateItem()
        {
            return new StoreItem(OnCheckItem);
        }
        public void OnCheckItem(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            var storeItem = checkBox.Parent as StoreItem;
            selectedItem = (storeItem.Index == selectedItem) ? -1 : storeItem.Index;
            UpdateItems();
        }
        public void OnUpdateItem(ListPanelItem item)
        {
			if ( item.Index < 0 ) return;
			Console.WriteLine("Here");
            var storeItem = item as StoreItem;
			Console.WriteLine("item index: " + item.Index );
            var product = dialog.ProductList[item.Index];
            storeItem.ItemCheck = (item.Index == selectedItem);
            storeItem.ItemIndex = (item.Index + 1).ToString();
            storeItem.ItemName = product.Name;

            storeItem.ItemPrice = (product.Price == "") ? "---" : product.Price;
			
            if (product.TicketType == InAppPurchaseTicketType.Normal) {
                storeItem.ItemTicket = !dialog.IsTicketInfoComplete ? "---" :
                                            (product.IsTicketValid ? "Yes" : "No");
            } else {
                storeItem.ItemTicket = !dialog.IsTicketInfoComplete ? "---" :
                                            product.ConsumableTicketCount.ToString();
            }
            
        }

        //  Button state

        private void SwitchButtons()
        {
            bool purchaseable = false;
            bool consumable = false;
            if (selectedItem >= 0 && dialog.IsProductInfoComplete && dialog.IsTicketInfoComplete) {
                var product = dialog.ProductList[selectedItem];
                if (product.TicketType == InAppPurchaseTicketType.Normal) {
                    purchaseable = !product.IsTicketValid;
                } else {
                    purchaseable = true;
                    consumable = product.IsTicketValid && (product.ConsumableTicketCount > 0);
                }
            }
            //PurchaseButton.Enabled = purchaseable;
            //Button_2.Enabled = consumable;
        }

        //  Action report

        private void CheckActionStart(InAppPurchaseCommand command)
        {
            var product = dialog.ProductList[selectedItem];
            actionCommand = command;
            actionLabel = product.Label;
            actionTicketIsOK = product.IsTicketValid;
            actionTicketCount = product.ConsumableTicketCount;
        }
        private void CheckActionResult()
        {
            var command = actionCommand;
            actionCommand = InAppPurchaseCommand.None;
            if (command == InAppPurchaseCommand.None) return;
			
            var product = dialog.ProductList[actionLabel];
            bool consumable = (product.TicketType == InAppPurchaseTicketType.Consumable);
            int count1 = !actionTicketIsOK ? 0 : (!consumable ? 1 : actionTicketCount);
            int count2 = !product.IsTicketValid ? 0 : (!consumable ? 1 : product.ConsumableTicketCount);
            bool purchasing = (command == InAppPurchaseCommand.Purchase);
            int count = purchasing ? (count2 - count1): (count1 - count2);
            if (count > 0) {
				Console.WriteLine(count);
                if (purchasing && Purchased != null) Purchased(product);
                if (!purchasing && Consumed != null) Consumed(product, count);
            }

            #if DEBUG
            if (count > 0 || dialog.Result != CommonDialogResult.Canceled) {
                string result = (count > 0) ? " completed." : " failed.";
                string message = command.ToString() + " " + product.Label + result;
                // new MyStoreMessage(message);
                Console.WriteLine(message);
            }
            #endif
        }
		
		///
    }
}
