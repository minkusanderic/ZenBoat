// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Pause
    {
        Button continueButton;
        Label pauseLabel;
        Button restartButton;
        Button levelButton;
        Button mainmenuButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            continueButton = new Button();
            continueButton.Name = "continueButton";
            pauseLabel = new Label();
            pauseLabel.Name = "pauseLabel";
            restartButton = new Button();
            restartButton.Name = "restartButton";
            levelButton = new Button();
            levelButton.Name = "levelButton";
            mainmenuButton = new Button();
            mainmenuButton.Name = "mainmenuButton";

            // Pause
            this.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 191f / 255f);
            this.AddChildLast(continueButton);
            this.AddChildLast(pauseLabel);
            this.AddChildLast(restartButton);
            this.AddChildLast(levelButton);
            this.AddChildLast(mainmenuButton);
            this.ShowEffect = new FadeInEffect()
            {
            };
            this.HideEffect = new TiltDropEffect();

            // continueButton
            continueButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            continueButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // pauseLabel
            pauseLabel.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            pauseLabel.Font = new UIFont(FontAlias.System, 72, FontStyle.Regular);
            pauseLabel.LineBreak = LineBreak.Character;
            pauseLabel.HorizontalAlignment = HorizontalAlignment.Center;

            // restartButton
            restartButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            restartButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // levelButton
            levelButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            levelButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // mainmenuButton
            mainmenuButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            mainmenuButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetPosition(0, 0);
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    continueButton.SetPosition(128, 138);
                    continueButton.SetSize(214, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    pauseLabel.SetPosition(250, 138);
                    pauseLabel.SetSize(214, 36);
                    pauseLabel.Anchors = Anchors.None;
                    pauseLabel.Visible = true;

                    restartButton.SetPosition(128, 138);
                    restartButton.SetSize(214, 56);
                    restartButton.Anchors = Anchors.None;
                    restartButton.Visible = true;

                    levelButton.SetPosition(128, 138);
                    levelButton.SetSize(214, 56);
                    levelButton.Anchors = Anchors.None;
                    levelButton.Visible = true;

                    mainmenuButton.SetPosition(128, 138);
                    mainmenuButton.SetSize(214, 56);
                    mainmenuButton.Anchors = Anchors.None;
                    mainmenuButton.Visible = true;

                    break;

                default:
                    this.SetPosition(0, 0);
                    this.SetSize(500, 500);
                    this.Anchors = Anchors.None;

                    continueButton.SetPosition(143, 183);
                    continueButton.SetSize(214, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    pauseLabel.SetPosition(122, 40);
                    pauseLabel.SetSize(255, 97);
                    pauseLabel.Anchors = Anchors.None;
                    pauseLabel.Visible = true;

                    restartButton.SetPosition(143, 257);
                    restartButton.SetSize(214, 56);
                    restartButton.Anchors = Anchors.None;
                    restartButton.Visible = true;

                    levelButton.SetPosition(143, 330);
                    levelButton.SetSize(214, 56);
                    levelButton.Anchors = Anchors.None;
                    levelButton.Visible = true;

                    mainmenuButton.SetPosition(143, 403);
                    mainmenuButton.SetSize(214, 56);
                    mainmenuButton.Anchors = Anchors.None;
                    mainmenuButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            continueButton.Text = "Continue";

            pauseLabel.Text = "Paused";

            restartButton.Text = "Restart";

            levelButton.Text = "Level Select";

            mainmenuButton.Text = "Main Menu";
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
