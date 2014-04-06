// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Level07
    {
        Button Button_1;
        ImageBox ImageBox_1_2;
        ImageBox ImageBox_1_1;
        ImageBox ImageBox_1_3;
        Label Label_1;
        Label LevelLabel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            ImageBox_1_2 = new ImageBox();
            ImageBox_1_2.Name = "ImageBox_1_2";
            ImageBox_1_1 = new ImageBox();
            ImageBox_1_1.Name = "ImageBox_1_1";
            ImageBox_1_3 = new ImageBox();
            ImageBox_1_3.Name = "ImageBox_1_3";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            LevelLabel_1 = new Label();
            LevelLabel_1.Name = "LevelLabel_1";

            // Level07
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(Button_1);
            this.AddChildLast(ImageBox_1_2);
            this.AddChildLast(ImageBox_1_1);
            this.AddChildLast(ImageBox_1_3);
            this.AddChildLast(Label_1);
            this.AddChildLast(LevelLabel_1);

            // Button_1
            Button_1.IconImage = new ImageAsset("/Application/assets/025.jpg");

            // ImageBox_1_2
            ImageBox_1_2.Image = new ImageAsset("/Application/assets/FullStar.png");

            // ImageBox_1_1
            ImageBox_1_1.Image = null;

            // ImageBox_1_3
            ImageBox_1_3.Image = new ImageAsset("/Application/assets/FullStar.png");

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;

            // LevelLabel_1
            LevelLabel_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            LevelLabel_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            LevelLabel_1.LineBreak = LineBreak.Character;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(400, 700);
                    this.Anchors = Anchors.None;

                    Button_1.SetPosition(97, 82);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

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

                    Label_1.SetPosition(37, 56);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    LevelLabel_1.SetPosition(53, 456);
                    LevelLabel_1.SetSize(214, 36);
                    LevelLabel_1.Anchors = Anchors.None;
                    LevelLabel_1.Visible = true;

                    break;

                default:
                    this.SetSize(700, 400);
                    this.Anchors = Anchors.None;

                    Button_1.SetPosition(0, 8);
                    Button_1.SetSize(334, 174);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    ImageBox_1_2.SetPosition(45, 17);
                    ImageBox_1_2.SetSize(37, 34);
                    ImageBox_1_2.Anchors = Anchors.None;
                    ImageBox_1_2.Visible = true;

                    ImageBox_1_1.SetPosition(12, 17);
                    ImageBox_1_1.SetSize(37, 34);
                    ImageBox_1_1.Anchors = Anchors.None;
                    ImageBox_1_1.Visible = true;

                    ImageBox_1_3.SetPosition(82, 17);
                    ImageBox_1_3.SetSize(37, 34);
                    ImageBox_1_3.Anchors = Anchors.None;
                    ImageBox_1_3.Visible = true;

                    Label_1.SetPosition(60, 77);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    LevelLabel_1.SetPosition(45, 451);
                    LevelLabel_1.SetSize(214, 36);
                    LevelLabel_1.Anchors = Anchors.None;
                    LevelLabel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "Level 25";

            LevelLabel_1.Text = "025";
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
