// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Select
    {
        ImageBox grass;
        ImageBox scroll;
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
            grass = new ImageBox();
            grass.Name = "grass";
            scroll = new ImageBox();
            scroll.Name = "scroll";
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
            this.RootWidget.AddChildLast(grass);
            this.RootWidget.AddChildLast(scroll);
            this.RootWidget.AddChildLast(craneImage);
            this.RootWidget.AddChildLast(craneCount);
            this.RootWidget.AddChildLast(buyButton);
            this.RootWidget.AddChildLast(backButton);
            this.RootWidget.AddChildLast(PagePanel_1);

            // grass
            grass.Image = new ImageAsset("/Application/assets/grassBack.png");

            // scroll
            scroll.Image = new ImageAsset("/Application/assets/scroll.png");

            // craneImage
            craneImage.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // craneCount
            craneCount.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            craneCount.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            craneCount.LineBreak = LineBreak.Character;
            craneCount.HorizontalAlignment = HorizontalAlignment.Center;

            // buyButton
            buyButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            buyButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            buyButton.Style = ButtonStyle.Custom;
            buyButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // backButton
            backButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            backButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            backButton.Style = ButtonStyle.Custom;
            backButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/back214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

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

                    grass.SetPosition(0, 0);
                    grass.SetSize(200, 200);
                    grass.Anchors = Anchors.None;
                    grass.Visible = true;

                    scroll.SetPosition(0, 0);
                    scroll.SetSize(200, 200);
                    scroll.Anchors = Anchors.None;
                    scroll.Visible = true;

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

                    grass.SetPosition(0, 0);
                    grass.SetSize(960, 544);
                    grass.Anchors = Anchors.None;
                    grass.Visible = true;

                    scroll.SetPosition(27, 0);
                    scroll.SetSize(906, 500);
                    scroll.Anchors = Anchors.None;
                    scroll.Visible = true;

                    craneImage.SetPosition(390, 0);
                    craneImage.SetSize(44, 36);
                    craneImage.Anchors = Anchors.None;
                    craneImage.Visible = true;

                    craneCount.SetPosition(436, 0);
                    craneCount.SetSize(134, 36);
                    craneCount.Anchors = Anchors.None;
                    craneCount.Visible = true;

                    buyButton.SetPosition(719, 480);
                    buyButton.SetSize(214, 56);
                    buyButton.Anchors = Anchors.None;
                    buyButton.Visible = true;

                    backButton.SetPosition(26, 480);
                    backButton.SetSize(214, 56);
                    backButton.Anchors = Anchors.None;
                    backButton.Visible = true;

                    PagePanel_1.SetPosition(169, 36);
                    PagePanel_1.SetSize(622, 428);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            craneCount.Text = "584";

            buyButton.Text = "Buy Cranes";
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
