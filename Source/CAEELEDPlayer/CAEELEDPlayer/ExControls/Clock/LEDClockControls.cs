#region

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

#endregion

namespace CAEELEDPlayer.ExControls.Clock
{
    ///<summary>
    ///  Clock's Style.时钟的样式定义
    ///</summary>
    public enum ClockStyle
    {
        /// <summary>
        /// 只显示日期
        /// </summary>
        DateOnly,

        /// <summary>
        /// 只显示时间
        /// </summary>
        TimeOnly, 

        /// <summary>
        /// 显示日期和时间
        /// </summary>
        DateAndTime, 
        /// <summary>
        /// 倒计时
        /// </summary>
        CountDown
    }

    //这是控件的关键代码
    public class LEDClockControls : UserControl
    {
        //我自定义的事件
        public event EventHandler CountDownTotalSecondsChangeEvent;

        //public delegate void CountDownTotalSecondsChangeEventHandler(object sender, EventArgs e);

        private Color _clockColor = Color.Black;
        private int _clockStringHeight;
        private int _clockStringWidth;
        private ClockStyle _clockStyle = ClockStyle.DateAndTime;
        private DateTime _dateTime;
        //是否绘制阴影（即残影），以摸拟真似的LED时钟
        private bool _isDrawShadow = true;

        //是否自动更新时间
        private bool _isTimerEnable;
        private Timer _timer;
        private Graphics g;
        private Bitmap m_Bitmap;

        private DateTime _CountDownEndTime;//倒计时结束时间点
        private TimeSpan _CountDownTimeSpan = new TimeSpan(0,1,0);//倒计时时长
        private double _countDownTotalSeconds;

        public DateTime CountDownEndTime
        {
            get { return _CountDownEndTime; }
            set { _CountDownEndTime = value;}
        }

        public TimeSpan CountDownTimeSpan
        {
            get { return _CountDownTimeSpan; }
            set { _CountDownTimeSpan = value; }
        }

        [Browsable(false)]
        public double CountDownTotalSeconds
        {
            get { return _countDownTotalSeconds; }
            set { _countDownTotalSeconds = value; 
                if(CountDownTotalSecondsChangeEvent!=null)
                {
                    CountDownTotalSecondsChangeEvent(this, EventArgs.Empty);
                }
            }
        }


        public LEDClockControls()
        {
            InitializeComponent();
            Text = "LEDClockControls";
            //使用双缓冲，支持透明绘制
            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
            Init();
            _dateTime = DateTime.Now;
        }

