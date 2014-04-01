// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Levels
    {
        Panel contentPanel;
        Button backButton;
        PagePanel PagePanel_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            contentPanel = new Panel();
            contentPanel.Name = "contentPanel";
            backButton = new Button();
            backButton.Name = "backButton";
            PagePanel_1 = new PagePanel();
            PagePanel_1.Name = "PagePanel_1";

            // Levels
            this.RootWidget.AddChildLast(contentPanel);

            // contentPanel
            contentPanel.BackgroundColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            contentPanel.Clip = true;
            contentPanel.AddChildLast(backButton);
            contentPanel.AddChildLast(PagePanel_1);

            // backButton
            backButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            backButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // PagePanel_1
            PagePanel_1.AddPage(new Level01());
            PagePanel_1.AddPage(new Level02());
            PagePanel_1.AddPage(new Level03());
            PagePanel_1.AddPage(new Level04());

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

                    contentPanel.SetPosition(411, 245);
                    contentPanel.SetSize(100, 100);
                    contentPanel.Anchors = Anchors.None;
                    contentPanel.Visible = true;

                    backButton.SetPosition(374, 439);
                    backButton.SetSize(214, 56);
                    backButton.Anchors = Anchors.None;
                    backButton.Visible = true;

                    PagePanel_1.SetPosition(0, 15);
                    PagePanel_1.SetSize(100, 50);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    contentPanel.SetPosition(0, 0);
                    contentPanel.SetSize(960, 544);
                    contentPanel.Anchors = Anchors.None;
                    contentPanel.Visible = true;

                    backButton.SetPosition(373, 480);
                    backButton.SetSize(214, 56);
                    backButton.Anchors = Anchors.None;
                    backButton.Visible = true;

                    PagePanel_1.SetPosition(0, 0);
                    PagePanel_1.SetSize(960, 471);
                    PagePanel_1.Anchors = Anchors.None;
                    PagePanel_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            backButton.Text = "Back";
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
