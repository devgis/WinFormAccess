#region

using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System;
using CAEELEDPlayer.Common.Model;
using CAEELEDPlayer.Settings;
using System.Threading;
using Timer=System.Threading.Timer;

#endregion

namespace CAEELEDPlayer.Common
{

    /// <summary>
    /// 窗体操作类
    /// </summary>
    public class FormControl
    {
        private volatile static FormControl _instance = null;

        private static frmLEDScreen1 fScreen1 = null;
        private static frmLEDScreen2 fScreen2 = null;
        private static frmLEDScreen3 fScreen3 = null;
        private static frmLEDScreen4 fScreen4 = null;
        private static frmConsole fConsole = null;
        private static frmScreenSetting fSetting = null;
        private static SettingsCommon settingsCommon = null;
        private static SettingsScreen1 settingsScreen1 = null;
        private static SettingsScreen2 settingsScreen2 = null;

        private int RequestSpan = 0;
        private static bool blInit = false;
        private bool bFirst = true;
        
        //private Timer tMonit;
        //private static AutoResetEvent autoEvent = new AutoResetEvent(false);
        
        static Thread thRequestData;
        static Thread thRequestData2;

        private List<ResponseData> listData;
        private List<ResponseData> listData2;
        
        private static readonly object lockHelper = new object();
        
        
       
        private FormControl()
        {
            RequestSpan = ConfigReader.RequestSpan * 1000;
            thRequestData = new Thread(MonitData);
            thRequestData2 = new Thread(MonitData2);
            
            
            //TimerCallback timerDelegate = new TimerCallback(MonitData);
            //tMonit = new Timer(timerDelegate, null, new TimeSpan(0), new TimeSpan(0, 0, RequestSpan));
        }


        #region 已将请求接口分为多个
        /// <summary>
        /// 获取服务器数据来同步当前数据
        /// </summary>
        /// <param name="o"></param>
        /*
        private void MonitData(object o)
        {
            //autoEvent.WaitOne();
            if (!blInit)
            {
                //autoEvent.Set();
                return;
            }

            if (bFirst)
            {
                bFirst = false;
                listData = RequestData.GetData("1001", 2);//屏幕2第一次请求数据
            }
            else
                listData = RequestData.GetData();

            if (listData == null || listData.Count <= 0)
            {
                //autoEvent.Set();
                return;
            }
            
            foreach(ResponseData data in listData)
            {
                switch(data.Cmd)
                {
                    case (int)ResultCmd.NewProject:
                        Screen1Data.GetProjectInfo(data.Content);//项目信息数据
                        break;
                    case (int)ResultCmd.ProjectBase://竞价项目基本数据
                        Screen2Data.GetProjectShowInfo(data.Content);
                        break;
                    case (int)ResultCmd.ProjectViw://竞价信息
                        Screen2Data.GetBuyInfo(data.Content);
                        break;
                    case (int)ResultCmd.ProjectStatus://竞价状态改变通知
                        Screen2Data.ChangeProjectStatus(data.Content);
                        break;
                    case (int)ResultCmd.ScreenTab://切换屏幕
                        Screen1Data.TabScreen(data.Content);
                        break;
                    default :
                        break;
                }
            }

           // autoEvent.Set();
            
            return;
        }*/
        
        #endregion 已将请求接口分为多个

