﻿// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class End6
    {
        ImageBox ImageBox_1;
        Button continueButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            continueButton = new Button();
            continueButton.Name = "continueButton";

            // End6
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(ImageBox_1);
            this.AddChildLast(continueButton);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/end/stry12.png");

            // continueButton
            continueButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            continueButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            continueButton.Style = ButtonStyle.Custom;
            continueButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign144.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    continueButton.SetPosition(652, 104);
                    continueButton.SetSize(214, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    continueButton.SetPosition(688, 100);
                    continueButton.SetSize(159, 76);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            continueButton.Text = "Continue";
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
