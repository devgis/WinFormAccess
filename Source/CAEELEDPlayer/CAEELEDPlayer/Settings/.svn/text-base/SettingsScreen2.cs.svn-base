using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using CAEELEDPlayer.Common;

namespace CAEELEDPlayer.Settings
{
    public class SettingsScreen2
    {
        public SettingsScreen2()
        {
        }
        
        

        #region Model

        private int _id = 0;
        private DateTime _savetime;
        private string _settingname;
        private Color _S2AreaBackColorTime;
        private Color _S2AreaBackColorBase;
        private Color _S2AreaBackColorDetail;
        private Color _S2AreaBackColorBottom;
        private Font _S2BuyTitleFont;
        private Color _S2BuyTitleColor;
        private int _S2BuyTitleHeight = 0;
        private Color _S2ClockBackColor;
        private Color _S2HourHandColor;
        private Color _S2MinuteHandColor;
        private Color _S2SecondColor;
        private Color _S2ScaleColor;
        private Color _S2TimeForeColor;
        private Color _S2TimeBackColor;
        private Color _S2LedClockForeColor;
        private Color _S2LedClockBackColor;
        private int _S2LedClockHeight = 0;
        private string _S2StartMusic;
        private string _S2EndMusic;
        private string _S2StartShowText;
        private Font _S2StartShowFont;
        private Color _S2StartShowForeColor;
        private string _S2EndShowText;
        private Font _S2EndShowFont;
        private Color _S2EndShowForeColor;
        private string _S2ProjectTitleText;
        private Font _S2ProjectTitleFont;
        private Color _S2ProjectTitleForeColor;
        private Font _S2BaseHeadFont;
        private Color _S2BaseHeadForeColor;
        private Color _S2BaseHeadBackColor;
        private int _S2BaseHeadHeight = 0;
        private Font _S2BaseContextFont;
        private Color _S2BaseContextForeColor;
        private Color _S2BaseContextGridColor;
        private int _S2BaseContextHeight = 0;
        private int _S2BaseDataSyn;
        private bool _S2BaseAutoSizeColumns;
        private BorderStyle _S2BaseBorderStyle;
        private int _S2BaseBorderWidth = 0;
        private List<Font> _S2BaseColumnsFont;
        private List<Color> _S2BaseColumnsForeColor;
        private List<Color> _S2BaseColumnsBackColor;
        private List<DataGridViewColumn> _S2BaseColumnsWidth;
        private Font _S2DetailHeadFont;
        private Color _S2DetailHeadForeColor;
        private Color _S2DetailHeadBackColor;
        private int _S2DetailHeadHeight;
        private Font _S2DetailContextFont;
        private Color _S2DetailContextForeColor;
        private Color _S2DetailContextGridColor;
        private int _S2DetailContextHeight = 0;
        private int _S2DetailDataSyn;
        private bool _S2DetailAutoSizeColumns;
        private BorderStyle _S2DetailBorderStyle;
        private int _S2DetailBorderWidth = 0;
        private List<DataGridViewColumn> _S2DetailColumns;
        private string _S2AfficheText;
        private Font _S2AfficheFont;
        private Color _S2AfficheForeColor;
        private int _S2AfficheHeight;
        private int _S2AfficheSpend = 0;
        private int _S2AfficheDirection = 0;
        private string _S2MusicSomeOne;
        private string _S2MusicNoOne;
        private bool _S2MusicSomeOneOpen;
        private bool _S2MusicNoOneOpen;
        private bool _S2StartMusicOpen;
        private bool _S2EndMusicOpen;
        
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        
        public DateTime SaveTime
        {
            set { _savetime = value; }
            get { return _savetime; }
        }

        public string SettingName
        {
            set { _settingname = value; }
            get { return _settingname; }
        }

        public Color S2AreaBackColorTime
        {
            set { _S2AreaBackColorTime = value; }
            get { return _S2AreaBackColorTime; }
        }

        public Color S2AreaBackColorBase
        {
            set { _S2AreaBackColorBase = value; }
            get { return _S2AreaBackColorBase; }
        }

        public Color S2AreaBackColorDetail
        {
            set { _S2AreaBackColorDetail = value; }
            get { return _S2AreaBackColorDetail; }
        }

        public Color S2AreaBackColorBottom
        {
            set { _S2AreaBackColorBottom = value; }
            get { return _S2AreaBackColorBottom; }
        }

        public Font S2BuyTitleFont
        {
            set { _S2BuyTitleFont = value; }
            get { return _S2BuyTitleFont; }
        }

        public Color S2BuyTitleColor
        {
            set { _S2BuyTitleColor = value; }
            get { return _S2BuyTitleColor; }
        }

        public int S2BuyTitleHeight
        {
            set { _S2BuyTitleHeight = value; }
            get { return _S2BuyTitleHeight; }
        }

        public Color S2ClockBackColor
        {
            set { _S2ClockBackColor = value; }
            get { return _S2ClockBackColor; }
        }

        public Color S2HourHandColor
        {
            set { _S2HourHandColor = value; }
            get { return _S2HourHandColor; }
        }

        public Color S2MinuteHandColor
        {
            set { _S2MinuteHandColor = value; }
            get { return _S2MinuteHandColor; }
        }

        public Color S2SecondColor
        {
            set { _S2SecondColor = value; }
            get { return _S2SecondColor; }
        }

        public Color S2ScaleColor
        {
            set { _S2ScaleColor = value; }
            get { return _S2ScaleColor; }
        }

        public Color S2TimeForeColor
        {
            set { _S2TimeForeColor = value; }
            get { return _S2TimeForeColor; }
        }

        public Color S2TimeBackColor
        {
            set { _S2TimeBackColor = value; }
            get { return _S2TimeBackColor; }
        }

        public Color S2LedClockForeColor
        {
            set { _S2LedClockForeColor = value; }
            get { return _S2LedClockForeColor; }
        }

        public Color S2LedClockBackColor
        {
            set { _S2LedClockBackColor = value; }
            get { return _S2LedClockBackColor; }
        }

        public int S2LedClockHeight
        {
            set { _S2LedClockHeight = value; }
            get { return _S2LedClockHeight; }
        }

        public string S2StartMusic
        {
            set { _S2StartMusic = value; }
            get { return _S2StartMusic; }
        }

        public string S2EndMusic
        {
            set { _S2EndMusic = value; }
            get { return _S2EndMusic; }
        }

        public string S2StartShowText
        {
            set { _S2StartShowText = value; }
            get { return _S2StartShowText; }
        }

        public Font S2StartShowFont
        {
            set { _S2StartShowFont = value; }
            get { return _S2StartShowFont; }
        }

        public Color S2StartShowForeColor
        {
            set { _S2StartShowForeColor = value; }
            get { return _S2StartShowForeColor; }
        }

        public string S2EndShowText
        {
            set { _S2EndShowText = value; }
            get { return _S2EndShowText; }
        }

        public Font S2EndShowFont
        {
            set { _S2EndShowFont = value; }
            get { return _S2EndShowFont; }
        }

