// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Level02
    {
        Button Button_1;
        Button Button_2;
        Button Button_3;
        Button Button_4;
        ImageBox ImageBox_1_2;
        ImageBox ImageBox_1_1;
        ImageBox ImageBox_1_3;
        ImageBox ImageBox_3_3;
        ImageBox ImageBox_3_1;
        ImageBox ImageBox_3_2;
        ImageBox ImageBox_2_3;
        ImageBox ImageBox_2_1;
        ImageBox ImageBox_2_2;
        ImageBox ImageBox_4_3;
        ImageBox ImageBox_4_1;
        ImageBox ImageBox_4_2;

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
            ImageBox_1_2 = new ImageBox();
            ImageBox_1_2.Name = "ImageBox_1_2";
            ImageBox_1_1 = new ImageBox();
            ImageBox_1_1.Name = "ImageBox_1_1";
            ImageBox_1_3 = new ImageBox();
            ImageBox_1_3.Name = "ImageBox_1_3";
            ImageBox_3_3 = new ImageBox();
            ImageBox_3_3.Name = "ImageBox_3_3";
            ImageBox_3_1 = new ImageBox();
            ImageBox_3_1.Name = "ImageBox_3_1";
            ImageBox_3_2 = new ImageBox();
            ImageBox_3_2.Name = "ImageBox_3_2";
            ImageBox_2_3 = new ImageBox();
            ImageBox_2_3.Name = "ImageBox_2_3";
            ImageBox_2_1 = new ImageBox();
            ImageBox_2_1.Name = "ImageBox_2_1";
            ImageBox_2_2 = new ImageBox();
            ImageBox_2_2.Name = "ImageBox_2_2";
            ImageBox_4_3 = new ImageBox();
            ImageBox_4_3.Name = "ImageBox_4_3";
            ImageBox_4_1 = new ImageBox();
            ImageBox_4_1.Name = "ImageBox_4_1";
            ImageBox_4_2 = new ImageBox();
            ImageBox_4_2.Name = "ImageBox_4_2";

            // Level02
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_1);
            this.AddChildLast(Button_2);
            this.AddChildLast(Button_3);
            this.AddChildLast(Button_4);
            this.AddChildLast(ImageBox_1_2);
            this.AddChildLast(ImageBox_1_1);
            this.AddChildLast(ImageBox_1_3);
            this.AddChildLast(ImageBox_3_3);
            this.AddChildLast(ImageBox_3_1);
            this.AddChildLast(ImageBox_3_2);
            this.AddChildLast(ImageBox_2_3);
            this.AddChildLast(ImageBox_2_1);
            this.AddChildLast(ImageBox_2_2);
            this.AddChildLast(ImageBox_4_3);
            this.AddChildLast(ImageBox_4_1);
            this.AddChildLast(ImageBox_4_2);

            // Button_1
            Button_1.IconImage = new ImageAsset("/Application/assets/Level Previews/001.jpg");

            // Button_2
            Button_2.IconImage = new ImageAsset("/Application/assets/Level Previews/002.jpg");

            // Button_3
            Button_3.IconImage = new ImageAsset("/Application/assets/Level Previews/003.jpg");

            // Button_4
            Button_4.IconImage = new ImageAsset("/Application/assets/Level Previews/004.jpg");

            // ImageBox_1_2
            ImageBox_1_2.Image = new ImageAsset("/Application/assets/FullStar.png");

            // ImageBox_1_1
            ImageBox_1_1.Image = null;

            // ImageBox_1_3
            ImageBox_1_3.Image = new ImageAsset("/Application/assets/FullStar.png");

            // ImageBox_3_3
            ImageBox_3_3.Image = null;

            // ImageBox_3_1
            ImageBox_3_1.Image = null;

            // ImageBox_3_2
            ImageBox_3_2.Image = null;

            // ImageBox_2_3
            ImageBox_2_3.Image = null;

            // ImageBox_2_1
            ImageBox_2_1.Image = null;

            // ImageBox_2_2
            ImageBox_2_2.Image = null;

            // ImageBox_4_3
            ImageBox_4_3.Image = null;

            // ImageBox_4_1
            ImageBox_4_1.Image = null;

            // ImageBox_4_2
            ImageBox_4_2.Image = null;

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

                    ImageBox_1_2.SetPosition(260, -56);
                    ImageBox_1_2.SetSize(200, 200);
                    ImageBox_1_2.Anchors = Anchors.None;
                    ImageBox_1_2.Visible = true;

                    ImageBox_1_1.SetPosition(260, -56);
                    ImageBox_1_1.SetSize(200, 200);
                    ImageBox_1_1.Anchors = Anchors.None;
                    ImageBox_1_1.Visible = true;

                    ImageBox_1_3.SetPosition(260, -56);
                    ImageBox_1_3.SetSize(200, 200);
                    ImageBox_1_3.Anchors = Anchors.None;
                    ImageBox_1_3.Visible = true;

                    ImageBox_3_3.SetPosition(260, -56);
                    ImageBox_3_3.SetSize(200, 200);
                    ImageBox_3_3.Anchors = Anchors.None;
                    ImageBox_3_3.Visible = true;

                    ImageBox_3_1.SetPosition(260, -56);
                    ImageBox_3_1.SetSize(200, 200);
                    ImageBox_3_1.Anchors = Anchors.None;
                    ImageBox_3_1.Visible = true;

                    ImageBox_3_2.SetPosition(260, -56);
                    ImageBox_3_2.SetSize(200, 200);
                    ImageBox_3_2.Anchors = Anchors.None;
                    ImageBox_3_2.Visible = true;

                    ImageBox_2_3.SetPosition(260, -56);
                    ImageBox_2_3.SetSize(200, 200);
                    ImageBox_2_3.Anchors = Anchors.None;
                    ImageBox_2_3.Visible = true;

                    ImageBox_2_1.SetPosition(260, -56);
                    ImageBox_2_1.SetSize(200, 200);
                    ImageBox_2_1.Anchors = Anchors.None;
                    ImageBox_2_1.Visible = true;

                    ImageBox_2_2.SetPosition(260, -56);
                    ImageBox_2_2.SetSize(200, 200);
                    ImageBox_2_2.Anchors = Anchors.None;
                    ImageBox_2_2.Visible = true;

                    ImageBox_4_3.SetPosition(260, -56);
                    ImageBox_4_3.SetSize(200, 200);
                    ImageBox_4_3.Anchors = Anchors.None;
                    ImageBox_4_3.Visible = true;

                    ImageBox_4_1.SetPosition(260, -56);
                    ImageBox_4_1.SetSize(200, 200);
                    ImageBox_4_1.Anchors = Anchors.None;
                    ImageBox_4_1.Visible = true;

                    ImageBox_4_2.SetPosition(260, -56);
                    ImageBox_4_2.SetSize(200, 200);
                    ImageBox_4_2.Anchors = Anchors.None;
                    ImageBox_4_2.Visible = true;

                    break;

                default:
                    this.SetSize(700, 400);
                    this.Anchors = Anchors.None;

                    Button_1.SetPosition(0, 0);
                    Button_1.SetSize(334, 174);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(366, 0);
                    Button_2.SetSize(334, 174);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Button_3.SetPosition(0, 226);
                    Button_3.SetSize(334, 174);
                    Button_3.Anchors = Anchors.None;
                    Button_3.Visible = true;

                    Button_4.SetPosition(366, 226);
                    Button_4.SetSize(334, 174);
                    Button_4.Anchors = Anchors.None;
                    Button_4.Visible = true;

                    ImageBox_1_2.SetPosition(45, 9);
                    ImageBox_1_2.SetSize(37, 34);
                    ImageBox_1_2.Anchors = Anchors.None;
                    ImageBox_1_2.Visible = true;

                    ImageBox_1_1.SetPosition(12, 9);
                    ImageBox_1_1.SetSize(37, 34);
                    ImageBox_1_1.Anchors = Anchors.None;
                    ImageBox_1_1.Visible = true;

                    ImageBox_1_3.SetPosition(82, 9);
                    ImageBox_1_3.SetSize(37, 34);
                    ImageBox_1_3.Anchors = Anchors.None;
                    ImageBox_1_3.Visible = true;

                    ImageBox_3_3.SetPosition(82, 355);
                    ImageBox_3_3.SetSize(37, 34);
                    ImageBox_3_3.Anchors = Anchors.None;
                    ImageBox_3_3.Visible = true;

                    ImageBox_3_1.SetPosition(12, 355);
                    ImageBox_3_1.SetSize(37, 34);
                    ImageBox_3_1.Anchors = Anchors.None;
                    ImageBox_3_1.Visible = true;

                    ImageBox_3_2.SetPosition(49, 355);
                    ImageBox_3_2.SetSize(37, 34);
                    ImageBox_3_2.Anchors = Anchors.None;
                    ImageBox_3_2.Visible = true;

                    ImageBox_2_3.SetPosition(653, 9);
                    ImageBox_2_3.SetSize(37, 34);
                    ImageBox_2_3.Anchors = Anchors.None;
                    ImageBox_2_3.Visible = true;

                    ImageBox_2_1.SetPosition(583, 9);
                    ImageBox_2_1.SetSize(37, 34);
                    ImageBox_2_1.Anchors = Anchors.None;
                    ImageBox_2_1.Visible = true;

                    ImageBox_2_2.SetPosition(618, 9);
                    ImageBox_2_2.SetSize(37, 34);
                    ImageBox_2_2.Anchors = Anchors.None;
                    ImageBox_2_2.Visible = true;

                    ImageBox_4_3.SetPosition(653, 355);
                    ImageBox_4_3.SetSize(37, 34);
                    ImageBox_4_3.Anchors = Anchors.None;
                    ImageBox_4_3.Visible = true;

                    ImageBox_4_1.SetPosition(583, 355);
                    ImageBox_4_1.SetSize(37, 34);
                    ImageBox_4_1.Anchors = Anchors.None;
                    ImageBox_4_1.Visible = true;

                    ImageBox_4_2.SetPosition(616, 355);
                    ImageBox_4_2.SetSize(37, 34);
                    ImageBox_4_2.Anchors = Anchors.None;
                    ImageBox_4_2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
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
