// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Level02
    {
        Button Button_5;
        Button Button_6;
        Button Button_7;
        Button Button_8;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_5 = new Button();
            Button_5.Name = "Button_5";
            Button_6 = new Button();
            Button_6.Name = "Button_6";
            Button_7 = new Button();
            Button_7.Name = "Button_7";
            Button_8 = new Button();
            Button_8.Name = "Button_8";

            // Level02
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_5);
            this.AddChildLast(Button_6);
            this.AddChildLast(Button_7);
            this.AddChildLast(Button_8);

            // Button_5
            Button_5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_6
            Button_6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_7
            Button_7.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_7.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_8
            Button_8.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_8.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Button_5.SetPosition(97, 82);
                    Button_5.SetSize(214, 56);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(97, 82);
                    Button_6.SetSize(214, 56);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    Button_7.SetPosition(97, 82);
                    Button_7.SetSize(214, 56);
                    Button_7.Anchors = Anchors.None;
                    Button_7.Visible = true;

                    Button_8.SetPosition(97, 82);
                    Button_8.SetSize(214, 56);
                    Button_8.Anchors = Anchors.None;
                    Button_8.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Button_5.SetPosition(22, 25);
                    Button_5.SetSize(400, 200);
                    Button_5.Anchors = Anchors.None;
                    Button_5.Visible = true;

                    Button_6.SetPosition(523, 25);
                    Button_6.SetSize(400, 200);
                    Button_6.Anchors = Anchors.None;
                    Button_6.Visible = true;

                    Button_7.SetPosition(22, 290);
                    Button_7.SetSize(400, 200);
                    Button_7.Anchors = Anchors.None;
                    Button_7.Visible = true;

                    Button_8.SetPosition(523, 290);
                    Button_8.SetSize(400, 200);
                    Button_8.Anchors = Anchors.None;
                    Button_8.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_5.Text = "5";

            Button_6.Text = "6";

            Button_7.Text = "7";

            Button_8.Text = "8";
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
