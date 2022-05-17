using CAEELEDPlayer.ExControls;

namespace CAEELEDPlayer
{
    partial class frmLEDScreen4
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
            this.components = new System.ComponentModel.Container();
            this.GVBiddingCustomerInfo = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx2 = new CAEELEDPlayer.ExControls.PanelEx();
            this.LblTimeDown = new System.Windows.Forms.Label();
            this.ledClockControls1 = new CAEELEDPlayer.ExControls.Clock.LEDClockControls();
            this.panelClock = new CAEELEDPlayer.ExControls.PanelEx();
            this.panelEx1 = new CAEELEDPlayer.ExControls.PanelEx();
            this.clockControl1 = new CAEELEDPlayer.ExControls.Clock.ClockControl();
            this.clockControls1 = new CAEELEDPlayer.ExControls.Clock.LEDClockControls();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.scrollingTextAffiche = new ScrollingTextControl.ScrollingText();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVBiddingInfo = new System.Windows.Forms.DataGridView();
            this.panelContent = new CAEELEDPlayer.ExControls.PanelEx();
            this.panelMain = new CAEELEDPlayer.ExControls.PanelEx();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelBaseInfo = new CAEELEDPlayer.ExControls.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.GVBiddingCustomerInfo)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelClock.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBiddingInfo)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVBiddingCustomerInfo
            // 
            this.GVBiddingCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVBiddingCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBiddingCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.GVBiddingCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GVBiddingCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.GVBiddingCustomerInfo.Name = "GVBiddingCustomerInfo";
            this.GVBiddingCustomerInfo.ReadOnly = true;
            this.GVBiddingCustomerInfo.RowHeadersVisible = false;
            this.GVBiddingCustomerInfo.RowTemplate.Height = 23;
            this.GVBiddingCustomerInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GVBiddingCustomerInfo.Size = new System.Drawing.Size(1208, 239);
            this.GVBiddingCustomerInfo.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "竞价ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "account";
            this.Column6.HeaderText = "会员账号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "userName";
            this.Column7.HeaderText = "会员名称";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "projectName";
            this.Column8.HeaderText = "项目名称";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "buyTime";
            this.Column9.HeaderText = "竞价时间";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "buyPrice";
            this.Column10.HeaderText = "报价";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // panelEx2
            // 
            this.panelEx2.BorderColor = System.Drawing.Color.Black;
            this.panelEx2.BorderWidth = 1;
            this.panelEx2.Controls.Add(this.LblTimeDown);
            this.panelEx2.Controls.Add(this.ledClockControls1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(240, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(357, 230);
            this.panelEx2.TabIndex = 3;
            // 
            // LblTimeDown
            // 
            this.LblTimeDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTimeDown.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTimeDown.Location = new System.Drawing.Point(3, 36);
            this.LblTimeDown.Name = "LblTimeDown";
            this.LblTimeDown.Size = new System.Drawing.Size(354, 14);
            this.LblTimeDown.TabIndex = 1;
            this.LblTimeDown.Text = "竞拍的开始倒计时和结束倒计时";
            this.LblTimeDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledClockControls1
            // 
            this.ledClockControls1.ClockColor = System.Drawing.Color.Black;
            this.ledClockControls1.ClockStyle = CAEELEDPlayer.ExControls.Clock.ClockStyle.CountDown;
            this.ledClockControls1.CountDownEndTime = new System.DateTime(2011, 4, 1, 15, 41, 39, 0);
            this.ledClockControls1.CountDownTimeSpan = System.TimeSpan.Parse("00:00:00");
            this.ledClockControls1.CountDownTotalSeconds = 0;
            this.ledClockControls1.DateTime = new System.DateTime(2011, 4, 2, 13, 47, 45, 0);
            this.ledClockControls1.IsDrawShadow = true;
            this.ledClockControls1.IsTimerEnable = true;
            this.ledClockControls1.Location = new System.Drawing.Point(51, 86);
            this.ledClockControls1.Name = "ledClockControls1";
            this.ledClockControls1.Size = new System.Drawing.Size(263, 64);
            this.ledClockControls1.TabIndex = 0;
            // 
            // panelClock
            // 
            this.panelClock.BorderColor = System.Drawing.Color.Black;
            this.panelClock.BorderWidth = 1;
            this.panelClock.Controls.Add(this.panelEx2);
            this.panelClock.Controls.Add(this.panelEx1);
            this.panelClock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClock.Location = new System.Drawing.Point(0, 0);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(597, 230);
            this.panelClock.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.BorderColor = System.Drawing.Color.Black;
            this.panelEx1.BorderWidth = 1;
            this.panelEx1.Controls.Add(this.clockControl1);
            this.panelEx1.Controls.Add(this.clockControls1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(240, 230);
            this.panelEx1.TabIndex = 2;
            // 
            // clockControl1
            // 
            this.clockControl1.BackColor = System.Drawing.Color.Transparent;
            this.clockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockControl1.HourHandColor = System.Drawing.Color.Black;
            this.clockControl1.Location = new System.Drawing.Point(0, 0);
            this.clockControl1.MinuteHandColor = System.Drawing.Color.Blue;
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.ScaleColor = System.Drawing.Color.Green;
            this.clockControl1.SecondHandColor = System.Drawing.Color.Red;
            this.clockControl1.Size = new System.Drawing.Size(240, 185);
            this.clockControl1.TabIndex = 1;
            // 
            // clockControls1
            // 
            this.clockControls1.ClockColor = System.Drawing.Color.Black;
            this.clockControls1.ClockStyle = CAEELEDPlayer.ExControls.Clock.ClockStyle.DateAndTime;
            this.clockControls1.CountDownEndTime = new System.DateTime(2011, 3, 25, 17, 46, 4, 0);
            this.clockControls1.CountDownTimeSpan = System.TimeSpan.Parse("00:01:00");
            this.clockControls1.CountDownTotalSeconds = 60;
            this.clockControls1.DateTime = new System.DateTime(2011, 4, 2, 13, 47, 45, 0);
            this.clockControls1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clockControls1.ForeColor = System.Drawing.Color.Black;
            this.clockControls1.IsDrawShadow = true;
            this.clockControls1.IsTimerEnable = true;
            this.clockControls1.Location = new System.Drawing.Point(0, 185);
            this.clockControls1.Name = "clockControls1";
            this.clockControls1.Size = new System.Drawing.Size(240, 45);
            this.clockControls1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.scrollingTextAffiche);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 471);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1210, 35);
            this.panelBottom.TabIndex = 0;
            // 
            // scrollingTextAffiche
            // 
            this.scrollingTextAffiche.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.scrollingTextAffiche.Cursor = System.Windows.Forms.Cursors.Default;
            this.scrollingTextAffiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollingTextAffiche.ForegroundBrush = null;
            this.scrollingTextAffiche.Location = new System.Drawing.Point(0, 0);
            this.scrollingTextAffiche.Name = "scrollingTextAffiche";
            this.scrollingTextAffiche.ScrollDirection = ScrollingTextControl.ScrollDirection.RightToLeft;
            this.scrollingTextAffiche.ScrollText = "Text";
            this.scrollingTextAffiche.ShowBorder = false;
            this.scrollingTextAffiche.Size = new System.Drawing.Size(1210, 35);
            this.scrollingTextAffiche.StopScrollOnMouseOver = false;
            this.scrollingTextAffiche.TabIndex = 0;
            this.scrollingTextAffiche.TextScrollDistance = 1;
            this.scrollingTextAffiche.TextScrollSpeed = 25;
            this.scrollingTextAffiche.VerticleTextPosition = ScrollingTextControl.VerticleTextPosition.Center;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "项目信息";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // GVBiddingInfo
            // 
            this.GVBiddingInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVBiddingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBiddingInfo.ColumnHeadersVisible = false;
            this.GVBiddingInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GVBiddingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GVBiddingInfo.Location = new System.Drawing.Point(0, 0);
            this.GVBiddingInfo.Name = "GVBiddingInfo";
            this.GVBiddingInfo.ReadOnly = true;
            this.GVBiddingInfo.RowHeadersVisible = false;
            this.GVBiddingInfo.RowTemplate.Height = 23;
            this.GVBiddingInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GVBiddingInfo.Size = new System.Drawing.Size(613, 230);
            this.GVBiddingInfo.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BorderColor = System.Drawing.Color.Black;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.BorderWidth = 1;
            this.panelContent.Controls.Add(this.GVBiddingCustomerInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 230);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1210, 241);
            this.panelContent.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.Black;
            this.panelMain.BorderWidth = 1;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 506);
            this.panelMain.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.panelBaseInfo);
            this.panelTitle.Controls.Add(this.panelClock);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1210, 230);
            this.panelTitle.TabIndex = 0;
            // 
            // panelBaseInfo
            // 
            this.panelBaseInfo.BorderColor = System.Drawing.Color.Black;
            this.panelBaseInfo.BorderWidth = 1;
            this.panelBaseInfo.Controls.Add(this.GVBiddingInfo);
            this.panelBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseInfo.Location = new System.Drawing.Point(597, 0);
            this.panelBaseInfo.Name = "panelBaseInfo";
            this.panelBaseInfo.Size = new System.Drawing.Size(613, 230);
            this.panelBaseInfo.TabIndex = 1;
            // 
            // frmLEDScreen4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1216, 512);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(64, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLEDScreen4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.GVBiddingCustomerInfo)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelClock.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVBiddingInfo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelBaseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GVBiddingCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private PanelEx panelEx2;
        private System.Windows.Forms.Label LblTimeDown;
        internal CAEELEDPlayer.ExControls.Clock.LEDClockControls ledClockControls1;
        public PanelEx panelClock;
        private PanelEx panelEx1;
        private CAEELEDPlayer.ExControls.Clock.ClockControl clockControl1;
        internal CAEELEDPlayer.ExControls.Clock.LEDClockControls clockControls1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Panel panelBottom;
        public ScrollingTextControl.ScrollingText scrollingTextAffiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridView GVBiddingInfo;
        public PanelEx panelContent;
        public PanelEx panelMain;
        public System.Windows.Forms.Panel panelTitle;
        public PanelEx panelBaseInfo;



    }
}

