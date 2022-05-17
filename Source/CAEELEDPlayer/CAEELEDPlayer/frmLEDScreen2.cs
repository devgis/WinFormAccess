using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CAEELEDPlayer.Common;
using CAEELEDPlayer.Common.Model;
using CAEELEDPlayer.Properties;
using System.IO;
using Timer=System.Windows.Forms.Timer;
using System.Timers;

namespace CAEELEDPlayer
{
    public partial class frmLEDScreen2 : Form
    {
        private FormControl fc = FormControl.CreateInstance();
        private Point mouseOffset;
        private static List<Buy> buyDetailList = null;

        public bool blListDetail = false; //是否竞价开始
        private DateTime dtBuyStart;
        private DateTime dtBuyEnd;
        public int iBaseSpan = 1000 * 600; //10分钟,可加载设置
        public int iDetailSpan = 1000;  //默认1秒同步，可加载设置
        public string strProjectTitle = "竞价信息"; //项目标题，可加载设置
        public string strMusicStart = string.Empty; //开始竞价倒计时声音，可加载设置
        public string strMusicEnd = string.Empty;  //结束竞价倒计时声音，可加载设置
        public string strMusicSomeOne = string.Empty; //竞价结束，有人倒计时声音，可加载设置
        public string strMusicNoOne = string.Empty; //竞价结束，无人倒计时声音，可加载设置
        public bool blMusicStartOpen = true;   //是否播放竞价开始倒计时音频
        public bool blMusicEndOpen = true;  //是否播放竞价结束倒计时音频
        public bool blMusicSomeOneOpen = true;  //是否播放有人竞价结束音频
        public bool blMusicNoOneOpen = true;  //是否播放无人竞价结束音频
        public int BaseContextHeight = 0;
        public int DetailHeadHeight = 0;
        public int DetailContextHeight = 0;
        public int iStartFlash = 10000;
        public int iEndFlash = 20000;
        public const string strNoneProject = "当前无竞拍项目";
        public const string strProjectStarting = "竞拍开始倒计时";
        public const string strProjectEnding = "竞拍结束倒计时";
        public const string strProjectEnded = "竞拍已结束";
        public const string strProjectSuspend = "竞拍暂停";
        //public frmChooseBuy frmChBuy;

        //public bool blShowEndFlash = false;

        public int iProjectMarquee = 1;//向上滚动的速度, 毫秒
        public int iProjectInfoSwitchTime = 30;//切换速度, 秒
        
        public frmLEDScreen2()
        {
            InitializeComponent();
            GVBiddingCustomerInfo.AutoGenerateColumns = false;
            BaseContextHeight = 20;
            DetailHeadHeight = 20;
            DetailContextHeight = 20;
            ProjectInfoShow_timer.Elapsed += new System.Timers.ElapsedEventHandler(ProjectInfoShow_timer_Tick);
            InitBuyBase();
        }
        public System.Timers.Timer ProjectInfoShow_timer =new System.Timers.Timer();
        private void InitBuyBase()
        {
            //DataGridViewRow row = (DataGridViewRow) GVBiddingInfo.Rows[0].Clone();
            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();
            //row.Cells[0].Value = strProjectTitle;
            //GVBiddingInfo.Rows.Add(row);

            lblHeadBase.Text = strProjectTitle;
            
            DataGridViewRow row;
            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();
            int i = 0;
            GVBiddingInfo.Rows.Add(7);
            
            row = GVBiddingInfo.Rows[i];
            i++;
            int iCol = 0;
            row.Cells[iCol++].Value = "项目编号：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "项目名称：";
            row.Cells[iCol].Value = string.Empty;
            //GVBiddingInfo.Rows.Add(row);

            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            row.Cells[iCol++].Value = "产权类型：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "报价模式：";
            row.Cells[iCol].Value = string.Empty;

            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();
            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            
            row.Cells[iCol++].Value = "挂牌价格：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "保留底价(万元)：";
            row.Cells[iCol].Value = string.Empty;
            //GVBiddingInfo.Rows.Add(row);

            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();
            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            row.Cells[iCol++].Value = "挂牌比例：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "归属地：";
            row.Cells[iCol].Value = string.Empty;
            //GVBiddingInfo.Rows.Add(row);

            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();
            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            row.Cells[iCol++].Value = "挂牌起始时间：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "挂牌结束时间：";
            row.Cells[iCol].Value = string.Empty;
            //GVBiddingInfo.Rows.Add(row);

            //row = (DataGridViewRow)GVBiddingInfo.Rows[0].Clone();

            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            row.Cells[iCol++].Value = "竞价开始时间：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "竞价结束时间：";
            row.Cells[iCol].Value = string.Empty;
            
            row = GVBiddingInfo.Rows[i];
            i++;
            iCol = 0;
            row.Cells[iCol++].Value = "底价(万元)：";
            row.Cells[iCol++].Value = string.Empty;
            row.Cells[iCol++].Value = "竞价阶梯(万元)：";
            row.Cells[iCol].Value = string.Empty;
            //GVBiddingInfo.Rows.Add(row);
            
        }