        public bool IsDrawShadow
        {
            get { return _isDrawShadow; }
            set
            {
                _isDrawShadow = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Timer Timer
        {
            get { return _timer; }
            set
            {
                _timer = value;
                if (_timer != null)
                {
                    _timer.Tick += TimerOnTick;
                }
            }
        }

        public bool IsTimerEnable
        {
            get { return _isTimerEnable; }
            set
            {
                if (value)
                {
                    if (_timer == null)
                    {
                        _timer = new Timer();
                        _timer.Tick += TimerOnTick;
                        _timer.Interval = 1000;
                    }
                    _timer.Enabled = true;
                }
                else
                {
                    if (_timer != null)
                    {
                        _timer.Enabled = false;
                    }
                }
                _isTimerEnable = value;
            }
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        //LED文字的颜色
        public Color ClockColor
        {
            get { return _clockColor; }
            set
            {
                _clockColor = value;
                Invalidate();
            }
        }

        public ClockStyle ClockStyle
        {
            get { return _clockStyle; }
            set
            {
                _clockStyle = value;
                Invalidate();
            }
        }

        public int ClockStringWidth
        {
            get { return _clockStringWidth; }
        }

        public int ClockStringHeight
        {
            get { return _clockStringHeight; }
        }

        public void Start()
        {
            IsTimerEnable = true;
            Refresh();
        }

        public void Stop()
        {
            IsTimerEnable = false;
        }

        //初始化
        private void Init()
        {
            m_Bitmap = new Bitmap(Width, Height);

            g = Graphics.FromImage(m_Bitmap);
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
        }

        private void TimerOnTick(object obj, EventArgs ea)
        {
            DateTime dtNow = DateTime.Now;
            dtNow = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, dtNow.Hour, dtNow.Minute, dtNow.Second);

            if (dtNow != _dateTime)
            {
                _dateTime = dtNow;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            m_Bitmap = DrawClock();
            Graphics gg = e.Graphics;
            gg.CompositingQuality = CompositingQuality.HighQuality;
            gg.DrawImageUnscaled(m_Bitmap, 0, 0);
            //g.Dispose();
        }

        public Bitmap DrawClock()
        {
            return DrawClock(ClientRectangle);
        }

        private void ClockControls_Resize(object sender, EventArgs e)
        {
            Init();
            Refresh();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LEDClockControls
            // 
            this.Resize += ClockControls_Resize;
            this.Name = "LEDClockControls";
            this.Size = new System.Drawing.Size(212, 49);
            this.ResumeLayout(false);

        }

        //绘制时钟
        public Bitmap DrawClock(Rectangle destRect)
        {
            m_Bitmap = new Bitmap(destRect.Width, destRect.Height);
            //m_Bitmap = new Bitmap(destRect.X + this.Width, destRect.Y + this.Height);
            Graphics grfx = Graphics.FromImage(m_Bitmap);
            //设置绘图面板的绘制质量等
            grfx.CompositingQuality = CompositingQuality.HighQuality;
            grfx.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            grfx.SmoothingMode = SmoothingMode.HighQuality;

            ClockDisplay ssd = new ClockDisplay(grfx);
            ssd.IsDrawShadow = _isDrawShadow;
            GraphicsState gs = grfx.Save();
            grfx.TranslateTransform(destRect.X, destRect.Y);
            string strTime = string.Empty;

            switch (_clockStyle)
            {
                case ClockStyle.TimeOnly:
                    strTime = _dateTime.ToString("T", DateTimeFormatInfo.InvariantInfo);
                    break;
                case ClockStyle.DateOnly:
                    strTime = _dateTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
                    break;
                case ClockStyle.DateAndTime:
                    strTime = _dateTime.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo) + " " +
                              _dateTime.ToString("T", DateTimeFormatInfo.InvariantInfo);
                    break;
                case ClockStyle.CountDown:
                    if (CountDownEndTime > _dateTime)
                    {
                        TimeSpan ts = (CountDownEndTime - _dateTime);
                        CountDownTotalSeconds = ts.TotalSeconds;
                        strTime = string.Format("{0}:{1}:{2}", ts.Hours.ToString("0").PadLeft(2, '0'),
                                                ts.Minutes.ToString().PadLeft(2, '0'),
                                                ts.Seconds.ToString().PadLeft(2, '0'));
                    }
                    else
                    {
                        strTime = "00:00:00";
                    }
                    break;
            }

            SizeF sizef = ssd.MeasureString(strTime, Font);
            float fScale = Math.Min(destRect.Width/sizef.Width, destRect.Height/sizef.Height);
            Font font = new Font(Font.FontFamily, fScale*Font.SizeInPoints);

            sizef = ssd.MeasureString(strTime, font);
            _clockStringWidth = (int) sizef.Width;
            _clockStringHeight = (int) sizef.Height;

            ssd.DrawString(strTime, font, new SolidBrush(_clockColor),
                           (destRect.Width - sizef.Width)/2,
                           (destRect.Height - sizef.Height)/2);
            grfx.Restore(gs);
            return m_Bitmap;
        }
    }

    //字符绘制的算法
    internal class ClockDisplay
    {
        private static readonly byte[,] bySegment = {
                                                        {1, 1, 1, 0, 1, 1, 1}, // 0
                                                        {0, 0, 1, 0, 0, 1, 0}, // 1
                                                        {1, 0, 1, 1, 1, 0, 1}, // 2
                                                        {1, 0, 1, 1, 0, 1, 1}, // 3
                                                        {0, 1, 1, 1, 0, 1, 0}, // 4
                                                        {1, 1, 0, 1, 0, 1, 1}, // 5
                                                        {1, 1, 0, 1, 1, 1, 1}, // 6
                                                        {1, 0, 1, 0, 0, 1, 0}, // 7
                                                        {1, 1, 1, 1, 1, 1, 1}, // 8
                                                        {1, 1, 1, 1, 0, 1, 1} // 9
                                                    };

        // Points that define each of the seven segments
        private readonly Point[][] apt = new Point[7][];
        private readonly Graphics grfx;
        private Brush _brush = Brushes.Black;
        private bool _isDrawShadow = true;
        private Brush _shadowBrush;
        private Color _shadowColor = Color.FromArgb(60, Color.White);
        // Indicates what segments are illuminated for all 10 digits

        public ClockDisplay(Graphics grfx)
        {
            this.grfx = grfx;
            // Initialize jagged Point array.
            apt[0] = new Point[]
                         {
                             new Point(3, 2), new Point(39, 2),
                             new Point(31, 10), new Point(11, 10)
                         };

            apt[1] = new Point[]
                         {
                             new Point(2, 3), new Point(10, 11),
                             new Point(10, 31), new Point(2, 35)
                         };

            apt[2] = new Point[]
                         {
                             new Point(40, 3), new Point(40, 35),
                             new Point(32, 31), new Point(32, 11)
                         };

            apt[3] = new Point[]
                         {
                             new Point(3, 36), new Point(11, 32),
                             new Point(31, 32), new Point(39, 36),
                             new Point(31, 40), new Point(11, 40)
                         };

            apt[4] = new Point[]
                         {
                             new Point(2, 37), new Point(10, 41),
                             new Point(10, 61), new Point(2, 69)
                         };

            apt[5] = new Point[]
                         {
                             new Point(40, 37), new Point(40, 69),
                             new Point(32, 61), new Point(32, 41)
                         };

            apt[6] = new Point[]
                         {
                             new Point(11, 62), new Point(31, 62),
                             new Point(39, 70), new Point(3, 70)
                         };
        }

        public bool IsDrawShadow
        {
            get { return _isDrawShadow; }
            set { _isDrawShadow = value; }
        }

        public SizeF MeasureString(string str, Font font)
        {
            SizeF sizef = new SizeF(0, grfx.DpiX*font.SizeInPoints/72);

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    sizef.Width += 42*grfx.DpiX*font.SizeInPoints/72/72;
                }
                else if (str[i] == '-')
                {
                    sizef.Width += 42*grfx.DpiX*font.SizeInPoints/72/72;
                }
                else if (str[i] == ':')
                {
                    sizef.Width += 20*grfx.DpiX*font.SizeInPoints/72/72;
                }
                else if (str[i] == ' ')
                {
                    sizef.Width += 36*grfx.DpiX*font.SizeInPoints/72/72;
                }
            }
            return sizef;
        }

