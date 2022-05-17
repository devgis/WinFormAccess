using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CAEELEDPlayer.Common;
using CAEELEDPlayer.ExControls;

namespace CAEELEDPlayer
{
    public partial class frmConsole : Form
    {
        private FormControl fc = FormControl.CreateInstance();
        private int x = 0, y = 0;

        public frmConsole()
        {
            InitializeComponent();
            x = Screen.PrimaryScreen.WorkingArea.Size.Width - Width;
            y = Screen.PrimaryScreen.WorkingArea.Size.Height - Height;
            SetDesktopLocation(x, y);


            numericX.Value = fc.CurrentScreen.Location.X;
            numericY.Value = fc.CurrentScreen.Location.Y;
            numericH.Value = fc.CurrentScreen.Height;
            numericW.Value = fc.CurrentScreen.Width;
            

        }

        private void btnScreenLock_Click(object sender, EventArgs e)
        {
            if (fc.CurrentScreen.TopMost)
            {
                groupBox1.Enabled = true;
                btnCloseScreen.Enabled = true;
                fc.CurrentScreen.TopMost = false;
                btnSettingScreen.Enabled = true;
                btnSave.Enabled = true;
                btnConver.Enabled = true;
                btnScreenLock.Text = "Ëø¶¨ÆÁÄ»";
            }
            else
            {
                groupBox1.Enabled = false;
                btnCloseScreen.Enabled = false;
                fc.CurrentScreen.TopMost = true;
                btnSettingScreen.Enabled = false;
                btnSave.Enabled = false;
                btnConver.Enabled = false;
                btnScreenLock.Text = "½âËøÆÁÄ»";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fc.CurrentScreen.Location = new Point((int)numericX.Value, (int)numericY.Value);
            fc.CurrentScreen.Height = (int)numericH.Value;
            fc.CurrentScreen.Width = (int)numericW.Value;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            MyColorDialog cd = new MyColorDialog(x, y, 0, 0);
            cd.FullOpen = true;
            cd.AnyColor = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelBackColor.BackColor = cd.Color;
                if (cbColorToScreen.Checked)
                {
                    SetScreenBackColor(cd.Color);
                }
            }
        }
        
        private void SetScreenBackColor(Color cd)
        {
            fc.CurrentScreen.BackColor = cd;
            if (fc.CurrentScreen == fc.FScreen1)
            {
                fc.FScreen1.GridViewDate.BackgroundColor = cd;
                fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor = cd;
                fc.FScreen1.GridViewDate.RowsDefaultCellStyle.BackColor = cd;
            }
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                fc.FScreen2.GVBiddingCustomerInfo.BackgroundColor = cd;
                fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = cd;
                fc.FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.BackColor = cd;
                fc.FScreen2.GVBiddingInfo.BackgroundColor = cd;
                fc.FScreen2.GVBiddingInfo.ColumnHeadersDefaultCellStyle.BackColor = cd;
                fc.FScreen2.GVBiddingInfo.RowsDefaultCellStyle.BackColor = cd;

                fc.FScreen2.clockControl1.BackColor = cd;
                fc.FScreen2.clockControls1.BackColor = cd;
                fc.FScreen2.panelEx2.BackColor = cd;
                fc.FScreen2.panelBaseHead.BackColor = cd;
                fc.FScreen2.panelBaseContent.BackColor = cd;
                fc.FScreen2.lblHeadBase.BackColor = cd;
                fc.FScreen2.lbl_CurrentTime.BackColor = cd;
                fc.FScreen2.LblTimeDown.BackColor = cd;
                fc.FScreen2.panelContent.BackColor = cd;
                fc.FScreen2.scrollingTextAffiche.BackColor =cd;
                fc.FScreen2.panelBottom.BackColor = cd;
                fc.FScreen2.ledClockControls1.BackColor = cd;
                
                if (fc.FScreen2.GVBiddingInfo.Rows.Count >0)
                {
                    for(int i=0;i<fc.FScreen2.GVBiddingInfo.ColumnCount;i++)
                    {
                        foreach (DataGridViewRow row in fc.FScreen2.GVBiddingInfo.Rows)
                        {
                            row.Cells[i].Style.BackColor = cd;
                        }
                    }
                }
            }
            else if (fc.CurrentScreen == fc.FScreen3)
            {

            }
            else if (fc.CurrentScreen == fc.FScreen4)
            {

            }
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {
            if (cbColorToScreen.Checked)
            {
                try
                {
                    if (numericX.Value.ToString() != string.Empty && numericY.Value.ToString() != string.Empty)
                        fc.CurrentScreen.Location = new Point((int)numericX.Value, (int)numericY.Value);
                    if (numericH.Value.ToString() != string.Empty)
                        fc.CurrentScreen.Height = (int)numericH.Value;
                    if (numericW.Value.ToString() != string.Empty)
                        fc.CurrentScreen.Width = (int)numericW.Value;

                    NumMargin_ValueChanged(sender, e);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return;
                }
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericX.Value.ToString() != string.Empty && numericY.Value.ToString() != string.Empty)
                    fc.CurrentScreen.Location = new Point((int)numericX.Value, (int)numericY.Value);
                if (numericH.Value.ToString() != string.Empty)
                    fc.CurrentScreen.Height = (int)numericH.Value;
                if (numericW.Value.ToString() != string.Empty)
                    fc.CurrentScreen.Width = (int)numericW.Value;

                NumMargin_ValueChanged(sender, e);
                NumScreenBorderSize_ValueChanged(sender, e);
                SetScreenBackColor(panelBackColor.BackColor);
                SetScreenFontColor(panelFontColor.BackColor);
                SetScreenBorderColor(panelBorderColor.BackColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return;
            }
        }

