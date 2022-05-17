using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAEELEDPlayer.Common;

using CAEELEDPlayer.ExControls;
using ScrollingTextControl;

namespace CAEELEDPlayer
{
    public partial class frmScreenSetting : Form
    {
        private FormControl fc = FormControl.CreateInstance();
        NumericUpDown[] numArr;
        private int x = 0, y = 0;

        public frmScreenSetting()
        {
            InitializeComponent();
            x = Screen.PrimaryScreen.WorkingArea.Size.Width - Width;
            y = Screen.PrimaryScreen.WorkingArea.Size.Height - Height;
            SetDesktopLocation(x, y);
        }

        public void Init()
        {
            numArr = null;

            if (tabSettings.TabPages.Contains(CaeeLED_NoticesSetting))
                tabSettings.TabPages.Remove(CaeeLED_NoticesSetting);
            //title
            if (fc.CurrentScreen == fc.FScreen1)
            {
                if (!tabSettings.TabPages.Contains(tabScreen1))
                    tabSettings.TabPages.Add(tabScreen1);
                if (tabSettings.TabPages.Contains(tabScreen2))
                    tabSettings.TabPages.Remove(tabScreen2);
                if (tabSettings.TabPages.Contains(tabScreen3))
                    tabSettings.TabPages.Remove(tabScreen3);
                if (tabSettings.TabPages.Contains(tabScreen4))
                    tabSettings.TabPages.Remove(tabScreen4);
                if (!tabSettings.TabPages.Contains(CaeeLED_NoticesSetting))
                    tabSettings.TabPages.Add(CaeeLED_NoticesSetting);

                txtTitle.Text = fc.FScreen1.lblTitle.Text;
                txtTitle.Font = fc.FScreen1.lblTitle.Font;
                txtTitle.ForeColor = fc.FScreen1.lblTitle.ForeColor;
                btnTitleFont.Font = fc.FScreen1.lblTitle.Font;
                btnTitleFont.ForeColor = fc.FScreen1.lblTitle.ForeColor;
                numTitleX.Value = fc.FScreen1.lblTitle.Location.X;
                numTitleY.Value = fc.FScreen1.lblTitle.Location.Y;

                btnTimeSetting.Font = fc.FScreen1.lbl_CurrentTime.Font;
                btnTimeSetting.ForeColor = fc.FScreen1.lbl_CurrentTime.ForeColor;
                numTimeLocationX.Value = fc.FScreen1.lbl_CurrentTime.Location.X;
                numTimeLocationY.Value = fc.FScreen1.lbl_CurrentTime.Location.Y;
                numericTitleHeight.Value = fc.FScreen1.panelTitle.Height;

                //content
                btnTableHeaderFont.Font = fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.Font;
                btnTableHeaderFont.ForeColor = fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor;
                btnLinColor.BackColor = fc.FScreen1.GridViewDate.GridColor;
                btnTableHeaderBackColor.BackColor = fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor;
                btnTableContentFont.Font = fc.FScreen1.GridViewDate.Font;
                btnTableContentFont.ForeColor = fc.FScreen1.GridViewDate.ForeColor;

                numericPageSpeed.Value = (fc.FScreen1.timer.Interval / 1000);
                numericPageSize.Value = fc.FScreen1.PageSize;
                numericRowHeight.Value = fc.FScreen1.RowHeight;
                numericHeaderHeight.Value = fc.FScreen1.GridViewDate.ColumnHeadersHeight;
                ckboxAutoColWidth.Checked = (fc.FScreen1.GridViewDate.AutoSizeColumnsMode ==
                                             DataGridViewAutoSizeColumnsMode.Fill);
                numericBorderSize.Value = fc.FScreen1.TableBorderSize;
                switch (fc.FScreen1.TableBorderStyle)
                {
                    case frmLEDScreen1.TableBorderType.None:
                        rbBorderNone.Checked = true;
                        break;
                    case frmLEDScreen1.TableBorderType.FixedSingle:
                        rbBorderFixedSingle.Checked = true;
                        break;
                    case frmLEDScreen1.TableBorderType.FixedDouble:
                        rbBorderFixedDouble.Checked = true;
                        break;

                }
                

                btnAfficheFont.Font = fc.FScreen1.scrollingTextAffiche.Font;
                btnAfficheFont.ForeColor = fc.FScreen1.scrollingTextAffiche.ForeColor;
                txtAffiche.Text = fc.FScreen1.scrollingTextAffiche.ScrollText;
                txtAffiche.Font = fc.FScreen1.scrollingTextAffiche.Font;
                txtAffiche.ForeColor = fc.FScreen1.scrollingTextAffiche.ForeColor;
                numericAfficheHeight.Value = fc.FScreen1.panelBottom.Height;

                cmbScollDirection.SelectedIndex = (int) fc.FScreen1.scrollingTextAffiche.ScrollDirection;
                numSpend.Value = fc.FScreen1.scrollingTextAffiche.TextScrollSpeed;
                initCol();
                //initCol(fc.FScreen1.GridViewDate,flowLayoutPanel);
            }
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                if (!tabSettings.TabPages.Contains(tabScreen2))
                    tabSettings.TabPages.Add(tabScreen2);
                if (tabSettings.TabPages.Contains(tabScreen1))
                    tabSettings.TabPages.Remove(tabScreen1);
                if (tabSettings.TabPages.Contains(tabScreen3))
                    tabSettings.TabPages.Remove(tabScreen3);
                if (tabSettings.TabPages.Contains(tabScreen4))
                    tabSettings.TabPages.Remove(tabScreen4);
                if (!tabSettings.TabPages.Contains(CaeeLED_NoticesSetting))
                    tabSettings.TabPages.Add(CaeeLED_NoticesSetting);

                InitS2();

            }
            else if (fc.CurrentScreen == fc.FScreen3)
            {
                if (!tabSettings.TabPages.Contains(tabScreen3))
                    tabSettings.TabPages.Add(tabScreen3);
                if (tabSettings.TabPages.Contains(tabScreen1))
                    tabSettings.TabPages.Remove(tabScreen1);
                if (tabSettings.TabPages.Contains(tabScreen2))
                    tabSettings.TabPages.Remove(tabScreen2);
                if (tabSettings.TabPages.Contains(tabScreen4))
                    tabSettings.TabPages.Remove(tabScreen4);

                cmbScollDirection.SelectedIndex = (int)fc.FScreen3.scrollingTextAffiche.ScrollDirection;
                numSpend.Value = fc.FScreen3.scrollingTextAffiche.TextScrollSpeed;
            }
            else if (fc.CurrentScreen == fc.FScreen4)
            {
                if (!tabSettings.TabPages.Contains(tabScreen4))
                    tabSettings.TabPages.Add(tabScreen4);
                if (tabSettings.TabPages.Contains(tabScreen1))
                    tabSettings.TabPages.Remove(tabScreen1);
                if (tabSettings.TabPages.Contains(tabScreen2))
                    tabSettings.TabPages.Remove(tabScreen2);
                if (tabSettings.TabPages.Contains(tabScreen3))
                    tabSettings.TabPages.Remove(tabScreen3);

                cmbScollDirection.SelectedIndex = (int)fc.FScreen4.scrollingTextAffiche.ScrollDirection;
                numSpend.Value = fc.FScreen4.scrollingTextAffiche.TextScrollSpeed;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (fc.CurrentScreen == fc.FScreen1)
                fc.FScreen1.GridViewDate.Columns[cb.Tag.ToString()].Visible = cb.Checked;
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                if (rdbDetail.Checked)
                    fc.FScreen2.GVBiddingCustomerInfo.Columns[cb.Tag.ToString()].Visible = cb.Checked;
            }
        }


