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
            this.BackgroundStyle = DialogBackgroundStyle.Custom;
            this.CustomBackgroundImage = new ImageAsset("/Application/assets/grassBack.png");
            this.CustomBackgroundNinePatchMargin = new NinePatchMargin(34, 34, 34, 34);
            this.CustomBackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 0f / 255f);
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
            continueButton.Style = ButtonStyle.Custom;
            continueButton.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/sign214.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(42, 27, 42, 27),
            };

            // pauseLabel
            pauseLabel.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            pauseLabel.Font = new UIFont(FontAlias.System, 72, FontStyle.Regular);
            pauseLabel.LineBreak = LineBreak.Character;
            pauseLabel.HorizontalAlignment = HorizontalAlignment.Center;

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
                    this.SetSize(400, 450);
                    this.Anchors = Anchors.None;

                    continueButton.SetPosition(93, 157);
                    continueButton.SetSize(214, 56);
                    continueButton.Anchors = Anchors.None;
                    continueButton.Visible = true;

                    pauseLabel.SetPosition(72, 13);
                    pauseLabel.SetSize(255, 97);
                    pauseLabel.Anchors = Anchors.None;
                    pauseLabel.Visible = true;

                    Button_1.SetPosition(93, 230);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(93, 304);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(93, 377);
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
