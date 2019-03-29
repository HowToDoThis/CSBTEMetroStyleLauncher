using MaterialSkin;
using MaterialSkin.Controls;

namespace CSBTE_MyWpnEditor
{
    partial class MainForm : MaterialForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.curselectToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.loadAllWeaponsToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.enableMyWpnToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialActionBarButton1 = new MaterialSkin.Controls.MaterialActionBarButton();
            this.materialActionBarButton3 = new MaterialSkin.Controls.MaterialActionBarButton();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.newemptyToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.newfromcurToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripMenuItem3 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripMenuItem4 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialContextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            resources.ApplyResources(this.materialContextMenuStrip1, "materialContextMenuStrip1");
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curselectToolStripMenuItem,
            this.toolStripSeparator4,
            this.clearToolStripMenuItem,
            this.loadAllWeaponsToolStripMenuItem,
            this.enableMyWpnToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.materialContextMenuStrip1_Closed);
            // 
            // curselectToolStripMenuItem
            // 
            resources.ApplyResources(this.curselectToolStripMenuItem, "curselectToolStripMenuItem");
            this.curselectToolStripMenuItem.Name = "curselectToolStripMenuItem";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // clearToolStripMenuItem
            // 
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // loadAllWeaponsToolStripMenuItem
            // 
            resources.ApplyResources(this.loadAllWeaponsToolStripMenuItem, "loadAllWeaponsToolStripMenuItem");
            this.loadAllWeaponsToolStripMenuItem.Name = "loadAllWeaponsToolStripMenuItem";
            this.loadAllWeaponsToolStripMenuItem.Click += new System.EventHandler(this.loadAllWeaponsToolStripMenuItem_Click);
            // 
            // enableMyWpnToolStripMenuItem
            // 
            resources.ApplyResources(this.enableMyWpnToolStripMenuItem, "enableMyWpnToolStripMenuItem");
            this.enableMyWpnToolStripMenuItem.Name = "enableMyWpnToolStripMenuItem";
            this.enableMyWpnToolStripMenuItem.Click += new System.EventHandler(this.enableMyWpnToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // materialActionBarButton1
            // 
            resources.ApplyResources(this.materialActionBarButton1, "materialActionBarButton1");
            this.materialActionBarButton1.Depth = 0;
            this.materialActionBarButton1.ImageScale = 0.7F;
            this.materialActionBarButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialActionBarButton1.Name = "materialActionBarButton1";
            this.materialActionBarButton1.UseVisualStyleBackColor = true;
            this.materialActionBarButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.materialRaisedButton1_MouseUp);
            // 
            // materialActionBarButton3
            // 
            resources.ApplyResources(this.materialActionBarButton3, "materialActionBarButton3");
            this.materialActionBarButton3.Depth = 0;
            this.materialActionBarButton3.ImageScale = 0.7F;
            this.materialActionBarButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialActionBarButton3.Name = "materialActionBarButton3";
            this.materialActionBarButton3.UseVisualStyleBackColor = true;
            this.materialActionBarButton3.Click += new System.EventHandler(this.materialActionBarButton3_Click);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newemptyToolStripMenuItem,
            this.newfromcurToolStripMenuItem,
            this.toolStripSeparator1,
            this.materialToolStripMenuItem1,
            this.toolStripSeparator2,
            this.materialToolStripMenuItem3,
            this.materialToolStripMenuItem4});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            resources.ApplyResources(this.materialContextMenuStrip2, "materialContextMenuStrip2");
            // 
            // newemptyToolStripMenuItem
            // 
            resources.ApplyResources(this.newemptyToolStripMenuItem, "newemptyToolStripMenuItem");
            this.newemptyToolStripMenuItem.Name = "newemptyToolStripMenuItem";
            this.newemptyToolStripMenuItem.Click += new System.EventHandler(this.addProfile);
            // 
            // newfromcurToolStripMenuItem
            // 
            resources.ApplyResources(this.newfromcurToolStripMenuItem, "newfromcurToolStripMenuItem");
            this.newfromcurToolStripMenuItem.Name = "newfromcurToolStripMenuItem";
            this.newfromcurToolStripMenuItem.Click += new System.EventHandler(this.addProfileCopy);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // materialToolStripMenuItem1
            // 
            resources.ApplyResources(this.materialToolStripMenuItem1, "materialToolStripMenuItem1");
            this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
            this.materialToolStripMenuItem1.Tag = "0";
            this.materialToolStripMenuItem1.Click += new System.EventHandler(this.selectProfile);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // materialToolStripMenuItem3
            // 
            resources.ApplyResources(this.materialToolStripMenuItem3, "materialToolStripMenuItem3");
            this.materialToolStripMenuItem3.Name = "materialToolStripMenuItem3";
            this.materialToolStripMenuItem3.Click += new System.EventHandler(this.renameCur);
            // 
            // materialToolStripMenuItem4
            // 
            resources.ApplyResources(this.materialToolStripMenuItem4, "materialToolStripMenuItem4");
            this.materialToolStripMenuItem4.Name = "materialToolStripMenuItem4";
            this.materialToolStripMenuItem4.Click += new System.EventHandler(this.deleteCur);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialActionBarButton3);
            this.Controls.Add(this.materialActionBarButton1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialContextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialToolStripMenuItem clearToolStripMenuItem;
        private MaterialToolStripMenuItem loadAllWeaponsToolStripMenuItem;
        private MaterialToolStripMenuItem enableMyWpnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private MaterialActionBarButton materialActionBarButton1;
        private MaterialActionBarButton materialActionBarButton3;
        private MaterialContextMenuStrip materialContextMenuStrip2;
        private MaterialToolStripMenuItem newemptyToolStripMenuItem;
        private MaterialToolStripMenuItem newfromcurToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MaterialToolStripMenuItem aboutToolStripMenuItem;
        private MaterialToolStripMenuItem curselectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MaterialToolStripMenuItem materialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MaterialToolStripMenuItem materialToolStripMenuItem3;
        private MaterialToolStripMenuItem materialToolStripMenuItem4;




    }
}

