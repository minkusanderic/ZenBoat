// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class StoreItem
    {
        CheckBox CheckBox_1;
        Label Label_1;
        Label Label_2;
        Label Label_3;
        Label Label_4;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            CheckBox_1 = new CheckBox();
            CheckBox_1.Name = "CheckBox_1";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            Label_2 = new Label();
            Label_2.Name = "Label_2";
            Label_3 = new Label();
            Label_3.Name = "Label_3";
            Label_4 = new Label();
            Label_4.Name = "Label_4";

            // StoreItem
            this.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 0f / 255f);
            this.AddChildLast(CheckBox_1);
            this.AddChildLast(Label_1);
            this.AddChildLast(Label_2);
            this.AddChildLast(Label_3);
            this.AddChildLast(Label_4);

            // CheckBox_1
            CheckBox_1.Style = CheckBoxStyle.RadioButton;

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;

            // Label_2
            Label_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_2.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_2.LineBreak = LineBreak.Character;

            // Label_3
            Label_3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_3.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_3.TextTrimming = TextTrimming.Character;
            Label_3.LineBreak = LineBreak.Character;
            Label_3.HorizontalAlignment = HorizontalAlignment.Right;

            // Label_4
            Label_4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_4.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_4.LineBreak = LineBreak.Character;
            Label_4.HorizontalAlignment = HorizontalAlignment.Right;

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

                    CheckBox_1.SetPosition(18, 8);
                    CheckBox_1.SetSize(56, 56);
                    CheckBox_1.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_1.Visible = true;

                    Label_1.SetPosition(63, 24);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(120, 24);
                    Label_2.SetSize(214, 36);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(593, 28);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(746, 24);
                    Label_4.SetSize(214, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;

                default:
                    this.SetSize(960, 88);
                    this.Anchors = Anchors.None;

                    CheckBox_1.SetPosition(24, 24);
                    CheckBox_1.SetSize(39, 39);
                    CheckBox_1.Anchors = Anchors.Height | Anchors.Width;
                    CheckBox_1.Visible = true;

                    Label_1.SetPosition(63, 24);
                    Label_1.SetSize(57, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    Label_2.SetPosition(120, 22);
                    Label_2.SetSize(413, 40);
                    Label_2.Anchors = Anchors.None;
                    Label_2.Visible = true;

                    Label_3.SetPosition(533, 24);
                    Label_3.SetSize(214, 36);
                    Label_3.Anchors = Anchors.None;
                    Label_3.Visible = true;

                    Label_4.SetPosition(747, 24);
                    Label_4.SetSize(113, 36);
                    Label_4.Anchors = Anchors.None;
                    Label_4.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "1";

            Label_2.Text = "Label_2";

            Label_3.Text = "Label_3";

            Label_4.Text = "Label_4";
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

        public static ListPanelItem Creator()
        {
            return new StoreItem();
        }

    }
}
