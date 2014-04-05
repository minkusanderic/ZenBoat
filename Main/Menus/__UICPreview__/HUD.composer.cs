// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class HUD
    {
        Button Button_1;
        Label Label_1;
        ImageBox ImageBox_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";

            // HUD
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Label_1);
            this.RootWidget.AddChildLast(ImageBox_1);

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // ImageBox_1
            ImageBox_1.Image = null;
            ImageBox_1.ImageScaleType = ImageScaleType.Center;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Button_1.SetPosition(0, 0);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Label_1.SetPosition(746, 0);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    ImageBox_1.SetPosition(546, 0);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Button_1.SetPosition(0, 0);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Label_1.SetPosition(746, 0);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    ImageBox_1.SetPosition(702, 0);
                    ImageBox_1.SetSize(43, 36);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "Pause";

            Label_1.Text = "Cranes:";
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
