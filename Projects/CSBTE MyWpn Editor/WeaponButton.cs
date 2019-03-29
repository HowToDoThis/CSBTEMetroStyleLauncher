using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace CSBTE_MyWpnEditor
{
    public partial class WeaponButton : MaterialFlatButton
    {
        public string WeaponText;
        public string WeaponRealName;
        //public bool Checked;
        private bool check;
        public bool Checked
        {
            get { return check; }
            set
            {
                check = value;

                animationTimer.Enabled = true;
                ticker = 0;

                Invalidate();
            }
        }

        public void ResetAnim()
        {
            animationTimer.Enabled = true;
            ticker = 0;

            Invalidate();
        }

        public void SetChecked(bool c)
        {
            check = c;      
        }

        private Timer animationTimer = new Timer { Interval = 5, Enabled = false };
        private int ticker;

        public WeaponButton()
        {
            check = false;

            ticker = 10;

            animationTimer.Tick += (sender, args) =>
            {
                ticker++;

                if (ticker > 10)
                {
                    ticker = 10;

                    Timer timer = (Timer)sender;
                    timer.Enabled = false;
                }

                Invalidate();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.Clear(Parent.BackColor);

            if (Image != null)
                g.DrawImage(Image, 0, 0, Image.Width, Image.Height);

            double animationProgress = ticker / 10.0;

            int alpha = check ? (int)(255.0 * animationProgress) : (255 - (int)(255.0 * animationProgress));
            var brush = new SolidBrush(Color.FromArgb(alpha, Enabled ? SkinManager.ColorScheme.AccentColor : SkinManager.GetCheckBoxOffDisabledColor()));

            Point point1 = new Point(Width - 46, Height - 32);
            Point point2 = new Point(Width, Height - 32);
            Point point3 = new Point(Width, Height);
            Point point4 = new Point(Width - 32, Height);
            Point[] curvePoints = { point1, point2, point3, point4 };

            g.FillPolygon(brush, curvePoints);

            int w = check ? (int)(24 * animationProgress) : (24 - (int)(24 * animationProgress));
            Rectangle rect = new Rectangle(Width - 30, Height - 28, w, 24);

            g.DrawImageUnscaledAndClipped(DrawCheckMarkBitmap(), rect);
            
            Clear = false;
            base.OnPaint(e);
            Clear = true;

            Font font = FontWeightMedium ? SkinManager.ROBOTO_MEDIUM_10 : SkinManager.ROBOTO_REGULAR_10;
            SizeF stringSize = g.MeasureString(WeaponText.ToUpper(), font);

            g.DrawString(
                WeaponText.ToUpper(),
                font,
                Enabled ? (Primary ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(),
                new RectangleF(4F, Height - stringSize.Height - 4, stringSize.Width, stringSize.Height),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode) return;

            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    check = !check;
                    animationTimer.Enabled = true;
                    ticker = 0;

                    Invalidate();
                }
            };
        }

        private const int CHECKBOX_SIZE = 24;
        private static readonly Point[] CHECKMARK_LINE = { new Point(4, 11), new Point(10, 17), new Point(21, 6) };

        private Bitmap DrawCheckMarkBitmap()
        {
            var checkMark = new Bitmap(CHECKBOX_SIZE, CHECKBOX_SIZE);
            var g = Graphics.FromImage(checkMark);

            // clear everything, transparant
            g.Clear(Color.Transparent);

            // draw the checkmark lines
            using (var pen = new Pen(Parent.BackColor, 3))
            {
                g.DrawLines(pen, CHECKMARK_LINE);
            }

            return checkMark;
        }
    }
}
