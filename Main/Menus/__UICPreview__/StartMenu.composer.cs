// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class StartMenu
    {
        Panel Panel_1;
        ImageBox titleImage;
        Button playButton;
        Button levelButton;
        Button storeButton;
        Button creditButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
            titleImage = new ImageBox();
            titleImage.Name = "titleImage";
            playButton = new Button();
            playButton.Name = "playButton";
            levelButton = new Button();
            levelButton.Name = "levelButton";
            storeButton = new Button();
            storeButton.Name = "storeButton";
            creditButton = new Button();
            creditButton.Name = "creditButton";

            // StartMenu
            this.RootWidget.AddChildLast(Panel_1);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(titleImage);
            Panel_1.AddChildLast(playButton);
            Panel_1.AddChildLast(levelButton);
            Panel_1.AddChildLast(storeButton);
            Panel_1.AddChildLast(creditButton);

            // titleImage
            titleImage.Image = new ImageAsset("/Application/assets/title.png");

            // playButton
            playButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            playButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            playButton.Style = ButtonStyle.Custom;
            playButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign144.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // levelButton
            levelButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            levelButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            levelButton.Style = ButtonStyle.Custom;
            levelButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign144.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // storeButton
            storeButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            storeButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            storeButton.Style = ButtonStyle.Custom;
            storeButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign144.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // creditButton
            creditButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            creditButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            creditButton.Style = ButtonStyle.Custom;
            creditButton.CustomImage = new CustomButtonImageSettings()
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
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Panel_1.SetPosition(522, 236);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    titleImage.SetPosition(366, 20);
                    titleImage.SetSize(200, 200);
                    titleImage.Anchors = Anchors.None;
                    titleImage.Visible = true;

                    playButton.SetPosition(361, 277);
                    playButton.SetSize(214, 56);
                    playButton.Anchors = Anchors.None;
                    playButton.Visible = true;

                    levelButton.SetPosition(337, 172);
                    levelButton.SetSize(214, 56);
                    levelButton.Anchors = Anchors.None;
                    levelButton.Visible = true;

                    storeButton.SetPosition(363, 217);
                    storeButton.SetSize(214, 56);
                    storeButton.Anchors = Anchors.None;
                    storeButton.Visible = true;

                    creditButton.SetPosition(495, 365);
                    creditButton.SetSize(214, 56);
                    creditButton.Anchors = Anchors.None;
                    creditButton.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    titleImage.SetPosition(0, 0);
                    titleImage.SetSize(959, 544);
                    titleImage.Anchors = Anchors.None;
                    titleImage.Visible = true;

                    playButton.SetPosition(63, 306);
                    playButton.SetSize(144, 66);
                    playButton.Anchors = Anchors.None;
                    playButton.Visible = true;

                    levelButton.SetPosition(220, 306);
                    levelButton.SetSize(144, 66);
                    levelButton.Anchors = Anchors.None;
                    levelButton.Visible = true;

                    storeButton.SetPosition(63, 393);
                    storeButton.SetSize(144, 66);
                    storeButton.Anchors = Anchors.None;
                    storeButton.Visible = true;

                    creditButton.SetPosition(220, 393);
                    creditButton.SetSize(144, 66);
                    creditButton.Anchors = Anchors.None;
                    creditButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            playButton.Text = "Play";

            levelButton.Text = "Levels";

            storeButton.Text = "Store";

            creditButton.Text = "Credits";
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