        public void DrawString(string str, Font font, Brush brush, float x, float y)
        {
            _brush = brush;
            _shadowBrush = new SolidBrush(Color.FromArgb(40, ((SolidBrush) _brush).Color));

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    x = Number(str[i] - '0', font, brush, x, y);
                }
                else if (str[i] == '-')
                {
                    x = MinusSign(font, brush, x, y);
                }
                else if (str[i] == ':')
                {
                    x = Colon(font, brush, x, y);
                }
                else if (str[i] == ' ')
                {
                    x = DrawSpace(font, brush, x, y);
                }
            }
        }

        private float Number(int num, Font font, Brush brush, float x, float y)
        {
            for (int i = 0; i < apt.Length; i++)
            {
                if (_isDrawShadow)
                {
                    Fill(apt[i], font, _shadowBrush, x, y);
                }
                if (bySegment[num, i] == 1)
                {
                    Fill(apt[i], font, brush, x, y);
                }
            }
            return x + 42*grfx.DpiX*font.SizeInPoints/72/72;
        }

        private float MinusSign(Font font, Brush brush, float x, float y)
        {
            Fill(apt[3], font, brush, x, y);
            return x + 42*grfx.DpiX*font.SizeInPoints/72/72;
        }

        private float DrawSpace(Font font, Brush brush, float x, float y)
        {
            return x + 36*grfx.DpiX*font.SizeInPoints/72/72;
        }

        private float Colon(Font font, Brush brush, float x, float y)
        {
            Point[][] apt = new Point[2][];

            apt[0] = new Point[]
                         {
                             new Point(4, 12), new Point(16, 12),
                             new Point(16, 24), new Point(4, 24)
                         };

            apt[1] = new Point[]
                         {
                             new Point(4, 50), new Point(16, 50),
                             new Point(16, 62), new Point(4, 62)
                         };

            for (int i = 0; i < apt.Length; i++)
            {
                Fill(apt[i], font, brush, x, y);
            }

            return x + 20*grfx.DpiX*font.SizeInPoints/72/72;
        }

        private void Fill(Point[] apt, Font font, Brush brush, float x, float y)
        {
            PointF[] aptf = new PointF[apt.Length];

            for (int i = 0; i < apt.Length; i++)
            {
                aptf[i].X = x + apt[i].X*grfx.DpiX*font.SizeInPoints/72/72;
                aptf[i].Y = y + apt[i].Y*grfx.DpiY*font.SizeInPoints/72/72;
            }

            grfx.FillPolygon(brush, aptf);
        }
    }
}