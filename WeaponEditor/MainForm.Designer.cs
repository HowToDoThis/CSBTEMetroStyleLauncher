namespace WeaponEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WeaponsPanel = new MetroFramework.Controls.MetroPanel();
            this.SeletedAmount = new MetroFramework.Controls.MetroLabel();
            this.ButtonClear = new MetroFramework.Controls.MetroButton();
            this.ButtonAll = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // WeaponsPanel
            // 
            resources.ApplyResources(this.WeaponsPanel, "WeaponsPanel");
            this.WeaponsPanel.HorizontalScrollbar = true;
            this.WeaponsPanel.HorizontalScrollbarBarColor = true;
            this.WeaponsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.WeaponsPanel.HorizontalScrollbarSize = 10;
            this.WeaponsPanel.Name = "WeaponsPanel";
            this.WeaponsPanel.VerticalScrollbar = true;
            this.WeaponsPanel.VerticalScrollbarBarColor = true;
            this.WeaponsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.WeaponsPanel.VerticalScrollbarSize = 10;
            // 
            // SeletedAmount
            // 
            resources.ApplyResources(this.SeletedAmount, "SeletedAmount");
            this.SeletedAmount.Name = "SeletedAmount";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonClear, "ButtonClear");
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.UseCustomBackColor = true;
            this.ButtonClear.UseSelectable = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.ButtonAll, "ButtonAll");
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.UseCustomBackColor = true;
            this.ButtonAll.UseSelectable = true;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAll);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.SeletedAmount);
            this.Controls.Add(this.WeaponsPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel WeaponsPanel;
        private MetroFramework.Controls.MetroLabel SeletedAmount;
        private MetroFramework.Controls.MetroButton ButtonClear;
        private MetroFramework.Controls.MetroButton ButtonAll;
    }
}

