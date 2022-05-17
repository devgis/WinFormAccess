using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CAEELEDPlayer.ExControls.Clock
{
    public partial class ClockControl : UserControl
    {
        private Color _scaleColor = Color.DarkBlue;
        private Color _hourHandColor = Color.Black;
        private Color _minuteHandColor = Color.DarkGreen;
        private Color _secondHandColor = Color.Red;

        /// <summary>
        /// 时针颜色
        /// </summary>
        [Description("时针颜色。"), Category("Appearance")]
        public Color HourHandColor
        {
            get { return _hourHandColor; }
            set { _hourHandColor = value; }
        }

        /// <summary>
        /// 分针颜色
        /// </summary>
        [Description("分针颜色。"), Category("Appearance")]
        public Color MinuteHandColor
        {
            get { return _minuteHandColor; }
            set { _minuteHandColor = value; }
        }

        /// <summary>
        /// 秒针颜色
        /// </summary>
        [Description("秒针颜色。"), Category("Appearance")]
        public Color SecondHandColor
        {
            get { return _secondHandColor; }
            set { _secondHandColor = value; }
        }

        /// <summary>
        /// 刻度颜色
        /// </summary>
        [Description("刻度颜色。"), Category("Appearance")]
        public Color ScaleColor
        {
            get { return _scaleColor; }
            set { _scaleColor = value; }
        }

        public ClockControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            // init the origin
            g.TranslateTransform(this.Width / 2.0f, this.Height / 2.0f);

            int dialRadius = Math.Min(this.Width, this.Height) / 2;

            // Draw the clock dial
            GraphicsState state = g.Save();

            for (int i = 0; i<60; i++)
            {
                Brush b = new SolidBrush(ScaleColor);
                int radius = 10;
                int x = radius/2;
                if (i % 5 == 0)
                {
                    g.FillRectangle(b, new Rectangle(-x / 2, -dialRadius, radius/2, radius * 2));

                }else
                {

                    g.FillRectangle(b, new Rectangle(-x / 2, -dialRadius, radius/2, radius));
                }


                g.RotateTransform(360 / 60);
            }

            g.Restore(state);

            // Get current time
            DateTime now = DateTime.Now;

            // Draw hour hand
            state = g.Save();

            //g.RotateTransform((Math.Abs(now.Hour - 12) + now.Minute / 60f ) * 360f / 12f);
            g.RotateTransform((now.Hour + now.Minute / 60f) * 360f / 12f);

            Brush hb = new SolidBrush(HourHandColor);
            g.FillRectangle(hb, new Rectangle(-5, -dialRadius + 50, 10, dialRadius - 40));
            
            g.Restore(state);

            // Draw Minute hand
            state = g.Save();

            //g.RotateTransform((now.Minute + now.Second / 60f) * 360f / 60f);
            g.RotateTransform(now.Minute * 360f / 60f);

            Brush mb = new SolidBrush(MinuteHandColor);
            g.FillRectangle(mb, new Rectangle(-3, -dialRadius + 30, 6, dialRadius - 15));

            g.Restore(state);

            // Draw Second hand
            state = g.Save();

            g.RotateTransform(now.Second * 360f / 60f);
            Brush sb = new SolidBrush(SecondHandColor);
            g.FillRectangle(sb, new Rectangle(-1, -dialRadius + 10, 2, dialRadius));

            g.Restore(state);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
