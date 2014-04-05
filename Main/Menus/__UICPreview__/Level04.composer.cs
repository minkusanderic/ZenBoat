// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Level04
    {
        Button Button_1;
        Button Button_2;
        Button Button_3;
        Button Button_4;
        ImageBox ImageBox_4_2;
        ImageBox ImageBox_4_3;
        ImageBox ImageBox_4_1;
        ImageBox ImageBox_3_2;
        ImageBox ImageBox_3_3;
        ImageBox ImageBox_2_1;
        ImageBox ImageBox_2_2;
        ImageBox ImageBox_2_3;
        ImageBox ImageBox_3_1;
        ImageBox ImageBox_1_1;
        ImageBox ImageBox_1_2;
        ImageBox ImageBox_1_3;

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
            ImageBox_4_2 = new ImageBox();
            ImageBox_4_2.Name = "ImageBox_4_2";
            ImageBox_4_3 = new ImageBox();
            ImageBox_4_3.Name = "ImageBox_4_3";
            ImageBox_4_1 = new ImageBox();
            ImageBox_4_1.Name = "ImageBox_4_1";
            ImageBox_3_2 = new ImageBox();
            ImageBox_3_2.Name = "ImageBox_3_2";
            ImageBox_3_3 = new ImageBox();
            ImageBox_3_3.Name = "ImageBox_3_3";
            ImageBox_2_1 = new ImageBox();
            ImageBox_2_1.Name = "ImageBox_2_1";
            ImageBox_2_2 = new ImageBox();
            ImageBox_2_2.Name = "ImageBox_2_2";
            ImageBox_2_3 = new ImageBox();
            ImageBox_2_3.Name = "ImageBox_2_3";
            ImageBox_3_1 = new ImageBox();
            ImageBox_3_1.Name = "ImageBox_3_1";
            ImageBox_1_1 = new ImageBox();
            ImageBox_1_1.Name = "ImageBox_1_1";
            ImageBox_1_2 = new ImageBox();
            ImageBox_1_2.Name = "ImageBox_1_2";
            ImageBox_1_3 = new ImageBox();
            ImageBox_1_3.Name = "ImageBox_1_3";

            // Level04
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_1);
            this.AddChildLast(Button_2);
            this.AddChildLast(Button_3);
            this.AddChildLast(Button_4);
            this.AddChildLast(ImageBox_4_2);
            this.AddChildLast(ImageBox_4_3);
            this.AddChildLast(ImageBox_4_1);
            this.AddChildLast(ImageBox_3_2);
            this.AddChildLast(ImageBox_3_3);
            this.AddChildLast(ImageBox_2_1);
            this.AddChildLast(ImageBox_2_2);
            this.AddChildLast(ImageBox_2_3);
            this.AddChildLast(ImageBox_3_1);
            this.AddChildLast(ImageBox_1_1);
            this.AddChildLast(ImageBox_1_2);
            this.AddChildLast(ImageBox_1_3);

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

            // ImageBox_4_2
            ImageBox_4_2.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_4_3
            ImageBox_4_3.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_4_1
            ImageBox_4_1.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_3_2
            ImageBox_3_2.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_3_3
            ImageBox_3_3.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_2_1
            ImageBox_2_1.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_2_2
            ImageBox_2_2.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_2_3
            ImageBox_2_3.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_3_1
            ImageBox_3_1.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_1_1
            ImageBox_1_1.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_1_2
            ImageBox_1_2.Image = new ImageAsset("/Application/assets/star.jpg");

            // ImageBox_1_3
            ImageBox_1_3.Image = new ImageAsset("/Application/assets/star.jpg");

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

                    Button_1.SetPosition(73, 87);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(73, 87);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(73, 87);
                    Button_3.SetSize(214, 56);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(73, 87);
                    Button_4.SetSize(214, 56);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    ImageBox_4_2.SetPosition(260, -56);
                    ImageBox_4_2.SetSize(200, 200);
                    ImageBox_4_2.Anchors = Anchors.None;
                    ImageBox_4_2.Visible = true;

                    ImageBox_4_3.SetPosition(260, -56);
                    ImageBox_4_3.SetSize(200, 200);
                    ImageBox_4_3.Anchors = Anchors.None;
                    ImageBox_4_3.Visible = true;

                    ImageBox_4_1.SetPosition(260, -56);
                    ImageBox_4_1.SetSize(200, 200);
                    ImageBox_4_1.Anchors = Anchors.None;
                    ImageBox_4_1.Visible = true;

                    ImageBox_3_2.SetPosition(260, -56);
                    ImageBox_3_2.SetSize(200, 200);
                    ImageBox_3_2.Anchors = Anchors.None;
                    ImageBox_3_2.Visible = true;

                    ImageBox_3_3.SetPosition(260, -56);
                    ImageBox_3_3.SetSize(200, 200);
                    ImageBox_3_3.Anchors = Anchors.None;
                    ImageBox_3_3.Visible = true;

                    ImageBox_2_1.SetPosition(260, -56);
                    ImageBox_2_1.SetSize(200, 200);
                    ImageBox_2_1.Anchors = Anchors.None;
                    ImageBox_2_1.Visible = true;

                    ImageBox_2_2.SetPosition(260, -56);
                    ImageBox_2_2.SetSize(200, 200);
                    ImageBox_2_2.Anchors = Anchors.None;
                    ImageBox_2_2.Visible = true;

                    ImageBox_2_3.SetPosition(260, -56);
                    ImageBox_2_3.SetSize(200, 200);
                    ImageBox_2_3.Anchors = Anchors.None;
                    ImageBox_2_3.Visible = true;

                    ImageBox_3_1.SetPosition(260, -56);
                    ImageBox_3_1.SetSize(200, 200);
                    ImageBox_3_1.Anchors = Anchors.None;
                    ImageBox_3_1.Visible = true;

                    ImageBox_1_1.SetPosition(260, -56);
                    ImageBox_1_1.SetSize(200, 200);
                    ImageBox_1_1.Anchors = Anchors.None;
                    ImageBox_1_1.Visible = true;

                    ImageBox_1_2.SetPosition(260, -56);
                    ImageBox_1_2.SetSize(200, 200);
                    ImageBox_1_2.Anchors = Anchors.None;
                    ImageBox_1_2.Visible = true;

                    ImageBox_1_3.SetPosition(260, -56);
                    ImageBox_1_3.SetSize(200, 200);
                    ImageBox_1_3.Anchors = Anchors.None;
                    ImageBox_1_3.Visible = true;

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

                    ImageBox_4_2.SetPosition(826, 432);
                    ImageBox_4_2.SetSize(37, 34);
                    ImageBox_4_2.Anchors = Anchors.None;
                    ImageBox_4_2.Visible = true;

                    ImageBox_4_3.SetPosition(863, 432);
                    ImageBox_4_3.SetSize(37, 34);
                    ImageBox_4_3.Anchors = Anchors.None;
                    ImageBox_4_3.Visible = true;

                    ImageBox_4_1.SetPosition(793, 432);
                    ImageBox_4_1.SetSize(37, 34);
                    ImageBox_4_1.Anchors = Anchors.None;
                    ImageBox_4_1.Visible = true;

                    ImageBox_3_2.SetPosition(80, 432);
                    ImageBox_3_2.SetSize(37, 34);
                    ImageBox_3_2.Anchors = Anchors.None;
                    ImageBox_3_2.Visible = true;

                    ImageBox_3_3.SetPosition(113, 432);
                    ImageBox_3_3.SetSize(37, 34);
                    ImageBox_3_3.Anchors = Anchors.None;
                    ImageBox_3_3.Visible = true;

                    ImageBox_2_1.SetPosition(793, 44);
                    ImageBox_2_1.SetSize(37, 34);
                    ImageBox_2_1.Anchors = Anchors.None;
                    ImageBox_2_1.Visible = true;

                    ImageBox_2_2.SetPosition(828, 44);
                    ImageBox_2_2.SetSize(37, 34);
                    ImageBox_2_2.Anchors = Anchors.None;
                    ImageBox_2_2.Visible = true;

                    ImageBox_2_3.SetPosition(863, 44);
                    ImageBox_2_3.SetSize(37, 34);
                    ImageBox_2_3.Anchors = Anchors.None;
                    ImageBox_2_3.Visible = true;

                    ImageBox_3_1.SetPosition(43, 432);
                    ImageBox_3_1.SetSize(37, 34);
                    ImageBox_3_1.Anchors = Anchors.None;
                    ImageBox_3_1.Visible = true;

                    ImageBox_1_1.SetPosition(43, 44);
                    ImageBox_1_1.SetSize(37, 34);
                    ImageBox_1_1.Anchors = Anchors.None;
                    ImageBox_1_1.Visible = true;

                    ImageBox_1_2.SetPosition(76, 44);
                    ImageBox_1_2.SetSize(37, 34);
                    ImageBox_1_2.Anchors = Anchors.None;
                    ImageBox_1_2.Visible = true;

                    ImageBox_1_3.SetPosition(113, 44);
                    ImageBox_1_3.SetSize(37, 34);
                    ImageBox_1_3.Anchors = Anchors.None;
                    ImageBox_1_3.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "013";

            Button_2.Text = "014";

            Button_3.Text = "015";

            Button_4.Text = "016";
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
