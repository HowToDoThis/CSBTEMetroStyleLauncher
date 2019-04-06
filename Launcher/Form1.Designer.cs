namespace Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Divider1 = new MetroFramework.Controls.MetroLabel();
            this.DataBot = new MetroFramework.Controls.MetroLabel();
            this.DataMap = new MetroFramework.Controls.MetroLabel();
            this.DataMode = new MetroFramework.Controls.MetroLabel();
            this.TitleBot = new MetroFramework.Controls.MetroLabel();
            this.TitleMap = new MetroFramework.Controls.MetroLabel();
            this.TitleMode = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.TabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Location = new System.Drawing.Point(23, 63);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(754, 364);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.Divider1);
            this.metroTabPage1.Controls.Add(this.DataBot);
            this.metroTabPage1.Controls.Add(this.DataMap);
            this.metroTabPage1.Controls.Add(this.DataMode);
            this.metroTabPage1.Controls.Add(this.TitleBot);
            this.metroTabPage1.Controls.Add(this.TitleMap);
            this.metroTabPage1.Controls.Add(this.TitleMode);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 322);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(453, 275);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(120, 40);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Custom;
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Launch Game";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 318);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(746, 2);
            this.metroLabel1.TabIndex = 10;
            // 
            // Divider1
            // 
            this.Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Divider1.Location = new System.Drawing.Point(579, 0);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(2, 320);
            this.Divider1.TabIndex = 9;
            // 
            // DataBot
            // 
            this.DataBot.AutoSize = true;
            this.DataBot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DataBot.Location = new System.Drawing.Point(150, 95);
            this.DataBot.Name = "DataBot";
            this.DataBot.Size = new System.Drawing.Size(106, 25);
            this.DataBot.TabIndex = 8;
            this.DataBot.Text = "metroLabel7";
            // 
            // DataMap
            // 
            this.DataMap.AutoSize = true;
            this.DataMap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DataMap.Location = new System.Drawing.Point(150, 55);
            this.DataMap.Name = "DataMap";
            this.DataMap.Size = new System.Drawing.Size(106, 25);
            this.DataMap.TabIndex = 7;
            this.DataMap.Text = "metroLabel6";
            // 
            // DataMode
            // 
            this.DataMode.AutoSize = true;
            this.DataMode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DataMode.Location = new System.Drawing.Point(150, 15);
            this.DataMode.Name = "DataMode";
            this.DataMode.Size = new System.Drawing.Size(106, 25);
            this.DataMode.TabIndex = 6;
            this.DataMode.Text = "metroLabel5";
            // 
            // TitleBot
            // 
            this.TitleBot.AutoSize = true;
            this.TitleBot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleBot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleBot.Location = new System.Drawing.Point(15, 95);
            this.TitleBot.Name = "TitleBot";
            this.TitleBot.Size = new System.Drawing.Size(42, 25);
            this.TitleBot.TabIndex = 4;
            this.TitleBot.Text = "Bot";
            // 
            // TitleMap
            // 
            this.TitleMap.AutoSize = true;
            this.TitleMap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleMap.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleMap.Location = new System.Drawing.Point(15, 55);
            this.TitleMap.Name = "TitleMap";
            this.TitleMap.Size = new System.Drawing.Size(50, 25);
            this.TitleMap.TabIndex = 3;
            this.TitleMap.Text = "Map";
            // 
            // TitleMode
            // 
            this.TitleMode.AutoSize = true;
            this.TitleMode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleMode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleMode.Location = new System.Drawing.Point(15, 15);
            this.TitleMode.Name = "TitleMode";
            this.TitleMode.Size = new System.Drawing.Size(61, 25);
            this.TitleMode.TabIndex = 2;
            this.TitleMode.Text = "Mode";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 322);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Launcher";
            this.TabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroLabel DataBot;
        private MetroFramework.Controls.MetroLabel DataMap;
        private MetroFramework.Controls.MetroLabel DataMode;
        private MetroFramework.Controls.MetroLabel TitleBot;
        private MetroFramework.Controls.MetroLabel TitleMap;
        private MetroFramework.Controls.MetroLabel TitleMode;
        private MetroFramework.Controls.MetroLabel Divider1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

