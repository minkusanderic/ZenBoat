﻿// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Story5
    {
        ImageBox story5;
        Button playButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            story5 = new ImageBox();
            story5.Name = "story5";
            playButton = new Button();
            playButton.Name = "playButton";

            // Story5
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(story5);
            this.AddChildLast(playButton);

            // story5
            story5.Image = new ImageAsset("/Application/assets/open/stry5.png");

            // playButton
            playButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            playButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            playButton.Style = ButtonStyle.Custom;
            playButton.CustomImage = new CustomButtonImageSettings()
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
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    story5.SetPosition(0, 0);
                    story5.SetSize(200, 200);
                    story5.Anchors = Anchors.None;
                    story5.Visible = true;

                    playButton.SetPosition(558, 355);
                    playButton.SetSize(214, 56);
                    playButton.Anchors = Anchors.None;
                    playButton.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    story5.SetPosition(0, 0);
                    story5.SetSize(960, 544);
                    story5.Anchors = Anchors.None;
                    story5.Visible = true;

                    playButton.SetPosition(667, 349);
                    playButton.SetSize(160, 77);
                    playButton.Anchors = Anchors.None;
                    playButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
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
