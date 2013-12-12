// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class StartMenu
    {
        Panel Panel_1;
        ImageBox titleImage;
        Button startButton;
        Button quitButton;

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
            startButton = new Button();
            startButton.Name = "startButton";
            quitButton = new Button();
            quitButton.Name = "quitButton";

            // StartMenu
            this.RootWidget.AddChildLast(Panel_1);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(titleImage);
            Panel_1.AddChildLast(startButton);
            Panel_1.AddChildLast(quitButton);

            // titleImage
            titleImage.Image = new ImageAsset("/Application/Assets/title.png");

            // startButton
            startButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            startButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // quitButton
            quitButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            quitButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    startButton.SetPosition(361, 277);
                    startButton.SetSize(214, 56);
                    startButton.Anchors = Anchors.None;
                    startButton.Visible = true;

                    quitButton.SetPosition(373, 421);
                    quitButton.SetSize(214, 56);
                    quitButton.Anchors = Anchors.None;
                    quitButton.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    titleImage.SetPosition(112, 0);
                    titleImage.SetSize(735, 333);
                    titleImage.Anchors = Anchors.None;
                    titleImage.Visible = true;

                    startButton.SetPosition(373, 299);
                    startButton.SetSize(214, 56);
                    startButton.Anchors = Anchors.None;
                    startButton.Visible = true;

                    quitButton.SetPosition(373, 421);
                    quitButton.SetSize(214, 56);
                    quitButton.Anchors = Anchors.None;
                    quitButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            startButton.Text = "Start";

            quitButton.Text = "Quit";
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
