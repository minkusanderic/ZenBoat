// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Level01
    {
        Button Button_1;
        Button Button_2;
        Button Button_3;
        Button Button_4;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Button_3 = new Button();
            Button_3.Name = "Button_3";
            Button_4 = new Button();
            Button_4.Name = "Button_4";

            // Level01
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_1);
            this.AddChildLast(Button_2);
            this.AddChildLast(Button_3);
            this.AddChildLast(Button_4);

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_3
            Button_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_4
            Button_4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    Button_1.SetPosition(97, 82);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(97, 82);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(97, 82);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(97, 82);
                    Button_4.SetSize(214, 56);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Button_1.SetPosition(22, 25);
                    Button_1.SetSize(400, 200);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(523, 25);
                    Button_2.SetSize(400, 200);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(22, 290);
                    Button_3.SetSize(400, 200);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(523, 290);
                    Button_4.SetSize(400, 200);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "1";

            Button_2.Text = "2";

            Button_3.Text = "3";

            Button_4.Text = "4";
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
