// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class Credits
    {
        Panel Panel_1;
        Label Label_1;
        LiveScrollPanel LiveScrollPanel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Panel_1 = new Panel();
            Panel_1.Name = "Panel_1";
            Label_1 = new Label();
            Label_1.Name = "Label_1";
            LiveScrollPanel_1 = new LiveScrollPanel();
            LiveScrollPanel_1.Name = "LiveScrollPanel_1";

            // Credits
            this.RootWidget.AddChildLast(Panel_1);
            this.RootWidget.AddChildLast(LiveScrollPanel_1);

            // Panel_1
            Panel_1.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            Panel_1.Clip = true;
            Panel_1.AddChildLast(Label_1);

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;

            // LiveScrollPanel_1
            LiveScrollPanel_1.HorizontalScroll = true;
            LiveScrollPanel_1.VerticalScroll = true;
            LiveScrollPanel_1.Elasticity = 1f;

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

                    Panel_1.SetPosition(683, 163);
                    Panel_1.SetSize(100, 100);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    Label_1.SetPosition(383, 214);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    LiveScrollPanel_1.SetPosition(413, 214);
                    LiveScrollPanel_1.SetSize(100, 50);
                    LiveScrollPanel_1.Anchors = Anchors.None;
                    LiveScrollPanel_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Panel_1.SetPosition(0, 0);
                    Panel_1.SetSize(960, 544);
                    Panel_1.Anchors = Anchors.None;
                    Panel_1.Visible = true;

                    Label_1.SetPosition(467, 282);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    LiveScrollPanel_1.SetPosition(413, 214);
                    LiveScrollPanel_1.SetSize(337, 215);
                    LiveScrollPanel_1.Anchors = Anchors.None;
                    LiveScrollPanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Label_1.Text = "label";
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
