using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
    public class MaterialActionBarButton : Button, IMaterialControl
    {
        private const int ACTION_BAR_HEIGHT = 40;
        
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public float ImageScale { get; set; }

        private readonly AnimationManager animationManager;
        private readonly AnimationManager hoverAnimationManager;

        private SizeF textSize;

        public MaterialActionBarButton()
        {
            ImageScale = 1.0f;

            animationManager = new AnimationManager(false)
            {
                Increment = 0.05,
                AnimationType = AnimationType.EaseOut
            };
            hoverAnimationManager = new AnimationManager
            {
                Increment = 0.07,
                AnimationType = AnimationType.Linear
            };

            hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
            animationManager.OnAnimationProgress += sender => Invalidate();

            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //AutoSize = true;
            Margin = new Padding(4, 6, 4, 6);
            Padding = new Padding(0);
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                textSize = CreateGraphics().MeasureString(value.ToUpper(), SkinManager.ROBOTO_MEDIUM_10);
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;

            g.Clear(SkinManager.ColorScheme.PrimaryColor);

            if (Image != null)
            {
                int w = Convert.ToInt32(Image.Width * ImageScale);
                int h = Convert.ToInt32(Image.Height * ImageScale);
                int x = Convert.ToInt32((ACTION_BAR_HEIGHT - w) / 2);
                int y = Convert.ToInt32((ACTION_BAR_HEIGHT - h) / 2);

                g.DrawImage(Image, x + 1, y, w, h);
            }
            
            //Hover
            Color c = SkinManager.GetFlatButtonHoverBackgroundColor();
           /* using (Brush b = new SolidBrush(Color.FromArgb((int)(hoverAnimationManager.GetProgress() * c.A * 0.5), c.RemoveAlpha())))
                g.FillRectangle(b, ClientRectangle);*/

            var hoverBrush = new SolidBrush(Color.FromArgb((int)(hoverAnimationManager.GetProgress() * c.A * 0.5), c.RemoveAlpha()));

            using (var path = DrawHelper.CreateRoundRect(0, 0, ACTION_BAR_HEIGHT, ACTION_BAR_HEIGHT, ACTION_BAR_HEIGHT / 2))
                g.FillPath(hoverBrush, path);


            //Ripple
            if (animationManager.IsAnimating())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < animationManager.GetAnimationCount(); i++)
                {
                    /*var animationValue = animationManager.GetProgress(i);
                    var animationSource = animationManager.GetSource(i);

                    using (Brush rippleBrush = new SolidBrush(Color.FromArgb((int)(151 - (animationValue * 150)), Color.White)))
                    {
                        var rippleSize = (int)(animationValue * Width * 2);
                        g.FillEllipse(rippleBrush, new Rectangle(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize));
                    }*/

                    var animationValue = animationManager.GetProgress(i);
                    var rippleBrush = new SolidBrush(Color.FromArgb((int)(101 - (animationValue * 100)), Color.White));
                    var rippleSize = (int)(animationValue * ACTION_BAR_HEIGHT);
                    if (rippleSize <= 0)
                        rippleSize = 2;

                    var x = (ACTION_BAR_HEIGHT - rippleSize) / 2;

                    using (var path = DrawHelper.CreateRoundRect(x, x, rippleSize, rippleSize, rippleSize / 2))
                        g.FillPath(rippleBrush, path);


                }
            }
        }

        private Size GetPreferredSize()
        {
            return GetPreferredSize(new Size(0, 0));
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return new Size(ACTION_BAR_HEIGHT, ACTION_BAR_HEIGHT);
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
    }
}