        public Color S2EndShowForeColor
        {
            set { _S2EndShowForeColor = value; }
            get { return _S2EndShowForeColor; }
        }

        public string S2ProjectTitleText
        {
            set { _S2ProjectTitleText = value; }
            get { return _S2ProjectTitleText; }
        }

        public Font S2ProjectTitleFont
        {
            set { _S2ProjectTitleFont = value; }
            get { return _S2ProjectTitleFont; }
        }

        public Color S2ProjectTitleForeColor
        {
            set { _S2ProjectTitleForeColor = value; }
            get { return _S2ProjectTitleForeColor; }
        }

        public Font S2BaseHeadFont
        {
            set { _S2BaseHeadFont = value; }
            get { return _S2BaseHeadFont; }
        }

        public Color S2BaseHeadForeColor
        {
            set { _S2BaseHeadForeColor = value; }
            get { return _S2BaseHeadForeColor; }
        }

        public Color S2BaseHeadBackColor
        {
            set { _S2BaseHeadBackColor = value; }
            get { return _S2BaseHeadBackColor; }
        }

        public int S2BaseHeadHeight
        {
            set { _S2BaseHeadHeight = value; }
            get { return _S2BaseHeadHeight; }
        }

        public Font S2BaseContextFont
        {
            set { _S2BaseContextFont = value; }
            get { return _S2BaseContextFont; }
        }

        public Color S2BaseContextForeColor
        {
            set { _S2BaseContextForeColor = value; }
            get { return _S2BaseContextForeColor; }
        }

        public Color S2BaseContextGridColor
        {
            set { _S2BaseContextGridColor = value; }
            get { return _S2BaseContextGridColor; }
        }

        public int S2BaseContextHeight
        {
            set { _S2BaseContextHeight = value; }
            get { return _S2BaseContextHeight; }
        }

        public int S2BaseDataSyn
        {
            set { _S2BaseDataSyn = value; }
            get { return _S2BaseDataSyn; }
        }

        public bool S2BaseAutoSizeColumns
        {
            set { _S2BaseAutoSizeColumns = value; }
            get { return _S2BaseAutoSizeColumns; }
        }

        public BorderStyle S2BaseBorderStyle
        {
            set { _S2BaseBorderStyle = value; }
            get { return _S2BaseBorderStyle; }
        }

        public int S2BaseBorderWidth
        {
            set { _S2BaseBorderWidth = value; }
            get { return _S2BaseBorderWidth; }
        }
        
        public List<Font> S2BaseColumnsFont
        {
            set { _S2BaseColumnsFont = value; }
            get { return _S2BaseColumnsFont; }
        }
        
        public List<Color> S2BaseColumnsForeColor
        {
            set { _S2BaseColumnsForeColor = value;}
            get { return _S2BaseColumnsForeColor;}
        }

        public List<Color> S2BaseColumnsBackColor
        {
            set { _S2BaseColumnsBackColor = value; }
            get { return _S2BaseColumnsBackColor; }
        }

        public List<DataGridViewColumn> S2BaseColumnsWidth
        {
            set { _S2BaseColumnsWidth = value; }
            get { return _S2BaseColumnsWidth; }
        }

        public Font S2DetailHeadFont
        {
            set { _S2DetailHeadFont = value; }
            get { return _S2DetailHeadFont; }
        }

        public Color S2DetailHeadForeColor
        {
            set { _S2DetailHeadForeColor = value; }
            get { return _S2DetailHeadForeColor; }
        }

        public Color S2DetailHeadBackColor
        {
            set { _S2DetailHeadBackColor = value; }
            get { return _S2DetailHeadBackColor; }
        }

        public int S2DetailHeadHeight
        {
            set { _S2DetailHeadHeight = value; }
            get { return _S2DetailHeadHeight; }
        }

        public Font S2DetailContextFont
        {
            set { _S2DetailContextFont = value; }
            get { return _S2DetailContextFont; }
        }

        public Color S2DetailContextForeColor
        {
            set { _S2DetailContextForeColor = value; }
            get { return _S2DetailContextForeColor; }
        }

        public Color S2DetailContextGridColor
        {
            set { _S2DetailContextGridColor = value; }
            get { return _S2DetailContextGridColor; }
        }

        public int S2DetailContextHeight
        {
            set { _S2DetailContextHeight = value; }
            get { return _S2DetailContextHeight; }
        }

        public int S2DetailDataSyn
        {
            set { _S2DetailDataSyn = value; }
            get { return _S2DetailDataSyn; }
        }

        public bool S2DetailAutoSizeColumns
        {
            set { _S2DetailAutoSizeColumns = value; }
            get { return _S2DetailAutoSizeColumns; }
        }

        public BorderStyle S2DetailBorderStyle
        {
            set { _S2DetailBorderStyle = value; }
            get { return _S2DetailBorderStyle; }
        }
        
        public int S2DetailBorderWidth
        {
            set { _S2DetailBorderWidth = value;}
            get { return _S2DetailBorderWidth;}
        }

        public List<DataGridViewColumn> S2DetailColumns
        {
            set { _S2DetailColumns = value; }
            get { return _S2DetailColumns; }
        }
        
        public string S2AfficheText
        {
            set { _S2AfficheText = value;}
            get { return _S2AfficheText;}
        }
        
        public Font S2AfficheFont
        {
            set { _S2AfficheFont = value;}
            get { return _S2AfficheFont;}
        }

        public Color S2AfficheForeColor
        {
            set { _S2AfficheForeColor = value; }
            get { return _S2AfficheForeColor; }
        }

        public int S2AfficheHeight
        {
            set { _S2AfficheHeight = value; }
            get { return _S2AfficheHeight; }
        }

        public int S2AfficheSpend
        {
            get { return _S2AfficheSpend; }
            set { _S2AfficheSpend = value; }
        }

        public int S2AfficheDirection
        {
            get { return _S2AfficheDirection; }
            set { _S2AfficheDirection = value; }
        }

        public string S2MusicSomeOne
        {
            get { return _S2MusicSomeOne; }
            set { _S2MusicSomeOne = value; }
        }

        public string S2MusicNoOne
        {
            get { return _S2MusicNoOne; }
            set { _S2MusicNoOne = value; }
        }

        public bool S2MusicSomeOneOpen
        {
            get { return _S2MusicSomeOneOpen; }
            set { _S2MusicSomeOneOpen = value; }
        }

        public bool S2MusicNoOneOpen
        {
            get { return _S2MusicNoOneOpen; }
            set { _S2MusicNoOneOpen = value; }
        }

        public bool S2StartMusicOpen
        {
            get { return _S2StartMusicOpen; }
            set { _S2StartMusicOpen = value; }
        }

        public bool S2EndMusicOpen
        {
            get { return _S2EndMusicOpen; }
            set { _S2EndMusicOpen = value; }
        }

        private int _S2ProjectInfoMarquee;
        /// <summary>
        /// 项目信息描述滚动的速度：以毫秒为单位
        /// </summary>
        public int S2ProjectInfoMarquee
        {
            get { return _S2ProjectInfoMarquee; }
            set { _S2ProjectInfoMarquee = value; }
        }