        /// <summary>
        /// 屏幕2请求数据接口
        /// </summary>
        private void MonitData2()
        {
            while (true)
            {
                if (!blInit)
                {
                    Thread.Sleep(RequestSpan);
                    continue;
                }

                if (bFirst)
                {
                    bFirst = false;
                    listData2 = RequestData.GetData("1001", 2);//屏幕2第一次请求数据
                }
                else
                    listData2 = RequestData.GetData("", 2);

                if (listData2 == null || listData2.Count <= 0)
                {
                    Thread.Sleep(RequestSpan);
                    continue;
                }

                foreach (ResponseData data in listData2)
                {
                    switch (data.Cmd)
                    {
                        //case (int)ResultCmd.NewProject:
                        //    Screen1Data.GetProjectInfo(data.Content);//项目信息数据
                        //    break;
                        case (int)ResultCmd.ProjectBase://竞价项目基本数据
                            Screen2Data.GetProjectShowInfo(data.Content);
                            break;
                        case (int)ResultCmd.ProjectViw://竞价信息
                            Screen2Data.GetBuyInfo(data.Content);
                            break;
                        case (int)ResultCmd.ProjectStatus://竞价状态改变通知
                            Screen2Data.ChangeProjectStatus(data.Content);
                            break;
                        case (int)ResultCmd.ScreenTab://切换屏幕
                            Screen1Data.TabScreen(data.Content);
                            break;
                        case (int)ResultCmd.ChangProjectField://改变竞价信息基本信息的字段值
                            Screen2Data.ChangeProjectField(data.Content);
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(RequestSpan);
            }
        }

        /// <summary>
        /// 屏幕1请求数据接口
        /// </summary>
        private void MonitData()
        {
            while (true)
            {
                if (!blInit)
                {
                    Thread.Sleep(RequestSpan);
                    continue;
                }

                listData = RequestData.GetData("", 1);

                if (listData == null || listData.Count <= 0)
                {
                    Thread.Sleep(RequestSpan);
                    continue;
                }

                foreach (ResponseData data in listData)
                {
                    switch (data.Cmd)
                    {
                        case (int)ResultCmd.NewProject:
                            Screen1Data.GetProjectInfo(data.Content);//项目信息数据
                            break;
                        //case (int)ResultCmd.ProjectBase://竞价项目基本数据
                        //    Screen2Data.GetProjectShowInfo(data.Content);
                        //    break;
                        //case (int)ResultCmd.ProjectViw://竞价信息
                        //    Screen2Data.GetBuyInfo(data.Content);
                        //    break;
                        //case (int)ResultCmd.ProjectStatus://竞价状态改变通知
                        //    Screen2Data.ChangeProjectStatus(data.Content);
                        //    break;
                        case (int)ResultCmd.ScreenTab://切换屏幕
                            Screen1Data.TabScreen(data.Content);
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(RequestSpan);
            }
        }
        

        /// <summary>
        /// 参数命令类型
        /// </summary>
        enum ResultCmd
        {
            InitProject = 1001,//项目信息初始化同步
            NewProject = 1002,//项目信息新增
            ProjectBase = 1003,//竞价项目基本信息同步
            ProjectViw = 1004, //项目竞价信息同步
            ProjectStatus = 1005, //项目竞价状态改变通知
            ScreenTab = 1006, //大屏幕切换
            ChangProjectField = 1007 //修改基本信息的值
        }

        private static int _currentScreen = 1;

        public static FormControl CreateInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new FormControl();
                    if (fSetting == null)
                        fSetting = new frmScreenSetting();
                    if (fScreen1 == null)
                        fScreen1 = new frmLEDScreen1();
                    if (fScreen2 == null)
                        fScreen2 = new frmLEDScreen2();
                    //if (fScreen3 == null)
                    //    fScreen3 = new frmLEDScreen3();
                    //if (fScreen4 == null)
                    //    fScreen4 = new frmLEDScreen4();
                    if (fConsole == null)
                        fConsole = new frmConsole();
                    if (settingsCommon == null)
                        settingsCommon = new SettingsCommon(1);
                    if (settingsScreen1 == null)
                        settingsScreen1 = new SettingsScreen1(1);
                    if (settingsScreen2 == null)
                        settingsScreen2 = new SettingsScreen2(1);
                }
                fSetting.Init();
                blInit = true;
                //autoEvent.Set();
                thRequestData.Start();
                thRequestData2.Start();
            }
            return _instance;
        }
        
        //public static FormControl GetInstance()
        //{
            
        //}

        public Form CurrentScreen
        {
            get
            {
                switch (_currentScreen)
                {
                    case 1:
                        return fScreen1;
                    case 2:
                        return fScreen2;
                    case 3:
                        return fScreen3;
                    case 4:
                        return fScreen4;
                    default:
                        return fScreen1;
                }
            }
        }

        public frmConsole FConsole
        {
            get { return fConsole; }
        }


        public frmLEDScreen1 FScreen1
        {
            get { return fScreen1; }
        }

        public frmLEDScreen2 FScreen2
        {
            get { return fScreen2; }
        }

        public frmLEDScreen3 FScreen3
        {
            get { return fScreen3; }
        }

        public frmLEDScreen4 FScreen4
        {
            get { return  fScreen4; }
        }
        public frmScreenSetting FSetting
        {
            get { return fSetting; }
        }

        public SettingsCommon SettingCommon
        {
            get { return settingsCommon; }
        }

        public SettingsScreen1 SettingScreen1
        {
            get { return settingsScreen1; }
        }
        
        public SettingsScreen2 SettingScreen2
        {
            get { return settingsScreen2; }
        }


        public Form GetScreen(int index)
        {
            switch (index)
            {
                case 1:
                    return fScreen1;
                case 2:
                    return fScreen2;
                case 3:
                    return fScreen3;
                case 4:
                    return fScreen4;
                default:
                    return fScreen1;
            }
        }

        public void ShowScreen(int index)
        {
            _currentScreen = index;

            switch (index)
            {
                case 1:
                    fScreen1.Show();
                    fScreen2.Hide();
                    //fScreen3.Hide();
                    //fScreen4.Hide();
                    InitScreen1();
                    break;
                case 2:
                    fScreen1.Hide();
                    fScreen2.Show();
                    //fScreen3.Hide();
                    //fScreen4.Hide();
                    InitScreen2();
                    FScreen2.StartList();
                    break;
                case 3:
                    fScreen1.Hide();
                    fScreen2.Hide();
                    fScreen3.Show();
                    fScreen4.Hide();
                    break;
                case 4:
                    fScreen1.Hide();
                    fScreen2.Hide();
                    fScreen3.Hide();
                    fScreen4.Show();
                    break;
                default:
                    fScreen1.Show();
                    fScreen2.Hide();
                    //fScreen3.Hide();
                    //fScreen4.Hide();
                    InitScreen1();
                    break;
            }
        }

        public void hidScreen()
        {
            CurrentScreen.Hide();
            CurrentScreen.Dispose();
        }

        public void ShowConsole()
        {
            fConsole.Show();
        }

        public void ShowSettings(int tabIndex)
        {
            fSetting.TabIndex = tabIndex;
            fSetting.ShowDialog();
        }

        public void hidConsole()
        {
            fConsole.Hide();
            fConsole.Dispose();
        }
        
        private void InitCommon()
        {
            if (settingsCommon == null) return;
            
            CurrentScreen.Location = new Point(SettingCommon.ScreenX, SettingCommon.ScreenY);

            CurrentScreen.Height = settingsCommon.ScreenH;
            CurrentScreen.Width = settingsCommon.ScreenW;
            CurrentScreen.BackColor = settingsCommon.ScreenColor;
            CurrentScreen.ForeColor = settingsCommon.ScreenFontColor;

            fConsole.numericX.Value = settingsCommon.ScreenX;
            fConsole.numericY.Value = settingsCommon.ScreenY;
            fConsole.numericH.Value = settingsCommon.ScreenH;
            fConsole.numericW.Value = settingsCommon.ScreenW;
            fConsole.NumScreenMargin.Value = settingsCommon.ScreenMargin;

            fConsole.NumScreenBorderSize.Value = settingsCommon.BorderWidth;
            fConsole.panelBackColor.BackColor = settingsCommon.ScreenColor;
            fConsole.panelBorderColor.BackColor = settingsCommon.ScreenLineColor;
            fConsole.panelFontColor.BackColor = settingsCommon.ScreenFontColor;
        }

        public void InitScreen1()
        {
            try
            {
                //if (settingsCommon == null)
                    settingsCommon = new SettingsCommon(1);
                //if (settingsScreen1 == null)
                    settingsScreen1 = new SettingsScreen1(1);

                if (CurrentScreen != null && SettingCommon != null && SettingCommon.ID == 1)
                {
                    
                    //初始化公共属性
                    InitCommon();
                    
                    FScreen1.GridViewDate.BackgroundColor = settingsCommon.ScreenColor;
                    FScreen1.GridViewDate.RowsDefaultCellStyle.BackColor = settingsCommon.ScreenColor;
                    FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor = settingsCommon.ScreenColor;

                    FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor = settingsCommon.ScreenFontColor;
                    FScreen1.GridViewDate.ForeColor = settingsCommon.ScreenFontColor;
                    FScreen1.lblTitle.ForeColor = settingsCommon.ScreenFontColor;
                    FScreen1.lbl_CurrentTime.ForeColor = settingsCommon.ScreenFontColor;
                    FScreen1.scrollingTextAffiche.ForeColor = settingsCommon.ScreenFontColor;

                    FScreen1.panelMain.BorderColor = SettingCommon.ScreenLineColor;
                }

                if (SettingScreen1 != null && SettingScreen1.ID != 0)
                {
                    FScreen1.lblTitle.Text = SettingScreen1.S1Title;
                    FScreen1.lblTitle.Font = SettingScreen1.S1TitleFont;
                    FScreen1.lblTitle.ForeColor = SettingScreen1.S1TitleFontColor;

                    fScreen1.lblTitle.Location = SettingScreen1.S1TitleLocation;

                    FScreen1.lbl_CurrentTime.Font = SettingScreen1.S1TimeFont;
                    FScreen1.lbl_CurrentTime.ForeColor = SettingScreen1.S1TimeFontColor;

                    fScreen1.lbl_CurrentTime.Location = SettingScreen1.S1TimeLocation;
                    
                    FScreen1.panelTitle.Height = SettingScreen1.S1TitleHeight;
                    FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.Font = SettingScreen1.S1TableHeaderFont;
                    FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor = SettingScreen1.S1TableHeaderFontColor;
                    FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor = SettingScreen1.S1TableHeaderBColor;
                    FScreen1.GridViewDate.ColumnHeadersHeight = SettingScreen1.S1TableHeaderHeight;
                    FScreen1.GridViewDate.Font = SettingScreen1.S1TableFont;
                    FScreen1.GridViewDate.ForeColor = SettingScreen1.S1TableFontColor;
                    FScreen1.GridViewDate.GridColor = SettingScreen1.S1TableLineColor;

                    FScreen1.timer.Interval = SettingScreen1.S1TablePageSpeed * 1000;
                    FScreen1.PageSize = SettingScreen1.S1TablePageSize;
                    FScreen1.timerSyn.Interval = SettingScreen1.S1TableDataSyn * 1000;
                    FScreen1.GridViewDate.AutoSizeColumnsMode = SettingScreen1.S1TableAutoSizeColumns
                                                                    ? DataGridViewAutoSizeColumnsMode.Fill
                                                                    : DataGridViewAutoSizeColumnsMode.None;


                    FScreen1.TableBorderStyle = SettingScreen1.S1TableBorderStyle;
                    FScreen1.TableBorderSize = SettingScreen1.S1TableBorderWidth;

                    //SettingScreen1.S1TableShowColumns = new List<DataGridViewColumn>();
                    foreach (DataGridViewColumn col in SettingScreen1.S1TableShowColumns)
                    {
                        if (FScreen1.GridViewDate.Columns.Count <= 0) continue;
                        FScreen1.GridViewDate.Columns[col.Name].Width = col.Width;
                        FScreen1.GridViewDate.Columns[col.Name].Visible = col.Visible;
                    }
                    FScreen1.scrollingTextAffiche.ScrollText = SettingScreen1.S1Affiche;
                    FScreen1.scrollingTextAffiche.Font = SettingScreen1.S1AfficheFont;
                    FScreen1.scrollingTextAffiche.ForeColor = SettingScreen1.S1AfficheFontColor;
                    FScreen1.panelBottom.Height = SettingScreen1.S1AfficheHeight;
                    FScreen1.DataFlag = SettingScreen1.S1DataFlag;
                    FScreen1.RowHeight = SettingScreen1.S1TableContextHeight;
                    FScreen1.scrollingTextAffiche.ScrollDirection =
                        (ScrollingTextControl.ScrollDirection) SettingScreen1.S1AfficheDirection;
                    FScreen1.scrollingTextAffiche.TextScrollSpeed = SettingScreen1.S1AfficheSpend;
                    FScreen1.SetRowHeight();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "初始化错误！", MessageBoxButtons.OK);
            }
        }

        public void InitScreen2()
        {
            try
            {
                settingsCommon = new SettingsCommon(2);
                settingsScreen2 = new SettingsScreen2(1);

                if (CurrentScreen != null && SettingCommon != null && SettingCommon.ID == 2)
                {
                    InitCommon();

                    FScreen2.GVBiddingCustomerInfo.BackgroundColor = SettingCommon.ScreenColor;
                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = SettingCommon.ScreenColor;
                    FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.BackColor = SettingCommon.ScreenColor;
                    FScreen2.GVBiddingInfo.BackgroundColor = SettingCommon.ScreenColor;
                    FScreen2.GVBiddingInfo.ColumnHeadersDefaultCellStyle.BackColor = SettingCommon.ScreenColor;
                    FScreen2.GVBiddingInfo.RowsDefaultCellStyle.BackColor = SettingCommon.ScreenColor;

                    FScreen2.clockControl1.BackColor = SettingCommon.ScreenColor;
                    FScreen2.clockControls1.BackColor = SettingCommon.ScreenColor;
                    FScreen2.ledClockControls1.BackColor = SettingCommon.ScreenColor;
                    FScreen2.panelEx2.BackColor = SettingCommon.ScreenColor;
                    FScreen2.panelBaseHead.BackColor = SettingCommon.ScreenColor;
                    FScreen2.panelBaseContent.BackColor = SettingCommon.ScreenColor;
                    FScreen2.lblHeadBase.BackColor = SettingCommon.ScreenColor;
                    FScreen2.LblTimeDown.BackColor = SettingCommon.ScreenColor;
                    fScreen2.lbl_CurrentTime.BackColor = SettingCommon.ScreenColor;
                    FScreen2.panelContent.BackColor = SettingCommon.ScreenColor;
                    FScreen2.scrollingTextAffiche.BackColor = SettingCommon.ScreenColor;
                    FScreen2.panelBottom.BackColor = SettingCommon.ScreenColor;
                    if (FScreen2.GVBiddingInfo.Rows.Count > 0)
                    {
                        for (int i = 0; i < FScreen2.GVBiddingInfo.ColumnCount; i++)
                        {
                            foreach (DataGridViewRow row in FScreen2.GVBiddingInfo.Rows)
                            {
                                row.Cells[i].Style.BackColor = SettingCommon.ScreenColor;
                                row.Cells[i].Style.ForeColor = SettingCommon.ScreenFontColor;
                            }
                        }
                    }

                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor = SettingCommon.ScreenFontColor;
                    FScreen2.GVBiddingCustomerInfo.ForeColor = SettingCommon.ScreenFontColor;
                    FScreen2.GVBiddingInfo.ColumnHeadersDefaultCellStyle.ForeColor = SettingCommon.ScreenFontColor;
                    FScreen2.GVBiddingInfo.ForeColor = SettingCommon.ScreenFontColor;
                    FScreen2.ledClockControls1.ClockColor = SettingCommon.ScreenFontColor;
                    FScreen2.clockControls1.ClockColor = SettingCommon.ScreenFontColor;
                    FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.ForeColor = SettingCommon.ScreenFontColor;
                    FScreen2.GVBiddingInfo.RowsDefaultCellStyle.ForeColor = SettingCommon.ScreenFontColor;

                    

                    FScreen2.panelMain.BorderColor = SettingCommon.ScreenLineColor;
                }
                if (CurrentScreen != null && SettingScreen2 != null && SettingScreen2.ID == 1)
                {
                    FScreen2.clockControl1.BackColor = SettingScreen2.S2AreaBackColorTime;
                    FScreen2.clockControls1.BackColor = SettingScreen2.S2AreaBackColorTime;
                    FScreen2.panelEx2.BackColor = SettingScreen2.S2AreaBackColorTime;
                    FScreen2.panelBaseHead.BackColor = SettingScreen2.S2AreaBackColorBase;
                    FScreen2.panelBaseContent.BackColor = SettingScreen2.S2AreaBackColorBase;
                    FScreen2.lblHeadBase.BackColor = SettingScreen2.S2AreaBackColorBase;
                    fScreen2.lbl_CurrentTime.BackColor = FScreen2.lblHeadBase.BackColor;
                    FScreen2.GVBiddingInfo.BackgroundColor = SettingScreen2.S2AreaBackColorBase;
                    FScreen2.GVBiddingInfo.RowsDefaultCellStyle.BackColor = SettingScreen2.S2AreaBackColorBase;
                    FScreen2.panelContent.BackColor = SettingScreen2.S2AreaBackColorDetail;
                    FScreen2.GVBiddingCustomerInfo.BackgroundColor = SettingScreen2.S2AreaBackColorDetail;
                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = SettingScreen2.S2AreaBackColorDetail;
                    FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.BackColor = SettingScreen2.S2AreaBackColorDetail;
                    FScreen2.scrollingTextAffiche.BackColor = SettingScreen2.S2AreaBackColorBottom;
                    FScreen2.panelBottom.BackColor = SettingScreen2.S2AreaBackColorBottom;
                    FScreen2.LblTimeDown.Font = SettingScreen2.S2BuyTitleFont;
                    FScreen2.LblTimeDown.ForeColor = SettingScreen2.S2BuyTitleColor;
                    FScreen2.LblTimeDown.Height = SettingScreen2.S2BuyTitleHeight;
                    FScreen2.clockControl1.BackColor = SettingScreen2.S2ClockBackColor;
                    FScreen2.clockControl1.HourHandColor = SettingScreen2.S2HourHandColor;
                    FScreen2.clockControl1.MinuteHandColor = SettingScreen2.S2MinuteHandColor;
                    FScreen2.clockControl1.SecondHandColor = SettingScreen2.S2SecondColor;
                    FScreen2.clockControl1.ScaleColor = SettingScreen2.S2ScaleColor;
                    FScreen2.clockControls1.ClockColor = SettingScreen2.S2TimeForeColor;
                    FScreen2.clockControls1.BackColor = SettingScreen2.S2TimeBackColor;
                    FScreen2.ledClockControls1.ClockColor = SettingScreen2.S2LedClockForeColor;
                    FScreen2.ledClockControls1.BackColor = SettingScreen2.S2LedClockBackColor;
                    FScreen2.ledClockControls1.Location =
                        new Point(FScreen2.ledClockControls1.Location.X, SettingScreen2.S2LedClockHeight);
                    FScreen2.strMusicStart = SettingScreen2.S2StartMusic;
                    FScreen2.strMusicEnd = SettingScreen2.S2EndMusic;
                    
                    ///////////////////////////////////////////////////////////
                    //开始文字设置功能暂未实现，先不初始化
                    
                    //结束文字设置功能暂未实现，先不初始化
                    
                    ///////////////////////////////////////////////////////////
                    FScreen2.strProjectTitle = SettingScreen2.S2ProjectTitleText;
                    FScreen2.lblHeadBase.Text = SettingScreen2.S2ProjectTitleText;
                    FScreen2.lblHeadBase.Font = SettingScreen2.S2ProjectTitleFont;
                    FScreen2.lblHeadBase.ForeColor = SettingScreen2.S2ProjectTitleForeColor;
                    FScreen2.lblHeadBase.Font = SettingScreen2.S2BaseHeadFont;
                    FScreen2.lblHeadBase.ForeColor = SettingScreen2.S2BaseHeadForeColor;
                    FScreen2.lblHeadBase.BackColor = FScreen2.lblHeadBase.BackColor;

                    FScreen2.lbl_CurrentTime.Font = SettingScreen2.S2TimeFont;
                    FScreen2.lbl_CurrentTime.ForeColor = SettingScreen2.S2TimeFontColor;

                    FScreen2.panelBaseHead.Height = SettingScreen2.S2BaseHeadHeight;

                    FScreen2.GVBiddingInfo.DefaultCellStyle.Font = SettingScreen2.S2BaseContextFont;
                    FScreen2.GVBiddingInfo.DefaultCellStyle.ForeColor = SettingScreen2.S2BaseContextForeColor;
                    FScreen2.GVBiddingInfo.GridColor = SettingScreen2.S2BaseContextGridColor;
                    FScreen2.BaseContextHeight = SettingScreen2.S2BaseContextHeight;
                    for (int i = 0; i < FScreen2.GVBiddingInfo.Rows.Count; i++)
                    {
                        FScreen2.GVBiddingInfo.Rows[i].Height = SettingScreen2.S2BaseContextHeight;
                    }
                    FScreen2.iBaseSpan = SettingScreen2.S2BaseDataSyn * 1000;
                    //FScreen2.timerBase.Interval = SettingScreen2.S2BaseDataSyn * 1000;
                    FScreen2.GVBiddingInfo.AutoSizeColumnsMode = SettingScreen2.S2BaseAutoSizeColumns
                                                                     ? DataGridViewAutoSizeColumnsMode.Fill
                                                                     : DataGridViewAutoSizeColumnsMode.None;
                    FScreen2.GVBiddingInfo.BorderStyle = SettingScreen2.S2BaseBorderStyle;
                    //边框线条该功能未实现，先不初始化
                    //SettingScreen2.S2BaseBorderWidth = 0;
                    
                    for(int i=0; i<FScreen2.GVBiddingInfo.ColumnCount;i++)
                    {
                        foreach(DataGridViewRow row in FScreen2.GVBiddingInfo.Rows)
                        {
                            if (SettingScreen2.S2BaseColumnsFont.Count > i)
                                row.Cells[i].Style.Font = SettingScreen2.S2BaseColumnsFont[i];
                            if (SettingScreen2.S2BaseColumnsForeColor.Count > i)
                                row.Cells[i].Style.ForeColor = SettingScreen2.S2BaseColumnsForeColor[i];
                            if (SettingScreen2.S2BaseColumnsBackColor.Count > i)
                                row.Cells[i].Style.BackColor = SettingScreen2.S2BaseColumnsBackColor[i];
                        }
                        if (SettingScreen2.S2BaseColumnsWidth.Count > i)
                        {
                            FScreen2.GVBiddingInfo.Columns[i].Width = SettingScreen2.S2BaseColumnsWidth[i].Width;
                            FScreen2.GVBiddingInfo.Columns[i].Visible = SettingScreen2.S2BaseColumnsWidth[i].Visible;
                        }
                    }

                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.Font = SettingScreen2.S2DetailHeadFont;
                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor = SettingScreen2.S2DetailHeadForeColor;
                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = SettingScreen2.S2DetailHeadBackColor;
                    FScreen2.GVBiddingCustomerInfo.ColumnHeadersHeight = SettingScreen2.S2DetailHeadHeight;
                    FScreen2.DetailHeadHeight = SettingScreen2.S2DetailHeadHeight;
                    FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.Font = SettingScreen2.S2DetailContextFont;
                    FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.ForeColor = SettingScreen2.S2DetailContextForeColor;
                    FScreen2.GVBiddingCustomerInfo.GridColor = SettingScreen2.S2DetailContextGridColor;
                    FScreen2.DetailContextHeight = SettingScreen2.S2DetailContextHeight;
                    for (int i = 0; i < FScreen2.GVBiddingCustomerInfo.Rows.Count; i++)
                    {
                        FScreen2.GVBiddingCustomerInfo.Rows[i].Height = SettingScreen2.S2DetailContextHeight;
                    }
                    FScreen2.iDetailSpan = SettingScreen2.S2DetailDataSyn * 1000;
                    //FScreen2.timerDetail.Interval = SettingScreen2.S2DetailDataSyn * 1000;
                    FScreen2.GVBiddingCustomerInfo.AutoSizeColumnsMode = SettingScreen2.S2DetailAutoSizeColumns
                                                                             ? DataGridViewAutoSizeColumnsMode.Fill
                                                                             : DataGridViewAutoSizeColumnsMode.None;
                    FScreen2.GVBiddingCustomerInfo.BorderStyle = SettingScreen2.S2DetailBorderStyle;
                    
                    //功能未实现，先不初始化
                    //SettingScreen2.S2DetailBorderWidth = 0;

                    foreach (DataGridViewColumn col in SettingScreen2.S2DetailColumns)
                    {
                        if (FScreen2.GVBiddingCustomerInfo.Columns.Count <= 0) continue;
                        FScreen2.GVBiddingCustomerInfo.Columns[col.Name].Width = col.Width;
                        FScreen2.GVBiddingCustomerInfo.Columns[col.Name].Visible = col.Visible;
                    }

                    FScreen2.scrollingTextAffiche.ScrollText = SettingScreen2.S2AfficheText;
                    FScreen2.scrollingTextAffiche.Font = SettingScreen2.S2AfficheFont;
                    FScreen2.ForeColor = SettingScreen2.S2AfficheForeColor;
                    FScreen2.panelBottom.Height = SettingScreen2.S2AfficheHeight;
                    FScreen2.scrollingTextAffiche.ScrollDirection =
                        (ScrollingTextControl.ScrollDirection)SettingScreen2.S2AfficheDirection;
                    FScreen2.scrollingTextAffiche.TextScrollSpeed = SettingScreen2.S2AfficheSpend;
                    FScreen2.strMusicSomeOne = SettingScreen2.S2MusicSomeOne;
                    FScreen2.strMusicNoOne = SettingScreen2.S2MusicNoOne;
                    FScreen2.blMusicStartOpen = SettingScreen2.S2StartMusicOpen;
                    FScreen2.blMusicEndOpen = SettingScreen2.S2EndMusicOpen;
                    FScreen2.blMusicSomeOneOpen = SettingScreen2.S2MusicSomeOneOpen;
                    FScreen2.blMusicNoOneOpen = SettingScreen2.S2MusicNoOneOpen;
                    fScreen2.iProjectMarquee = SettingScreen2.S2ProjectInfoMarquee;
                    fScreen2.iProjectInfoSwitchTime = SettingScreen2.S2ProjectInfoSwitchTime;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "初始化错误！", MessageBoxButtons.OK);
            }
        }

        public void InitScreen3()
        {
            throw new Exception("方法未实现！");
        }

        public void InitScreen4()
        {
            throw new Exception("方法未实现！");
        }

        public bool SaveCommonDefault(bool showMsg)
        {
            if (CurrentScreen == fScreen1)
                SettingCommon.ID = 1;
            else if (CurrentScreen == fScreen2)
                SettingCommon.ID = 2;
            else if (CurrentScreen == fScreen3)
                SettingCommon.ID = 3;
            else if (CurrentScreen == fScreen4)
                SettingCommon.ID = 4;
            
            SettingCommon.SaveTime= DateTime.Now;
            SettingCommon.SettingName = string.Format("{0}_{1}", fSetting.Name, DateTime.Now.ToString("yyyyMMdd"));

            SettingCommon.ScreenX = CurrentScreen.Location.X;
            SettingCommon.ScreenY = CurrentScreen.Location.Y;
            SettingCommon.ScreenH = CurrentScreen.Height;
            SettingCommon.ScreenW = CurrentScreen.Width;
            SettingCommon.ScreenColor = CurrentScreen.BackColor;
            SettingCommon.ScreenFontColor = CurrentScreen.ForeColor;
            SettingCommon.ScreenLineColor = fConsole.panelBorderColor.BackColor;
            SettingCommon.ScreenMargin = (int)fConsole.NumScreenMargin.Value;
            SettingCommon.BorderWidth = (int)fConsole.NumScreenBorderSize.Value;

            bool orst = false;
            if (SettingCommon.Exists(SettingCommon.ID))
            {
                orst = SettingCommon.Update() > 0;
            }
            else
            {
                orst = SettingCommon.Add() > 0;
            }

            if (showMsg)
            {
                if (orst)
                {
                    MessageBox.Show("存为默认设置成功！", fConsole.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (!orst)
                    {
                        if (MessageBox.Show("存为默认设置失败！重试？", fConsole.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
                            == DialogResult.Retry)
                        {
                            orst = SettingCommon.Add() > 0;
                        }
                        if (!orst) continue;
                        MessageBox.Show("存为默认设置成功！", fConsole.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            return orst;
        }

        public bool SaveScreen1Default(bool showMsg)
        {
            SettingScreen1.ID = 1;
            SettingScreen1.SaveTime = DateTime.Now;
            SettingScreen1.SettingName = string.Format("{0}_{1}", FScreen1.Name, DateTime.Now.ToString("yyyyMMdd"));
            SettingScreen1.S1Title = FScreen1.lblTitle.Text;
            SettingScreen1.S1TitleFont = FScreen1.lblTitle.Font;
            SettingScreen1.S1TitleFontColor = FScreen1.lblTitle.ForeColor;
            SettingScreen1.S1TitleHeight = FScreen1.panelTitle.Height;
            SettingScreen1.S1TableHeaderFont = FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.Font;
            SettingScreen1.S1TableHeaderFontColor = FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.ForeColor;
            SettingScreen1.S1TableHeaderBColor = FScreen1.GridViewDate.ColumnHeadersDefaultCellStyle.BackColor;
            SettingScreen1.S1TableHeaderHeight = FScreen1.GridViewDate.ColumnHeadersHeight;
            SettingScreen1.S1TableFont = FScreen1.GridViewDate.Font;
            SettingScreen1.S1TableFontColor = FScreen1.GridViewDate.ForeColor;
            SettingScreen1.S1TableLineColor = FScreen1.GridViewDate.GridColor;
            SettingScreen1.S1TablePageSpeed = FScreen1.timer.Interval / 1000;
            SettingScreen1.S1TablePageSize = FScreen1.PageSize;
            SettingScreen1.S1TableDataSyn = FScreen1.timerSyn.Interval / 1000;
            SettingScreen1.S1TableAutoSizeColumns = (FScreen1.GridViewDate.AutoSizeColumnsMode ==
                                                   DataGridViewAutoSizeColumnsMode.Fill);
            SettingScreen1.S1TableBorderStyle = FScreen1.TableBorderStyle;
            SettingScreen1.S1TableBorderWidth = FScreen1.TableBorderSize;

            SettingScreen1.S1TableShowColumns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn col in FScreen1.GridViewDate.Columns)
            {
                SettingScreen1.S1TableShowColumns.Add(col);
            }
            SettingScreen1.S1Affiche = FScreen1.scrollingTextAffiche.ScrollText;
            SettingScreen1.S1AfficheFont = FScreen1.scrollingTextAffiche.Font;
            SettingScreen1.S1AfficheFontColor = FScreen1.scrollingTextAffiche.ForeColor;
            SettingScreen1.S1AfficheHeight = FScreen1.panelBottom.Height;
            SettingScreen1.S1DataFlag = FScreen1.DataFlag;
            SettingScreen1.S1TableContextHeight = FScreen1.RowHeight;
            SettingScreen1.S1AfficheDirection = (int) FScreen1.scrollingTextAffiche.ScrollDirection;
            SettingScreen1.S1AfficheSpend = FScreen1.scrollingTextAffiche.TextScrollSpeed;

            SettingScreen1.S1TimeFont = fScreen1.lbl_CurrentTime.Font;
            SettingScreen1.S1TimeFontColor = fScreen1.lbl_CurrentTime.ForeColor;
            SettingScreen1.S1TimeLocation = fScreen1.lbl_CurrentTime.Location;
            SettingScreen1.S1TitleLocation = fScreen1.lblTitle.Location;

            bool orst = false;
            if (SettingScreen1.Exists(1))
            {
                orst = SettingScreen1.Update() > 0;
            }
            else
            {
                orst = SettingScreen1.Add() > 0;
            }

            if (showMsg)
            {
                if (orst)
                {
                    MessageBox.Show("存为默认设置成功！", FScreen1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (!orst)
                    {
                        if (MessageBox.Show("存为默认设置失败！重试？", FScreen1.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
                            == DialogResult.Retry)
                        {
                            orst = SettingScreen1.Add() > 0;
                        }
                        if (!orst) continue;
                        MessageBox.Show("存为默认设置成功！", FScreen1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            return orst;
        }

        public bool SaveScreen2Default(bool showMsg)
        {
            SettingScreen2.ID = 1;
            SettingScreen2.SaveTime = DateTime.Now;
            SettingScreen2.SettingName = string.Format("{0}_{1}", FScreen2.Name, DateTime.Now.ToString("yyyyMMdd"));
            SettingScreen2.S2AreaBackColorTime = FScreen2.panelEx2.BackColor;
            SettingScreen2.S2AreaBackColorBase = FScreen2.panelBaseHead.BackColor;
            SettingScreen2.S2AreaBackColorDetail = FScreen2.panelContent.BackColor;
            SettingScreen2.S2AreaBackColorBottom = FScreen2.panelBottom.BackColor;
            SettingScreen2.S2BuyTitleFont = FScreen2.LblTimeDown.Font;
            SettingScreen2.S2BuyTitleColor = FScreen2.LblTimeDown.ForeColor;
            SettingScreen2.S2BuyTitleHeight = FScreen2.LblTimeDown.Height;
            SettingScreen2.S2ClockBackColor = FScreen2.clockControl1.BackColor;
            SettingScreen2.S2HourHandColor = FScreen2.clockControl1.HourHandColor;
            SettingScreen2.S2MinuteHandColor = FScreen2.clockControl1.MinuteHandColor;
            SettingScreen2.S2SecondColor = FScreen2.clockControl1.SecondHandColor;
            SettingScreen2.S2ScaleColor = FScreen2.clockControl1.ScaleColor;
            SettingScreen2.S2TimeForeColor = FScreen2.clockControls1.ClockColor;
            SettingScreen2.S2TimeBackColor = FScreen2.clockControls1.BackColor;
            SettingScreen2.S2LedClockForeColor = FScreen2.ledClockControls1.ClockColor;
            SettingScreen2.S2LedClockBackColor = FScreen2.ledClockControls1.BackColor;
            SettingScreen2.S2LedClockHeight = FScreen2.ledClockControls1.Location.Y;
            SettingScreen2.S2StartMusic = FScreen2.strMusicStart;
            SettingScreen2.S2EndMusic = FScreen2.strMusicEnd;
            ///////////////////////////////////////////////////////////
            //开始文字设置功能暂未实现，先随便替换一个
            SettingScreen2.S2StartShowText = "开始竞价";
            SettingScreen2.S2StartShowFont = FScreen2.lblHeadBase.Font;
            SettingScreen2.S2StartShowForeColor = FScreen2.lblHeadBase.ForeColor;
            //结束文字设置功能暂未实现，先随便替换一个
            SettingScreen2.S2EndShowText = "结束竞价";
            SettingScreen2.S2EndShowFont = FScreen2.lblHeadBase.Font;
            SettingScreen2.S2EndShowForeColor = FScreen2.lblHeadBase.ForeColor;
            ///////////////////////////////////////////////////////////
            SettingScreen2.S2ProjectTitleText = FScreen2.strProjectTitle;
            SettingScreen2.S2ProjectTitleFont = FScreen2.lblHeadBase.Font;
            SettingScreen2.S2ProjectTitleForeColor = FScreen2.lblHeadBase.ForeColor;
            
            SettingScreen2.S2BaseHeadFont = FScreen2.lblHeadBase.Font;
            SettingScreen2.S2BaseHeadForeColor = FScreen2.lblHeadBase.ForeColor;
            SettingScreen2.S2BaseHeadBackColor = FScreen2.lblHeadBase.BackColor;
            SettingScreen2.S2BaseHeadHeight = FScreen2.panelBaseHead.Height;
            SettingScreen2.S2BaseContextFont = FScreen2.GVBiddingInfo.DefaultCellStyle.Font;
            SettingScreen2.S2BaseContextForeColor = FScreen2.GVBiddingInfo.DefaultCellStyle.ForeColor;
            SettingScreen2.S2BaseContextGridColor = FScreen2.GVBiddingInfo.GridColor;
            if (FScreen2.GVBiddingInfo.Rows.Count >0)
                SettingScreen2.S2BaseContextHeight = FScreen2.GVBiddingInfo.Rows[0].Height;
            else
                SettingScreen2.S2BaseContextHeight = FScreen2.BaseContextHeight;
            
            SettingScreen2.S2BaseDataSyn = fScreen2.iBaseSpan/1000;
            SettingScreen2.S2BaseAutoSizeColumns = FScreen2.GVBiddingInfo.AutoSizeColumnsMode ==
                                                   DataGridViewAutoSizeColumnsMode.Fill;
            SettingScreen2.S2BaseBorderStyle = FScreen2.GVBiddingInfo.BorderStyle;
            //该功能未实现，暂时默认0
            SettingScreen2.S2BaseBorderWidth = 0;
            SettingScreen2.S2BaseColumnsFont = new List<Font>();
            SettingScreen2.S2BaseColumnsForeColor = new List<Color>();
            SettingScreen2.S2BaseColumnsBackColor = new List<Color>();
            SettingScreen2.S2BaseColumnsWidth = new List<DataGridViewColumn>();
            foreach(DataGridViewColumn col in FScreen2.GVBiddingInfo.Columns)
            {
                if (FScreen2.GVBiddingInfo.Rows.Count > 0)
                {
                    if (FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.Font == null)
                        SettingScreen2.S2BaseColumnsFont.Add(FScreen2.GVBiddingInfo.DefaultCellStyle.Font);
                    else 
                        SettingScreen2.S2BaseColumnsFont.Add(FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.Font);
                    
                    if (FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.ForeColor == null)
                        SettingScreen2.S2BaseColumnsForeColor.Add(FScreen2.GVBiddingInfo.DefaultCellStyle.ForeColor);
                    else 
                        SettingScreen2.S2BaseColumnsForeColor.Add(FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.ForeColor);
                    
                    if (FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.BackColor == null)
                        SettingScreen2.S2BaseColumnsBackColor.Add(FScreen2.GVBiddingInfo.DefaultCellStyle.BackColor);
                    else 
                        SettingScreen2.S2BaseColumnsBackColor.Add(FScreen2.GVBiddingInfo.Rows[0].Cells[col.Name].Style.BackColor);
                }
                SettingScreen2.S2BaseColumnsWidth.Add(col);
            }

            SettingScreen2.S2DetailHeadFont = FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.Font;
            SettingScreen2.S2DetailHeadForeColor = FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor;
            SettingScreen2.S2DetailHeadBackColor = FScreen2.GVBiddingCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor;
            SettingScreen2.S2DetailHeadHeight = FScreen2.GVBiddingCustomerInfo.ColumnHeadersHeight;
            SettingScreen2.S2DetailContextFont = FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.Font;
            SettingScreen2.S2DetailContextForeColor = FScreen2.GVBiddingCustomerInfo.RowsDefaultCellStyle.ForeColor;
            SettingScreen2.S2DetailContextGridColor = FScreen2.GVBiddingCustomerInfo.GridColor;
            if (FScreen2.GVBiddingCustomerInfo.Rows.Count > 0)
                SettingScreen2.S2DetailContextHeight = FScreen2.GVBiddingCustomerInfo.Rows[0].Height;
            else
                SettingScreen2.S2DetailContextHeight = FScreen2.DetailContextHeight;
            
            SettingScreen2.S2DetailDataSyn = FScreen2.iDetailSpan/1000;
            SettingScreen2.S2DetailAutoSizeColumns = FScreen2.GVBiddingCustomerInfo.AutoSizeColumnsMode ==
                                                     DataGridViewAutoSizeColumnsMode.Fill;
            SettingScreen2.S2DetailBorderStyle = FScreen2.GVBiddingCustomerInfo.BorderStyle;
            //功能未实现，暂时默认0
            SettingScreen2.S2DetailBorderWidth = 0;
            SettingScreen2.S2DetailColumns = new List<DataGridViewColumn>();
            foreach(DataGridViewColumn col in FScreen2.GVBiddingCustomerInfo.Columns)
            {
                SettingScreen2.S2DetailColumns.Add(col);
            }

            SettingScreen2.S2AfficheText = FScreen2.scrollingTextAffiche.ScrollText;
            SettingScreen2.S2AfficheFont = FScreen2.scrollingTextAffiche.Font;
            SettingScreen2.S2AfficheForeColor = FScreen2.ForeColor;
            SettingScreen2.S2AfficheHeight = FScreen2.panelBottom.Height;

            SettingScreen2.S2AfficheDirection = (int)FScreen2.scrollingTextAffiche.ScrollDirection;
            SettingScreen2.S2AfficheSpend = FScreen2.scrollingTextAffiche.TextScrollSpeed;
            SettingScreen2.S2MusicSomeOne = FScreen2.strMusicSomeOne;
            SettingScreen2.S2MusicNoOne = FScreen2.strMusicNoOne;
            SettingScreen2.S2MusicSomeOneOpen = FScreen2.blMusicSomeOneOpen;
            SettingScreen2.S2MusicNoOneOpen = FScreen2.blMusicNoOneOpen;
            SettingScreen2.S2StartMusicOpen = FScreen2.blMusicStartOpen;
            SettingScreen2.S2EndMusicOpen = FScreen2.blMusicEndOpen;
            SettingScreen2.S2ProjectInfoMarquee = fScreen2.iProjectMarquee;
            SettingScreen2.S2ProjectInfoSwitchTime = fScreen2.iProjectInfoSwitchTime;

            SettingScreen2.S2TimeFont = fScreen2.lbl_CurrentTime.Font;
            SettingScreen2.S2TimeFontColor = fScreen2.lbl_CurrentTime.ForeColor;


            bool orst = false;
            if (SettingScreen2.Exists(1))
            {
                orst = SettingScreen2.Update() > 0;
            }
            else
            {
                orst = SettingScreen2.Add() > 0;
            }

            if (showMsg)
            {
                if (orst)
                {
                    MessageBox.Show("存为默认设置成功！", FScreen2.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    while (!orst)
                    {
                        if (MessageBox.Show("存为默认设置失败！重试？", FScreen2.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
                            == DialogResult.Retry)
                        {
                            orst = SettingScreen2.Add() > 0;
                        }
                        if (!orst) continue;
                        MessageBox.Show("存为默认设置成功！", FScreen2.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            return orst;
        }

        public bool SaveScreen3Default()
        {
            throw new Exception("方法未实现！");
        }

        public bool SaveScreen4Default()
        {
            throw new Exception("方法未实现！");
        }

        public void Exit()
        { 
            if (MessageBox.Show("确定要退出吗？", FConsole.Text, MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            FConsole.notifyIcon.Visible = false;
            FConsole.Dispose();

            //tMonit.Dispose();
            Environment.Exit(0);
            //Application.ExitThread();
            //Application.Exit();
        }
    }
}