// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class NotEnoughMessage
    {
        Label Label_1;
        Button okButton;
        Button cancelButton;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            okButton = new Button();
            okButton.Name = "okButton";
            cancelButton = new Button();
            cancelButton.Name = "cancelButton";

            // NotEnoughMessage
            this.AddChildLast(Label_1);
            this.AddChildLast(okButton);
            this.AddChildLast(cancelButton);
            this.ShowEffect = new BunjeeJumpEffect()
            {
            };
            this.HideEffect = new TiltDropEffect();

            // Label_1
            Label_1.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 72, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;

            // okButton
            okButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            okButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // cancelButton
            cancelButton.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            cancelButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

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

                    okButton.SetPosition(140, 440);
                    okButton.SetSize(214, 56);
                    okButton.Anchors = Anchors.None;
                    okButton.Visible = true;

                    cancelButton.SetPosition(606, 440);
                    cancelButton.SetSize(214, 56);
                    cancelButton.Anchors = Anchors.None;
                    cancelButton.Visible = true;

                    break;

                default:
                    this.SetPosition(0, 0);
                    this.SetSize(960, 544);
                    this.Anchors = Anchors.None;

                    Label_1.SetPosition(69, 52);
                    Label_1.SetSize(822, 370);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    okButton.SetPosition(140, 440);
                    okButton.SetSize(214, 56);
                    okButton.Anchors = Anchors.None;
                    okButton.Visible = true;

                    cancelButton.SetPosition(606, 440);
                    cancelButton.SetSize(214, 56);
                    cancelButton.Anchors = Anchors.None;
                    cancelButton.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "Would you like to buy more cranes?";

            okButton.Text = "OK";

            cancelButton.Text = "Cancel";
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
