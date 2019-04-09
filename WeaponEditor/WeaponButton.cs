using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace WeaponEditor
{
    public partial class WeaponButton : MetroButton
    {
        public string WeaponText;
        public string WeaponName;
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

        [Browsable(false)]
        public bool Clear { get; set; }
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private readonly AnimationManager animationManager;
        private readonly AnimationManager hoverAnimationManager;
        private Timer animationTimer = new Timer { Interval = 5, Enabled = false };
        private int ticker;

        public WeaponButton()
        {
            check = false;
            ticker = 10;

            animationManager = new AnimationManager(false)
            {
                Increment = 0.03,
                AnimationType = AnimationType.EaseOut
            };
            hoverAnimationManager = new AnimationManager
            {
                Increment = 0.07,
                AnimationType = AnimationType.Linear
            };
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

            hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
            animationManager.OnAnimationProgress += sender => Invalidate();

            Clear = true;
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
            var brush = new SolidBrush(Color.FromArgb(alpha, Enabled ? MetroColors.Blue : MetroColors.Blue));

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

            Font font = MetroFonts.Default(11f);
            SizeF stringSize = g.MeasureString(WeaponText.ToUpper(), font);

            g.DrawString(
                WeaponText.ToUpper(),
                font,
                brush,
                new RectangleF(4F, Height - stringSize.Height - 4, stringSize.Width, stringSize.Height),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            base.OnPaint(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode) return;

            MouseState = MouseState.OUT;
            MouseEnter += (sender, args) =>
            {
                MouseState = MouseState.HOVER;
                hoverAnimationManager.StartNewAnimation(AnimationDirection.In);
                Invalidate();
            };
            MouseLeave += (sender, args) =>
            {
                MouseState = MouseState.OUT;
                hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);
                Invalidate();
            };
            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    check = !check;
                    animationTimer.Enabled = true;
                    ticker = 0;

                    Invalidate();
                }

                if (args.Button == MouseButtons.Left)
                {
                    MouseState = MouseState.DOWN;

                    animationManager.StartNewAnimation(AnimationDirection.In, args.Location);
                    Invalidate();
                }
            };
            MouseUp += (sender, args) =>
            {
                MouseState = MouseState.HOVER;

                Invalidate();
            };
        }

        private static readonly Point[] FOLDED_LINE = new Point[]
        {
            new Point(0, 12),
            new Point(12, 0)
        };

        private Bitmap DrawCheckMarkBitmap()
        {
            Bitmap bitmap = new Bitmap(12, 12);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Transparent);
            using (Pen pen = new Pen(MetroColors.Blue, 3f))
            {
                graphics.DrawLines(pen, WeaponButton.FOLDED_LINE);
            }
            return bitmap;
        }
    }
}
