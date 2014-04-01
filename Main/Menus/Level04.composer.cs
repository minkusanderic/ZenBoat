// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Level04
    {
        Button Button_13;
        Button Button_14;
        Button Button_15;
        Button Button_16;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_13 = new Button();
            Button_13.Name = "Button_13";
            Button_14 = new Button();
            Button_14.Name = "Button_14";
            Button_15 = new Button();
            Button_15.Name = "Button_15";
            Button_16 = new Button();
            Button_16.Name = "Button_16";

            // Level04
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_13);
            this.AddChildLast(Button_14);
            this.AddChildLast(Button_15);
            this.AddChildLast(Button_16);

            // Button_13
            Button_13.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_13.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_14
            Button_14.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_14.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_15
            Button_15.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_15.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_16
            Button_16.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_16.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Button_13.SetPosition(73, 87);
                    Button_13.SetSize(214, 56);
                    Button_13.Anchors = Anchors.None;
                    Button_13.Visible = true;

                    Button_14.SetPosition(73, 87);
                    Button_14.SetSize(214, 56);
                    Button_14.Anchors = Anchors.None;
                    Button_14.Visible = true;

                    Button_15.SetPosition(73, 87);
                    Button_15.SetSize(214, 56);
                    Button_15.Anchors = Anchors.None;
                    Button_15.Visible = true;

                    Button_16.SetPosition(73, 87);
                    Button_16.SetSize(214, 56);
                    Button_16.Anchors = Anchors.None;
                    Button_16.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Button_13.SetPosition(22, 25);
                    Button_13.SetSize(400, 200);
                    Button_13.Anchors = Anchors.None;
                    Button_13.Visible = true;

                    Button_14.SetPosition(523, 25);
                    Button_14.SetSize(400, 200);
                    Button_14.Anchors = Anchors.None;
                    Button_14.Visible = true;

                    Button_15.SetPosition(22, 290);
                    Button_15.SetSize(400, 200);
                    Button_15.Anchors = Anchors.None;
                    Button_15.Visible = true;

                    Button_16.SetPosition(523, 290);
                    Button_16.SetSize(400, 200);
                    Button_16.Anchors = Anchors.None;
                    Button_16.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_13.Text = "13";

            Button_14.Text = "14";

            Button_15.Text = "15";

            Button_16.Text = "16";
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
