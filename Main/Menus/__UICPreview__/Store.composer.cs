// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Store
    {
        ImageBox grass;
        ImageBox scroll;
        Button BackButton;
        Label Label_1;
        Label Label_2;
        Label Label_3;
        Label Label_4;
        Label Label_5;
        Label Label_6;
        Label Label_7;
        Label Label_8;
        Label Label_9;
        Label Label_10;
        Label Label_11;
        Label Label_12;
        Button Button_1;
        Button Button_2;
        Button Button_3;
        Button Button_4;
        Button Button_5;
        Button Button_6;
        ImageBox ImageBox_1;
        ImageBox ImageBox_2;
        ImageBox ImageBox_3;
        ImageBox ImageBox_4;
        ImageBox ImageBox_5;
        ImageBox ImageBox_6;

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
            Label_5 = new Label();
            Label_5.Name = "Label_5";
            Label_6 = new Label();
            Label_6.Name = "Label_6";
            Label_7 = new Label();
            Label_7.Name = "Label_7";
            Label_8 = new Label();
            Label_8.Name = "Label_8";
            Label_9 = new Label();
            Label_9.Name = "Label_9";
            Label_10 = new Label();
            Label_10.Name = "Label_10";
            Label_11 = new Label();
            Label_11.Name = "Label_11";
            Label_12 = new Label();
            Label_12.Name = "Label_12";
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Button_3 = new Button();
            Button_3.Name = "Button_3";
            Button_4 = new Button();
            Button_4.Name = "Button_4";
            Button_5 = new Button();
            Button_5.Name = "Button_5";
            Button_6 = new Button();
            Button_6.Name = "Button_6";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            ImageBox_2 = new ImageBox();
            ImageBox_2.Name = "ImageBox_2";
            ImageBox_3 = new ImageBox();
            ImageBox_3.Name = "ImageBox_3";
            ImageBox_4 = new ImageBox();
            ImageBox_4.Name = "ImageBox_4";
            ImageBox_5 = new ImageBox();
            ImageBox_5.Name = "ImageBox_5";
            ImageBox_6 = new ImageBox();
            ImageBox_6.Name = "ImageBox_6";

            // Store
            this.RootWidget.AddChildLast(grass);
            this.RootWidget.AddChildLast(scroll);
            this.RootWidget.AddChildLast(BackButton);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(Label_2);
            this.RootWidget.AddChildLast(Label_3);
            this.RootWidget.AddChildLast(Label_4);
            this.RootWidget.AddChildLast(Label_5);
            this.RootWidget.AddChildLast(Label_6);
            this.RootWidget.AddChildLast(Label_7);
            this.RootWidget.AddChildLast(Label_8);
            this.RootWidget.AddChildLast(Label_9);
            this.RootWidget.AddChildLast(Label_10);
            this.RootWidget.AddChildLast(Label_11);
            this.RootWidget.AddChildLast(Label_12);
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Button_2);
            this.RootWidget.AddChildLast(Button_3);
            this.RootWidget.AddChildLast(Button_4);
            this.RootWidget.AddChildLast(Button_5);
            this.RootWidget.AddChildLast(Button_6);
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(ImageBox_2);
            this.RootWidget.AddChildLast(ImageBox_3);
            this.RootWidget.AddChildLast(ImageBox_4);
            this.RootWidget.AddChildLast(ImageBox_5);
            this.RootWidget.AddChildLast(ImageBox_6);

            // grass
            grass.Image = new ImageAsset("/Application/assets/grassBack.png");

            // scroll
            scroll.Image = new ImageAsset("/Application/assets/scroll.png");

            // BackButton
            BackButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            BackButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            BackButton.Style = ButtonStyle.Custom;
            BackButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // Label_2
            Label_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_2.LineBreak = LineBreak.Character;

            // Label_3
            Label_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_3.LineBreak = LineBreak.Character;

            // Label_4
            Label_4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_4.LineBreak = LineBreak.Character;

            // Label_5
            Label_5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_5.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_5.LineBreak = LineBreak.Character;

            // Label_6
            Label_6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_6.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_6.LineBreak = LineBreak.Character;

            // Label_7
            Label_7.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_7.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_7.LineBreak = LineBreak.Character;

            // Label_8
            Label_8.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_8.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_8.LineBreak = LineBreak.Character;

            // Label_9
            Label_9.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_9.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_9.LineBreak = LineBreak.Character;

            // Label_10
            Label_10.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_10.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_10.LineBreak = LineBreak.Character;

            // Label_11
            Label_11.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_11.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_11.LineBreak = LineBreak.Character;

            // Label_12
            Label_12.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_12.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_12.LineBreak = LineBreak.Character;

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_1.Style = ButtonStyle.Custom;
            Button_1.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_2.Style = ButtonStyle.Custom;
            Button_2.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Button_3
            Button_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_3.Style = ButtonStyle.Custom;
            Button_3.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Button_4
            Button_4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_4.Style = ButtonStyle.Custom;
            Button_4.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Button_5
            Button_5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_5.Style = ButtonStyle.Custom;
            Button_5.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // Button_6
            Button_6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Button_6.Style = ButtonStyle.Custom;
            Button_6.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // ImageBox_2
            ImageBox_2.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // ImageBox_3
            ImageBox_3.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // ImageBox_4
            ImageBox_4.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // ImageBox_5
            ImageBox_5.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

            // ImageBox_6
            ImageBox_6.Image = new ImageAsset("/Application/assets/Crane_Icon2.png");

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

                    grass.SetPosition(316, 201);
                    grass.SetSize(200, 200);
                    grass.Anchors = Anchors.None;
                    grass.Visible = true;

                    scroll.SetPosition(0, 0);
                    scroll.SetSize(200, 200);
                    scroll.Anchors = Anchors.None;
                    scroll.Visible = true;

                    BackButton.SetPosition(133, 436);
                    BackButton.SetSize(214, 56);
                    BackButton.Anchors = Anchors.None;
                    BackButton.Visible = true;

                    Label_1.SetPosition(140, 120);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(140, 120);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(140, 120);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(140, 120);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Label_5.SetPosition(140, 120);
                    Label_5.SetSize(214, 36);
                    Label_5.Anchors = Anchors.None;
                    Label_5.Visible = true;

                    Label_6.SetPosition(140, 120);
                    Label_6.SetSize(214, 36);
                    Label_6.Anchors = Anchors.None;
                    Label_6.Visible = true;

                    Label_7.SetPosition(140, 120);
                    Label_7.SetSize(214, 36);
                    Label_7.Anchors = Anchors.None;
                    Label_7.Visible = true;

                    Label_8.SetPosition(140, 120);
                    Label_8.SetSize(214, 36);
                    Label_8.Anchors = Anchors.None;
                    Label_8.Visible = true;

                    Label_9.SetPosition(140, 120);
                    Label_9.SetSize(214, 36);
                    Label_9.Anchors = Anchors.None;
                    Label_9.Visible = true;

                    Label_10.SetPosition(140, 120);
                    Label_10.SetSize(214, 36);
                    Label_10.Anchors = Anchors.None;
                    Label_10.Visible = true;

                    Label_11.SetPosition(140, 120);
                    Label_11.SetSize(214, 36);
                    Label_11.Anchors = Anchors.None;
                    Label_11.Visible = true;

                    Label_12.SetPosition(140, 120);
                    Label_12.SetSize(214, 36);
                    Label_12.Anchors = Anchors.None;
                    Label_12.Visible = true;

                    Button_1.SetPosition(606, 33);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(606, 33);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(606, 33);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(606, 33);
                    Button_4.SetSize(214, 56);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    Button_5.SetPosition(606, 33);
                    Button_5.SetSize(214, 56);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(606, 33);
                    Button_6.SetSize(214, 56);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    ImageBox_1.SetPosition(40, 2);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ImageBox_2.SetPosition(40, 2);
                    ImageBox_2.SetSize(200, 200);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    ImageBox_3.SetPosition(40, 2);
                    ImageBox_3.SetSize(200, 200);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    ImageBox_4.SetPosition(40, 2);
                    ImageBox_4.SetSize(200, 200);
                    ImageBox_4.Anchors = Anchors.None;
                    ImageBox_4.Visible = true;

                    ImageBox_5.SetPosition(40, 2);
                    ImageBox_5.SetSize(200, 200);
                    ImageBox_5.Anchors = Anchors.None;
                    ImageBox_5.Visible = true;

                    ImageBox_6.SetPosition(40, 2);
                    ImageBox_6.SetSize(200, 200);
                    ImageBox_6.Anchors = Anchors.None;
                    ImageBox_6.Visible = true;

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

                    BackButton.SetPosition(373, 473);
                    BackButton.SetSize(214, 56);
                    BackButton.Anchors = Anchors.None;
                    BackButton.Visible = true;

                    Label_1.SetPosition(262, 90);
                    Label_1.SetSize(134, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(262, 150);
                    Label_2.SetSize(134, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(262, 390);
                    Label_3.SetSize(134, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(262, 270);
                    Label_4.SetSize(134, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    Label_5.SetPosition(262, 330);
                    Label_5.SetSize(134, 36);
                    Label_5.Anchors = Anchors.None;
                    Label_5.Visible = true;

                    Label_6.SetPosition(262, 210);
                    Label_6.SetSize(134, 36);
                    Label_6.Anchors = Anchors.None;
                    Label_6.Visible = true;

                    Label_7.SetPosition(420, 90);
                    Label_7.SetSize(110, 36);
                    Label_7.Anchors = Anchors.None;
                    Label_7.Visible = true;

                    Label_8.SetPosition(420, 150);
                    Label_8.SetSize(110, 36);
                    Label_8.Anchors = Anchors.None;
                    Label_8.Visible = true;

                    Label_9.SetPosition(420, 390);
                    Label_9.SetSize(110, 36);
                    Label_9.Anchors = Anchors.None;
                    Label_9.Visible = true;

                    Label_10.SetPosition(420, 270);
                    Label_10.SetSize(110, 36);
                    Label_10.Anchors = Anchors.None;
                    Label_10.Visible = true;

                    Label_11.SetPosition(420, 330);
                    Label_11.SetSize(110, 36);
                    Label_11.Anchors = Anchors.None;
                    Label_11.Visible = true;

                    Label_12.SetPosition(420, 210);
                    Label_12.SetSize(110, 36);
                    Label_12.Anchors = Anchors.None;
                    Label_12.Visible = true;

                    Button_1.SetPosition(549, 80);
                    Button_1.SetSize(213, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(549, 140);
                    Button_2.SetSize(213, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(549, 200);
                    Button_3.SetSize(213, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(549, 260);
                    Button_4.SetSize(213, 56);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    Button_5.SetPosition(549, 320);
                    Button_5.SetSize(213, 56);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(549, 380);
                    Button_6.SetSize(213, 56);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    ImageBox_1.SetPosition(220, 90);
                    ImageBox_1.SetSize(36, 36);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ImageBox_2.SetPosition(220, 150);
                    ImageBox_2.SetSize(36, 36);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    ImageBox_3.SetPosition(220, 210);
                    ImageBox_3.SetSize(36, 36);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    ImageBox_4.SetPosition(220, 270);
                    ImageBox_4.SetSize(36, 36);
                    ImageBox_4.Anchors = Anchors.None;
                    ImageBox_4.Visible = true;

                    ImageBox_5.SetPosition(220, 330);
                    ImageBox_5.SetSize(36, 36);
                    ImageBox_5.Anchors = Anchors.None;
                    ImageBox_5.Visible = true;

                    ImageBox_6.SetPosition(220, 390);
                    ImageBox_6.SetSize(36, 36);
                    ImageBox_6.Anchors = Anchors.None;
                    ImageBox_6.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            BackButton.Text = "Back";

            Label_1.Text = "X 1,000";

            Label_2.Text = "X 3,000";

            Label_3.Text = "X 50,000";

            Label_4.Text = "X 10,000";

            Label_5.Text = "X 20,000";

            Label_6.Text = "X 5,000";

            Label_7.Text = "$1.00";

            Label_8.Text = "$2.50";

            Label_9.Text = "$25.00";

            Label_10.Text = "$7.50";

            Label_11.Text = "$12.50";

            Label_12.Text = "$4.00";

            Button_1.Text = "Buy";

            Button_2.Text = "Buy";

            Button_3.Text = "Buy";

            Button_4.Text = "Buy";

            Button_5.Text = "Buy";

            Button_6.Text = "Buy";
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
