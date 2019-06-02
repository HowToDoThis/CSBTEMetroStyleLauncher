using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public bool FontSize10 { get; set; }
        public bool FontWeightMedium { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = SkinManager.GetPrimaryTextColor();
            FlatStyle = FlatStyle.Flat;

            if (FontSize10)
                Font = FontWeightMedium ? SkinManager.ROBOTO_MEDIUM_10 : SkinManager.ROBOTO_REGULAR_10;
            else
                Font = FontWeightMedium ? SkinManager.ROBOTO_MEDIUM_11 : SkinManager.ROBOTO_REGULAR_11;

            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            // clear the control
            g.Clear(Parent.BackColor);

            g.DrawString(
                Text,
                Font,
                SkinManager.GetPrimaryTextBrush(),
                0,
                0);

            //base.OnPaint(e);
        }
    }    
}
