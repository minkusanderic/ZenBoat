// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Store
    {
        ListPanel ListPanel_1;
        Button PurchaseButton;
        Button BackButton;
        Label Label_1;
        Label Label_2;
        Label Label_3;
        Label Label_4;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ListPanel_1 = new ListPanel();
            ListPanel_1.Name = "ListPanel_1";
            PurchaseButton = new Button();
            PurchaseButton.Name = "PurchaseButton";
            BackButton = new Button();
            BackButton.Name = "BackButton";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_2 = new Label();
            Label_2.Name = "Label_2";
            Label_3 = new Label();
            Label_3.Name = "Label_3";
            Label_4 = new Label();
            Label_4.Name = "Label_4";

            // Store
            this.RootWidget.AddChildLast(ListPanel_1);
            this.RootWidget.AddChildLast(PurchaseButton);
            this.RootWidget.AddChildLast(BackButton);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(Label_2);
            this.RootWidget.AddChildLast(Label_3);
            this.RootWidget.AddChildLast(Label_4);

            // ListPanel_1
            ListPanel_1.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;
            ListPanel_1.SetListItemCreator(StoreItem.Creator);

            // PurchaseButton
            PurchaseButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            PurchaseButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // BackButton
            BackButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            BackButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // Label_2
            Label_2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_2.LineBreak = LineBreak.Character;

            // Label_3
            Label_3.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_3.LineBreak = LineBreak.Character;
            Label_3.HorizontalAlignment = HorizontalAlignment.Right;

            // Label_4
            Label_4.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_4.LineBreak = LineBreak.Character;
            Label_4.HorizontalAlignment = HorizontalAlignment.Right;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    ListPanel_1.SetPosition(57, 51);
                    ListPanel_1.SetSize(854, 400);
                    ListPanel_1.Anchors = Anchors.None;
                    ListPanel_1.Visible = true;

                    PurchaseButton.SetPosition(101, 438);
                    PurchaseButton.SetSize(214, 56);
                    PurchaseButton.Anchors = Anchors.None;
                    PurchaseButton.Visible = true;

                    BackButton.SetPosition(133, 436);
                    BackButton.SetSize(214, 56);
                    BackButton.Anchors = Anchors.None;
                    BackButton.Visible = true;

                    Label_1.SetPosition(47, 30);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(211, 86);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(525, 84);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(664, 84);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    ListPanel_1.SetPosition(47, 138);
                    ListPanel_1.SetSize(859, 288);
                    ListPanel_1.Anchors = Anchors.None;
                    ListPanel_1.Visible = true;

                    PurchaseButton.SetPosition(693, 442);
                    PurchaseButton.SetSize(214, 56);
                    PurchaseButton.Anchors = Anchors.None;
                    PurchaseButton.Visible = true;

                    BackButton.SetPosition(47, 442);
                    BackButton.SetSize(214, 56);
                    BackButton.Anchors = Anchors.None;
                    BackButton.Visible = true;

                    Label_1.SetPosition(47, 30);
                    Label_1.SetSize(529, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(143, 84);
                    Label_2.SetSize(409, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(552, 84);
                    Label_3.SetSize(112, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(664, 84);
                    Label_4.SetSize(107, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            PurchaseButton.Text = "Purchase";

            BackButton.Text = "Back";

            Label_1.Text = "Product List";

            Label_2.Text = "Name";

            Label_3.Text = "Price";

            Label_4.Text = "Ticket";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
