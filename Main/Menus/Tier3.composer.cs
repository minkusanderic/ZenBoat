<<<<<<< HEAD
﻿// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Tier3
    {
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        Label label5;
        Label label6;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            button1 = new Button();
            button1.Name = "button1";
            button2 = new Button();
            button2.Name = "button2";
            button3 = new Button();
            button3.Name = "button3";
            button4 = new Button();
            button4.Name = "button4";
            button5 = new Button();
            button5.Name = "button5";
            button6 = new Button();
            button6.Name = "button6";
            label1 = new Label();
            label1.Name = "label1";
            label2 = new Label();
            label2.Name = "label2";
            label3 = new Label();
            label3.Name = "label3";
            label4 = new Label();
            label4.Name = "label4";
            label5 = new Label();
            label5.Name = "label5";
            label6 = new Label();
            label6.Name = "label6";

            // Tier3
            this.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 0f / 255f);
            this.Clip = true;
            this.AddChildLast(button1);
            this.AddChildLast(button2);
            this.AddChildLast(button3);
            this.AddChildLast(button4);
            this.AddChildLast(button5);
            this.AddChildLast(button6);
            this.AddChildLast(label1);
            this.AddChildLast(label2);
            this.AddChildLast(label3);
            this.AddChildLast(label4);
            this.AddChildLast(label5);
            this.AddChildLast(label6);

            // button1
            button1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button2
            button2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button3
            button3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button4
            button4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button5
            button5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button6
            button6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // label1
            label1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label1.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label1.LineBreak = LineBreak.Character;
            label1.HorizontalAlignment = HorizontalAlignment.Center;

            // label2
            label2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label2.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label2.LineBreak = LineBreak.Character;
            label2.HorizontalAlignment = HorizontalAlignment.Center;

            // label3
            label3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label3.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label3.LineBreak = LineBreak.Character;
            label3.HorizontalAlignment = HorizontalAlignment.Center;

            // label4
            label4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label4.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label4.LineBreak = LineBreak.Character;
            label4.HorizontalAlignment = HorizontalAlignment.Center;

            // label5
            label5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label5.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label5.LineBreak = LineBreak.Character;
            label5.HorizontalAlignment = HorizontalAlignment.Center;

            // label6
            label6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label6.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label6.LineBreak = LineBreak.Character;
            label6.HorizontalAlignment = HorizontalAlignment.Center;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(420, 960);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(395, 205);
                    button1.SetSize(214, 56);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(395, 205);
                    button2.SetSize(214, 56);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(395, 205);
                    button3.SetSize(214, 56);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(395, 205);
                    button4.SetSize(214, 56);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(395, 205);
                    button5.SetSize(214, 56);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(395, 205);
                    button6.SetSize(214, 56);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    label1.SetPosition(678, 80);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(678, 80);
                    label2.SetSize(214, 36);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(678, 80);
                    label3.SetSize(214, 36);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(678, 80);
                    label4.SetSize(214, 36);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(678, 80);
                    label5.SetSize(214, 36);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(678, 80);
                    label6.SetSize(214, 36);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    break;

                default:
                    this.SetSize(960, 420);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(273, 75);
                    button1.SetSize(84, 84);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(446, 75);
                    button2.SetSize(84, 84);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(623, 75);
                    button3.SetSize(84, 84);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(273, 257);
                    button4.SetSize(84, 84);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(441, 257);
                    button5.SetSize(84, 84);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(623, 258);
                    button6.SetSize(84, 84);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    label1.SetPosition(270, 159);
                    label1.SetSize(90, 19);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(441, 159);
                    label2.SetSize(90, 19);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(620, 159);
                    label3.SetSize(90, 19);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(270, 341);
                    label4.SetSize(90, 19);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(435, 341);
                    label5.SetSize(90, 19);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(620, 345);
                    label6.SetSize(90, 19);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            button1.Text = "Button";

            button2.Text = "Button";

            button3.Text = "Button";

            button4.Text = "Button";

            button5.Text = "Button";

            button6.Text = "Button";

            label1.Text = "label";

            label2.Text = "label";

            label3.Text = "label";

            label4.Text = "label";

            label5.Text = "label";

            label6.Text = "label";
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
=======
﻿// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Menu
{
    partial class Tier3
    {
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        Button button5;
        Button button6;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        Label label5;
        Label label6;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            button1 = new Button();
            button1.Name = "button1";
            button2 = new Button();
            button2.Name = "button2";
            button3 = new Button();
            button3.Name = "button3";
            button4 = new Button();
            button4.Name = "button4";
            button5 = new Button();
            button5.Name = "button5";
            button6 = new Button();
            button6.Name = "button6";
            label1 = new Label();
            label1.Name = "label1";
            label2 = new Label();
            label2.Name = "label2";
            label3 = new Label();
            label3.Name = "label3";
            label4 = new Label();
            label4.Name = "label4";
            label5 = new Label();
            label5.Name = "label5";
            label6 = new Label();
            label6.Name = "label6";

            // Tier3
            this.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            this.Clip = true;
            this.AddChildLast(button1);
            this.AddChildLast(button2);
            this.AddChildLast(button3);
            this.AddChildLast(button4);
            this.AddChildLast(button5);
            this.AddChildLast(button6);
            this.AddChildLast(label1);
            this.AddChildLast(label2);
            this.AddChildLast(label3);
            this.AddChildLast(label4);
            this.AddChildLast(label5);
            this.AddChildLast(label6);

            // button1
            button1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button2
            button2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button3
            button3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button3.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button4
            button4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button4.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button5
            button5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button5.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // button6
            button6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            button6.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // label1
            label1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label1.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label1.LineBreak = LineBreak.Character;
            label1.HorizontalAlignment = HorizontalAlignment.Center;

            // label2
            label2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label2.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label2.LineBreak = LineBreak.Character;
            label2.HorizontalAlignment = HorizontalAlignment.Center;

            // label3
            label3.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label3.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label3.LineBreak = LineBreak.Character;
            label3.HorizontalAlignment = HorizontalAlignment.Center;

            // label4
            label4.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label4.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label4.LineBreak = LineBreak.Character;
            label4.HorizontalAlignment = HorizontalAlignment.Center;

            // label5
            label5.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label5.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label5.LineBreak = LineBreak.Character;
            label5.HorizontalAlignment = HorizontalAlignment.Center;

            // label6
            label6.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            label6.Font = new UIFont(FontAlias.System, 17, FontStyle.Regular);
            label6.LineBreak = LineBreak.Character;
            label6.HorizontalAlignment = HorizontalAlignment.Center;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.SetSize(420, 960);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(395, 205);
                    button1.SetSize(214, 56);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(395, 205);
                    button2.SetSize(214, 56);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(395, 205);
                    button3.SetSize(214, 56);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(395, 205);
                    button4.SetSize(214, 56);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(395, 205);
                    button5.SetSize(214, 56);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(395, 205);
                    button6.SetSize(214, 56);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    label1.SetPosition(678, 80);
                    label1.SetSize(214, 36);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(678, 80);
                    label2.SetSize(214, 36);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(678, 80);
                    label3.SetSize(214, 36);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(678, 80);
                    label4.SetSize(214, 36);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(678, 80);
                    label5.SetSize(214, 36);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(678, 80);
                    label6.SetSize(214, 36);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    break;

                default:
                    this.SetSize(960, 420);
                    this.Anchors = Anchors.None;

                    button1.SetPosition(273, 75);
                    button1.SetSize(84, 84);
                    button1.Anchors = Anchors.None;
                    button1.Visible = true;

                    button2.SetPosition(446, 75);
                    button2.SetSize(84, 84);
                    button2.Anchors = Anchors.None;
                    button2.Visible = true;

                    button3.SetPosition(623, 75);
                    button3.SetSize(84, 84);
                    button3.Anchors = Anchors.None;
                    button3.Visible = true;

                    button4.SetPosition(273, 257);
                    button4.SetSize(84, 84);
                    button4.Anchors = Anchors.None;
                    button4.Visible = true;

                    button5.SetPosition(441, 257);
                    button5.SetSize(84, 84);
                    button5.Anchors = Anchors.None;
                    button5.Visible = true;

                    button6.SetPosition(623, 258);
                    button6.SetSize(84, 84);
                    button6.Anchors = Anchors.None;
                    button6.Visible = true;

                    label1.SetPosition(270, 159);
                    label1.SetSize(90, 19);
                    label1.Anchors = Anchors.None;
                    label1.Visible = true;

                    label2.SetPosition(441, 159);
                    label2.SetSize(90, 19);
                    label2.Anchors = Anchors.None;
                    label2.Visible = true;

                    label3.SetPosition(620, 159);
                    label3.SetSize(90, 19);
                    label3.Anchors = Anchors.None;
                    label3.Visible = true;

                    label4.SetPosition(270, 341);
                    label4.SetSize(90, 19);
                    label4.Anchors = Anchors.None;
                    label4.Visible = true;

                    label5.SetPosition(435, 341);
                    label5.SetSize(90, 19);
                    label5.Anchors = Anchors.None;
                    label5.Visible = true;

                    label6.SetPosition(620, 345);
                    label6.SetSize(90, 19);
                    label6.Anchors = Anchors.None;
                    label6.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            button1.Text = "Button";

            button2.Text = "Button";

            button3.Text = "Button";

            button4.Text = "Button";

            button5.Text = "Button";

            button6.Text = "Button";

            label1.Text = "label";

            label2.Text = "label";

            label3.Text = "label";

            label4.Text = "label";

            label5.Text = "label";

            label6.Text = "label";
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
>>>>>>> 5037d548fc28379daf908c1e726c824dc717201f
