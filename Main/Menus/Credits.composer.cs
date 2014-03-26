// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Credits
    {
        Panel Panel_1;
        ImageBox ImageBox_1;
        Button continueButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            continueButton = new Button();
            continueButton.Name = "continueButton";

            // Credits
            this.RootWidget.AddChildLast(Panel_1);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(ImageBox_1);
            Panel_1.AddChildLast(continueButton);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/credits.png");

            // continueButton
            continueButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            continueButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            continueButton.Style = ButtonStyle.Custom;
            continueButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = null,
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
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Panel_1.SetPosition(683, 163);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    ImageBox_1.SetPosition(192, 64);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    continueButton.SetPosition(696, 425);
                    continueButton.SetSize(214, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    ImageBox_1.SetPosition(0, -6);
                    ImageBox_1.SetSize(960, 550);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    continueButton.SetPosition(641, 415);
                    continueButton.SetSize(155, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
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
