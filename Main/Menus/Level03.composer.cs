// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Level03
    {
        Button Button_9;
        Button Button_10;
        Button Button_11;
        Button Button_12;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_9 = new Button();
            Button_9.Name = "Button_9";
            Button_10 = new Button();
            Button_10.Name = "Button_10";
            Button_11 = new Button();
            Button_11.Name = "Button_11";
            Button_12 = new Button();
            Button_12.Name = "Button_12";

            // Level03
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_9);
            this.AddChildLast(Button_10);
            this.AddChildLast(Button_11);
            this.AddChildLast(Button_12);

            // Button_9
            Button_9.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_9.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_10
            Button_10.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_10.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_11
            Button_11.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_11.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_12
            Button_12.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_12.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Button_9.SetPosition(76, 75);
                    Button_9.SetSize(214, 56);
                    Button_9.Anchors = Anchors.None;
                    Button_9.Visible = true;

                    Button_10.SetPosition(76, 75);
                    Button_10.SetSize(214, 56);
                    Button_10.Anchors = Anchors.None;
                    Button_10.Visible = true;

                    Button_11.SetPosition(76, 75);
                    Button_11.SetSize(214, 56);
                    Button_11.Anchors = Anchors.None;
                    Button_11.Visible = true;

                    Button_12.SetPosition(76, 75);
                    Button_12.SetSize(214, 56);
                    Button_12.Anchors = Anchors.None;
                    Button_12.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Button_9.SetPosition(22, 25);
                    Button_9.SetSize(400, 200);
                    Button_9.Anchors = Anchors.None;
                    Button_9.Visible = true;

                    Button_10.SetPosition(523, 25);
                    Button_10.SetSize(400, 200);
                    Button_10.Anchors = Anchors.None;
                    Button_10.Visible = true;

                    Button_11.SetPosition(22, 290);
                    Button_11.SetSize(400, 200);
                    Button_11.Anchors = Anchors.None;
                    Button_11.Visible = true;

                    Button_12.SetPosition(523, 290);
                    Button_12.SetSize(400, 200);
                    Button_12.Anchors = Anchors.None;
                    Button_12.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_9.Text = "9";

            Button_10.Text = "10";

            Button_11.Text = "11";

            Button_12.Text = "12";
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
