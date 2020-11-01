namespace WeaponEditor
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
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.Note = new MetroFramework.Controls.MetroLabel();
            this.Rights = new MetroFramework.Controls.MetroLabel();
            this.Copyright = new MetroFramework.Controls.MetroLabel();
            this.Creator = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CloseButton.Location = new System.Drawing.Point(319, 142);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 40);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseCustomBackColor = true;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Title.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Title.Location = new System.Drawing.Point(23, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Weapon Editor";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(23, 85);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(221, 19);
            this.Note.TabIndex = 2;
            this.Note.Text = "Rework On NN CSBTEMyWpnEditor";
            // 
            // Rights
            // 
            this.Rights.AutoSize = true;
            this.Rights.Location = new System.Drawing.Point(23, 163);
            this.Rights.Name = "Rights";
            this.Rights.Size = new System.Drawing.Size(247, 19);
            this.Rights.TabIndex = 3;
            this.Rights.Text = "版权所有 侵权必究. All Rights Reserved.";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(23, 142);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(86, 19);
            this.Copyright.TabIndex = 4;
            this.Copyright.Text = "© 2018 Neko";
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Location = new System.Drawing.Point(23, 104);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(132, 19);
            this.Creator.TabIndex = 5;
            this.Creator.Text = "Creator : NekoMeow";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 205);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Rights);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CloseButton);
            this.Name = "Main";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroLabel Title;
        private MetroFramework.Controls.MetroLabel Note;
        private MetroFramework.Controls.MetroLabel Rights;
        private MetroFramework.Controls.MetroLabel Copyright;
        private MetroFramework.Controls.MetroLabel Creator;
    }
}