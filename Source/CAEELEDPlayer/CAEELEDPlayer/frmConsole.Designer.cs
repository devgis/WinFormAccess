namespace CAEELEDPlayer
{
    partial class frmConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsole));
            this.menuConsole = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NumScreenBorderSize = new System.Windows.Forms.NumericUpDown();
            this.NumScreenMargin = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericW = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.cbColorToScreen = new System.Windows.Forms.CheckBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.panelBorderColor = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelFontColor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelBackColor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConver = new System.Windows.Forms.Button();
            this.btnScreenLock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettingScreen = new System.Windows.Forms.Button();
            this.btnCloseScreen = new System.Windows.Forms.Button();
            this.cbCloseScreen = new System.Windows.Forms.CheckBox();
            this.rbScreen4 = new System.Windows.Forms.RadioButton();
            this.rbScreen3 = new System.Windows.Forms.RadioButton();
            this.rbScreen2 = new System.Windows.Forms.RadioButton();
            this.rbScreen1 = new System.Windows.Forms.RadioButton();
            this.txtLocationY = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemShowConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemSwitchScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemLockUnlock = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsole.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumScreenBorderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumScreenMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuConsole
            // 
            this.menuConsole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemScreen,
            this.MenuItemData,
            this.MenuItemSystem});
            this.menuConsole.Location = new System.Drawing.Point(0, 0);
            this.menuConsole.Name = "menuConsole";
            this.menuConsole.Size = new System.Drawing.Size(624, 24);
            this.menuConsole.TabIndex = 0;
            this.menuConsole.Visible = false;
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(59, 20);
            this.MenuItemFile.Text = "文件(&F)";
            // 
            // MenuItemScreen
            // 
            this.MenuItemScreen.Name = "MenuItemScreen";
            this.MenuItemScreen.Size = new System.Drawing.Size(59, 20);
            this.MenuItemScreen.Text = "屏幕(&S)";
            // 
            // MenuItemData
            // 
            this.MenuItemData.Name = "MenuItemData";
            this.MenuItemData.Size = new System.Drawing.Size(59, 20);
            this.MenuItemData.Text = "数据(&D)";
            // 
            // MenuItemSystem
            // 
            this.MenuItemSystem.Name = "MenuItemSystem";
            this.MenuItemSystem.Size = new System.Drawing.Size(59, 20);
            this.MenuItemSystem.Text = "系统(&S)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnConver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 139);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAEELEDPlayer.Properties.Resources.LOGO1;
            this.pictureBox1.Location = new System.Drawing.Point(543, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NumScreenBorderSize);
            this.groupBox1.Controls.Add(this.NumScreenMargin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericW);
            this.groupBox1.Controls.Add(this.numericH);
            this.groupBox1.Controls.Add(this.numericY);
            this.groupBox1.Controls.Add(this.numericX);
            this.groupBox1.Controls.Add(this.cbColorToScreen);
            this.groupBox1.Controls.Add(this.btnSetColor);
            this.groupBox1.Controls.Add(this.panelBorderColor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panelFontColor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panelBackColor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "屏幕设置";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "px";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "px";
            // 
            // NumScreenBorderSize
            // 
            this.NumScreenBorderSize.Location = new System.Drawing.Point(421, 41);
            this.NumScreenBorderSize.Name = "NumScreenBorderSize";
            this.NumScreenBorderSize.Size = new System.Drawing.Size(64, 21);
            this.NumScreenBorderSize.TabIndex = 12;
            this.NumScreenBorderSize.ValueChanged += new System.EventHandler(this.NumScreenBorderSize_ValueChanged);
            // 
            // NumScreenMargin
            // 
            this.NumScreenMargin.Location = new System.Drawing.Point(421, 14);
            this.NumScreenMargin.Name = "NumScreenMargin";
            this.NumScreenMargin.Size = new System.Drawing.Size(64, 21);
            this.NumScreenMargin.TabIndex = 12;
            this.NumScreenMargin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumScreenMargin.ValueChanged += new System.EventHandler(this.NumMargin_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "边框线条：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "边框颜色：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "屏幕边距：";
            // 
            // numericW
            // 
            this.numericW.Location = new System.Drawing.Point(63, 102);
            this.numericW.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericW.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericW.Name = "numericW";
            this.numericW.Size = new System.Drawing.Size(63, 21);
            this.numericW.TabIndex = 10;
            this.numericW.Value = new decimal(new int[] {
            1216,
            0,
            0,
            0});
            this.numericW.ValueChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // numericH
            // 
            this.numericH.Location = new System.Drawing.Point(63, 75);
            this.numericH.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericH.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(63, 21);
            this.numericH.TabIndex = 10;
            this.numericH.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericH.ValueChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(63, 48);
            this.numericY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(63, 21);
            this.numericY.TabIndex = 10;
            this.numericY.ValueChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(63, 21);
            this.numericX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(63, 21);
            this.numericX.TabIndex = 10;
            this.numericX.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericX.ValueChanged += new System.EventHandler(this.txtScreen_TextChanged);
            // 
            // cbColorToScreen
            // 
            this.cbColorToScreen.AutoSize = true;
            this.cbColorToScreen.Checked = true;
            this.cbColorToScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbColorToScreen.Location = new System.Drawing.Point(366, 114);
            this.cbColorToScreen.Name = "cbColorToScreen";
            this.cbColorToScreen.Size = new System.Drawing.Size(84, 16);
            this.cbColorToScreen.TabIndex = 9;
            this.cbColorToScreen.Text = "同步到屏幕";
            this.cbColorToScreen.UseVisualStyleBackColor = true;
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(456, 110);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor.TabIndex = 8;
            this.btnSetColor.Text = "设定";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // panelBorderColor
            // 
            this.panelBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBorderColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBorderColor.Location = new System.Drawing.Point(421, 68);
            this.panelBorderColor.Name = "panelBorderColor";
            this.panelBorderColor.Size = new System.Drawing.Size(87, 30);
            this.panelBorderColor.TabIndex = 6;
            this.panelBorderColor.Click += new System.EventHandler(this.panelBorderColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "文字颜色:";
            // 
            // panelFontColor
            // 
            this.panelFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFontColor.Location = new System.Drawing.Point(240, 60);
            this.panelFontColor.Name = "panelFontColor";
            this.panelFontColor.Size = new System.Drawing.Size(87, 30);
            this.panelFontColor.TabIndex = 6;
            this.panelFontColor.Click += new System.EventHandler(this.panelFontColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "屏幕背景色:";
            // 
            // panelBackColor
            // 
            this.panelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBackColor.Location = new System.Drawing.Point(240, 20);
            this.panelBackColor.Name = "panelBackColor";
            this.panelBackColor.Size = new System.Drawing.Size(87, 30);
            this.panelBackColor.TabIndex = 6;
            this.panelBackColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "px";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "px";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "宽(&W)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "高(&H)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "位置(&Y)：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "位置(&X)：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(542, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(542, 78);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(75, 23);
            this.btnConver.TabIndex = 8;
            this.btnConver.Text = "恢复修改";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Visible = false;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // btnScreenLock
            // 
            this.btnScreenLock.Location = new System.Drawing.Point(456, 17);
            this.btnScreenLock.Name = "btnScreenLock";
            this.btnScreenLock.Size = new System.Drawing.Size(75, 23);
            this.btnScreenLock.TabIndex = 3;
            this.btnScreenLock.Text = "锁定屏幕";
            this.btnScreenLock.UseVisualStyleBackColor = true;
            this.btnScreenLock.Click += new System.EventHandler(this.btnScreenLock_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.btnSettingScreen);
            this.panel2.Controls.Add(this.btnCloseScreen);
            this.panel2.Controls.Add(this.btnScreenLock);
            this.panel2.Controls.Add(this.cbCloseScreen);
            this.panel2.Controls.Add(this.rbScreen4);
            this.panel2.Controls.Add(this.rbScreen3);
            this.panel2.Controls.Add(this.rbScreen2);
            this.panel2.Controls.Add(this.rbScreen1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 59);
            this.panel2.TabIndex = 2;
            // 
            // btnSettingScreen
            // 
            this.btnSettingScreen.Location = new System.Drawing.Point(273, 17);
            this.btnSettingScreen.Name = "btnSettingScreen";
            this.btnSettingScreen.Size = new System.Drawing.Size(85, 23);
            this.btnSettingScreen.TabIndex = 3;
            this.btnSettingScreen.Text = "设置所选屏幕";
            this.btnSettingScreen.UseVisualStyleBackColor = true;
            this.btnSettingScreen.Click += new System.EventHandler(this.btnSettingScreen_Click);
            // 
            // btnCloseScreen
            // 
            this.btnCloseScreen.Location = new System.Drawing.Point(542, 17);
            this.btnCloseScreen.Name = "btnCloseScreen";
            this.btnCloseScreen.Size = new System.Drawing.Size(75, 23);
            this.btnCloseScreen.TabIndex = 3;
            this.btnCloseScreen.Text = "关闭屏幕";
            this.btnCloseScreen.UseVisualStyleBackColor = true;
            this.btnCloseScreen.Click += new System.EventHandler(this.btnCloseScreen_Click);
            // 
            // cbCloseScreen
            // 
            this.cbCloseScreen.AutoSize = true;
            this.cbCloseScreen.Location = new System.Drawing.Point(557, 26);
            this.cbCloseScreen.Name = "cbCloseScreen";
            this.cbCloseScreen.Size = new System.Drawing.Size(15, 14);
            this.cbCloseScreen.TabIndex = 10;
            this.cbCloseScreen.UseVisualStyleBackColor = true;
            // 
            // rbScreen4
            // 
            this.rbScreen4.AutoSize = true;
            this.rbScreen4.Location = new System.Drawing.Point(208, 20);
            this.rbScreen4.Name = "rbScreen4";
            this.rbScreen4.Size = new System.Drawing.Size(59, 16);
            this.rbScreen4.TabIndex = 1;
            this.rbScreen4.Text = "屏幕四";
            this.rbScreen4.UseVisualStyleBackColor = true;
            this.rbScreen4.Visible = false;
            this.rbScreen4.CheckedChanged += new System.EventHandler(this.rbScreen_CheckedChanged);
            // 
            // rbScreen3
            // 
            this.rbScreen3.AutoSize = true;
            this.rbScreen3.Location = new System.Drawing.Point(143, 20);
            this.rbScreen3.Name = "rbScreen3";
            this.rbScreen3.Size = new System.Drawing.Size(59, 16);
            this.rbScreen3.TabIndex = 1;
            this.rbScreen3.Text = "屏幕三";
            this.rbScreen3.UseVisualStyleBackColor = true;
            this.rbScreen3.Visible = false;
            this.rbScreen3.CheckedChanged += new System.EventHandler(this.rbScreen_CheckedChanged);
            // 
            // rbScreen2
            // 
            this.rbScreen2.AutoSize = true;
            this.rbScreen2.Location = new System.Drawing.Point(81, 20);
            this.rbScreen2.Name = "rbScreen2";
            this.rbScreen2.Size = new System.Drawing.Size(59, 16);
            this.rbScreen2.TabIndex = 1;
            this.rbScreen2.Text = "屏幕二";
            this.rbScreen2.UseVisualStyleBackColor = true;
            this.rbScreen2.CheckedChanged += new System.EventHandler(this.rbScreen_CheckedChanged);
            // 
            // rbScreen1
            // 
            this.rbScreen1.AutoSize = true;
            this.rbScreen1.Checked = true;
            this.rbScreen1.Location = new System.Drawing.Point(16, 20);
            this.rbScreen1.Name = "rbScreen1";
            this.rbScreen1.Size = new System.Drawing.Size(59, 16);
            this.rbScreen1.TabIndex = 1;
            this.rbScreen1.TabStop = true;
            this.rbScreen1.Text = "屏幕一";
            this.rbScreen1.UseVisualStyleBackColor = true;
            this.rbScreen1.CheckedChanged += new System.EventHandler(this.rbScreen_CheckedChanged);
            // 
            // txtLocationY
            // 
            this.txtLocationY.Location = new System.Drawing.Point(68, 48);
            this.txtLocationY.Name = "txtLocationY";
            this.txtLocationY.Size = new System.Drawing.Size(67, 21);
            this.txtLocationY.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 21);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 21);
            this.textBox4.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LED显示客户端";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemShowConsole,
            this.contextMenuItemSwitchScreen,
            this.contextMenuItemLockUnlock,
            this.contextMenuItemExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(131, 92);
            // 
            // contextMenuItemShowConsole
            // 
            this.contextMenuItemShowConsole.Name = "contextMenuItemShowConsole";
            this.contextMenuItemShowConsole.Size = new System.Drawing.Size(130, 22);
            this.contextMenuItemShowConsole.Text = "显示控制台";
            this.contextMenuItemShowConsole.Click += new System.EventHandler(this.contextMenuItemShowConsole_Click);
            // 
            // contextMenuItemSwitchScreen
            // 
            this.contextMenuItemSwitchScreen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.contextMenuItemSwitchScreen.Name = "contextMenuItemSwitchScreen";
            this.contextMenuItemSwitchScreen.Size = new System.Drawing.Size(130, 22);
            this.contextMenuItemSwitchScreen.Text = "切换屏幕";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem1.Tag = "1";
            this.toolStripMenuItem1.Text = "屏幕一";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem5.Tag = "2";
            this.toolStripMenuItem5.Text = "屏幕二";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem6.Tag = "3";
            this.toolStripMenuItem6.Text = "屏幕三";
            this.toolStripMenuItem6.Visible = false;
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem7.Tag = "4";
            this.toolStripMenuItem7.Text = "屏幕四";
            this.toolStripMenuItem7.Visible = false;
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuItemLockUnlock
            // 
            this.contextMenuItemLockUnlock.Name = "contextMenuItemLockUnlock";
            this.contextMenuItemLockUnlock.Size = new System.Drawing.Size(130, 22);
            this.contextMenuItemLockUnlock.Text = "锁定/解锁";
            this.contextMenuItemLockUnlock.Click += new System.EventHandler(this.btnScreenLock_Click);
            // 
            // contextMenuItemExit
            // 
            this.contextMenuItemExit.Name = "contextMenuItemExit";
            this.contextMenuItemExit.Size = new System.Drawing.Size(130, 22);
            this.contextMenuItemExit.Text = "退出系统";
            this.contextMenuItemExit.Click += new System.EventHandler(this.contextMenuItemExit_Click);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 198);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuConsole;
            this.MaximizeBox = false;
            this.Name = "frmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LED控制台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsole_FormClosing);
            this.menuConsole.ResumeLayout(false);
            this.menuConsole.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumScreenBorderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumScreenMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuConsole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocationY;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnScreenLock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.CheckBox cbColorToScreen;
        private System.Windows.Forms.RadioButton rbScreen2;
        private System.Windows.Forms.RadioButton rbScreen1;
        private System.Windows.Forms.Button btnSettingScreen;
        private System.Windows.Forms.Button btnCloseScreen;
        private System.Windows.Forms.RadioButton rbScreen4;
        private System.Windows.Forms.RadioButton rbScreen3;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemScreen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSystem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemShowConsole;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSwitchScreen;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemLockUnlock;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.CheckBox cbCloseScreen;
        public System.Windows.Forms.NumericUpDown numericW;
        public System.Windows.Forms.NumericUpDown numericH;
        public System.Windows.Forms.NumericUpDown numericY;
        public System.Windows.Forms.NumericUpDown numericX;
        public System.Windows.Forms.Panel panelBorderColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConver;
        public System.Windows.Forms.NumericUpDown NumScreenMargin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel panelBackColor;
        public System.Windows.Forms.Panel panelFontColor;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown NumScreenBorderSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}