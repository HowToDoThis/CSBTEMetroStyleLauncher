using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBTE_MyWpnEditor
{
    public partial class AboutForm : PopupForm
    {
        public AboutForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo300, Accent.Pink200, TextShade.WHITE);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer { Interval = 200, Enabled = true };

            animationTimer.Tick += (_sender, args) =>
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)_sender;
                timer.Enabled = false;

                Close();

                timer.Dispose();
            };            
        }
    }
}