        private void btnAfficheFont_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnAfficheFont))
            {
                txtAffiche.Font = btnAfficheFont.Font;
                txtAffiche.ForeColor = btnAfficheFont.ForeColor;
            }
        }

        private void btnSetAffiche_Click(object sender, EventArgs e)
        {
            if (fc.CurrentScreen == fc.FScreen1)
                SetAffiche(fc.FScreen1.scrollingTextAffiche);
            else if (fc.CurrentScreen == fc.FScreen2)
                SetAffiche(fc.FScreen2.scrollingTextAffiche);
            else if (fc.CurrentScreen == fc.FScreen3)
                SetAffiche(fc.FScreen3.scrollingTextAffiche);
            else if (fc.CurrentScreen == fc.FScreen4)
                SetAffiche(fc.FScreen4.scrollingTextAffiche);
        }

        private void numericAfficheHeight_ValueChanged(object sender, EventArgs e)
        {
            if (fc.CurrentScreen == fc.FScreen1)
                fc.FScreen1.panelBottom.Height = (int)numericAfficheHeight.Value;
            else if (fc.CurrentScreen == fc.FScreen2)
                fc.FScreen2.panelBottom.Height = (int)numericAfficheHeight.Value;
            else if (fc.CurrentScreen == fc.FScreen3)
                fc.FScreen3.panelBottom.Height = (int)numericAfficheHeight.Value;
            else if (fc.CurrentScreen == fc.FScreen4)
                fc.FScreen4.panelBottom.Height = (int)numericAfficheHeight.Value;
        }

        private void frmScreenSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            fc.FSetting.Hide();
            e.Cancel = true;
        }

        private void numSpend_ValueChanged(object sender, EventArgs e)
        {
            if (fc.CurrentScreen == fc.FScreen1)
                fc.FScreen1.scrollingTextAffiche.TextScrollSpeed = (int) numSpend.Value;
            else if (fc.CurrentScreen == fc.FScreen2)
                fc.FScreen2.scrollingTextAffiche.TextScrollSpeed = (int)numSpend.Value;
            else if (fc.CurrentScreen == fc.FScreen3)
                fc.FScreen3.scrollingTextAffiche.TextScrollSpeed = (int)numSpend.Value;
            else if (fc.CurrentScreen == fc.FScreen4)
                fc.FScreen4.scrollingTextAffiche.TextScrollSpeed = (int)numSpend.Value;
        }

        private void cmbScollDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbScollDirection.SelectedIndex <0)
                return;
            ScrollDirection sdType = new ScrollDirection();
            if (cmbScollDirection.SelectedIndex == 0)
                sdType = ScrollDirection.RightToLeft;
            else if (cmbScollDirection.SelectedIndex == 1)
                sdType = ScrollDirection.LeftToRight;
            else if (cmbScollDirection.SelectedIndex == 2)
                sdType = ScrollDirection.Bouncing;
            else
                sdType = ScrollDirection.RightToLeft;
            
            if (fc.CurrentScreen == fc.FScreen1)
                fc.FScreen1.scrollingTextAffiche.ScrollDirection = sdType;
            else if (fc.CurrentScreen == fc.FScreen2)
                fc.FScreen2.scrollingTextAffiche.ScrollDirection = sdType;
            else if (fc.CurrentScreen == fc.FScreen3)
                fc.FScreen3.scrollingTextAffiche.ScrollDirection = sdType;
            else if (fc.CurrentScreen == fc.FScreen4)
                fc.FScreen4.scrollingTextAffiche.ScrollDirection = sdType;
        }

        #region 窗体1事件

        private void button1_Click(object sender, EventArgs e)
        {
            MyFontDialog fd = new MyFontDialog(x + 10, y, 0, 0);
            fd.ShowApply = true;
            fd.ShowColor = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;

            fd.Font = txtTitle.Font;
            fd.Color = txtTitle.ForeColor;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtTitle.Font = fd.Font;
                txtTitle.ForeColor = fd.Color;
            }
        }
        
        private void btnTitleOK_Click(object sender, EventArgs e)
        {
            fc.FScreen1.lblTitle.Text = txtTitle.Text;
            fc.FScreen1.lblTitle.Font = txtTitle.Font;
            fc.FScreen1.lblTitle.ForeColor = txtTitle.ForeColor;
            
            /*
            fc.FScreen1.lblTitle.Location =
                new Point(
                    (fc.FScreen1.panelTitle.Location.X + fc.FScreen1.panelTitle.Width - fc.FScreen1.lblTitle.Width) / 2,
                    (fc.FScreen1.panelTitle.Location.Y + fc.FScreen1.panelTitle.Height - fc.FScreen1.lblTitle.Height) / 2);
             */
            
            //fc.FScreen1.lbl_CurrentTime.ForeColor = fc.FScreen1.lblTitle.ForeColor;
            //fc.FScreen1.lbl_CurrentTime.Font = fc.FScreen1.lblTitle.Font;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.panelTitle.Height = (int)numericTitleHeight.Value;
        }
        
        private void btnTableHeaderFont_Click(object sender, EventArgs e)
        {
            if(SetFontStyle(btnTableHeaderFont))
            {
                fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.Font = btnTableHeaderFont.Font;
                fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor = btnTableHeaderFont.ForeColor;
            }
        }

        private void btnTableContentFont_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTableContentFont))
            {
                fc.FScreen1.GridViewDate.Font = btnTableContentFont.Font;
                fc.FScreen1.GridViewDate.ForeColor = btnTableContentFont.ForeColor;
            }
        }

        private void btnLinColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnLinColor))
            {
                fc.FScreen1.GridViewDate.GridColor = btnLinColor.BackColor;
                fc.FScreen1.panelContent.BorderColor = btnLinColor.BackColor;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.timer.Interval = (int)(numericPageSpeed.Value*1000);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.PageSize = (int)numericPageSize.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SetBackColor(btnTableHeaderBackColor))
            {
                if (fc.CurrentScreen == fc.FScreen1)
                    fc.FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor = btnTableHeaderBackColor.BackColor;
            }
        }

        private void numericRowHeight_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.RowHeight = (int)numericRowHeight.Value;

            fc.FScreen1.SetRowHeight();
        }

        private void numericHeaderHeight_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.GridViewDate.ColumnHeadersHeight = (int)numericHeaderHeight.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;

            ////单元格的边框为单行边框
            //fc.FScreen1.GridViewDate.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            ////网络线的颜色为红色
            //fc.FScreen1.GridViewDate.GridColor = Color.Red;

            switch (rb.Tag.ToString())
            {
                case "FixedSingle":
                    fc.FScreen1.TableBorderStyle = frmLEDScreen1.TableBorderType.FixedSingle;
                    break;
                case "FixedDouble":
                    fc.FScreen1.TableBorderStyle = frmLEDScreen1.TableBorderType.FixedDouble;
                    break;
                case "None":
                    fc.FScreen1.TableBorderStyle = frmLEDScreen1.TableBorderType.None;
                    break;
                default:
                    fc.FScreen1.TableBorderStyle = frmLEDScreen1.TableBorderType.FixedSingle;
                    break;
            }
            fc.FScreen1.TableBorderSize = (int)numericBorderSize.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckboxAutoColWidth.Checked)
            {
                fc.FScreen1.GridViewDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }else
            {
                fc.FScreen1.GridViewDate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fc.SaveScreen1Default(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fc.InitScreen1();
        }

        private void numericBorderSize_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.TableBorderSize = (int)numericBorderSize.Value;
        }

        #endregion
        
        #region 窗体2事件
        private void rdbDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDetail.Checked)
            {
                btnTableContentFont2.Enabled = true;
                initCol(fc.FScreen2.GVBiddingCustomerInfo, flowBuy);
                initCommon();
                numericSynData2.Value = Convert.ToDecimal(fc.FScreen2.iDetailSpan/1000);
            }
        }

        private void rdbBase_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {
                btnTableContentFont2.Enabled = false;
                initColSetMore(fc.FScreen2.GVBiddingInfo, flowBuy);
                initCommon();
                numericSynData2.Value = Convert.ToDecimal(fc.FScreen2.iBaseSpan/1000);
            }
        }

        private void btnTitleFont2_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTitleFont2))
            {
                txtTitleFont2.Font = btnTitleFont2.Font;
                txtTitleFont2.ForeColor = btnTitleFont2.ForeColor;
                //fc.FScreen2.lblHeadBase.Font = btnTitleFont2.Font;
                //fc.FScreen2.ForeColor = btnTitleFont2.ForeColor;
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            fc.SaveScreen2Default(true);
        }

        private void numericSynData2_ValueChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {
                fc.FScreen2.iBaseSpan = Convert.ToInt32(numericSynData2.Value)*1000;
                //fc.FScreen2.timerBase.Interval = Convert.ToInt32(numericSynData2.Value)*1000;
            }
            else if (rdbDetail.Checked)
            {
                fc.FScreen2.iDetailSpan = Convert.ToInt32(numericSynData2.Value)*1000;
                //fc.FScreen2.timerDetail.Interval = Convert.ToInt32(numericSynData2.Value)*1000;
            }
        }

        private void btnShowTitle2_Click(object sender, EventArgs e)
        {
            //fc.FScreen2.LblTimeDown.Text = txtTitleFont2.Text.Trim();
            //fc.FScreen2.LblTimeDown.Font = txtTitleFont2.Font;
            //fc.FScreen2.LblTimeDown.ForeColor = txtTitleFont2.ForeColor;
            
            fc.FScreen2.strProjectTitle = txtTitleFont2.Text.Trim();
            fc.FScreen2.lblHeadBase.Text = txtTitleFont2.Text.Trim();
            fc.FScreen2.lblHeadBase.Font = txtTitleFont2.Font;
            fc.FScreen2.lblHeadBase.ForeColor = txtTitleFont2.ForeColor;

            
            //fc.FScreen2.lbl_CurrentTime.Font = fc.FScreen2.lblHeadBase.Font;
            //fc.FScreen2.lbl_CurrentTime.ForeColor = fc.FScreen2.lblHeadBase.ForeColor;
        }

        private void numericTitleHigh2_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen2.LblTimeDown.Height = Convert.ToInt32(numericTitleHigh2.Value);
        }

        private void btnTableHeadFont2_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTableHeadFont2))
            {
                if (rdbBase.Checked)
                {
                    //SetBaseStyle(fc.FScreen2.GVBiddingInfo, btnTableHeadFont2, true, "font");
                    fc.FScreen2.lblHeadBase.Font = btnTableHeadFont2.Font;
                    fc.FScreen2.lblHeadBase.ForeColor = btnTableHeadFont2.ForeColor;

                    //fc.FScreen2.lbl_CurrentTime.Font = fc.FScreen2.lblHeadBase.Font;
                    //fc.FScreen2.lbl_CurrentTime.ForeColor = fc.FScreen2.lblHeadBase.ForeColor;
                }
                else if (rdbDetail.Checked)
                {
                    SetHeadFontStyle(fc.FScreen2.GVBiddingCustomerInfo, btnTableHeadFont2);
                }
            }
        }

        private void btnTableContentFont2_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTableContentFont2))
            {
                if (rdbBase.Checked)
                {
                    //SetBaseStyle(fc.FScreen2.GVBiddingInfo, btnTableContentFont2, false, "font");
                    SetContentFontStyle(fc.FScreen2.GVBiddingInfo, btnTableContentFont2);
                }
                else if (rdbDetail.Checked)
                {
                    SetContentFontStyle(fc.FScreen2.GVBiddingCustomerInfo, btnTableContentFont2);
                }
            }
        }

        private void btnTableHeaderBackColor2_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnTableHeaderBackColor2))
            {
                if (rdbBase.Checked)
                {
                    //SetBaseStyle(fc.FScreen2.GVBiddingInfo, btnTableHeaderBackColor2, true, "backcolor");
                    fc.FScreen2.lblHeadBase.BackColor = btnTableHeaderBackColor2.BackColor;

                    fc.FScreen2.lbl_CurrentTime.BackColor = fc.FScreen2.lblHeadBase.BackColor;
                    fc.FScreen2.panelBaseHead.BackColor = fc.FScreen2.lblHeadBase.BackColor;
                }
                else if (rdbDetail.Checked)
                {
                    SetHeadBackColor(fc.FScreen2.GVBiddingCustomerInfo, btnTableHeaderBackColor2);
                }
            }
            
        }

        private void btnLinColor2_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnLinColor2))
            {
                if (rdbBase.Checked)
                {
                    SetGridColor(fc.FScreen2.GVBiddingInfo, btnLinColor2);
                }
                else if (rdbDetail.Checked)
                {
                    SetGridColor(fc.FScreen2.GVBiddingCustomerInfo, btnLinColor2);
                }
            }
        }

        private void numericHeaderHeight2_ValueChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {
                //if (fc.FScreen2.GVBiddingInfo.Rows.Count > 0)
                //{
                //    fc.FScreen2.GVBiddingInfo.Rows[0].Height = Convert.ToInt32(numericHeaderHeight2.Value);
                //}
                fc.FScreen2.panelBaseHead.Height = Convert.ToInt32(numericHeaderHeight2.Value);
            }
            else if (rdbDetail.Checked)
            {
                SetHeadHigh(fc.FScreen2.GVBiddingCustomerInfo, numericHeaderHeight2);
                fc.FScreen2.DetailHeadHeight = Convert.ToInt32(numericHeaderHeight2.Value);
            }
        }

        private void numericRowHeight2_ValueChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {
                //if (fc.FScreen2.GVBiddingInfo.Rows.Count <=0)
                //    return;
                //foreach(DataGridViewRow row in fc.FScreen2.GVBiddingInfo.Rows)
                //{
                //    row.Height = Convert.ToInt32(numericRowHeight2.Value);
                //}
                SetContentHeigh(fc.FScreen2.GVBiddingInfo, numericRowHeight2);
                fc.FScreen2.BaseContextHeight = Convert.ToInt32(numericRowHeight2.Value);
            }
            else if (rdbDetail.Checked)
            {
                SetContentHeigh(fc.FScreen2.GVBiddingCustomerInfo, numericRowHeight2);
                fc.FScreen2.DetailContextHeight = Convert.ToInt32(numericRowHeight2.Value);
            }
        }

        private void ckboxAutoColWidth2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBase.Checked)
            {
                if (ckboxAutoColWidth2.Checked)
                    fc.FScreen2.GVBiddingInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                    fc.FScreen2.GVBiddingInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
            else if (rdbDetail.Checked)
            {
                if (ckboxAutoColWidth2.Checked)
                    fc.FScreen2.GVBiddingCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                else
                    fc.FScreen2.GVBiddingCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
        }

        private void rbBorderFixedDouble2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbTemp = (RadioButton) sender;
            
            if (rdbBase.Checked)
            {
                SetBorderStyle(fc.FScreen2.GVBiddingInfo, rbTemp.Tag.ToString());
            }
            else if (rdbDetail.Checked)
            {
                SetBorderStyle(fc.FScreen2.GVBiddingCustomerInfo, rbTemp.Tag.ToString());
            }
        }

        private void btnBuySelect_Click(object sender, EventArgs e)
        {
            //frmChooseBuy frmChBuy = new frmChooseBuy();
            //frmChBuy.Show(this);
        }

        private void btnBuyTitle2_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnBuyTitle2))
            {
                fc.FScreen2.LblTimeDown.Font = btnBuyTitle2.Font;
                fc.FScreen2.LblTimeDown.ForeColor = btnBuyTitle2.ForeColor;
            }
        }

        private void btnBackColo2_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnBackColo2))
            {
                SetAreaBackColor(cmbBackColor2.SelectedIndex,btnBackColo2);
            }
        }

        private void cmbBackColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAreaBtnColor(cmbBackColor2.SelectedIndex, btnBackColo2);
        }

        private void btnClock2_Click(object sender, EventArgs e)
        {
            if(SetBackColor(btnClock2))
            {
                fc.FScreen2.clockControl1.BackColor = btnClock2.BackColor;
            }
        }

        private void btnHourHandColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnHourHandColor))
            {
                fc.FScreen2.clockControl1.HourHandColor = btnHourHandColor.BackColor;
            }
        }

        private void btnMinuteHandColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnMinuteHandColor))
            {
                fc.FScreen2.clockControl1.MinuteHandColor = btnMinuteHandColor.BackColor;
            }
        }

        private void btnSecondColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnSecondColor))
            {
                fc.FScreen2.clockControl1.SecondHandColor = btnSecondColor.BackColor;
            }
        }

        private void btnScaleColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnScaleColor))
            {
                fc.FScreen2.clockControl1.ScaleColor = btnScaleColor.BackColor;
            }
        }

        private void btnTime2ForeColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnTime2ForeColor))
            {
                fc.FScreen2.clockControls1.ClockColor = btnTime2ForeColor.BackColor;
            }
        }

        private void btnTime2BackColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnTime2BackColor))
            {
                fc.FScreen2.clockControls1.BackColor = btnTime2BackColor.BackColor;
            }
        }

        private void btnLedClock2ForeColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnLedClock2ForeColor))
            {
                fc.FScreen2.ledClockControls1.ClockColor = btnLedClock2ForeColor.BackColor;
            }
        }

        private void btnLedClock2BackColor_Click(object sender, EventArgs e)
        {
            if (SetBackColor(btnLedClock2BackColor))
            {
                fc.FScreen2.ledClockControls1.BackColor = btnLedClock2BackColor.BackColor;
            }
        }

        private void numericCountDown2_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen2.ledClockControls1.Location =
                new Point(fc.FScreen2.ledClockControls1.Location.X, Convert.ToInt32(numericCountDown2.Value));

        }

        private void btnStartMusic_Click(object sender, EventArgs e)
        {
            string strPath = GetFilePath();
            if (strPath != string.Empty)
            {
                fc.FScreen2.strMusicStart = strPath;
                SetToolTip(btnStartMusic, strPath);
            }
        }

        private void btnEndMusic_Click(object sender, EventArgs e)
        {
            string strPath = GetFilePath();
            if (strPath != string.Empty)
            {
                fc.FScreen2.strMusicEnd = strPath;
                SetToolTip(btnEndMusic, strPath);
            }
        }


        private void btnSomeOne_Click(object sender, EventArgs e)
        {
            string strPath = GetFilePath();
            if (strPath != string.Empty)
            {
                fc.FScreen2.strMusicSomeOne = strPath;
                SetToolTip(btnSomeOne, strPath);
            }
        }

        private void btnNoOne_Click(object sender, EventArgs e)
        {
            string strPath = GetFilePath();
            if (strPath != string.Empty)
            {
                fc.FScreen2.strMusicNoOne = strPath;
                SetToolTip(btnNoOne, strPath);
            }
        }


        private void chkStartMusic_CheckedChanged(object sender, EventArgs e)
        {
            fc.FScreen2.blMusicStartOpen = chkStartMusic.Checked;
        }

        private void chkEndMusic_CheckedChanged(object sender, EventArgs e)
        {
            fc.FScreen2.blMusicEndOpen = chkEndMusic.Checked;
        }

        private void chkSomeOne_CheckedChanged(object sender, EventArgs e)
        {
            fc.FScreen2.blMusicSomeOneOpen = chkSomeOne.Checked;
        }

        private void chkNoOne_CheckedChanged(object sender, EventArgs e)
        {
            fc.FScreen2.blMusicNoOneOpen = chkNoOne.Checked;
        }

        #endregion
        
        #region 自定义事件
        void btnColor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (fc.CurrentScreen == fc.FScreen2)
            {
                if (rdbBase.Checked)
                    SetBackColor(fc.FScreen2.GVBiddingInfo, btn.Tag.ToString(), btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (fc.CurrentScreen == fc.FScreen2)
            {
                if (rdbBase.Checked)
                    SetFontStyle(fc.FScreen2.GVBiddingInfo, btn.Tag.ToString(), btn);
            }
        }


        void num_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown s = ((NumericUpDown)sender);
            if (fc.CurrentScreen == fc.FScreen1)
            {
                fc.FScreen1.GridViewDate.Columns[s.Tag.ToString()].Width = (int)s.Value;
                ChangeNumericValue(fc.FScreen1.GridViewDate);
            }
            else if (fc.CurrentScreen == fc.FScreen2)
            {
                if (rdbDetail.Checked)
                {
                    fc.FScreen2.GVBiddingCustomerInfo.Columns[s.Tag.ToString()].Width = (int)s.Value;
                    ChangeNumericValue(fc.FScreen2.GVBiddingCustomerInfo);
                }
                else if (rdbBase.Checked)
                {
                    fc.FScreen2.GVBiddingInfo.Columns[s.Tag.ToString()].Width = (int)s.Value;
                    fc.FScreen2.SetBaseHeadWidht();
                    ChangeNumericValue(fc.FScreen2.GVBiddingInfo);
                }
            }
        }

        #endregion
        
        #region 自定义方法

        /// <summary>
        /// 自动改变所有NumericUpDown控件的值，跟随网格变化而变化
        /// </summary>
        /// <param name="dgvTemp"></param>
        private void ChangeNumericValue(DataGridView dgvTemp)
        {
            if (numArr == null || numArr.Length <=0) return;
            foreach (NumericUpDown num in numArr)
            {
                if (num == null || num.Name == null) continue;
                if (dgvTemp.Columns.Contains(num.Name))
                    num.Value = dgvTemp.Columns[num.Name].Width;
            }
        }

        /// <summary>
        /// 设置数据控件表头的字体
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="btnTemp">按钮控件</param>
        private void SetHeadFontStyle(DataGridView dgvTemp, Button btnTemp)
        {
            dgvTemp.ColumnHeadersDefaultCellStyle.Font = btnTemp.Font;
            dgvTemp.ColumnHeadersDefaultCellStyle.ForeColor = btnTemp.ForeColor;
        }

        /// <summary>
        /// 设置数据控件内容字体
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="btnTemp">按钮</param>
        private void SetContentFontStyle(DataGridView dgvTemp, Button btnTemp)
        {
            dgvTemp.RowsDefaultCellStyle.Font = btnTemp.Font;
            dgvTemp.RowsDefaultCellStyle.ForeColor = btnTemp.ForeColor;
        }
        
        /// <summary>
        /// 设置数据控件表头的底色
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="btnTemp">按钮</param>
        private void SetHeadBackColor(DataGridView dgvTemp,Button btnTemp)
        {
            dgvTemp.ColumnHeadersDefaultCellStyle.BackColor = btnTemp.BackColor;
        }
        
        /// <summary>
        /// 设置数据控件网格线条颜色
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="btnTemp">按钮</param>
        private void SetGridColor(DataGridView dgvTemp,Button btnTemp)
        {
            dgvTemp.GridColor = btnTemp.BackColor;
        }
        
        /// <summary>
        /// 设置数据控件表头的高度
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="nudTemp">数值控件</param>
        private void SetHeadHigh(DataGridView dgvTemp,NumericUpDown nudTemp)
        {
            dgvTemp.ColumnHeadersHeight = Convert.ToInt32(nudTemp.Value);
        }
        
        /// <summary>
        /// 设置数据控件内容的高度
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="nudTemp">数值控件</param>
        private void SetContentHeigh(DataGridView dgvTemp,NumericUpDown nudTemp)
        {
            for(int i=0;i<dgvTemp.Rows.Count;i++)
            {
                dgvTemp.Rows[i].Height = Convert.ToInt32(nudTemp.Value);
            }
        }
        
        /// <summary>
        /// 设置区域背景的底色
        /// </summary>
        /// <param name="index">所选择设置的区域1为时间显示区，2项目竞价基本信息区，3竞价数据显示区，3底部通告区</param>
        /// <param name="btnTemp">按钮控件</param>
        private void SetAreaBackColor(int index,Button btnTemp)
        {
            switch(index)
            {
                case 0:
                    fc.FScreen2.clockControl1.BackColor = btnTemp.BackColor;
                    fc.FScreen2.clockControls1.BackColor = btnTemp.BackColor;
                    fc.FScreen2.ledClockControls1.BackColor = btnTemp.BackColor;
                    fc.FScreen2.panelEx2.BackColor = btnTemp.BackColor;
                    break;
                case 1:
                    fc.FScreen2.panelBaseHead.BackColor = btnTemp.BackColor;
                    fc.FScreen2.panelBaseContent.BackColor = btnTemp.BackColor;
                    fc.FScreen2.lblHeadBase.BackColor = btnTemp.BackColor;
                    fc.FScreen2.lbl_CurrentTime.BackColor = btnTemp.BackColor;
                    fc.FScreen2.GVBiddingInfo.BackgroundColor = btnTemp.BackColor;
                    fc.FScreen2.GVBiddingInfo.RowsDefaultCellStyle.BackColor = btnTemp.BackColor;
                    if (fc.FScreen2.GVBiddingInfo.Rows.Count > 0)
                    {
                        for (int i = 0; i < fc.FScreen2.GVBiddingInfo.ColumnCount; i++)
                        {
                            foreach (DataGridViewRow row in fc.FScreen2.GVBiddingInfo.Rows)
                            {
                                row.Cells[i].Style.BackColor = btnTemp.BackColor;
                            }
                        }
                    }
                    break;
                case 2:
                    fc.FScreen2.panelContent.BackColor = btnTemp.BackColor;
                    fc.FScreen2.GVBiddingCustomerInfo.BackgroundColor = btnTemp.BackColor;
                    fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = btnTemp.BackColor;
                    fc.FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.BackColor = btnTemp.BackColor;
                    break;
                case 3:
                    fc.FScreen2.scrollingTextAffiche.BackColor = btnTemp.BackColor;
                    fc.FScreen2.panelBottom.BackColor = btnTemp.BackColor;
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// 设置区域按钮的底色
        /// </summary>
        /// <param name="index">所选择设置的区域1为时间显示区，2项目竞价基本信息区，3竞价数据显示区，3底部通告区</param>
        /// <param name="btnTemp">按钮控件</param>
        private void SetAreaBtnColor(int index,Button btnTemp)
        {
            switch(index)
            {
                case 0:
                    btnTemp.BackColor = fc.FScreen2.panelEx2.BackColor;
                    break;
                case 1:
                    btnTemp.BackColor = fc.FScreen2.panelBaseHead.BackColor;
                    break;
                case 2:
                    btnTemp.BackColor = fc.FScreen2.panelContent.BackColor;
                    break;
                case 3:
                    btnTemp.BackColor = fc.FScreen2.panelBottom.BackColor;
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// 设置数据控件边框的样式
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="strMode">边框样式</param>
        private void SetBorderStyle(DataGridView dgvTemp,string strMode)
        {
            switch (strMode)
            {
                case "FixedSingle":
                    dgvTemp.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "FixedDouble":
                    dgvTemp.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "None":
                    dgvTemp.BorderStyle = BorderStyle.None;
                    break;
                default:
                    dgvTemp.BorderStyle = BorderStyle.FixedSingle;
                    break;
            }
        }

        /// <summary>
        /// 设置Button控件的字体
        /// </summary>
        /// <param name="btnTemp"></param>
        private bool SetFontStyle(Button btnTemp)
        {
            MyFontDialog fd = new MyFontDialog(x+10, y, 0, 0);
            fd.ShowApply = true;
            fd.ShowColor = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;

            fd.Font = btnTemp.Font;
            fd.Color = btnTemp.ForeColor;

            bool blTemp = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                btnTemp.Font = fd.Font;
                btnTemp.ForeColor = fd.Color;
                blTemp = true;
            }
            return blTemp;
        }

        /// <summary>
        /// 设置Button控件的底色
        /// </summary>
        /// <param name="btnTemp"></param>
        private bool SetBackColor(Button btnTemp)
        {
            MyColorDialog cd = new MyColorDialog(x + 10, y, 0, 0);
            cd.FullOpen = true;
            cd.AnyColor = true;

            cd.Color = btnTemp.BackColor;

            bool blTemp = false;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnTemp.BackColor = cd.Color;
                blTemp = true;
            }
            return blTemp;
        }
        
        /// <summary>
        /// 设置控件的提示
        /// </summary>
        /// <param name="ctlTemp">提示的控件</param>
        /// <param name="strTitle">提示的描述</param>
        private void SetToolTip(Control ctlTemp ,string strTitle)
        {
            ToolTip tl = new ToolTip();
            tl.AutoPopDelay = 5000;
            tl.InitialDelay = 1000;
            tl.ReshowDelay = 500;
            tl.ShowAlways = true;
            tl.SetToolTip(ctlTemp, strTitle);
            ctlTemp.Tag = strTitle;
        }
        
        /// <summary>
        /// 获得文件路径
        /// </summary>
        /// <returns></returns>
        private string GetFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "音频文件|*.wav";
            ofd.Title = "插入音频";
            string strTemp = string.Empty;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strTemp = ofd.FileName;
            }
            
            return strTemp;
        }

        /// <summary>
        /// 设置公告
        /// </summary>
        /// <param name="ScroTemp">滚动公告控件</param>
        private void SetAffiche(ScrollingTextControl.ScrollingText ScroTemp)
        {
            ScroTemp.ScrollText = txtAffiche.Text;
            ScroTemp.Font = txtAffiche.Font;
            ScroTemp.ForeColor = txtAffiche.ForeColor;
        }
        
        /// <summary>
        /// 设置基础网格控件的外观（表头在内容中）
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="btnTemp">按钮</param>
        /// <param name="IsHead">是设置头还是内容</param>
        /// <param name="Field">font为设置字体，backcolor为底色</param>
        private void SetBaseStyle(DataGridView dgvTemp, Button btnTemp, bool IsHead, string Field)
        {
            if (dgvTemp.Rows.Count > 0)
            {
                for (int i = 0; i < dgvTemp.Rows.Count; i++)
                {
                    if (Field == "font")
                    {
                        if (IsHead)
                        {
                            dgvTemp.Rows[i].DefaultCellStyle.Font = btnTemp.Font;
                            dgvTemp.Rows[i].DefaultCellStyle.ForeColor = btnTemp.ForeColor;
                            break;
                        }
                        else if (IsHead == false)
                        {
                            if (i < 1)
                                continue;
                            dgvTemp.Rows[i].DefaultCellStyle.Font = btnTemp.Font;
                            dgvTemp.Rows[i].DefaultCellStyle.ForeColor = btnTemp.ForeColor;
                        }
                    }
                    else if (Field == "backcolor")
                    {
                        if (IsHead)
                        {
                            dgvTemp.Rows[i].DefaultCellStyle.BackColor = btnTemp.BackColor;
                            break;
                        }
                        else if (IsHead == false)
                        {
                            if (i < 1)
                                continue;
                            dgvTemp.Rows[i].DefaultCellStyle.BackColor = btnTemp.BackColor;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 设置基本网格数据列的字体（表头在内容中）
        /// </summary>
        /// <param name="dgvTemp">数据网格</param>
        /// <param name="colName">列名</param>
        /// <param name="btnTemp">要改变颜色的控件</param>
        private void SetFontStyle(DataGridView dgvTemp, string colName, Button btnTemp)
        {
            MyFontDialog fd = new MyFontDialog(x + 10, y, 0, 0);
            fd.ShowApply = true;
            fd.ShowColor = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;


            if (dgvTemp.Rows.Count > 0)
            {
                fd.Font = dgvTemp.Rows[0].Cells[colName].Style.Font;
                fd.Color = dgvTemp.Rows[0].Cells[colName].Style.ForeColor;
            }
            else
                return;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                btnTemp.Font = fd.Font;
                btnTemp.ForeColor = fd.Color;

                if (dgvTemp.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvTemp.Rows.Count; i++)
                    {
                        dgvTemp.Rows[i].Cells[colName].Style.Font = fd.Font;
                        dgvTemp.Rows[i].Cells[colName].Style.ForeColor = fd.Color;
                    }
                }
            }
        }

        /// <summary>
        /// 设置基本网格数据列的底色（表头在内容中）
        /// </summary>
        /// <param name="dgvTemp">数据网格</param>
        /// <param name="colName">列名</param>
        /// <param name="btnTemp">要改变颜色的控件</param>
        private void SetBackColor(DataGridView dgvTemp, string colName, Button btnTemp)
        {
            MyColorDialog cd = new MyColorDialog(x + 10, y, 0, 0);
            cd.FullOpen = true;
            cd.AnyColor = true;

            if (dgvTemp.Rows.Count > 0)
                cd.Color = dgvTemp.Rows[0].Cells[colName].Style.BackColor;
            else
                return;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnTemp.BackColor = cd.Color;
                if (fc.CurrentScreen == fc.FScreen2)
                {
                    for (int i = 0; i < dgvTemp.Rows.Count; i++)
                    {
                        dgvTemp.Rows[i].Cells[colName].Style.BackColor = cd.Color;
                    }
                }
            }
        }

        public void initCol()
        {
            flowLayoutPanel.Controls.Clear();
            numArr = new NumericUpDown[fc.FScreen1.GridViewDate.Columns.Count];
            int i = 0;
            foreach (DataGridViewColumn column in fc.FScreen1.GridViewDate.Columns)
            {
                CheckBox cb = new CheckBox();
                cb.Text = column.HeaderText;
                cb.Tag = column.Name;
                cb.Checked = column.Visible;
                cb.Width = 110;
                cb.CheckedChanged += CheckBox_CheckedChanged;
                cb.Margin = new Padding(3, 3, 3, 3);
                flowLayoutPanel.Controls.Add(cb);

                Label lbl = new Label();
                lbl.Text = "宽:";
                lbl.Width = 25;
                lbl.Margin = new Padding(3, 6, -1, 3);
                flowLayoutPanel.Controls.Add(lbl);
                lbl.Location = new Point(lbl.Location.X + 20, lbl.Location.Y);

                NumericUpDown num = new NumericUpDown();
                num.ValueChanged += new EventHandler(num_ValueChanged);
                num.Tag = column.Name;
                num.Width = 50;
                num.Maximum = fc.FScreen1.GridViewDate.Width;
                num.Minimum = 0;
                num.Value = column.Width;
                num.Margin = new Padding(3, 3, 3, 3);
                num.Name = "numColumnWidth";
                flowLayoutPanel.Controls.Add(num);
                numArr[i] = num;
                numArr[i].Name = column.Name;
                i++;

                Label lblpx = new Label();
                lblpx.Text = "px";
                lblpx.Width = 20;
                lblpx.Margin = new Padding(0, 5, 3, 3);
                flowLayoutPanel.Controls.Add(lblpx);
                lblpx.Location = new Point(lblpx.Location.X + 20, lblpx.Location.Y);
            }
        }

        /// <summary>
        /// 初始化Flow控件的列控件内容
        /// </summary>
        /// <param name="dgvTemp">要初始化的DataGridView数据控件</param>
        /// <param name="flowTemp">要初始化的FlowPanle控件</param>
        public void initCol(DataGridView dgvTemp, FlowLayoutPanel flowTemp)
        {
            flowTemp.Controls.Clear();
            numArr = new NumericUpDown[dgvTemp.Columns.Count];
            int i = 0;
            foreach (DataGridViewColumn column in dgvTemp.Columns)
            {
                CheckBox cb = new CheckBox();
                cb.Text = column.HeaderText;
                cb.Tag = column.Name;
                cb.Checked = column.Visible;
                cb.Width = 85;
                cb.CheckedChanged += CheckBox_CheckedChanged;
                cb.Margin = new Padding(10, 5, 0, 7);
                flowTemp.Controls.Add(cb);

                Label lbl = new Label();
                lbl.Text = "宽:";
                lbl.Width = 25;
                lbl.Margin = new Padding(0, 11, -1, 0);
                flowTemp.Controls.Add(lbl);

                NumericUpDown num = new NumericUpDown();
                num.ValueChanged += new EventHandler(num_ValueChanged);
                num.Tag = column.Name;
                num.Width = 50;
                num.Maximum = dgvTemp.Width;
                num.Minimum = 0;
                num.Value = column.Width;
                num.Margin = new Padding(3, 8, 3, 0);
                num.Name = "numColumnWidth";
                flowTemp.Controls.Add(num);
                numArr[i] = num;
                numArr[i].Name = column.Name;
                i++;
                
                Label lblpx = new Label();
                lblpx.Text = "px";
                lblpx.Width = 20;
                lblpx.Margin = new Padding(0, 10, 3, 0);
                flowTemp.Controls.Add(lblpx);
            }
        }
        
        private void initColSetMore(DataGridView dgvTemp, FlowLayoutPanel flowTemp)
        {
            flowTemp.Controls.Clear();
            numArr = new NumericUpDown[dgvTemp.Columns.Count];
            int i = 0;
            foreach (DataGridViewColumn column in dgvTemp.Columns)
            {
                Label lbl = new Label();
                lbl.Text = column.HeaderText;
                lbl.AutoSize = true;
                lbl.Margin = new Padding(0, 11, 3, 3);
                flowTemp.Controls.Add(lbl);

                Button btn = new Button();
                btn.Text = "字体";
                btn.Tag = column.Name;
                btn.Size = new Size(40, 23);
                btn.BackColor = SystemColors.Control;
                if (dgvTemp.Rows.Count > 0)
                {
                    btn.Font = dgvTemp.Rows[0].Cells[column.Name].Style.Font;
                    btn.ForeColor = dgvTemp.Rows[0].Cells[column.Name].Style.ForeColor;
                }
                btn.FlatStyle = FlatStyle.Popup;
                btn.Margin = new Padding(2, 5, 3, 3);
                btn.Click += new EventHandler(btn_Click);
                flowTemp.Controls.Add(btn);

                Button btnColor = new Button();
                btnColor.Text = "底色";
                btnColor.Tag = column.Name;
                btnColor.Size = new Size(40, 23);
                if (dgvTemp.Rows.Count > 0)
                    btnColor.BackColor = dgvTemp.Rows[0].Cells[column.Name].Style.BackColor;
                else
                    btnColor.BackColor = SystemColors.Control;
                btnColor.FlatStyle = FlatStyle.Popup;
                btnColor.Margin = new Padding(2, 5, 3, 3);
                btnColor.Click += new EventHandler(btnColor_Click);
                flowTemp.Controls.Add(btnColor);

                Label lblWidth = new Label();
                lblWidth.Text = "宽:";
                lblWidth.Width = 25;
                lblWidth.Margin = new Padding(3, 11, -1, 3);
                flowTemp.Controls.Add(lblWidth);

                NumericUpDown num = new NumericUpDown();
                num.ValueChanged += new EventHandler(num_ValueChanged);
                num.Tag = column.Name;
                num.Width = 50;
                num.Maximum = dgvTemp.Width;
                num.Minimum = 0;
                num.Value = column.Width;
                num.Margin = new Padding(3, 5, 3, 3);
                num.Name = "numColumnWidth";
                flowTemp.Controls.Add(num);
                numArr[i] = num;
                numArr[i].Name = column.Name;
                i++;

                Label lblpx = new Label();
                lblpx.Text = "px";
                lblpx.Width = 20;
                lblpx.Margin = new Padding(0, 7, 3, 3);
                flowTemp.Controls.Add(lblpx);
            }
        }
        
        private void InitS2()
        {
            cmbBackColor2.SelectedIndex = 0;

            if (rdbDetail.Checked)
                initCol(fc.FScreen2.GVBiddingCustomerInfo, flowBuy);
            else if (rdbBase.Checked)
                initColSetMore(fc.FScreen2.GVBiddingInfo, flowBuy);

            btnTimeSetting2.Font = fc.FScreen2.lbl_CurrentTime.Font;
            btnTimeSetting2.ForeColor = fc.FScreen2.lbl_CurrentTime.ForeColor;

            btnBackColo2.BackColor = fc.FScreen2.panelEx2.BackColor;
            btnBuyTitle2.Font = fc.FScreen2.LblTimeDown.Font;
            btnBuyTitle2.ForeColor = fc.FScreen2.LblTimeDown.ForeColor;
            numericTitleHigh2.Value = fc.FScreen2.LblTimeDown.Height;
            btnClock2.BackColor = fc.FScreen2.clockControl1.BackColor;
            btnHourHandColor.BackColor = fc.FScreen2.clockControl1.HourHandColor;
            btnMinuteHandColor.BackColor = fc.FScreen2.clockControl1.MinuteHandColor;
            btnSecondColor.BackColor = fc.FScreen2.clockControl1.SecondHandColor;
            btnScaleColor.BackColor = fc.FScreen2.clockControl1.ScaleColor;
            btnTime2ForeColor.BackColor = fc.FScreen2.clockControls1.ClockColor;
            btnTime2BackColor.BackColor = fc.FScreen2.clockControls1.BackColor;
            btnLedClock2ForeColor.BackColor = fc.FScreen2.ledClockControls1.ClockColor;
            btnLedClock2BackColor.BackColor = fc.FScreen2.ledClockControls1.BackColor;
            numericCountDown2.Value = fc.FScreen2.ledClockControls1.Location.Y;
            SetToolTip(btnStartMusic, fc.FScreen2.strMusicStart);
            SetToolTip(btnEndMusic,fc.FScreen2.strMusicEnd);
            //开始文字和结束文字功能未实现，暂未初始化

            txtTitleFont2.Text = fc.FScreen2.lblHeadBase.Text;
            btnTitleFont2.Font = txtTitleFont2.Font = fc.FScreen2.lblHeadBase.Font;
            btnTitleFont2.ForeColor = txtTitleFont2.ForeColor = fc.FScreen2.lblHeadBase.ForeColor;
            
            initCommon();

            txtAffiche.Text = fc.FScreen2.scrollingTextAffiche.ScrollText;
            btnAfficheFont.Font = txtAffiche.Font = fc.FScreen2.scrollingTextAffiche.Font;
            btnAfficheFont.ForeColor = txtAffiche.ForeColor = fc.FScreen2.scrollingTextAffiche.ForeColor;
            numericAfficheHeight.Value = fc.FScreen2.panelBottom.Height;
            cmbScollDirection.SelectedIndex = (int)fc.FScreen2.scrollingTextAffiche.ScrollDirection;
            numSpend.Value = fc.FScreen2.scrollingTextAffiche.TextScrollSpeed;
            SetToolTip(btnSomeOne, fc.FScreen2.strMusicSomeOne);
            SetToolTip(btnNoOne, fc.FScreen2.strMusicNoOne);
            chkStartMusic.Checked = fc.FScreen2.blMusicStartOpen;
            chkEndMusic.Checked = fc.FScreen2.blMusicEndOpen;
            chkSomeOne.Checked = fc.FScreen2.blMusicSomeOneOpen;
            chkNoOne.Checked = fc.FScreen2.blMusicNoOneOpen;

            numericProjectInfoSwitchTime.Value = fc.FScreen2.iProjectInfoSwitchTime;
            numericiProjectMarquee.Value = fc.FScreen2.iProjectMarquee;
        }
        
        private void initCommon()
        {
            if (rdbBase.Checked)
            {
                btnTableHeadFont2.Font = fc.FScreen2.lblHeadBase.Font;
                btnTableHeadFont2.ForeColor = fc.FScreen2.lblHeadBase.ForeColor;
                btnTableHeaderBackColor2.BackColor = fc.FScreen2.lblHeadBase.BackColor;
                numericHeaderHeight2.Value = fc.FScreen2.panelBaseHead.Height;
                btnTableContentFont2.Font = fc.FScreen2.GVBiddingInfo.RowsDefaultCellStyle.Font;
                btnTableContentFont2.ForeColor = fc.FScreen2.GVBiddingInfo.RowsDefaultCellStyle.ForeColor;
                btnLinColor2.BackColor = fc.FScreen2.GVBiddingInfo.GridColor;
                if (fc.FScreen2.GVBiddingInfo.Rows.Count >0)
                    numericRowHeight2.Value = fc.FScreen2.GVBiddingInfo.Rows[0].Height;
                else
                    numericRowHeight2.Value = fc.FScreen2.BaseContextHeight;
                numericSynData2.Value = fc.FScreen2.iBaseSpan /1000;
                ckboxAutoColWidth2.Checked = fc.FScreen2.GVBiddingInfo.AutoSizeColumnsMode ==
                                             DataGridViewAutoSizeColumnsMode.Fill;
                
                if (fc.FScreen2.GVBiddingInfo.BorderStyle == BorderStyle.None)
                    rbBorderNone2.Checked = true;
                else if (fc.FScreen2.GVBiddingInfo.BorderStyle == BorderStyle.FixedSingle)
                    rbBorderFixedSingle2.Checked = true;
                else if (fc.FScreen2.GVBiddingInfo.BorderStyle == BorderStyle.Fixed3D)
                    rbBorderFixedDouble2.Checked = true;
                else
                    rbBorderNone2.Checked = true;
                
            }
            else if (rdbDetail.Checked)
            {
                btnTableHeadFont2.Font = fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.Font;
                btnTableHeadFont2.ForeColor = fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor;
                btnTableHeaderBackColor2.BackColor =
                    fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor;
                numericHeaderHeight2.Value = fc.FScreen2.GVBiddingCustomerInfo.ColumnHeadersHeight;
                btnTableContentFont2.Font = fc.FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.Font;
                btnTableContentFont2.ForeColor = fc.FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.ForeColor;
                btnLinColor2.BackColor = fc.FScreen2.GVBiddingCustomerInfo.GridColor;
                if (fc.FScreen2.GVBiddingCustomerInfo.Rows.Count >0)
                     numericRowHeight2.Value = fc.FScreen2.GVBiddingCustomerInfo.Rows[0].Height;
                else
                     numericRowHeight2.Value = fc.FScreen2.DetailContextHeight;
                numericSynData2.Value = fc.FScreen2.iDetailSpan /1000;
                ckboxAutoColWidth2.Checked = fc.FScreen2.GVBiddingCustomerInfo.AutoSizeColumnsMode ==
                                             DataGridViewAutoSizeColumnsMode.Fill;

                if (fc.FScreen2.GVBiddingCustomerInfo.BorderStyle == BorderStyle.None)
                    rbBorderNone2.Checked = true;
                else if (fc.FScreen2.GVBiddingCustomerInfo.BorderStyle == BorderStyle.FixedSingle)
                    rbBorderFixedSingle2.Checked = true;
                else if (fc.FScreen2.GVBiddingCustomerInfo.BorderStyle == BorderStyle.Fixed3D)
                    rbBorderFixedDouble2.Checked = true;
                else
                    rbBorderNone2.Checked = true;
            }
            
            //边框线条功能暂未实现，先不初始化
        }

        #endregion    

        private void btnTimeSetting_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTimeSetting))
            {
                fc.FScreen1.lbl_CurrentTime.Font = btnTimeSetting.Font;
                fc.FScreen1.lbl_CurrentTime.ForeColor = btnTimeSetting.ForeColor;
            }
        }

        private void btnTimeSetting2_Click(object sender, EventArgs e)
        {
            if (SetFontStyle(btnTimeSetting2))
            {
                fc.FScreen2.lbl_CurrentTime.Font = btnTimeSetting2.Font;
                fc.FScreen2.lbl_CurrentTime.ForeColor = btnTimeSetting2.ForeColor;
            }
        }

        private void numericProjectInfoSwitchTime_ValueChanged(object sender, EventArgs e)
        {
            int itime = Convert.ToInt32(numericProjectInfoSwitchTime.Value);
            fc.FScreen2.iProjectInfoSwitchTime = itime;
            fc.FScreen2.ProjectInfoShow_timer.Interval = itime*1000;
        }

        private void numericiProjectMarquee_ValueChanged(object sender, EventArgs e)
        {
            int itime = Convert.ToInt32(numericiProjectMarquee.Value);
            fc.FScreen2.iProjectMarquee = itime;
        }

        private void numTimeLocationX_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.lbl_CurrentTime.Location =
                new Point((int) numTimeLocationX.Value, fc.FScreen1.lbl_CurrentTime.Location.Y);
        }

        private void numTimeLocationY_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.lbl_CurrentTime.Location =
                new Point(fc.FScreen1.lbl_CurrentTime.Location.X, (int) numTimeLocationY.Value);
        }

        private void numTitleX_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.lblTitle.Location = new Point((int)numTitleX.Value, fc.FScreen1.lblTitle.Location.Y);
        }

        private void numTitleY_ValueChanged(object sender, EventArgs e)
        {
            fc.FScreen1.lblTitle.Location = new Point(fc.FScreen1.lblTitle.Location.X, (int) numTitleY.Value);
        }

    }
}