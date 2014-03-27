// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class StoreMessage
    {
        Label Label_1;
        Button Button_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Button_1 = new Button();
            Button_1.Name = "Button_1";

            // StoreMessage
            this.AddChildLast(Label_1);
            this.AddChildLast(Button_1);
            this.ShowEffect = new BunjeeJumpEffect()
            {
            };
            this.HideEffect = new TiltDropEffect();

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;

            // Button_1
            Button_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetPosition(0, 0);
                    this.SetSize(544, 960);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(244, 216);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Button_1.SetPosition(330, 470);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;

                default:
                    this.SetPosition(0, 0);
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(69, 42);
                    Label_1.SetSize(822, 370);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Button_1.SetPosition(373, 435);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "OK";
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
