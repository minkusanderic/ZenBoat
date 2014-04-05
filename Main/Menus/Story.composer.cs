// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Story
    {
        Panel contentPanel;
        PagePanel PagePanel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            contentPanel = new Panel();
            contentPanel.Name = "contentPanel";
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";

            // Story
            this.RootWidget.AddChildLast(contentPanel);
            this.RootWidget.AddChildLast(PagePanel_1);

            // contentPanel
            contentPanel.BackgroundColor = new UIColor(153f / 255f, 153f / 255f, 153f / 255f, 255f / 255f);
            contentPanel.Clip = true;

            // PagePanel_1
            PagePanel_1.AddPage(new Story1());
            PagePanel_1.AddPage(new Story2());
            PagePanel_1.AddPage(new Story3());
            PagePanel_1.AddPage(new Story4());
            PagePanel_1.AddPage(new Story5());

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

                    contentPanel.SetPosition(47, 80);
                    contentPanel.SetSize(100, 100);
                    contentPanel.Anchors = Anchors.None;
                    contentPanel.Visible = true;

                    PagePanel_1.SetPosition(0, 0);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    contentPanel.SetPosition(0, 0);
                    contentPanel.SetSize(958, 542);
                    contentPanel.Anchors = Anchors.None;
                    contentPanel.Visible = true;

                    PagePanel_1.SetPosition(0, 0);
                    PagePanel_1.SetSize(960, 544);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
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
