using CAEELEDPlayer.ExControls;

namespace CAEELEDPlayer
{
    partial class frmLEDScreen3
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
            this.panelMain = new CAEELEDPlayer.ExControls.PanelEx();
            this.panelContent = new CAEELEDPlayer.ExControls.PanelEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.scrollingTextAffiche = new ScrollingTextControl.ScrollingText();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.Black;
            this.panelMain.BorderWidth = 1;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1210, 506);
            this.panelMain.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.BorderColor = System.Drawing.Color.Black;
            this.panelContent.BorderWidth = 1;
            this.panelContent.Controls.Add(this.tableLayoutPanel1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1210, 471);
            this.panelContent.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.zedGraphControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zedGraphControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1210, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.BackColor = System.Drawing.Color.Transparent;
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0;
            this.zedGraphControl2.ScrollMaxX = 0;
            this.zedGraphControl2.ScrollMaxY = 0;
            this.zedGraphControl2.ScrollMaxY2 = 0;
            this.zedGraphControl2.ScrollMinX = 0;
            this.zedGraphControl2.ScrollMinY = 0;
            this.zedGraphControl2.ScrollMinY2 = 0;
            this.zedGraphControl2.Size = new System.Drawing.Size(599, 229);
            this.zedGraphControl2.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Transparent;
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 238);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(599, 230);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(608, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(608, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(599, 229);
            this.dataGridView1.TabIndex = 3;
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
            // frmLEDScreen3
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
            this.Name = "frmLEDScreen3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLEDScreen_MouseDown);
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public PanelEx panelMain;
        public PanelEx panelContent;
        public System.Windows.Forms.Panel panelBottom;
        public ScrollingTextControl.ScrollingText scrollingTextAffiche;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;




    }
}

