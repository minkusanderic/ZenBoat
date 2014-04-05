// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Pause
    {
        Button continueButton;
        Label pauseLabel;
        Button Button_1;
        Button Button_2;
        Button Button_3;

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
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Button_3 = new Button();
            Button_3.Name = "Button_3";

            // Pause
            this.BackgroundFilterColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 191f / 255f);
            this.AddChildLast(continueButton);
            this.AddChildLast(pauseLabel);
            this.AddChildLast(Button_1);
            this.AddChildLast(Button_2);
            this.AddChildLast(Button_3);
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

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_3
            Button_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Button_1.SetPosition(128, 138);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(128, 138);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(128, 138);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

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

                    Button_1.SetPosition(143, 257);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(143, 330);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(143, 403);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            continueButton.Text = "Continue";

            pauseLabel.Text = "Paused";

            Button_1.Text = "Restart";

            Button_2.Text = "Level Select";

            Button_3.Text = "Main Menu";
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