        private void btnCloseScreen_Click(object sender, EventArgs e)
        {
            if (cbCloseScreen.Checked)
            {
                btnScreenLock.Enabled = true;
                cbCloseScreen.Checked = false;
                fc.CurrentScreen.Show();
                btnCloseScreen.Text = "¹Ø±ÕÆÁÄ»";
            }
            else
            {
                btnScreenLock.Enabled = false;
                cbCloseScreen.Checked = true;
                btnCloseScreen.Text = "ÏÔÊ¾ÆÁÄ»";
                fc.CurrentScreen.Hide();
            }
        }

        private void btnSettingScreen_Click(object sender, EventArgs e)
        {
            if (rbScreen1.Checked)
            {
                fc.FSetting.Init();
                //fc.FSetting.tabSettings.SelectedIndex = 0;
            }
            if (rbScreen2.Checked)
            {
                fc.FSetting.Init();
                //fc.FSetting.tabSettings.SelectedIndex = 1;
            }
            if (rbScreen3.Checked)
            {
                fc.FSetting.Init();
                //fc.FSetting.tabSettings.SelectedIndex = 2;
            }
            if (rbScreen4.Checked)
            {
                fc.FSetting.Init();
                //fc.FSetting.tabSettings.SelectedIndex = 3;
            }
            fc.ShowSettings(fc.FSetting.tabSettings.SelectedIndex);
            fc.FSetting.Activate();
        }


        private delegate void SetShowScrenCallback(string str);
        private void SetShowScreen(string strScreenID)
        {
            if (fc.FConsole.InvokeRequired)
            {
                SetShowScrenCallback d = new SetShowScrenCallback(SetShowScreen);
                this.Invoke(d, new object[] { strScreenID });
            }
            else
            {
                switch (strScreenID)
                {
                    case "1" :
                        rbScreen1.Checked = true;
                        fc.ShowScreen(1);
                        break;
                    case "2":
                        rbScreen2.Checked = true;
                        fc.ShowScreen(2);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            }
        }
        
        /// <summary>
        /// ÆÁÄ»ÇÐ»»
        /// </summary>
        /// <param name="index"></param>
        public void TabScreen(string index)
        {
            SetShowScreen(index);
        }

        private void rbScreen_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton) sender);
            if (!rb.Checked) return;
            //if (fc.CurrentScreen == fc.FScreen2 && fc.FScreen2.frmChBuy != null)
            //    fc.FScreen2.frmChBuy.Close();
            string sname = rb.Name;
            switch (sname)
            {
                case "rbScreen1":
                    fc.ShowScreen(1);
                    break;
                case "rbScreen2":
                    fc.ShowScreen(2);
                    break;
                case "rbScreen3":
                    fc.ShowScreen(3);
                    break;
                case "rbScreen4":
                    fc.ShowScreen(4);
                    break;
                default:
                    fc.ShowScreen(1);
                    break;
            }
            numericX.ValueChanged -= txtScreen_TextChanged;
            numericY.ValueChanged -= txtScreen_TextChanged;
            numericH.ValueChanged -= txtScreen_TextChanged;
            numericW.ValueChanged -= txtScreen_TextChanged;

