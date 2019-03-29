using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace CSBTE_MyWpnEditor
{
    public class PopupForm : Form
    {
        private readonly MaterialSkinManager materialSkinManager;

        public PopupForm()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            ShowInTaskbar = false;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            //TopLevel = false;
            BackColor = materialSkinManager.GetApplicationBackgroundColor();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PopupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "PopupForm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }
    }
}
