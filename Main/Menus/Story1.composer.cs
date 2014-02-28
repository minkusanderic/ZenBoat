// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Story1
    {
        ImageBox ImageBox_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";

            // Story1
            this.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(ImageBox_1);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/story1.png");

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

                    ImageBox_1.SetPosition(368, 103);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    break;

                default:
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    ImageBox_1.SetPosition(0, 0);
                    ImageBox_1.SetSize(960, 544);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

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
