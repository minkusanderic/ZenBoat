// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Tier4
    {
        Button button1;
        Label label1;
        Button button2;
        Label label2;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            button1 = new Button();
            button1.Name = "button1";
            label1 = new Label();
            label1.Name = "label1";
            button2 = new Button();
            button2.Name = "button2";
            label2 = new Label();
            label2.Name = "label2";

            // Tier4
            this.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(button1);
            this.AddChildLast(label1);
            this.AddChildLast(button2);
            this.AddChildLast(label2);

            // button1
            button1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button1.Style = ButtonStyle.Custom;
            button1.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/pirate.png"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // label1
            label1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label1.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label1.LineBreak = LineBreak.Character;
            label1.HorizontalAlignment = HorizontalAlignment.Center;
            label1.VerticalAlignment = VerticalAlignment.Top;

            // button2
            button2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            button2.Style = ButtonStyle.Custom;
            button2.CustomImage = new CustomButtonImageSettings()
            {
                BackgroundNormalImage = new ImageAsset("/Application/assets/duckie.PNG"),
                BackgroundPressedImage = null,
                BackgroundDisabledImage = null,
                BackgroundNinePatchMargin = new NinePatchMargin(0, 0, 0, 0),
            };

            // label2
            label2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label2.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label2.LineBreak = LineBreak.Character;
            label2.HorizontalAlignment = HorizontalAlignment.Center;
            label2.VerticalAlignment = VerticalAlignment.Top;

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

                    button1.SetPosition(395, 205);
                    button1.SetSize(214, 56);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    label1.SetPosition(678, 80);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    button2.SetPosition(395, 205);
                    button2.SetSize(214, 56);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    label2.SetPosition(678, 80);
                    label2.SetSize(214, 36);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    break;

                default:
                    this.SetSize(622, 420);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(141, 140);
                    button1.SetSize(155, 111);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    label1.SetPosition(167, 251);
                    label1.SetSize(102, 28);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    button2.SetPosition(326, 140);
                    button2.SetSize(155, 111);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    label2.SetPosition(353, 251);
                    label2.SetSize(102, 28);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            label1.Text = "10,000";

            label2.Text = "10,000";
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
