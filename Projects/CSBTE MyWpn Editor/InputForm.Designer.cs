namespace CSBTE_MyWpnEditor
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Error = false;
            this.materialSingleLineTextField1.Hint = "Enter profile name";
            resources.ApplyResources(this.materialSingleLineTextField1, "materialSingleLineTextField1");
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.NumOnly = false;
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialFlatButton2
            // 
            resources.ApplyResources(this.materialFlatButton2, "materialFlatButton2");
            this.materialFlatButton2.Clear = true;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.FontWeightMedium = true;
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = true;
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            resources.ApplyResources(this.materialFlatButton1, "materialFlatButton1");
            this.materialFlatButton1.Clear = true;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FontWeightMedium = true;
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}