            numericX.Value = fc.CurrentScreen.Location.X;
            numericY.Value = fc.CurrentScreen.Location.Y;
            numericH.Value = fc.CurrentScreen.Height;
            numericW.Value = fc.CurrentScreen.Width;

            numericX.ValueChanged += txtScreen_TextChanged;
            numericY.ValueChanged += txtScreen_TextChanged;
            numericH.ValueChanged += txtScreen_TextChanged;
            numericW.ValueChanged += txtScreen_TextChanged;
        }

        private void contextMenuItemShowConsole_Click(object sender, EventArgs e)
        {
            fc.FConsole.Show();
            fc.FConsole.ShowInTaskbar = true;
            fc.FConsole.WindowState = FormWindowState.Normal;
            fc.FConsole.Activate();
        }

        private void contextMenuItemExit_Click(object sender, EventArgs e)
        {
            fc.Exit();
        }

        private void frmConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            fc.FConsole.Hide();
            fc.FConsole.ShowInTaskbar = false;
            fc.FConsole.notifyIcon.Visible = true;
            e.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itme = (ToolStripMenuItem)sender;
            switch (itme.Tag.ToString())
            {
                case "1":
                    //fc.ShowScreen(1);
                    rbScreen1.Checked = true;
                    break;
                case "2":
                    //fc.ShowScreen(2);
                    rbScreen2.Checked = true;
                    break;
                case "3":
                    //fc.ShowScreen(3);
                    rbScreen3.Checked = true;
                    break;
                case "4":
                    //fc.ShowScreen(4);
                    rbScreen4.Checked = true;
                    break;
                default:
                    //fc.ShowScreen(1);
                    rbScreen1.Checked = true;
                    break;
            }
        }

        private void panelFontColor_Click(object sender, EventArgs e)
        {
            MyColorDialog cd = new MyColorDialog(x, y, 0, 0);
            cd.FullOpen = true;
            cd.AnyColor = true;

            
            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelFontColor.BackColor = cd.Color;
                if (cbColorToScreen.Checked)
                {
                    SetScreenFontColor(cd.Color);
                }
            }
        }
        
        private void SetScreenFontColor(Color cd)
        {
            if (fc.CurrentScreen == fc.FScreen1)
            {
                fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor = cd;
                fc.FScreen1.GridViewDate.ForeColor = cd;
                fc.FScreen1.lblTitle.ForeColor = cd;
                fc.FScreen1.lbl_CurrentTime.ForeColor = cd;
                fc.FScreen1.scrollingTextAffiche.ForeColor = cd;

            }
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor = cd;
                fc.FScreen2.GVBiddingCustomerInfo.ForeColor = cd;
                fc.FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.ForeColor = cd;
                fc.FScreen2.GVBiddingInfo.ColumnHeadersDefaultCellStyle.ForeColor = cd;
                fc.FScreen2.GVBiddingInfo.RowsDefaultCellStyle.ForeColor = cd;
                fc.FScreen2.GVBiddingInfo.ForeColor = cd;
                fc.FScreen2.ledClockControls1.ClockColor = cd;
                fc.FScreen2.clockControls1.ClockColor = cd;
                fc.FScreen2.lblHeadBase.ForeColor = cd;
                fc.FScreen2.lbl_CurrentTime.ForeColor = cd;
                fc.FScreen2.LblTimeDown.ForeColor = cd;

                if (fc.FScreen2.GVBiddingInfo.Rows.Count > 0)
                {
                    for (int i = 0; i < fc.FScreen2.GVBiddingInfo.ColumnCount; i++)
                    {
                        foreach (DataGridViewRow row in fc.FScreen2.GVBiddingInfo.Rows)
                        {
                            row.Cells[i].Style.ForeColor = cd;
                        }
                    }
                }
            }
            else if (fc.CurrentScreen == fc.FScreen3)
            {

            }
            else if (fc.CurrentScreen == fc.FScreen4)
            {

            }
            fc.CurrentScreen.ForeColor = cd;
        }

        private void panelBorderColor_Click(object sender, EventArgs e)
        {

            MyColorDialog cd = new MyColorDialog(x, y, 0, 0);
            cd.FullOpen = true;
            cd.AnyColor = true;
            //cd.Color = fc.FScreen1.GridViewDate.GridColor;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                panelBorderColor.BackColor = cd.Color;
                if (cbColorToScreen.Checked)
                {
                    SetScreenBorderColor(cd.Color);
                }
            }
            
        }
        
        private void SetScreenBorderColor(Color cd)
        {
            if (fc.CurrentScreen == fc.FScreen1)
            {
                //fc.FScreen1.GridViewDate.GridColor = cd.Color;
                //fc.FScreen1.panelContent.BorderColor = cd.Color;
                fc.FScreen1.panelMain.BorderColor = cd;
            }
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                fc.FScreen2.panelMain.BorderColor = cd;
            }
            else if (fc.CurrentScreen == fc.FScreen3)
            {
                fc.FScreen3.panelMain.BorderColor = cd;
            }
            else if (fc.CurrentScreen == fc.FScreen4)
            {
                fc.FScreen4.panelMain.BorderColor = cd;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fc.SaveCommonDefault(false);
            if (fc.CurrentScreen == fc.FScreen1)
                fc.SaveScreen1Default(true);
            else if (fc.CurrentScreen == fc.FScreen2)
                fc.SaveScreen2Default(true);
            else if (fc.CurrentScreen == fc.FScreen3)
                return;
            else if (fc.CurrentScreen == fc.FScreen4)
                return;
        }

        private void btnConver_Click(object sender, EventArgs e)
        {

            if (rbScreen1.Checked)
                fc.InitScreen1();

            if (rbScreen2.Checked)
                fc.InitScreen2();

            if (rbScreen3.Checked)
                fc.InitScreen3();

            if (rbScreen4.Checked)
                fc.InitScreen4();
        }

        private void NumMargin_ValueChanged(object sender, EventArgs e)
        {
            if (cbColorToScreen.Checked)
            {
                if (NumScreenMargin.Value > 0)
                {
                    if (fc.CurrentScreen == fc.FScreen1)
                    {
                        fc.FScreen1.panelMain.Dock = DockStyle.None;
                        fc.FScreen1.panelMain.Width = (int)(fc.FScreen1.Width - NumScreenMargin.Value * 2);
                        fc.FScreen1.panelMain.Height = (int)(fc.FScreen1.Height - NumScreenMargin.Value * 2);

                        //fc.FScreen1.panelMain.Margin = new Padding((int)NumScreenMargin.Value, (int)NumScreenMargin.Value,
                        //                                           (int)NumScreenMargin.Value, (int)NumScreenMargin.Value);
                        fc.FScreen1.panelMain.Location =
                            new Point((int)NumScreenMargin.Value,
                                      (int)NumScreenMargin.Value);
                    }
                    else if (fc.CurrentScreen == fc.FScreen2)
                    {
                        fc.FScreen2.panelMain.Dock = DockStyle.None;
                        fc.FScreen2.panelMain.Width = (int) (fc.FScreen2.Width - NumScreenMargin.Value*2);
                        fc.FScreen2.panelMain.Height = (int) (fc.FScreen2.Height - NumScreenMargin.Value*2);
                        fc.FScreen2.panelMain.Location =
                            new Point((int) NumScreenMargin.Value, (int) NumScreenMargin.Value);
                    }
                    else if (fc.CurrentScreen == fc.FScreen3)
                    {
                        fc.FScreen3.panelMain.Dock = DockStyle.None;
                        fc.FScreen3.panelMain.Width = (int)(fc.FScreen3.Width - NumScreenMargin.Value * 2);
                        fc.FScreen3.panelMain.Height = (int)(fc.FScreen3.Height - NumScreenMargin.Value * 2);
                        fc.FScreen3.panelMain.Location =
                            new Point((int)NumScreenMargin.Value, (int)NumScreenMargin.Value);
                    }
                    else if (fc.CurrentScreen == fc.FScreen4)
                    {
                        fc.FScreen4.panelMain.Dock = DockStyle.None;
                        fc.FScreen4.panelMain.Width = (int)(fc.FScreen4.Width - NumScreenMargin.Value * 2);
                        fc.FScreen4.panelMain.Height = (int)(fc.FScreen4.Height - NumScreenMargin.Value * 2);
                        fc.FScreen4.panelMain.Location =
                            new Point((int)NumScreenMargin.Value, (int)NumScreenMargin.Value);
                    }
                }
                else
                {
                    if (fc.CurrentScreen == fc.FScreen1)
                    {
                        fc.FScreen1.panelMain.Dock = DockStyle.Fill;
                    }
                    else if (fc.CurrentScreen == fc.FScreen2)
                    {
                        fc.FScreen2.panelMain.Dock = DockStyle.Fill;
                    }
                    else if (fc.CurrentScreen == fc.FScreen3)
                    {
                        fc.FScreen2.panelMain.Dock = DockStyle.Fill;
                    }
                    else if (fc.CurrentScreen == fc.FScreen4)
                    {
                        fc.FScreen2.panelMain.Dock = DockStyle.Fill;
                    }
                }
            }
        }

        private void NumScreenBorderSize_ValueChanged(object sender, EventArgs e)
        {
            if (cbColorToScreen.Checked)
            {
                if (NumScreenBorderSize.Value > 0)
                {
                    if (fc.CurrentScreen == fc.FScreen1)
                    {
                        fc.FScreen1.panelMain.BorderStyle = BorderStyle.FixedSingle;
                        fc.FScreen1.panelMain.BorderWidth = (int)NumScreenBorderSize.Value;
                    }
                    else if (fc.CurrentScreen == fc.FScreen2)
                    {
                        fc.FScreen2.panelMain.BorderStyle = BorderStyle.FixedSingle;
                        fc.FScreen2.panelMain.BorderWidth = (int) NumScreenBorderSize.Value;
                    }
                    else if (fc.CurrentScreen == fc.FScreen3)
                    {
                        fc.FScreen3.panelMain.BorderStyle = BorderStyle.FixedSingle;
                        fc.FScreen3.panelMain.BorderWidth = (int)NumScreenBorderSize.Value;
                    }
                    else if (fc.CurrentScreen == fc.FScreen4)
                    {
                        fc.FScreen4.panelMain.BorderStyle = BorderStyle.FixedSingle;
                        fc.FScreen4.panelMain.BorderWidth = (int)NumScreenBorderSize.Value;
                    }
                }
                else
                {
                    if (fc.CurrentScreen == fc.FScreen1)
                    {
                        fc.FScreen1.panelMain.BorderStyle = BorderStyle.None;
                    }
                    else if (fc.CurrentScreen == fc.FScreen2)
                    {
                        fc.FScreen2.panelMain.BorderStyle = BorderStyle.None;
                    }
                    else if (fc.CurrentScreen == fc.FScreen3)
                    {
                        fc.FScreen3.panelMain.BorderStyle = BorderStyle.None;
                    }
                    else if (fc.CurrentScreen == fc.FScreen4)
                    {
                        fc.FScreen4.panelMain.BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (fc.CurrentScreen.Tag == null || fc.CurrentScreen.Tag.ToString() != "1")
                {
                    fc.CurrentScreen.Tag = "1";
                    fc.CurrentScreen.Activate();
                    fc.CurrentScreen.Show();

                    fc.FConsole.Tag = "1";
                    //fc.FConsole.WindowState = 
                    fc.FConsole.Activate();
                    fc.FConsole.Show();
                }
                else
                {
                    fc.CurrentScreen.Tag = "0";
                    fc.CurrentScreen.Hide();

                    fc.FConsole.Tag = "0";
                    fc.FConsole.Hide();
                }
        }
    }
}