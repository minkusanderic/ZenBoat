﻿// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Tier1
    {
        ImageBox ImageBox_1;
        ImageBox ImageBox_2;
        ImageBox ImageBox_3;
        ImageBox ImageBox_4;
        ImageBox ImageBox_5;
        ImageBox ImageBox_6;
        ImageBox ImageBox_7;
        ImageBox ImageBox_8;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        Button button8;
        ImageBox ImageBox_9;
        ImageBox ImageBox_10;
        ImageBox ImageBox_11;
        ImageBox ImageBox_12;
        ImageBox ImageBox_13;
        ImageBox ImageBox_14;
        ImageBox ImageBox_15;
        ImageBox ImageBox_16;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        Label label5;
        Label label6;
        Label label7;
        Label label8;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
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
            ImageBox_7 = new ImageBox();
            ImageBox_7.Name = "ImageBox_7";
            ImageBox_8 = new ImageBox();
            ImageBox_8.Name = "ImageBox_8";
            button1 = new Button();
            button1.Name = "button1";
            button2 = new Button();
            button2.Name = "button2";
            button3 = new Button();
            button3.Name = "button3";
            button4 = new Button();
            button4.Name = "button4";
            button5 = new Button();
            button5.Name = "button5";
            button6 = new Button();
            button6.Name = "button6";
            button7 = new Button();
            button7.Name = "button7";
            button8 = new Button();
            button8.Name = "button8";
            ImageBox_9 = new ImageBox();
            ImageBox_9.Name = "ImageBox_9";
            ImageBox_10 = new ImageBox();
            ImageBox_10.Name = "ImageBox_10";
            ImageBox_11 = new ImageBox();
            ImageBox_11.Name = "ImageBox_11";
            ImageBox_12 = new ImageBox();
            ImageBox_12.Name = "ImageBox_12";
            ImageBox_13 = new ImageBox();
            ImageBox_13.Name = "ImageBox_13";
            ImageBox_14 = new ImageBox();
            ImageBox_14.Name = "ImageBox_14";
            ImageBox_15 = new ImageBox();
            ImageBox_15.Name = "ImageBox_15";
            ImageBox_16 = new ImageBox();
            ImageBox_16.Name = "ImageBox_16";
            label1 = new Label();
            label1.Name = "label1";
            label2 = new Label();
            label2.Name = "label2";
            label3 = new Label();
            label3.Name = "label3";
            label4 = new Label();
            label4.Name = "label4";
            label5 = new Label();
            label5.Name = "label5";
            label6 = new Label();
            label6.Name = "label6";
            label7 = new Label();
            label7.Name = "label7";
            label8 = new Label();
            label8.Name = "label8";

            // Tier1
            this.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(ImageBox_1);
            this.AddChildLast(ImageBox_2);
            this.AddChildLast(ImageBox_3);
            this.AddChildLast(ImageBox_4);
            this.AddChildLast(ImageBox_5);
            this.AddChildLast(ImageBox_6);
            this.AddChildLast(ImageBox_7);
            this.AddChildLast(ImageBox_8);
            this.AddChildLast(button1);
            this.AddChildLast(button2);
            this.AddChildLast(button3);
            this.AddChildLast(button4);
            this.AddChildLast(button5);
            this.AddChildLast(button6);
            this.AddChildLast(button7);
            this.AddChildLast(button8);
            this.AddChildLast(ImageBox_9);
            this.AddChildLast(ImageBox_10);
            this.AddChildLast(ImageBox_11);
            this.AddChildLast(ImageBox_12);
            this.AddChildLast(ImageBox_13);
            this.AddChildLast(ImageBox_14);
            this.AddChildLast(ImageBox_15);
            this.AddChildLast(ImageBox_16);
            this.AddChildLast(label1);
            this.AddChildLast(label2);
            this.AddChildLast(label3);
            this.AddChildLast(label4);
            this.AddChildLast(label5);
            this.AddChildLast(label6);
            this.AddChildLast(label7);
            this.AddChildLast(label8);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_2
            ImageBox_2.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_3
            ImageBox_3.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_4
            ImageBox_4.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_5
            ImageBox_5.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_6
            ImageBox_6.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_7
            ImageBox_7.Image = new ImageAsset("/Application/assets/halo.png");

            // ImageBox_8
            ImageBox_8.Image = new ImageAsset("/Application/assets/halo.png");

            // button1
            button1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button1.Style = ButtonStyle.Custom;
            button1.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Black.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button2
            button2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button2.Style = ButtonStyle.Custom;
            button2.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Blue.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button3
            button3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button3.Style = ButtonStyle.Custom;
            button3.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Green.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button4
            button4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button4.Style = ButtonStyle.Custom;
            button4.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Pink.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button5
            button5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button5.Style = ButtonStyle.Custom;
            button5.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Red.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button6
            button6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button6.Style = ButtonStyle.Custom;
            button6.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Teal.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button7
            button7.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button7.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button7.Style = ButtonStyle.Custom;
            button7.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/White.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // button8
            button8.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button8.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button8.Style = ButtonStyle.Custom;
            button8.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/Yellow.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // ImageBox_9
            ImageBox_9.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_10
            ImageBox_10.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_11
            ImageBox_11.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_12
            ImageBox_12.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_13
            ImageBox_13.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_14
            ImageBox_14.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_15
            ImageBox_15.Image = new ImageAsset("/Application/assets/score.png");

            // ImageBox_16
            ImageBox_16.Image = new ImageAsset("/Application/assets/score.png");

            // label1
            label1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label1.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label1.LineBreak = LineBreak.Character;
            label1.HorizontalAlignment = HorizontalAlignment.Center;
            label1.VerticalAlignment = VerticalAlignment.Top;

            // label2
            label2.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label2.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label2.LineBreak = LineBreak.Character;
            label2.HorizontalAlignment = HorizontalAlignment.Center;
            label2.VerticalAlignment = VerticalAlignment.Top;

            // label3
            label3.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label3.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label3.LineBreak = LineBreak.Character;
            label3.HorizontalAlignment = HorizontalAlignment.Center;
            label3.VerticalAlignment = VerticalAlignment.Top;

            // label4
            label4.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label4.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label4.LineBreak = LineBreak.Character;
            label4.HorizontalAlignment = HorizontalAlignment.Center;
            label4.VerticalAlignment = VerticalAlignment.Top;

            // label5
            label5.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label5.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label5.LineBreak = LineBreak.Character;
            label5.HorizontalAlignment = HorizontalAlignment.Center;
            label5.VerticalAlignment = VerticalAlignment.Top;

            // label6
            label6.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label6.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label6.LineBreak = LineBreak.Character;
            label6.HorizontalAlignment = HorizontalAlignment.Center;
            label6.VerticalAlignment = VerticalAlignment.Top;

            // label7
            label7.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label7.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label7.LineBreak = LineBreak.Character;
            label7.HorizontalAlignment = HorizontalAlignment.Center;
            label7.VerticalAlignment = VerticalAlignment.Top;

            // label8
            label8.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            label8.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label8.LineBreak = LineBreak.Character;
            label8.HorizontalAlignment = HorizontalAlignment.Center;
            label8.VerticalAlignment = VerticalAlignment.Top;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(420, 960);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(3, 53);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ImageBox_2.SetPosition(3, 53);
                    ImageBox_2.SetSize(200, 200);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    ImageBox_3.SetPosition(3, 53);
                    ImageBox_3.SetSize(200, 200);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    ImageBox_4.SetPosition(3, 53);
                    ImageBox_4.SetSize(200, 200);
                    ImageBox_4.Anchors = Anchors.None;
                    ImageBox_4.Visible = true;

                    ImageBox_5.SetPosition(3, 53);
                    ImageBox_5.SetSize(200, 200);
                    ImageBox_5.Anchors = Anchors.None;
                    ImageBox_5.Visible = true;

                    ImageBox_6.SetPosition(3, 53);
                    ImageBox_6.SetSize(200, 200);
                    ImageBox_6.Anchors = Anchors.None;
                    ImageBox_6.Visible = true;

                    ImageBox_7.SetPosition(3, 53);
                    ImageBox_7.SetSize(200, 200);
                    ImageBox_7.Anchors = Anchors.None;
                    ImageBox_7.Visible = true;

                    ImageBox_8.SetPosition(3, 53);
                    ImageBox_8.SetSize(200, 200);
                    ImageBox_8.Anchors = Anchors.None;
                    ImageBox_8.Visible = true;

                    button1.SetPosition(395, 205);
                    button1.SetSize(214, 56);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(395, 205);
                    button2.SetSize(214, 56);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(395, 205);
                    button3.SetSize(214, 56);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(395, 205);
                    button4.SetSize(214, 56);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(395, 205);
                    button5.SetSize(214, 56);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(395, 205);
                    button6.SetSize(214, 56);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    button7.SetPosition(395, 205);
                    button7.SetSize(214, 56);
                    button7.Anchors = Anchors.None;
                    button7.Visible = true;

                    button8.SetPosition(395, 205);
                    button8.SetSize(214, 56);
                    button8.Anchors = Anchors.None;
                    button8.Visible = true;

                    ImageBox_9.SetPosition(546, 0);
                    ImageBox_9.SetSize(200, 200);
                    ImageBox_9.Anchors = Anchors.None;
                    ImageBox_9.Visible = true;

                    ImageBox_10.SetPosition(546, 0);
                    ImageBox_10.SetSize(200, 200);
                    ImageBox_10.Anchors = Anchors.None;
                    ImageBox_10.Visible = true;

                    ImageBox_11.SetPosition(546, 0);
                    ImageBox_11.SetSize(200, 200);
                    ImageBox_11.Anchors = Anchors.None;
                    ImageBox_11.Visible = true;

                    ImageBox_12.SetPosition(546, 0);
                    ImageBox_12.SetSize(200, 200);
                    ImageBox_12.Anchors = Anchors.None;
                    ImageBox_12.Visible = true;

                    ImageBox_13.SetPosition(546, 0);
                    ImageBox_13.SetSize(200, 200);
                    ImageBox_13.Anchors = Anchors.None;
                    ImageBox_13.Visible = true;

                    ImageBox_14.SetPosition(546, 0);
                    ImageBox_14.SetSize(200, 200);
                    ImageBox_14.Anchors = Anchors.None;
                    ImageBox_14.Visible = true;

                    ImageBox_15.SetPosition(546, 0);
                    ImageBox_15.SetSize(200, 200);
                    ImageBox_15.Anchors = Anchors.None;
                    ImageBox_15.Visible = true;

                    ImageBox_16.SetPosition(546, 0);
                    ImageBox_16.SetSize(200, 200);
                    ImageBox_16.Anchors = Anchors.None;
                    ImageBox_16.Visible = true;

                    label1.SetPosition(678, 80);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(678, 80);
                    label2.SetSize(214, 36);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(678, 80);
                    label3.SetSize(214, 36);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(678, 80);
                    label4.SetSize(214, 36);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(678, 80);
                    label5.SetSize(214, 36);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(678, 80);
                    label6.SetSize(214, 36);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    label7.SetPosition(678, 80);
                    label7.SetSize(214, 36);
                    label7.Anchors = Anchors.None;
                    label7.Visible = true;

                    label8.SetPosition(678, 80);
                    label8.SetSize(214, 36);
                    label8.Anchors = Anchors.None;
                    label8.Visible = true;

                    break;

                default:
                    this.SetSize(622, 420);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(3, 71);
                    ImageBox_1.SetSize(155, 94);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    ImageBox_2.SetPosition(158, 71);
                    ImageBox_2.SetSize(155, 94);
                    ImageBox_2.Anchors = Anchors.None;
                    ImageBox_2.Visible = true;

                    ImageBox_3.SetPosition(313, 71);
                    ImageBox_3.SetSize(155, 94);
                    ImageBox_3.Anchors = Anchors.None;
                    ImageBox_3.Visible = true;

                    ImageBox_4.SetPosition(468, 71);
                    ImageBox_4.SetSize(155, 94);
                    ImageBox_4.Anchors = Anchors.None;
                    ImageBox_4.Visible = true;

                    ImageBox_5.SetPosition(3, 226);
                    ImageBox_5.SetSize(155, 94);
                    ImageBox_5.Anchors = Anchors.None;
                    ImageBox_5.Visible = true;

                    ImageBox_6.SetPosition(158, 226);
                    ImageBox_6.SetSize(155, 94);
                    ImageBox_6.Anchors = Anchors.None;
                    ImageBox_6.Visible = true;

                    ImageBox_7.SetPosition(313, 226);
                    ImageBox_7.SetSize(155, 94);
                    ImageBox_7.Anchors = Anchors.None;
                    ImageBox_7.Visible = true;

                    ImageBox_8.SetPosition(468, 226);
                    ImageBox_8.SetSize(155, 94);
                    ImageBox_8.Anchors = Anchors.None;
                    ImageBox_8.Visible = true;

                    button1.SetPosition(3, 62);
                    button1.SetSize(155, 111);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(158, 62);
                    button2.SetSize(155, 111);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(310, 63);
                    button3.SetSize(155, 111);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(463, 62);
                    button4.SetSize(155, 111);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(3, 218);
                    button5.SetSize(155, 111);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(158, 218);
                    button6.SetSize(155, 111);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    button7.SetPosition(310, 217);
                    button7.SetSize(155, 111);
                    button7.Anchors = Anchors.None;
                    button7.Visible = true;

                    button8.SetPosition(463, 218);
                    button8.SetSize(155, 111);
                    button8.Anchors = Anchors.None;
                    button8.Visible = true;

                    ImageBox_9.SetPosition(16, 157);
                    ImageBox_9.SetSize(142, 57);
                    ImageBox_9.Anchors = Anchors.None;
                    ImageBox_9.Visible = true;

                    ImageBox_10.SetPosition(172, 156);
                    ImageBox_10.SetSize(142, 57);
                    ImageBox_10.Anchors = Anchors.None;
                    ImageBox_10.Visible = true;

                    ImageBox_11.SetPosition(324, 155);
                    ImageBox_11.SetSize(142, 57);
                    ImageBox_11.Anchors = Anchors.None;
                    ImageBox_11.Visible = true;

                    ImageBox_12.SetPosition(480, 156);
                    ImageBox_12.SetSize(142, 57);
                    ImageBox_12.Anchors = Anchors.None;
                    ImageBox_12.Visible = true;

                    ImageBox_13.SetPosition(19, 312);
                    ImageBox_13.SetSize(142, 57);
                    ImageBox_13.Anchors = Anchors.None;
                    ImageBox_13.Visible = true;

                    ImageBox_14.SetPosition(174, 312);
                    ImageBox_14.SetSize(142, 57);
                    ImageBox_14.Anchors = Anchors.None;
                    ImageBox_14.Visible = true;

                    ImageBox_15.SetPosition(325, 312);
                    ImageBox_15.SetSize(142, 57);
                    ImageBox_15.Anchors = Anchors.None;
                    ImageBox_15.Visible = true;

                    ImageBox_16.SetPosition(480, 313);
                    ImageBox_16.SetSize(142, 57);
                    ImageBox_16.Anchors = Anchors.None;
                    ImageBox_16.Visible = true;

                    label1.SetPosition(35, 173);
                    label1.SetSize(90, 28);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(190, 173);
                    label2.SetSize(90, 28);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(343, 173);
                    label3.SetSize(90, 28);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(496, 173);
                    label4.SetSize(90, 28);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(35, 329);
                    label5.SetSize(90, 28);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(190, 329);
                    label6.SetSize(90, 28);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    label7.SetPosition(343, 328);
                    label7.SetSize(90, 28);
                    label7.Anchors = Anchors.None;
                    label7.Visible = true;

                    label8.SetPosition(496, 329);
                    label8.SetSize(90, 28);
                    label8.Anchors = Anchors.None;
                    label8.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            label1.Text = "500";

            label2.Text = "500";

            label3.Text = "500";

            label4.Text = "500";

            label5.Text = "500";

            label6.Text = "500";

            label7.Text = "500";

            label8.Text = "500";
        }

        public void InitializeDefaultEffect()
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        public void StartDefaultEffect()
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