        public void StartList()
        {
            ProjectInfoShow_timer.Interval = iProjectInfoSwitchTime*1000;
        }

        #region 设置XY坐标
        /// <summary>
        /// 递归得到指定控件偏移量X值
        /// </summary>
        /// <param name="sender">指定的控件</param>
        /// <returns></returns>
        private int GetOffsetX(Control sender)
        {
            if (sender == this)
            {
                return 0;
            }
            if (sender.Parent != this)
            {
                return sender.Left + GetOffsetX(sender.Parent);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 递归得到指定控件偏移量Y值
        /// </summary>
        /// <param name="sender">指定的控件</param>
        /// <returns></returns>
        private int GetOffsetY(Control sender)
        {
            if (sender == this)
            {
                return 0;
            }
            if (sender.Parent != this)
            {
                return sender.Top + GetOffsetY(sender.Parent);
            }
            else
            {
                return 0;
            }

        }

        private void frmLEDScreen_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset,yOffset;
            
            if (e.Button != MouseButtons.Left) return;
            Cursor = Cursors.SizeAll;
            xOffset = -(e.X + GetOffsetX((Control)sender));
            yOffset = -(e.Y + GetOffsetY((Control)sender));
            mouseOffset = new Point(xOffset, yOffset);
        }

        private void frmLEDScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (Cursor != Cursors.SizeAll || fc.CurrentScreen.TopMost) return;
            Point mousePos = Control.MousePosition;
            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
            Location = mousePos;
            

            fc.FConsole.numericX.Value = Location.X;
            fc.FConsole.numericY.Value = Location.Y;
            fc.FConsole.numericH.Value = Height;
            fc.FConsole.numericW.Value = Width;
        }

