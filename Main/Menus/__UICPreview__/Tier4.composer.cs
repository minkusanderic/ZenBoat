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

            // Tier4
            this.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(button1);
            this.AddChildLast(label1);

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

                    break;

                default:
                    this.SetSize(622, 420);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(233, 140);
                    button1.SetSize(155, 111);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    label1.SetPosition(265, 251);
                    label1.SetSize(90, 28);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            label1.Text = "10,000";
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
