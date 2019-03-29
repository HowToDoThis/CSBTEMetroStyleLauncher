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
    
    public partial class InputForm : PopupForm
    {
        public enum CloseType { OK, CANCLE };

        public class CloseEventArgs : EventArgs
        {
            public CloseType status;
            public string text;

            public CloseEventArgs(CloseType aCloseType, string str)
            {
                text = str;
                status = aCloseType;
            }
        }

        public delegate void CloseResultHandler(object sender, CloseEventArgs e);
        public event CloseResultHandler FormClose;
        protected void OnFormClose(CloseEventArgs e)
        {
            if (e == null)
                return;

            FormClose(this, e);
        }

        public InputForm(string name = "")
        {
            InitializeComponent();

            materialSingleLineTextField1.Focus();
            materialSingleLineTextField1.Text = name;
            materialSingleLineTextField1.KeyUp += (sender, args) =>
            {
                if (args.KeyValue == (char)Keys.Enter)
                {
                    if (materialSingleLineTextField1.Text != "")
                    {
                        Close();

                        CloseEventArgs anEventArg = new CloseEventArgs(CloseType.OK, materialSingleLineTextField1.Text);
                        FormClose(this, anEventArg);
                    }

                    args.Handled = true;
                }
            };
        }

        private void close(CloseType type)
        {
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer { Interval = 200, Enabled = true };

            animationTimer.Tick += (_sender, args) =>
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)_sender;
                timer.Enabled = false;

                Close();

                CloseEventArgs anEventArg = new CloseEventArgs(type, materialSingleLineTextField1.Text);
                FormClose(this, anEventArg);

                timer.Dispose();
            };
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            close(CloseType.CANCLE);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (materialSingleLineTextField1.Text != "")
                close(CloseType.OK);
        }
    }
}
