// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Select
    {
        ImageBox craneImage;
        Label craneCount;
        Button buyButton;
        Button backButton;
        PagePanel PagePanel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            craneImage = new ImageBox();
            craneImage.Name = "craneImage";
            craneCount = new Label();
            craneCount.Name = "craneCount";
            buyButton = new Button();
            buyButton.Name = "buyButton";
            backButton = new Button();
            backButton.Name = "backButton";
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";

            // Select
            this.RootWidget.AddChildLast(craneImage);
            this.RootWidget.AddChildLast(craneCount);
            this.RootWidget.AddChildLast(buyButton);
            this.RootWidget.AddChildLast(backButton);
            this.RootWidget.AddChildLast(PagePanel_1);

            // craneImage
            craneImage.Image = null;
            craneImage.ImageScaleType = ImageScaleType.Center;

            // craneCount
            craneCount.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            craneCount.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            craneCount.LineBreak = LineBreak.Character;
            craneCount.HorizontalAlignment = HorizontalAlignment.Center;

            // buyButton
            buyButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            buyButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // backButton
            backButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            backButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // PagePanel_1
            PagePanel_1.AddPage(new Tier1());
            PagePanel_1.AddPage(new Tier2());
            PagePanel_1.AddPage(new Tier3());
            PagePanel_1.AddPage(new Tier4());

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

                    craneImage.SetPosition(608, -77);
                    craneImage.SetSize(200, 200);
                    craneImage.Anchors = Anchors.None;
                    craneImage.Visible = true;

                    craneCount.SetPosition(746, 0);
                    craneCount.SetSize(214, 36);
                    craneCount.Anchors = Anchors.None;
                    craneCount.Visible = true;

                    buyButton.SetPosition(439, 0);
                    buyButton.SetSize(214, 56);
                    buyButton.Anchors = Anchors.None;
                    buyButton.Visible = true;

                    backButton.SetPosition(0, 0);
                    backButton.SetSize(214, 56);
                    backButton.Anchors = Anchors.None;
                    backButton.Visible = true;

                    PagePanel_1.SetPosition(380, 200);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    craneImage.SetPosition(700, 0);
                    craneImage.SetSize(44, 36);
                    craneImage.Anchors = Anchors.None;
                    craneImage.Visible = true;

                    craneCount.SetPosition(746, 0);
                    craneCount.SetSize(214, 36);
                    craneCount.Anchors = Anchors.None;
                    craneCount.Visible = true;

                    buyButton.SetPosition(726, 464);
                    buyButton.SetSize(214, 56);
                    buyButton.Anchors = Anchors.None;
                    buyButton.Visible = true;

                    backButton.SetPosition(20, 464);
                    backButton.SetSize(214, 56);
                    backButton.Anchors = Anchors.None;
                    backButton.Visible = true;

                    PagePanel_1.SetPosition(0, 40);
                    PagePanel_1.SetSize(960, 420);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            craneCount.Text = "crane count";

            buyButton.Text = "Buy Cranes";

            backButton.Text = "Back";
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