        private int _S2ProjectInfoSwitchTime;
        /// <summary>
        /// 项目信息描述与项目基本信息切换的时间，以秒为单位
        /// </summary>
        public int S2ProjectInfoSwitchTime
        {
            get { return _S2ProjectInfoSwitchTime; }
            set { _S2ProjectInfoSwitchTime = value; }
        }

        private Font _s2TimeFont;
        public Font S2TimeFont
        {
            set { _s2TimeFont = value; }
            get { return _s2TimeFont; }
        }

        private Color _s2TimeFontColor;
        public Color S2TimeFontColor
        {
            set { _s2TimeFontColor = value; }
            get { return _s2TimeFontColor; }
        }

        
        #endregion

        #region Method
        
        public SettingsScreen2(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from SettingsScreen2 where ID=@ID");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@ID", OleDbType.Integer, 4)
                                          };
            parameters[0].Value = id;

            DataSet ds = AccessHelper.Query(strSql.ToString(), parameters);
            if (ds == null || ds.Tables.Count <=0 || ds.Tables[0] == null || ds.Tables[0].Rows.Count <=0) return;
            
            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaveTime"].ToString() != "")
            {
                SaveTime = DateTime.Parse(ds.Tables[0].Rows[0]["SaveTime"].ToString());
            }
            SettingName = ds.Tables[0].Rows[0]["SettingName"].ToString();
            S2AreaBackColorTime = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorTime"].ToString());
            S2AreaBackColorBase = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorBase"].ToString());
            S2AreaBackColorDetail = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorDetail"].ToString());
            S2AreaBackColorBottom = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorBottom"].ToString());
            S2BuyTitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BuyTitleFont"].ToString());
            S2BuyTitleColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BuyTitleColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BuyTitleHeight"].ToString() != string.Empty)
            {
                S2BuyTitleHeight = int.Parse(ds.Tables[0].Rows[0]["S2BuyTitleHeight"].ToString().Trim());
            }
            S2ClockBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ClockBackColor"].ToString());
            S2HourHandColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2HourHandColor"].ToString());
            S2MinuteHandColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2MinuteHandColor"].ToString());
            S2SecondColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2SecondColor"].ToString());
            S2ScaleColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ScaleColor"].ToString());
            S2TimeForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2TimeForeColor"].ToString());
            S2TimeBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2TimeBackColor"].ToString());
            S2LedClockForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2LedClockForeColor"].ToString());
            S2LedClockBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2LedClockBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2LedClockHeight"].ToString() != string.Empty)
            {
                S2LedClockHeight = int.Parse(ds.Tables[0].Rows[0]["S2LedClockHeight"].ToString().Trim());
            }
            S2StartMusic = ds.Tables[0].Rows[0]["S2StartMusic"].ToString();
            S2EndMusic = ds.Tables[0].Rows[0]["S2EndMusic"].ToString();
            S2StartShowText = ds.Tables[0].Rows[0]["S2StartShowText"].ToString();
            S2StartShowFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2StartShowFont"].ToString());
            S2StartShowForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2StartShowForeColor"].ToString());
            S2EndShowText = ds.Tables[0].Rows[0]["S2EndShowText"].ToString();
            S2EndShowFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2EndShowFont"].ToString());
            S2EndShowForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2EndShowForeColor"].ToString());
            S2ProjectTitleText = ds.Tables[0].Rows[0]["S2ProjectTitleText"].ToString();
            S2ProjectTitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2ProjectTitleFont"].ToString());
            S2ProjectTitleForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ProjectTitleForeColor"].ToString());
            S2BaseHeadFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BaseHeadFont"].ToString());
            S2BaseHeadForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseHeadForeColor"].ToString());
            S2BaseHeadBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseHeadBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BaseHeadHeight"].ToString() != string.Empty)
            {
                S2BaseHeadHeight = int.Parse(ds.Tables[0].Rows[0]["S2BaseHeadHeight"].ToString().Trim());
            }
            S2BaseContextFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BaseContextFont"].ToString());
            S2BaseContextForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseContextForeColor"].ToString());
            S2BaseContextGridColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseContextGridColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BaseContextHeight"].ToString() != string.Empty)
            {
                S2BaseContextHeight = int.Parse(ds.Tables[0].Rows[0]["S2BaseContextHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString() != string.Empty)
            {
                S2BaseDataSyn = int.Parse(ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString() != string.Empty)
            {
                S2BaseAutoSizeColumns = bool.Parse(ds.Tables[0].Rows[0]["S2BaseAutoSizeColumns"].ToString().Trim());
            }
            S2BaseBorderStyle =
                CommFunction.StringToBorderStyle(ds.Tables[0].Rows[0]["S2BaseBorderStyle"].ToString().Trim());
            if (ds.Tables[0].Rows[0]["S2BaseBorderWidth"].ToString() != string.Empty)
            {
                S2BaseBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S2BaseBorderWidth"].ToString().Trim());
            }
            S2BaseColumnsFont = new List<Font>();
            S2BaseColumnsForeColor = new List<Color>();
            S2BaseColumnsBackColor = new List<Color>();
            S2BaseColumnsWidth = new List<DataGridViewColumn>();
            CommFunction.StringToFontList(S2BaseColumnsFont, ds.Tables[0].Rows[0]["S2BaseColumnsFont"].ToString());
            CommFunction.StringToColorList(S2BaseColumnsForeColor, ds.Tables[0].Rows[0]["S2BaseColumnsForeColor"].ToString());
            CommFunction.StringToColorList(S2BaseColumnsBackColor, ds.Tables[0].Rows[0]["S2BaseColumnsBackColor"].ToString());
            CommFunction.StringToDataGridViewList(S2BaseColumnsWidth, ds.Tables[0].Rows[0]["S2BaseColumnsWidth"].ToString());
            S2DetailHeadFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2DetailHeadFont"].ToString());
            S2DetailHeadForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailHeadForeColor"].ToString());
            S2DetailHeadBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailHeadBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2DetailHeadHeight"].ToString() != string.Empty)
            {
                S2DetailHeadHeight = int.Parse(ds.Tables[0].Rows[0]["S2DetailHeadHeight"].ToString().Trim());
            }
            S2DetailContextFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2DetailContextFont"].ToString());
            S2DetailContextForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailContextForeColor"].ToString());
            S2DetailContextGridColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailContextGridColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2DetailContextHeight"].ToString() != string.Empty)
            {
                S2DetailContextHeight = int.Parse(ds.Tables[0].Rows[0]["S2DetailContextHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2DetailDataSyn"].ToString() != string.Empty)
            {
                S2DetailDataSyn = int.Parse(ds.Tables[0].Rows[0]["S2DetailDataSyn"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2DetailAutoSizeColumns"].ToString() != string.Empty)
            {
                S2DetailAutoSizeColumns = bool.Parse(ds.Tables[0].Rows[0]["S2DetailAutoSizeColumns"].ToString().Trim());
            }
            S2DetailBorderStyle = CommFunction.StringToBorderStyle(ds.Tables[0].Rows[0]["S2DetailBorderStyle"].ToString().Trim());
            if (ds.Tables[0].Rows[0]["S2DetailBorderWidth"].ToString() != string.Empty)
            {
                S2DetailBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S2DetailBorderWidth"].ToString().Trim());
            }
            S2DetailColumns = new List<DataGridViewColumn>();
            CommFunction.StringToDataGridViewList(S2DetailColumns, ds.Tables[0].Rows[0]["S2DetailColumns"].ToString());
            S2AfficheText = ds.Tables[0].Rows[0]["S2AfficheText"].ToString();
            S2AfficheFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2AfficheFont"].ToString());
            S2AfficheForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AfficheForeColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2AfficheHeight"].ToString() != string.Empty)
            {
                S2AfficheHeight = int.Parse(ds.Tables[0].Rows[0]["S2AfficheHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2AfficheSpend"].ToString() != string.Empty)
            {
                S2AfficheSpend = int.Parse(ds.Tables[0].Rows[0]["S2AfficheSpend"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2AfficheDirection"].ToString() != string.Empty)
            {
                S2AfficheDirection = int.Parse(ds.Tables[0].Rows[0]["S2AfficheDirection"].ToString().Trim());
            }
            S2MusicSomeOne = ds.Tables[0].Rows[0]["S2MusicSomeOne"].ToString().Trim();
            S2MusicNoOne = ds.Tables[0].Rows[0]["S2MusicNoOne"].ToString().Trim();
            S2MusicSomeOneOpen = bool.Parse(ds.Tables[0].Rows[0]["S2MusicSomeOneOpen"].ToString().Trim());
            S2MusicNoOneOpen = bool.Parse(ds.Tables[0].Rows[0]["S2MusicNoOneOpen"].ToString().Trim());
            S2StartMusicOpen = bool.Parse(ds.Tables[0].Rows[0]["S2StartMusicOpen"].ToString().Trim());
            S2EndMusicOpen = bool.Parse(ds.Tables[0].Rows[0]["S2EndMusicOpen"].ToString().Trim());
            S2ProjectInfoMarquee = int.Parse(ds.Tables[0].Rows[0]["S2ProjectInfoMarquee"].ToString().Trim());
            S2ProjectInfoSwitchTime = int.Parse(ds.Tables[0].Rows[0]["S2ProjectInfoSwitchTime"].ToString().Trim());

            S2TimeFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2TimeFont"].ToString());
            S2TimeFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2TimeFontColor"].ToString());

        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SettingsScreen2");
            strSql.Append(" where ID=@ID ");

            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = id;

            return AccessHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SettingsScreen2(");
            strSql.Append("ID,SaveTime,SettingName,S2AreaBackColorTime,S2AreaBackColorBase,S2AreaBackColorDetail,S2AreaBackColorBottom,S2BuyTitleFont,S2BuyTitleColor,S2BuyTitleHeight,S2ClockBackColor,S2HourHandColor,S2MinuteHandColor,S2SecondColor,S2ScaleColor,S2TimeForeColor,S2TimeBackColor,S2LedClockForeColor,S2LedClockBackColor,S2LedClockHeight,S2StartMusic,S2EndMusic,S2StartShowText,S2StartShowFont,S2StartShowForeColor,S2EndShowText,S2EndShowFont,S2EndShowForeColor,S2ProjectTitleText,S2ProjectTitleFont,S2ProjectTitleForeColor,S2BaseHeadFont,S2BaseHeadForeColor,S2BaseHeadBackColor,S2BaseHeadHeight,S2BaseContextFont,S2BaseContextForeColor,S2BaseContextGridColor,S2BaseContextHeight,S2BaseDataSyn,S2BaseAutoSizeColumns,S2BaseBorderStyle,S2BaseBorderWidth,S2BaseColumnsFont,S2BaseColumnsForeColor,S2BaseColumnsBackColor,S2BaseColumnsWidth,S2DetailHeadFont,S2DetailHeadForeColor,S2DetailHeadBackColor,S2DetailHeadHeight,S2DetailContextFont,S2DetailContextForeColor,S2DetailContextGridColor,S2DetailContextHeight,S2DetailDataSyn,S2DetailAutoSizeColumns,S2DetailBorderStyle,S2DetailBorderWidth,S2DetailColumns,S2AfficheText,S2AfficheFont,S2AfficheForeColor,S2AfficheHeight,S2AfficheSpend,S2AfficheDirection,S2MusicSomeOne,S2MusicNoOne,S2MusicSomeOneOpen,S2MusicNoOneOpen,S2StartMusicOpen,S2EndMusicOpen)");
            strSql.Append(" values (");
            strSql.Append("@ID,@SaveTime,@SettingName,@S2AreaBackColorTime,@S2AreaBackColorBase,@S2AreaBackColorDetail,@S2AreaBackColorBottom,@S2BuyTitleFont,@S2BuyTitleColor,@S2BuyTitleHeight,@S2ClockBackColor,@S2HourHandColor,@S2MinuteHandColor,@S2SecondColor,@S2ScaleColor,@S2TimeForeColor,@S2TimeBackColor,@S2LedClockForeColor,@S2LedClockBackColor,@S2LedClockHeight,@S2StartMusic,@S2EndMusic,@S2StartShowText,@S2StartShowFont,@S2StartShowForeColor,@S2EndShowText,@S2EndShowFont,@S2EndShowForeColor,@S2ProjectTitleText,@S2ProjectTitleFont,@S2ProjectTitleForeColor,@S2BaseHeadFont,@S2BaseHeadForeColor,@S2BaseHeadBackColor,@S2BaseHeadHeight,@S2BaseContextFont,@S2BaseContextForeColor,@S2BaseContextGridColor,@S2BaseContextHeight,@S2BaseDataSyn,@S2BaseAutoSizeColumns,@S2BaseBorderStyle,@S2BaseBorderWidth,@S2BaseColumnsFont,@S2BaseColumnsForeColor,@S2BaseColumnsBackColor,@S2BaseColumnsWidth,@S2DetailHeadFont,@S2DetailHeadForeColor,@S2DetailHeadBackColor,@S2DetailHeadHeight,@S2DetailContextFont,@S2DetailContextForeColor,@S2DetailContextGridColor,@S2DetailContextHeight,@S2DetailDataSyn,@S2DetailAutoSizeColumns,@S2DetailBorderStyle,@S2DetailBorderWidth,@S2DetailColumns,@S2AfficheText,@S2AfficheFont,@S2AfficheForeColor,@S2AfficheHeight,@S2AfficheSpend,@S2AfficheDirection,@S2MusicSomeOne,@S2MusicNoOne,@S2MusicSomeOneOpen,@S2MusicNoOneOpen,@S2StartMusicOpen,@S2EndMusicOpen)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@SaveTime", OleDbType.Date),
					new OleDbParameter("@SettingName", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorTime", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorBase", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorDetail", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorBottom", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2ClockBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2HourHandColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2MinuteHandColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2SecondColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2ScaleColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2TimeForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2TimeBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockHeight", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartMusic", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndMusic", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowText", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowText", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleText", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseContextFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextGridColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseDataSyn", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseAutoSizeColumns", OleDbType.Boolean,1),
					new OleDbParameter("@S2BaseBorderStyle", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseBorderWidth", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseColumnsFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsWidth", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailContextFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextGridColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailDataSyn", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailAutoSizeColumns", OleDbType.Boolean,1),
					new OleDbParameter("@S2DetailBorderStyle", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailBorderWidth", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailColumns", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheText", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheHeight", OleDbType.Integer,4),
                    new OleDbParameter("@S2AfficheSpend",OleDbType.Integer,4),
                    new OleDbParameter("@S2AfficheDirection",OleDbType.Integer,4) ,
					new OleDbParameter("@S2MusicSomeOne",OleDbType.VarChar,0),
					new OleDbParameter("@S2MusicNoOne",OleDbType.VarChar,0),
					new OleDbParameter("@S2MusicSomeOneOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2MusicNoOneOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2StartMusicOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2EndMusicOpen",OleDbType.Boolean,1)
                                          };
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = CommFunction.ColorToString(S2AreaBackColorTime);
            parameters[4].Value = CommFunction.ColorToString(S2AreaBackColorBase);
            parameters[5].Value = CommFunction.ColorToString(S2AreaBackColorDetail);
            parameters[6].Value = CommFunction.ColorToString(S2AreaBackColorBottom);
            parameters[7].Value = CommFunction.FontToString(S2BuyTitleFont);
            parameters[8].Value = CommFunction.ColorToString(S2BuyTitleColor);
            parameters[9].Value = S2BuyTitleHeight;
            parameters[10].Value = CommFunction.ColorToString(S2ClockBackColor);
            parameters[11].Value = CommFunction.ColorToString(S2HourHandColor);
            parameters[12].Value = CommFunction.ColorToString(S2MinuteHandColor);
            parameters[13].Value = CommFunction.ColorToString(S2SecondColor);
            parameters[14].Value = CommFunction.ColorToString(S2ScaleColor);
            parameters[15].Value = CommFunction.ColorToString(S2TimeForeColor);
            parameters[16].Value = CommFunction.ColorToString(S2TimeBackColor);
            parameters[17].Value = CommFunction.ColorToString(S2LedClockForeColor);
            parameters[18].Value = CommFunction.ColorToString(S2LedClockBackColor);
            parameters[19].Value = S2LedClockHeight;
            parameters[20].Value = S2StartMusic;
            parameters[21].Value = S2EndMusic;
            parameters[22].Value = S2StartShowText;
            parameters[23].Value = CommFunction.FontToString(S2StartShowFont);
            parameters[24].Value = CommFunction.ColorToString(S2StartShowForeColor);
            parameters[25].Value = S2EndShowText;
            parameters[26].Value = CommFunction.FontToString(S2EndShowFont);
            parameters[27].Value = CommFunction.ColorToString(S2EndShowForeColor);
            parameters[28].Value = S2ProjectTitleText;
            parameters[29].Value = CommFunction.FontToString(S2ProjectTitleFont);
            parameters[30].Value = CommFunction.ColorToString(S2ProjectTitleForeColor);
            parameters[31].Value = CommFunction.FontToString(S2BaseHeadFont);
            parameters[32].Value = CommFunction.ColorToString(S2BaseHeadForeColor);
            parameters[33].Value = CommFunction.ColorToString(S2BaseHeadBackColor);
            parameters[34].Value = S2BaseHeadHeight;
            parameters[35].Value = CommFunction.FontToString(S2BaseContextFont);
            parameters[36].Value = CommFunction.ColorToString(S2BaseContextForeColor);
            parameters[37].Value = CommFunction.ColorToString(S2BaseContextGridColor);
            parameters[38].Value = S2BaseContextHeight;
            parameters[39].Value = S2BaseDataSyn;
            parameters[40].Value = S2BaseAutoSizeColumns;
            parameters[41].Value = CommFunction.BorderStyleToString(S2BaseBorderStyle);
            parameters[42].Value = S2BaseBorderWidth;
            parameters[43].Value = CommFunction.FontListToString(S2BaseColumnsFont);
            parameters[44].Value = CommFunction.ColorListToString(S2BaseColumnsForeColor);
            parameters[45].Value = CommFunction.ColorListToString(S2BaseColumnsBackColor);
            parameters[46].Value = CommFunction.DataGridViewListToString(S2BaseColumnsWidth);
            parameters[47].Value = CommFunction.FontToString(S2DetailHeadFont);
            parameters[48].Value = CommFunction.ColorToString(S2DetailHeadForeColor);
            parameters[49].Value = CommFunction.ColorToString(S2DetailHeadBackColor);
            parameters[50].Value = S2DetailHeadHeight;
            parameters[51].Value = CommFunction.FontToString(S2DetailContextFont);
            parameters[52].Value = CommFunction.ColorToString(S2DetailContextForeColor);
            parameters[53].Value = CommFunction.ColorToString(S2DetailContextGridColor);
            parameters[54].Value = S2DetailContextHeight;
            parameters[55].Value = S2DetailDataSyn;
            parameters[56].Value = S2DetailAutoSizeColumns;
            parameters[57].Value = CommFunction.BorderStyleToString(S2DetailBorderStyle);
            parameters[58].Value = S2DetailBorderWidth;
            parameters[59].Value = CommFunction.DataGridViewListToString(S2DetailColumns);
            parameters[60].Value = S2AfficheText;
            parameters[61].Value = CommFunction.FontToString(S2AfficheFont);
            parameters[62].Value = CommFunction.ColorToString(S2AfficheForeColor);
            parameters[63].Value = S2AfficheHeight;
            parameters[64].Value = S2AfficheSpend;
            parameters[65].Value = S2AfficheDirection;
            parameters[66].Value = S2MusicSomeOne;
            parameters[67].Value = S2MusicNoOne;
            parameters[68].Value = S2MusicSomeOneOpen;
            parameters[69].Value = S2MusicNoOneOpen;
            parameters[70].Value = S2StartMusicOpen;
            parameters[71].Value = S2EndMusicOpen;

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SettingsScreen2 set ");
            strSql.Append("ID=@ID,");
            strSql.Append("SaveTime=@SaveTime,");
            strSql.Append("SettingName=@SettingName,");
            strSql.Append("S2AreaBackColorTime=@S2AreaBackColorTime,");
            strSql.Append("S2AreaBackColorBase=@S2AreaBackColorBase,");
            strSql.Append("S2AreaBackColorDetail=@S2AreaBackColorDetail,");
            strSql.Append("S2AreaBackColorBottom=@S2AreaBackColorBottom,");
            strSql.Append("S2BuyTitleFont=@S2BuyTitleFont,");
            strSql.Append("S2BuyTitleColor=@S2BuyTitleColor,");
            strSql.Append("S2BuyTitleHeight=@S2BuyTitleHeight,");
            strSql.Append("S2ClockBackColor=@S2ClockBackColor,");
            strSql.Append("S2HourHandColor=@S2HourHandColor,");
            strSql.Append("S2MinuteHandColor=@S2MinuteHandColor,");
            strSql.Append("S2SecondColor=@S2SecondColor,");
            strSql.Append("S2ScaleColor=@S2ScaleColor,");
            strSql.Append("S2TimeForeColor=@S2TimeForeColor,");
            strSql.Append("S2TimeBackColor=@S2TimeBackColor,");
            strSql.Append("S2LedClockForeColor=@S2LedClockForeColor,");
            strSql.Append("S2LedClockBackColor=@S2LedClockBackColor,");
            strSql.Append("S2LedClockHeight=@S2LedClockHeight,");
            strSql.Append("S2StartMusic=@S2StartMusic,");
            strSql.Append("S2EndMusic=@S2EndMusic,");
            strSql.Append("S2StartShowText=@S2StartShowText,");
            strSql.Append("S2StartShowFont=@S2StartShowFont,");
            strSql.Append("S2StartShowForeColor=@S2StartShowForeColor,");
            strSql.Append("S2EndShowText=@S2EndShowText,");
            strSql.Append("S2EndShowFont=@S2EndShowFont,");
            strSql.Append("S2EndShowForeColor=@S2EndShowForeColor,");
            strSql.Append("S2ProjectTitleText=@S2ProjectTitleText,");
            strSql.Append("S2ProjectTitleFont=@S2ProjectTitleFont,");
            strSql.Append("S2ProjectTitleForeColor=@S2ProjectTitleForeColor,");
            strSql.Append("S2BaseHeadFont=@S2BaseHeadFont,");
            strSql.Append("S2BaseHeadForeColor=@S2BaseHeadForeColor,");
            strSql.Append("S2BaseHeadBackColor=@S2BaseHeadBackColor,");
            strSql.Append("S2BaseHeadHeight=@S2BaseHeadHeight,");
            strSql.Append("S2BaseContextFont=@S2BaseContextFont,");
            strSql.Append("S2BaseContextForeColor=@S2BaseContextForeColor,");
            strSql.Append("S2BaseContextGridColor=@S2BaseContextGridColor,");
            strSql.Append("S2BaseContextHeight=@S2BaseContextHeight,");
            strSql.Append("S2BaseDataSyn=@S2BaseDataSyn,");
            strSql.Append("S2BaseAutoSizeColumns=@S2BaseAutoSizeColumns,");
            strSql.Append("S2BaseBorderStyle=@S2BaseBorderStyle,");
            strSql.Append("S2BaseBorderWidth=@S2BaseBorderWidth,");
            strSql.Append("S2BaseColumnsFont=@S2BaseColumnsFont,");
            strSql.Append("S2BaseColumnsForeColor=@S2BaseColumnsForeColor,");
            strSql.Append("S2BaseColumnsBackColor=@S2BaseColumnsBackColor,");
            strSql.Append("S2BaseColumnsWidth=@S2BaseColumnsWidth,");
            strSql.Append("S2DetailHeadFont=@S2DetailHeadFont,");
            strSql.Append("S2DetailHeadForeColor=@S2DetailHeadForeColor,");
            strSql.Append("S2DetailHeadBackColor=@S2DetailHeadBackColor,");
            strSql.Append("S2DetailHeadHeight=@S2DetailHeadHeight,");
            strSql.Append("S2DetailContextFont=@S2DetailContextFont,");
            strSql.Append("S2DetailContextForeColor=@S2DetailContextForeColor,");
            strSql.Append("S2DetailContextGridColor=@S2DetailContextGridColor,");
            strSql.Append("S2DetailContextHeight=@S2DetailContextHeight,");
            strSql.Append("S2DetailDataSyn=@S2DetailDataSyn,");
            strSql.Append("S2DetailAutoSizeColumns=@S2DetailAutoSizeColumns,");
            strSql.Append("S2DetailBorderStyle=@S2DetailBorderStyle,");
            strSql.Append("S2DetailBorderWidth=@S2DetailBorderWidth,");
            strSql.Append("S2DetailColumns=@S2DetailColumns,");
            strSql.Append("S2AfficheText=@S2AfficheText,");
            strSql.Append("S2AfficheFont=@S2AfficheFont,");
            strSql.Append("S2AfficheForeColor=@S2AfficheForeColor,");
            strSql.Append("S2AfficheHeight=@S2AfficheHeight,");
            strSql.Append("S2AfficheSpend=@S2AfficheSpend,");
            strSql.Append("S2AfficheDirection=@S2AfficheDirection,");
            strSql.Append("S2MusicSomeOne=@S2MusicSomeOne,");
            strSql.Append("S2MusicNoOne=@S2MusicNoOne,");
            strSql.Append("S2MusicSomeOneOpen=@S2MusicSomeOneOpen,");
            strSql.Append("S2MusicNoOneOpen=@S2MusicNoOneOpen,");
            strSql.Append("S2StartMusicOpen=@S2StartMusicOpen,");
            strSql.Append("S2EndMusicOpen=@S2EndMusicOpen,");
            strSql.Append("S2ProjectInfoMarquee=@S2ProjectInfoMarquee,");
            strSql.Append("S2ProjectInfoSwitchTime=@S2ProjectInfoSwitchTime,");
            strSql.Append("S2TimeFont=@S2TimeFont,");
            strSql.Append("S2TimeFontColor=@S2TimeFontColor");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@SaveTime", OleDbType.Date),
					new OleDbParameter("@SettingName", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorTime", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorBase", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorDetail", OleDbType.VarChar,0),
					new OleDbParameter("@S2AreaBackColorBottom", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BuyTitleHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2ClockBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2HourHandColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2MinuteHandColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2SecondColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2ScaleColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2TimeForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2TimeBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2LedClockHeight", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartMusic", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndMusic", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowText", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2StartShowForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowText", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2EndShowForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleText", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2ProjectTitleForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseHeadHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseContextFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextGridColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseContextHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseDataSyn", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseAutoSizeColumns", OleDbType.Boolean,1),
					new OleDbParameter("@S2BaseBorderStyle", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseBorderWidth", OleDbType.Integer,4),
					new OleDbParameter("@S2BaseColumnsFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2BaseColumnsWidth", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadBackColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailHeadHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailContextFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextGridColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailContextHeight", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailDataSyn", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailAutoSizeColumns", OleDbType.Boolean,1),
					new OleDbParameter("@S2DetailBorderStyle", OleDbType.VarChar,0),
					new OleDbParameter("@S2DetailBorderWidth", OleDbType.Integer,4),
					new OleDbParameter("@S2DetailColumns", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheText", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheFont", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheForeColor", OleDbType.VarChar,0),
					new OleDbParameter("@S2AfficheHeight", OleDbType.Integer,4),
                    new OleDbParameter("@S2AfficheSpend",OleDbType.Integer,4),
                    new OleDbParameter("@S2AfficheDirection",OleDbType.Integer,4),
					new OleDbParameter("@S2MusicSomeOne",OleDbType.VarChar,0),
					new OleDbParameter("@S2MusicNoOne",OleDbType.VarChar,0),
					new OleDbParameter("@S2MusicSomeOneOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2MusicNoOneOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2StartMusicOpen",OleDbType.Boolean,1),
					new OleDbParameter("@S2EndMusicOpen",OleDbType.Boolean,1),
                    new OleDbParameter("@S2ProjectInfoMarquee",OleDbType.Integer,4),
                    new OleDbParameter("@S2ProjectInfoSwitchTime",OleDbType.Integer,4),
                    new OleDbParameter("@S2TimeFont", OleDbType.VarChar, 5000),
                    new OleDbParameter("@S2TimeFontColor", OleDbType.VarChar, 5000)
                                          };
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = CommFunction.ColorToString(S2AreaBackColorTime);
            parameters[4].Value = CommFunction.ColorToString(S2AreaBackColorBase);
            parameters[5].Value = CommFunction.ColorToString(S2AreaBackColorDetail);
            parameters[6].Value = CommFunction.ColorToString(S2AreaBackColorBottom);
            parameters[7].Value = CommFunction.FontToString(S2BuyTitleFont);
            parameters[8].Value = CommFunction.ColorToString(S2BuyTitleColor);
            parameters[9].Value = S2BuyTitleHeight;
            parameters[10].Value = CommFunction.ColorToString(S2ClockBackColor);
            parameters[11].Value = CommFunction.ColorToString(S2HourHandColor);
            parameters[12].Value = CommFunction.ColorToString(S2MinuteHandColor);
            parameters[13].Value = CommFunction.ColorToString(S2SecondColor);
            parameters[14].Value = CommFunction.ColorToString(S2ScaleColor);
            parameters[15].Value = CommFunction.ColorToString(S2TimeForeColor);
            parameters[16].Value = CommFunction.ColorToString(S2TimeBackColor);
            parameters[17].Value = CommFunction.ColorToString(S2LedClockForeColor);
            parameters[18].Value = CommFunction.ColorToString(S2LedClockBackColor);
            parameters[19].Value = S2LedClockHeight;
            parameters[20].Value = S2StartMusic;
            parameters[21].Value = S2EndMusic;
            parameters[22].Value = S2StartShowText;
            parameters[23].Value = CommFunction.FontToString(S2StartShowFont);
            parameters[24].Value = CommFunction.ColorToString(S2StartShowForeColor);
            parameters[25].Value = S2EndShowText;
            parameters[26].Value = CommFunction.FontToString(S2EndShowFont);
            parameters[27].Value = CommFunction.ColorToString(S2EndShowForeColor);
            parameters[28].Value = S2ProjectTitleText;
            parameters[29].Value = CommFunction.FontToString(S2ProjectTitleFont);
            parameters[30].Value = CommFunction.ColorToString(S2ProjectTitleForeColor);
            parameters[31].Value = CommFunction.FontToString(S2BaseHeadFont);
            parameters[32].Value = CommFunction.ColorToString(S2BaseHeadForeColor);
            parameters[33].Value = CommFunction.ColorToString(S2BaseHeadBackColor);
            parameters[34].Value = S2BaseHeadHeight;
            parameters[35].Value = CommFunction.FontToString(S2BaseContextFont);
            parameters[36].Value = CommFunction.ColorToString(S2BaseContextForeColor);
            parameters[37].Value = CommFunction.ColorToString(S2BaseContextGridColor);
            parameters[38].Value = S2BaseContextHeight;
            parameters[39].Value = S2BaseDataSyn;
            parameters[40].Value = S2BaseAutoSizeColumns;
            parameters[41].Value = CommFunction.BorderStyleToString(S2BaseBorderStyle);
            parameters[42].Value = S2BaseBorderWidth;
            parameters[43].Value = CommFunction.FontListToString(S2BaseColumnsFont);
            parameters[44].Value = CommFunction.ColorListToString(S2BaseColumnsForeColor);
            parameters[45].Value = CommFunction.ColorListToString(S2BaseColumnsBackColor);
            parameters[46].Value = CommFunction.DataGridViewListToString(S2BaseColumnsWidth);
            parameters[47].Value = CommFunction.FontToString(S2DetailHeadFont);
            parameters[48].Value = CommFunction.ColorToString(S2DetailHeadForeColor);
            parameters[49].Value = CommFunction.ColorToString(S2DetailHeadBackColor);
            parameters[50].Value = S2DetailHeadHeight;
            parameters[51].Value = CommFunction.FontToString(S2DetailContextFont);
            parameters[52].Value = CommFunction.ColorToString(S2DetailContextForeColor);
            parameters[53].Value = CommFunction.ColorToString(S2DetailContextGridColor);
            parameters[54].Value = S2DetailContextHeight;
            parameters[55].Value = S2DetailDataSyn;
            parameters[56].Value = S2DetailAutoSizeColumns;
            parameters[57].Value = CommFunction.BorderStyleToString(S2DetailBorderStyle);
            parameters[58].Value = S2DetailBorderWidth;
            parameters[59].Value = CommFunction.DataGridViewListToString(S2DetailColumns);
            parameters[60].Value = S2AfficheText;
            parameters[61].Value = CommFunction.FontToString(S2AfficheFont);
            parameters[62].Value = CommFunction.ColorToString(S2AfficheForeColor);
            parameters[63].Value = S2AfficheHeight;
            parameters[64].Value = S2AfficheSpend;
            parameters[65].Value = S2AfficheDirection;
            parameters[66].Value = S2MusicSomeOne;
            parameters[67].Value = S2MusicNoOne;
            parameters[68].Value = S2MusicSomeOneOpen;
            parameters[69].Value = S2MusicNoOneOpen;
            parameters[70].Value = S2StartMusicOpen;
            parameters[71].Value = S2EndMusicOpen;
            parameters[72].Value = S2ProjectInfoMarquee;
            parameters[73].Value = S2ProjectInfoSwitchTime;
            parameters[74].Value = CommFunction.FontToString(S2TimeFont);
            parameters[75].Value = CommFunction.ColorToString(S2TimeFontColor);


            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SettingsScreen2 ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = ID;

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from SettingsScreen2 where ID=@ID");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@ID", OleDbType.Integer, 4)
                                          };
            parameters[0].Value = id;

            DataSet ds = AccessHelper.Query(strSql.ToString(), parameters);
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0] == null || ds.Tables[0].Rows.Count <= 0) return;

            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaveTime"].ToString() != "")
            {
                SaveTime = DateTime.Parse(ds.Tables[0].Rows[0]["SaveTime"].ToString());
            }
            SettingName = ds.Tables[0].Rows[0]["SettingName"].ToString();
            S2AreaBackColorTime = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorTime"].ToString());
            S2AreaBackColorBase = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorBase"].ToString());
            S2AreaBackColorDetail = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorDetail"].ToString());
            S2AreaBackColorBottom = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AreaBackColorBottom"].ToString());
            S2BuyTitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BuyTitleFont"].ToString());
            S2BuyTitleColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BuyTitleColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BuyTitleHeight"].ToString() != string.Empty)
            {
                S2BuyTitleHeight = int.Parse(ds.Tables[0].Rows[0]["S2BuyTitleHeight"].ToString().Trim());
            }
            S2ClockBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ClockBackColor"].ToString());
            S2HourHandColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2HourHandColor"].ToString());
            S2MinuteHandColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2MinuteHandColor"].ToString());
            S2SecondColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2SecondColor"].ToString());
            S2ScaleColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ScaleColor"].ToString());
            S2TimeForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2TimeForeColor"].ToString());
            S2TimeBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2TimeBackColor"].ToString());
            S2LedClockForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2LedClockForeColor"].ToString());
            S2LedClockBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2LedClockBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2LedClockHeight"].ToString() != string.Empty)
            {
                S2LedClockHeight = int.Parse(ds.Tables[0].Rows[0]["S2LedClockHeight"].ToString().Trim());
            }
            S2StartMusic = ds.Tables[0].Rows[0]["S2StartMusic"].ToString();
            S2EndMusic = ds.Tables[0].Rows[0]["S2EndMusic"].ToString();
            S2StartShowText = ds.Tables[0].Rows[0]["S2StartShowText"].ToString();
            S2StartShowFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2StartShowFont"].ToString());
            S2StartShowForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2StartShowForeColor"].ToString());
            S2EndShowText = ds.Tables[0].Rows[0]["S2EndShowText"].ToString();
            S2EndShowFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2EndShowFont"].ToString());
            S2EndShowForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2EndShowForeColor"].ToString());
            S2ProjectTitleText = ds.Tables[0].Rows[0]["S2ProjectTitleText"].ToString();
            S2ProjectTitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2ProjectTitleFont"].ToString());
            S2ProjectTitleForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2ProjectTitleForeColor"].ToString());
            S2BaseHeadFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BaseHeadFont"].ToString());
            S2BaseHeadForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseHeadForeColor"].ToString());
            S2BaseHeadBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseHeadBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BaseHeadHeight"].ToString() != string.Empty)
            {
                S2BaseHeadHeight = int.Parse(ds.Tables[0].Rows[0]["S2BaseHeadHeight"].ToString().Trim());
            }
            S2BaseContextFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2BaseContextFont"].ToString());
            S2BaseContextForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseContextForeColor"].ToString());
            S2BaseContextGridColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2BaseContextGridColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2BaseContextHeight"].ToString() != string.Empty)
            {
                S2BaseContextHeight = int.Parse(ds.Tables[0].Rows[0]["S2BaseContextHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString() != string.Empty)
            {
                S2BaseDataSyn = int.Parse(ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2BaseDataSyn"].ToString() != string.Empty)
            {
                S2BaseAutoSizeColumns = bool.Parse(ds.Tables[0].Rows[0]["S2BaseAutoSizeColumns"].ToString().Trim());
            }
            S2BaseBorderStyle =
                CommFunction.StringToBorderStyle(ds.Tables[0].Rows[0]["S2BaseBorderStyle"].ToString().Trim());
            if (ds.Tables[0].Rows[0]["S2BaseBorderWidth"].ToString() != string.Empty)
            {
                S2BaseBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S2BaseBorderWidth"].ToString().Trim());
            }
            CommFunction.StringToFontList(S2BaseColumnsFont, ds.Tables[0].Rows[0]["S2BaseColumnsFont"].ToString());
            CommFunction.StringToColorList(S2BaseColumnsForeColor, ds.Tables[0].Rows[0]["S2BaseColumnsForeColor"].ToString());
            CommFunction.StringToColorList(S2BaseColumnsBackColor, ds.Tables[0].Rows[0]["S2BaseColumnsBackColor"].ToString());
            CommFunction.StringToDataGridViewList(S2BaseColumnsWidth, ds.Tables[0].Rows[0]["S2BaseColumnsWidth"].ToString());
            S2DetailHeadFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2DetailHeadFont"].ToString());
            S2DetailHeadForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailHeadForeColor"].ToString());
            S2DetailHeadBackColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailHeadBackColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2DetailHeadHeight"].ToString() != string.Empty)
            {
                S2DetailHeadHeight = int.Parse(ds.Tables[0].Rows[0]["S2DetailHeadHeight"].ToString().Trim());
            }
            S2DetailContextFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2DetailContextFont"].ToString());
            S2DetailContextForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailContextForeColor"].ToString());
            S2DetailContextGridColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2DetailContextGridColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2DetailContextHeight"].ToString() != string.Empty)
            {
                S2DetailContextHeight = int.Parse(ds.Tables[0].Rows[0]["S2DetailContextHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2DetailDataSyn"].ToString() != string.Empty)
            {
                S2DetailDataSyn = int.Parse(ds.Tables[0].Rows[0]["S2DetailDataSyn"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2DetailAutoSizeColumns"].ToString() != string.Empty)
            {
                S2DetailAutoSizeColumns = bool.Parse(ds.Tables[0].Rows[0]["S2DetailAutoSizeColumns"].ToString().Trim());
            }
            S2DetailBorderStyle = CommFunction.StringToBorderStyle(ds.Tables[0].Rows[0]["S2DetailBorderStyle"].ToString().Trim());
            if (ds.Tables[0].Rows[0]["S2DetailBorderWidth"].ToString() != string.Empty)
            {
                S2DetailBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S2DetailBorderWidth"].ToString().Trim());
            }
            CommFunction.StringToDataGridViewList(S2DetailColumns, ds.Tables[0].Rows[0]["S2DetailColumns"].ToString());
            S2AfficheText = ds.Tables[0].Rows[0]["S2AfficheText"].ToString();
            S2AfficheFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S2AfficheFont"].ToString());
            S2AfficheForeColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S2AfficheForeColor"].ToString());
            if (ds.Tables[0].Rows[0]["S2AfficheHeight"].ToString() != string.Empty)
            {
                S2AfficheHeight = int.Parse(ds.Tables[0].Rows[0]["S2AfficheHeight"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2AfficheSpend"].ToString() != string.Empty)
            {
                S2AfficheSpend = int.Parse(ds.Tables[0].Rows[0]["S1AfficheSpend"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S2AfficheDirection"].ToString() != string.Empty)
            {
                S2AfficheDirection = int.Parse(ds.Tables[0].Rows[0]["S2AfficheDirection"].ToString().Trim());
            }
            S2MusicSomeOne = ds.Tables[0].Rows[0]["S2MusicSomeOne"].ToString().Trim();
            S2MusicNoOne = ds.Tables[0].Rows[0]["S2MusicNoOne"].ToString().Trim();
            S2MusicSomeOneOpen = bool.Parse(ds.Tables[0].Rows[0]["S2MusicSomeOneOpen"].ToString().Trim());
            S2MusicNoOneOpen = bool.Parse(ds.Tables[0].Rows[0]["S2MusicNoOneOpen"].ToString().Trim());
            S2StartMusicOpen = bool.Parse(ds.Tables[0].Rows[0]["S2StartMusicOpen"].ToString().Trim());
            S2EndMusicOpen = bool.Parse(ds.Tables[0].Rows[0]["S2EndMusicOpen"].ToString().Trim());
            
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM SettingsScreen2 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return AccessHelper.Query(strSql.ToString());
        }
        
        #endregion
    }
}