        private void frmLEDScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        private void GVBiddingInfo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex != 0) return;
            //GridViewEx.MerageRowSpan(GVBiddingInfo, e, 0, 3);
        }

        /// <summary>
        /// 设置数据控件内容的高度
        /// </summary>
        /// <param name="dgvTemp">数据控件</param>
        /// <param name="height">高度</param>
        private void SetContentHeigh(DataGridView dgvTemp, int height)
        {
            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {
                dgvTemp.Rows[i].Height = height;
            }
        }
        
        /// <summary>
        /// 清除网格的数据
        /// </summary>
        private void ClearBuyBase(DataGridView dgvTemp)
        {
            for (int i = 0; i < dgvTemp.Rows.Count; i++)
            {
                for (int j = 1; j < dgvTemp.Columns.Count; j+=2)
                    dgvTemp.Rows[i].Cells[j].Value = string.Empty;
            }
        }

        private delegate void SetProjectInfoCallback(string str);
        private void SetProjectInfo(string text)
        {
            if (LblTimeDown.InvokeRequired)
            {
                SetProjectInfoCallback d = new SetProjectInfoCallback(SetProjectInfo);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lblProjectInfo.Visible = false;
                GVBiddingInfo.Visible = true;
                lblProjectInfo.DocumentText =
                        "<html><body bgcolor='#" + GVBiddingInfo.BackgroundColor.Name.Substring(2) + "' style='border: 1px solid #" + GVBiddingInfo.GridColor.Name.Substring(2) + "'>" +
                        "<script language='javascript'>var i=0;function f(){i+=0.5;window.scrollTo(1,i);if(i==document.body.scrollHeight- 100) i=0;}  " +
                        "function run(){setInterval('f()'," + iProjectMarquee + ");} window.onload=function(){ setTimeout('run()',1000); }</script>" +
                        "<font face='" + GVBiddingInfo.Rows[0].Cells[0].Style.Font.Name + "' style=font-size:" + (GVBiddingInfo.Rows[0].Cells[0].Style.Font.Size + 3) + "px color='" + GVBiddingInfo.Rows[0].Cells[0].Style.ForeColor.Name.Substring(2) + "'>" +
                        text + "</font></body></html>";
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SystemTime
        {
            public ushort year;
            public ushort month;
            public ushort dayOfWeek;
            public ushort day;
            public ushort hour;
            public ushort minute;
            public ushort second;
            public ushort milliseconds;
        }

        [DllImport("Kernel32.dll")]
        public static extern bool SetSystemTime([In, Out] SystemTime st);

        private static string strProjectInfo = string.Empty;
        //绑定竞拍基本的数据
        private DateTime dtServerTime;
        public void BindProjectBaseInfo(ProjectShowInfo prj)
        {
            ProjectInfoShow_timer.Enabled = false;
            //blShowEndFlash = false;
            blShowProjectBaseInfo = false;
            ClearBuyBase(GVBiddingInfo);

            if (GVBiddingInfo.Rows.Count < 7)
                GVBiddingInfo.Rows.Add(7 - GVBiddingInfo.Rows.Count);

            if (prj == null)
            {
                lblHeadBase.Text = strNoneProject;
                ProjectInfoShow_timer.Enabled = false;
                //ProjectInfoShow_timer.Stop();//没有数据侧不切换
                return;
            }


            //初始化时间，竞拍人员信息
            blListDetail = false;
            BindBuyDetailInvoke(null);
            buyDetailList = new List<Buy>();

            dtServerTime = Convert.ToDateTime(prj.serverTime);
            DateTime temp = Convert.ToDateTime(dtServerTime);
            //Debug.WriteLine(temp);
            SystemTime st = new SystemTime();
            st.year = (ushort)temp.Year;
            st.month = (ushort)temp.Month;
            st.day = (ushort)temp.Day;
            st.hour = (ushort) (temp.Hour-8);
            st.minute = (ushort)temp.Minute;
            st.second = (ushort)temp.Second;
            SetSystemTime(st);
            
            lblHeadBase.Text = strProjectTitle;

            int iRow = 0;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.code ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.projectName ?? string.Empty;
            ++iRow;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.property ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.modeKey ?? string.Empty;
            ++iRow;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.releasePrice ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.reserveBasePrice ?? string.Empty;
            ++iRow;
            
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.releaseRatio ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.area ?? string.Empty;
            ++iRow;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.startTime ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.endTime ?? string.Empty;
            ++iRow;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.buyStartTime ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.buyEndTime ?? string.Empty;
            ++iRow;
            GVBiddingInfo.Rows[iRow].Cells[1].Value = prj.basePrice ?? string.Empty;
            GVBiddingInfo.Rows[iRow].Cells[3].Value = prj.priceStep ?? string.Empty;


            ProjectInfoShow_timer.Enabled = true;
            //ProjectInfoShow_timer.Start();
            SetProjectInfo(prj.projectInfo ?? string.Empty);
            strProjectInfo = prj.projectInfo ?? string.Empty;

            dtBuyStart = Convert.ToDateTime(prj.buyStartTime);
            dtBuyEnd = Convert.ToDateTime(prj.buyEndTime);

            if (dtBuyEnd <= dtServerTime)
            {
                SetTimeDownValue(strProjectEnded);
                ledClockControls1.CountDownEndTime = Convert.ToDateTime("1990-01-01 00:00:00");
                blListDetail = false;
            }
            else if (dtBuyStart > dtServerTime && blListDetail == false)//竞价开始之前
            {
                SetTimeDownValue(strProjectStarting);
                ledClockControls1.CountDownEndTime = dtBuyStart;
                blListDetail = false;
            }
            /*
            else //竞价开始
            {
                SetTimeDownValue(strProjectEnding);
                ledClockControls1.CountDownEndTime = dtBuyEnd;
                blListDetail = true;
            }
             */

            ClearRowsSelect(GVBiddingInfo);

            SetFlashText("");
        }

        private delegate void SetTimeDownValueCallback(string str);
        private void SetTimeDownValue(string text)
        {
            if (LblTimeDown.InvokeRequired)
            {
                SetTimeDownValueCallback d = new SetTimeDownValueCallback(SetTimeDownValue);
                this.Invoke(d, new object[] {text});
            }
            else
            {
                this.LblTimeDown.Text = text;
            }
        }
        

        private delegate void BindBuyDetailCallback(List<Buy> currentBuyList);
        void BindBuyDetailInvoke(List<Buy> currentBuyList)
        {
            if (GVBiddingCustomerInfo.InvokeRequired)
            {
                BindBuyDetailCallback d = new BindBuyDetailCallback(BindBuyDetailInvoke);
                while (!this.IsHandleCreated) { ;}//线程等待，直到窗口句柄创建完毕
                this.Invoke(d,currentBuyList);
            }
            else
            {
                if (currentBuyList == null)
                {
                    GVBiddingCustomerInfo.DataSource = null;
                    return;
                }

                //1.将新增数据加入到列表中
                buyDetailList.AddRange(currentBuyList);

                //2.排序
                buyDetailList.Sort(BigToSamll);

                //取出10条数据
                List<BuyInfo> tempBuyInfo=new List<BuyInfo>();
                int iSeqNo = buyDetailList.Count;
                int iCountRow = 0;
                foreach (Buy buy in buyDetailList)
                {
                    if (iCountRow > 10)
                        break;
                    tempBuyInfo.Add(new BuyInfo(iSeqNo, buy));
                    iSeqNo--;
                }

                GVBiddingCustomerInfo.DataSource = tempBuyInfo;

                SetContentHeigh(GVBiddingCustomerInfo, DetailContextHeight);

                ClearRowsSelect(GVBiddingCustomerInfo);

                //blShowEndFlash = false;
            }
        }


        /// <summary>
        /// 显示竞价客户详细信息
        /// </summary>
        public void BindBuyDetail(List<Buy> currentBuyList)
        {
            if (dtBuyEnd < dtServerTime)
            {
                SetTimeDownValue(strProjectEnded);
                ledClockControls1.CountDownEndTime = Convert.ToDateTime("1990-01-01 00:00:00");
                blListDetail = false;
            }

            BindBuyDetailInvoke(currentBuyList);
        }


        /// <summary>
        /// 实现泛型竞价时间从最新到最早的数据排序
        /// </summary>
        /// <param name="info1"></param>
        /// <param name="info2"></param>
        /// <returns></returns>
        private int BigToSamll(Buy info1,Buy info2)
        {
            if (info1 == null || info1.buyTime == null)
            {
                if (info2 == null || info2.buyTime == null)
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (info2 == null || info2.buyTime == null)
                    return -1;
                else
                {
                    return info2.id.CompareTo(info1.id);
                }
            }
        }
        
        /// <summary>
        /// 修改字段
        /// </summary>
        /// <param name="model"></param>
        public void ChangeFiled(ProjectFiled model)
        {
            dtBuyEnd = Convert.ToDateTime(model.endTime);
            GVBiddingInfo.Rows[5].Cells[3].Value = model.endTime;
            ledClockControls1.CountDownEndTime = dtBuyEnd;
        }
        
        /// <summary>
        /// 竞价等待
        /// </summary>
        public void WaitBuy()
        {
            SetTimeDownValue(strProjectStarting);
        }

        /// <summary>
        /// 竞价开始
        /// </summary>
        public void StartBuy()
        {
            //竞价开始倒数计时切换回基本信息显示
            ProjectInfoShow_timer.Enabled = false;
            SetProjectInfoVisible(true);
            
            blListDetail = true;
            SetTimeDownValue(strProjectEnding);
            ledClockControls1.CountDownEndTime = dtBuyEnd;

            ShowFlash(true, "", null); //第二个参数对于当前无效,可随便传
        }
        
        /// <summary>
        /// 竞价暂停
        /// </summary>
        public void SuspendBuy()
        {
            //竞价开始倒数计时切换回基本信息显示
            ProjectInfoShow_timer.Enabled = false;
            SetProjectInfoVisible(true);

            blListDetail = true;
            SetTimeDownValue(strProjectSuspend);
            ledClockControls1.CountDownEndTime = dtBuyEnd;
        }
        
        /// <summary>
        /// 竞价恢复
        /// </summary>
        public void RecoverBuy()
        {
            //竞价开始倒数计时切换回基本信息显示
            ProjectInfoShow_timer.Enabled = false;
            SetProjectInfoVisible(true);

            blListDetail = true;
            SetTimeDownValue(strProjectEnding);
            ledClockControls1.CountDownEndTime = dtBuyEnd;
        }
        
        /// <summary>
        /// 竞价结束
        /// </summary>
        public void EndBuy(string result)
        {
            SetTimeDownValue(strProjectEnded);
            ledClockControls1.CountDownEndTime = Convert.ToDateTime("1990-01-01 00:00:00");
            blListDetail = false;
            ProjectInfoShow_timer.Enabled = true;

            ShowFlash(false, result, buyDetailList);
        }
        
        private void ledClockControls1_CountDownTotalSecondsChangeEvent(object sender, EventArgs e)
        {
            /*
            //开始竞拍倒计时，剩余10秒插入音频，音频可设置
            if (blListDetail == false && ledClockControls1.CountDownTotalSeconds == 10)
            {
                // 去掉10秒倒计时声音 [9/3/2012 xgd]
                //PlayMusic(strMusicStart, true);

                //竞价开始倒数计时切换回基本信息显示
                ProjectInfoShow_timer.Enabled = false;
                lblProjectInfo.Visible = false;
                GVBiddingInfo.Visible = true;
            }
            //剩余1秒切换成结束竞拍倒计时
            else if (blListDetail == false && ledClockControls1.CountDownTotalSeconds == 1)
            {
                // 修改为接收到竞价开始指令才执行 [9/3/2012 xgd]
                if (blShowEndFlash)
                    return;
                blShowEndFlash = true;
                blListDetail = true;
                LblTimeDown.Text = strProjectEnding;
                ledClockControls1.CountDownEndTime = dtBuyEnd;

                ShowFlash(true, null);
            }
            //结束竞拍倒计时，剩余10秒插入音频，可设置
            else if (blListDetail && ledClockControls1.CountDownTotalSeconds == 10)
            {
                // 去掉10秒倒计时声音 [9/3/2012 xgd]
                //PlayMusic(strMusicEnd, false);
                blShowEndFlash = false;
            }
            //竞拍结束，显示竞拍成功的用户
            else if (blListDetail && ledClockControls1.CountDownTotalSeconds == 1)
            {
                if (blShowEndFlash)
                    return;
                ledClockControls1.CountDownEndTime = Convert.ToDateTime("1990-01-01 00:00:00");
                blShowEndFlash = true;
                LblTimeDown.Text = strProjectEnded;
                blListDetail = false;

                ProjectInfoShow_timer.Enabled = true;
                ShowFlash(false, buyDetailList);
            }
             */
        }

        private void GVBiddingInfo_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            SetBaseHeadWidht();
        }
        
        public void SetBaseHeadWidht()
        {
            lblHeadBase.Width = CountColsWidth(GVBiddingInfo);
        }
        
        private int CountColsWidth(DataGridView dgvTemp)
        {
            if (dgvTemp.Columns.Count <= 0) return 0;
            
            int iCount = 0;
            
            foreach(DataGridViewColumn col in dgvTemp.Columns)
            {
                iCount += col.Width;
            }
            return iCount;
        }
        
        /// <summary>
        /// 播放声音
        /// </summary>
        /// <param name="strFileName">声音路径</param>
        /// <param name="blStart">是开始，还是结束</param>
        private void PlayMusic(string strFileName,bool blStart)
        {
            if (!System.IO.File.Exists(strFileName))
                return;
            System.Media.SoundPlayer sP;
            if (blStart)
            {
                //如果设置了开始竞价倒计时静音，则不播放声音
                if (blMusicStartOpen)
                    return;
                if (strFileName == string.Empty)
                {
                    sP = new SoundPlayer(Resources.ResourceManager.GetStream("MusicStart"));
                    sP.Play();
                }
                else
                {
                    if (System.IO.File.Exists(strFileName))
                    {
                        sP = new SoundPlayer(strFileName);
                        sP.Play();
                    }
                    else
                    {
                        sP = new SoundPlayer(Resources.ResourceManager.GetStream("MusicStart"));
                        sP.Play();
                    }
                }
            }
            else
            {
                //如果设置了结束竞价倒计时静音，则不播放声音
                if (blMusicEndOpen)
                    return;
                if (strFileName == string.Empty)
                {
                    sP = new SoundPlayer(Resources.ResourceManager.GetStream("MusicEnd"));
                    sP.Play();
                }
                else
                {
                    if (System.IO.File.Exists(strFileName))
                    {
                        sP = new SoundPlayer(strFileName);
                        sP.Play();
                    }
                    else
                    {
                        sP = new SoundPlayer(Resources.ResourceManager.GetStream("MusicEnd"));
                        sP.Play();
                    }
                }
            }
        }
        
        //private void PlayEndMusic(string strFileName,bool blSomeOne)
        //{
        //    if (strFileName == string.Empty)
        //        return;
        //    System.Media.SoundPlayer sP;
        //    if (blSomeOne)//有人竞拍
        //    {
        //        //如果设置了结束竞价时，有人竞拍为静音，则不播放声音
        //        if (blMusicSomeOneOpen)
        //            return;
        //        sP = new SoundPlayer(strFileName);
        //        sP.Play();
        //    }
        //    else//无人竞拍
        //    {
        //        //如果设置了结束竞价时，无人竞拍为静音，则不播放声音
        //        if (blMusicNoOneOpen)
        //            return;
        //        sP = new SoundPlayer(strFileName);
        //        sP.Play();
        //    }
        //}

        /// <summary>
        /// 显示Flash，第二个参数表示竞拍成功或失败，对于开始显示没有意义
        /// </summary>
        /// <param name="blStart"></param>
        /// <param name="result"></param>
        /// <param name="lTemp"></param>
        private void ShowFlash(bool blStart, string result, List<Buy> lTemp)
        {            
            //是否有人竞拍
            bool blSomeOne = false;

            if (!blStart)
            {
                if (lTemp == null || lTemp.Count <=0)
                {
                    SetFlashText("pmcg=当前项目无人竞拍");
                }
                else
                {
                    bool blSuccess = (result != "1");
                    if(!blSuccess)
                    {
                        SetFlashText("pmcg=当前项目竞拍失败");
                    }
                    else
                    {
                        SetFlashText(string.Format("pmcg={0}竞拍成功", result));
                        blSomeOne = true;
                    }
                }
            }

            string strEndMusic = string.Empty;
            if (!blStart)
            {
                if (blSomeOne)
                    strEndMusic = strMusicSomeOne;
                else
                    strEndMusic = strMusicNoOne;
            }

            ShowFlashDemo(blStart, blStart ? iStartFlash : iEndFlash, strEndMusic, blSomeOne);
        }

        private delegate void ShowFlashDemoCallback(bool blFlag, int iCloseFlash, string MusicFilePath, bool blSomeOne);
        private void ShowFlashDemo(bool blFlag, int iCloseFlash, string MusicFilePath, bool blSomeOne)
        {
            if (LblTimeDown.InvokeRequired)
            {
                ShowFlashDemoCallback d = new ShowFlashDemoCallback(ShowFlashDemo);
                this.Invoke(d, new object[] { blFlag, iCloseFlash, MusicFilePath, blSomeOne });
            }
            else
            {
                frmFlashDemo frmFlash = new frmFlashDemo(fc.FScreen2);
                frmFlash.blFlag = blFlag;
                frmFlash.iCloseFlash = iCloseFlash;

                frmFlash.MusicFilePath = MusicFilePath;
                frmFlash.blSomeOne = blSomeOne;

                frmFlash.Show();
            }
        }
        
        public bool SetFlashText(string strText)
        {
            try
            {
                string strFile = Application.StartupPath + @"\Flash\test.txt";
                FileStream flStream = new FileStream(strFile, FileMode.Create);
                StreamWriter strWriter = new StreamWriter(flStream,Encoding.Unicode);
                strWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                strWriter.Write(strText);
                strWriter.Flush();
                strWriter.Close();
                return true;
            }
            catch(Exception er)
            {
                return false;
            }
        }
       
        
        /// <summary>
        /// 清楚网格选中
        /// </summary>
        /// <param name="dgvTemp"></param>
        private void ClearRowsSelect(DataGridView dgvTemp)
        {
            dgvTemp.ClearSelection();
            //this.panelTitle.Focus();
        }

        private void frmLEDScreen2_Load(object sender, EventArgs e)
        {
            ClearRowsSelect(GVBiddingInfo);
        }

        private void CurrentTime_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_CurrentTime.Text = string.Format("{0}年{1}月{2}日 {3} {4:T}", dt.Year, dt.Month, dt.Day,
                                                 CommFunction.GetWeekOfDay(dt), dt);
        }

        private delegate void SetProjectInfoVisibleCallback(bool blVisible);
        private void SetProjectInfoVisible(bool blVisible)
        {
            if (LblTimeDown.InvokeRequired)
            {
                SetProjectInfoVisibleCallback d = new SetProjectInfoVisibleCallback(SetProjectInfoVisible);
                this.Invoke(d, blVisible);
            }
            else
            {
                if (blShowProjectBaseInfo == false)
                {
                    lblProjectInfo.DocumentText =
                        "<html><body bgcolor='#" + GVBiddingInfo.BackgroundColor.Name.Substring(2) +
                        "' style='border: 1px solid #" + GVBiddingInfo.GridColor.Name.Substring(2) + "'>" +
                        "<script language='javascript'>var i=0;function f(){i+=0.5;window.scrollTo(1,i);if(i==document.body.scrollHeight- 100) i=0;}  " +
                        "function run(){setInterval('f()'," + iProjectMarquee +
                        ");} window.onload=function(){ setTimeout('run()',1000); }</script>" +
                        "<font face='" + GVBiddingInfo.Rows[0].Cells[0].Style.Font.Name + "' style=font-size:" +
                        (GVBiddingInfo.Rows[0].Cells[0].Style.Font.Size + 3) + "px color='" +
                        GVBiddingInfo.Rows[0].Cells[0].Style.ForeColor.Name.Substring(2) + "'>" +
                        strProjectInfo.Replace("\r\n","<br/>") + "</font></body></html>";
                }
                lblProjectInfo.Visible = !blVisible;
                GVBiddingInfo.Visible = blVisible;
            }
        }


        private bool blShowProjectBaseInfo = false;
        private void ProjectInfoShow_timer_Tick(object sender,ElapsedEventArgs e)//(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strProjectInfo) && blListDetail == false)//不为空并且没有开始竞拍才切换
            {
                SetProjectInfoVisible(blShowProjectBaseInfo);
                blShowProjectBaseInfo = !blShowProjectBaseInfo;
            }
        }
        
        
        
        
        
    }
}