using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using CAEELEDPlayer.Common;

namespace CAEELEDPlayer.Settings
{
    /// <summary>
    /// 类SettingsScreen1。
    /// </summary>
    public class SettingsScreen1
    {
        public SettingsScreen1()
        { }
        #region Model
        private int _id = 0;
        private DateTime _savetime;
        private string _settingname;
        private string _s1title;
        private Font _s1titlefont;
        private Color _s1titlefontcolor;
        private int _s1titleheight = 0;
        private Font _s1tableheaderfont;
        private Color _s1tableheaderfontcolor;
        private Color _s1tableheaderbcolor;
        private int _s1tableheaderheight = 0;
        private Font _s1tablefont;
        private Color _s1tablefontcolor;
        private Color _s1tablelinecolor;
        private int _s1tablepagespeed = 0;
        private int _s1tablepagesize = 0;
        private int _s1tabledatasyn = 0;
        private bool _s1tableautosizecolumns;
        private frmLEDScreen1.TableBorderType _s1tableborderstyle;
        private int _s1tableborderwidth = 0;
        private List<DataGridViewColumn> _s1tableshowcolumns;
        private string _s1affiche;
        private Font _s1affichefont;
        private Color _s1affichefontcolor;
        private int _s1afficheheight = 0;
        private int _s1dataflag = 0;
        private int _S1TableContextHeight = 0;
        private int _S1AfficheSpend = 0;
        private int _S1AfficheDirection = 0;
        private Font _s1TimeFont;
        private Color _s1TimeFontColor;
        private Point _S1TimeLocation;
        private Point _S1TitleLocation;
        
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value;}
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SaveTime
        {
            set { _savetime = value; }
            get { return _savetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SettingName
        {
            set { _settingname = value; }
            get { return _settingname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S1Title
        {
            set { _s1title = value; }
            get { return _s1title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Font S1TitleFont
        {
            set { _s1titlefont = value; }
            get { return _s1titlefont; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1TitleFontColor
        {
            set { _s1titlefontcolor = value; }
            get { return _s1titlefontcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TitleHeight
        {
            set { _s1titleheight = value; }
            get { return _s1titleheight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Font S1TableHeaderFont
        {
            set { _s1tableheaderfont = value; }
            get { return _s1tableheaderfont; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1TableHeaderFontColor
        {
            set { _s1tableheaderfontcolor = value; }
            get { return _s1tableheaderfontcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1TableHeaderBColor
        {
            set { _s1tableheaderbcolor = value; }
            get { return _s1tableheaderbcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TableHeaderHeight
        {
            set { _s1tableheaderheight = value; }
            get { return _s1tableheaderheight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Font S1TableFont
        {
            set { _s1tablefont = value; }
            get { return _s1tablefont; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1TableFontColor
        {
            set { _s1tablefontcolor = value; }
            get { return _s1tablefontcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1TableLineColor
        {
            set { _s1tablelinecolor = value; }
            get { return _s1tablelinecolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TablePageSpeed
        {
            set { _s1tablepagespeed = value; }
            get { return _s1tablepagespeed; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TablePageSize
        {
            set { _s1tablepagesize = value; }
            get { return _s1tablepagesize; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TableDataSyn
        {
            set { _s1tabledatasyn = value; }
            get { return _s1tabledatasyn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool S1TableAutoSizeColumns
        {
            set { _s1tableautosizecolumns = value; }
            get { return _s1tableautosizecolumns; }
        }
        /// <summary>
        /// 
        /// </summary>
        public frmLEDScreen1.TableBorderType S1TableBorderStyle
        {
            set { _s1tableborderstyle = value; }
            get { return _s1tableborderstyle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1TableBorderWidth
        {
            set { _s1tableborderwidth = value; }
            get { return _s1tableborderwidth; }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<DataGridViewColumn> S1TableShowColumns
        {
            set { _s1tableshowcolumns = value; }
            get { return _s1tableshowcolumns; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string S1TableShowColumnsString
        {
            set
            {
                string scString = value.Trim();
                if (!string.IsNullOrEmpty(scString))
                {
                    S1TableShowColumns = new List<DataGridViewColumn>();
                    string[] scols = scString.Split(';');

                    foreach (string s in scols)
                    {
                        string[] sp = s.Split(',');
                        if (sp.Length != 3) continue;
                        DataGridViewColumn col = new DataGridViewColumn();
                        col.Name = sp[0];
                        col.Width = int.Parse(sp[1]);
                        col.Visible = bool.Parse(sp[2]);
                        S1TableShowColumns.Add(col);
                    }
                }
                else
                {
                    S1TableShowColumns = null;
                }
            }
            get
            {
                StringBuilder cstring = new StringBuilder();
                if (S1TableShowColumns != null)
                {
                    foreach (DataGridViewColumn col in S1TableShowColumns)
                    {
                        cstring.Append(string.Format("{0},{1},{2};", col.Name, col.Width, col.Visible));
                    }
                }
                if (cstring.Length > 0)
                {
                    cstring = cstring.Remove(cstring.Length - 1, 1);
                }
                return cstring.ToString().Trim();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string S1Affiche
        {
            set { _s1affiche = value; }
            get { return _s1affiche; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Font S1AfficheFont
        {
            set { _s1affichefont = value; }
            get { return _s1affichefont; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color S1AfficheFontColor
        {
            set { _s1affichefontcolor = value; }
            get { return _s1affichefontcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int S1AfficheHeight
        {
            set { _s1afficheheight = value; }
            get { return _s1afficheheight; }
        }
        
        public int S1DataFlag
        {
            set { _s1dataflag = value;}
            get { return _s1dataflag; }
        }
        
        public int S1TableContextHeight
        {
            set { _S1TableContextHeight =  value;}
            get { return _S1TableContextHeight;}
        }

        public int S1AfficheSpend
        {
            get { return _S1AfficheSpend; }
            set { _S1AfficheSpend = value; }
        }

        public int S1AfficheDirection
        {
            get { return _S1AfficheDirection; }
            set { _S1AfficheDirection = value; }
        }

        public Font S1TimeFont
        {
            set { _s1TimeFont = value; }
            get { return _s1TimeFont; }
        }
        
        public Color S1TimeFontColor
        {
            set { _s1TimeFontColor = value; }
            get { return _s1TimeFontColor; }
        }

        public Point S1TimeLocation
        {
            get { return _S1TimeLocation; }
            set { _S1TimeLocation = value; }
        }

        public Point S1TitleLocation
        {
            get { return _S1TitleLocation; }
            set { _S1TitleLocation = value; }
        }
        
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SettingsScreen1(int id)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select ID,SaveTime,SettingName,S1Title,S1TitleFont,S1TitleFontColor,S1TitleHeight,S1TableHeaderFont,S1TableHeaderFontColor,S1TableHeaderBColor,S1TableHeaderHeight,S1TableFont,S1TableFontColor,S1TableLineColor,S1TablePageSpeed,S1TablePageSize,S1TableDataSyn,S1TableAutoSizeColumns,S1TableBorderStyle,S1TableBorderWidth,S1TableShowColumns,S1Affiche,S1AfficheFont,S1AfficheFontColor,S1AfficheHeight ");
            strSql.Append("select *  ");
            strSql.Append(" FROM SettingsScreen1 ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = id;

            DataSet ds = AccessHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count <= 0) return;
            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaveTime"].ToString() != "")
            {
                SaveTime = DateTime.Parse(ds.Tables[0].Rows[0]["SaveTime"].ToString());
            }
            SettingName = ds.Tables[0].Rows[0]["SettingName"].ToString();
            S1Title = ds.Tables[0].Rows[0]["S1Title"].ToString();
            S1TitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TitleFont"].ToString());
            S1TitleFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TitleFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TitleHeight"].ToString() != "")
            {
                S1TitleHeight = int.Parse(ds.Tables[0].Rows[0]["S1TitleHeight"].ToString());
            }
            S1TableHeaderFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TableHeaderFont"].ToString());
            S1TableHeaderFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableHeaderFontColor"].ToString());
            S1TableHeaderBColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableHeaderBColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TableHeaderHeight"].ToString() != "")
            {
                S1TableHeaderHeight = int.Parse(ds.Tables[0].Rows[0]["S1TableHeaderHeight"].ToString());
            }
            S1TableFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TableFont"].ToString());
            S1TableFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableFontColor"].ToString());
            S1TableLineColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableLineColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TablePageSpeed"].ToString() != "")
            {
                S1TablePageSpeed = int.Parse(ds.Tables[0].Rows[0]["S1TablePageSpeed"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TablePageSize"].ToString() != "")
            {
                S1TablePageSize = int.Parse(ds.Tables[0].Rows[0]["S1TablePageSize"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TableDataSyn"].ToString() != "")
            {
                S1TableDataSyn = int.Parse(ds.Tables[0].Rows[0]["S1TableDataSyn"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString() != "")
            {
                if ((ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString() == "1") || (ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString().ToLower() == "true"))
                {
                    S1TableAutoSizeColumns = true;
                }
                else
                {
                    S1TableAutoSizeColumns = false;
                }
            }

            S1TableBorderStyle = (frmLEDScreen1.TableBorderType)int.Parse(ds.Tables[0].Rows[0]["S1TableBorderStyle"].ToString());
            if (ds.Tables[0].Rows[0]["S1TableBorderWidth"].ToString() != "")
            {
                S1TableBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S1TableBorderWidth"].ToString());
            }
            S1TableShowColumnsString = ds.Tables[0].Rows[0]["S1TableShowColumns"].ToString();
            S1Affiche = ds.Tables[0].Rows[0]["S1Affiche"].ToString();
            S1AfficheFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1AfficheFont"].ToString());
            S1AfficheFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1AfficheFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1AfficheHeight"].ToString() != "")
            {
                S1AfficheHeight = int.Parse(ds.Tables[0].Rows[0]["S1AfficheHeight"].ToString());
            }

            if (ds.Tables[0].Rows[0]["S1DataFlag"] != null && ds.Tables[0].Rows[0]["S1DataFlag"].ToString().Trim() != string.Empty)
                S1DataFlag = Convert.ToInt32(ds.Tables[0].Rows[0]["S1DataFlag"].ToString());
            S1TableContextHeight = Convert.ToInt32(ds.Tables[0].Rows[0]["S1TableContextHeight"].ToString());
            if (ds.Tables[0].Rows[0]["S1AfficheSpend"].ToString() != string.Empty)
            {
                S1AfficheSpend = int.Parse(ds.Tables[0].Rows[0]["S1AfficheSpend"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S1AfficheDirection"].ToString() != string.Empty)
            {
                S1AfficheDirection = int.Parse(ds.Tables[0].Rows[0]["S1AfficheDirection"].ToString().Trim());
            }

            S1TimeFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TimeFont"].ToString());
            S1TimeFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TimeFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TimeLocation"].ToString() != string.Empty)
            {
                S1TimeLocation = CommFunction.StringToPoint(ds.Tables[0].Rows[0]["S1TimeLocation"].ToString().Trim());
            }

            if (ds.Tables[0].Rows[0]["S1TitleLocation"].ToString() != string.Empty)
            {
                S1TitleLocation = CommFunction.StringToPoint(ds.Tables[0].Rows[0]["S1TitleLocation"].ToString().Trim());
            }
            
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SettingsScreen1");
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
            strSql.Append("insert into SettingsScreen1(");
            strSql.Append(
                "ID,SaveTime,SettingName,S1Title,S1TitleFont,S1TitleFontColor,S1TitleHeight,S1TableHeaderFont,S1TableHeaderFontColor,S1TableHeaderBColor,S1TableHeaderHeight,S1TableFont,S1TableFontColor,S1TableLineColor,S1TablePageSpeed,S1TablePageSize,S1TableDataSyn,S1TableAutoSizeColumns,S1TableBorderStyle,S1TableBorderWidth,S1TableShowColumns,S1Affiche,S1AfficheFont,S1AfficheFontColor,S1AfficheHeight,S1DataFlag,S1TableContextHeight,S1AfficheSpend,S1AfficheDirection,S1TimeFont,S1TimeFontColor,S1TimeLocation,S1TitleLocation)");
            strSql.Append(" values (");
            strSql.Append(
                "@ID,@SaveTime,@SettingName,@S1Title,@S1TitleFont,@S1TitleFontColor,@S1TitleHeight,@S1TableHeaderFont,@S1TableHeaderFontColor,@S1TableHeaderBColor,@S1TableHeaderHeight,@S1TableFont,@S1TableFontColor,@S1TableLineColor,@S1TablePageSpeed,@S1TablePageSize,@S1TableDataSyn,@S1TableAutoSizeColumns,@S1TableBorderStyle,@S1TableBorderWidth,@S1TableShowColumns,@S1Affiche,@S1AfficheFont,@S1AfficheFontColor,@S1AfficheHeight,@S1DataFlag,@S1TableContextHeight,@S1AfficheSpend,@S1AfficheDirection,@S1TimeFont,@S1TimeFontColor,@S1TimeLocation,@S1TitleLocation)");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@ID", OleDbType.Integer, 4),
                                              new OleDbParameter("@SaveTime", OleDbType.Date),
                                              new OleDbParameter("@SettingName", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1Title", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableHeaderFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderBColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableLineColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TablePageSpeed", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TablePageSize", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableDataSyn", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableAutoSizeColumns", OleDbType.Boolean, 1),
                                              new OleDbParameter("@S1TableBorderStyle", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableBorderWidth", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableShowColumns", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1Affiche", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1DataFlag",OleDbType.Integer,4) ,
                                              new OleDbParameter("@S1TableContextHeight",OleDbType.Integer,4),
                                              new OleDbParameter("@S1AfficheSpend",OleDbType.Integer,4),
                                              new OleDbParameter("@S1AfficheDirection",OleDbType.Integer,4),
                                              new OleDbParameter("@S1TimeFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TimeFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TimeLocation", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleLocation",OleDbType.VarChar,5000) 
                                          };
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = S1Title;
            parameters[4].Value = CommFunction.FontToString(S1TitleFont);
            parameters[5].Value = CommFunction.ColorToString(S1TitleFontColor);
            parameters[6].Value = S1TitleHeight;
            parameters[7].Value = CommFunction.FontToString(S1TableHeaderFont);
            parameters[8].Value = CommFunction.ColorToString(S1TableHeaderFontColor);
            parameters[9].Value = CommFunction.ColorToString(S1TableHeaderBColor);
            parameters[10].Value = S1TableHeaderHeight;
            parameters[11].Value = CommFunction.FontToString(S1TableFont);
            parameters[12].Value = CommFunction.ColorToString(S1TableFontColor);
            parameters[13].Value = CommFunction.ColorToString(S1TableLineColor);
            parameters[14].Value = S1TablePageSpeed;
            parameters[15].Value = S1TablePageSize;
            parameters[16].Value = S1TableDataSyn;
            parameters[17].Value = S1TableAutoSizeColumns;
            parameters[18].Value = (int)S1TableBorderStyle;
            parameters[19].Value = S1TableBorderWidth;
            parameters[20].Value = S1TableShowColumnsString;
            parameters[21].Value = S1Affiche;
            parameters[22].Value = CommFunction.FontToString(S1AfficheFont);
            parameters[23].Value = CommFunction.ColorToString(S1AfficheFontColor);
            parameters[24].Value = S1AfficheHeight;
            parameters[25].Value = S1DataFlag;
            parameters[26].Value = S1TableContextHeight;
            parameters[27].Value = S1AfficheSpend;
            parameters[28].Value = S1AfficheDirection;
            parameters[29].Value = CommFunction.FontToString(S1TimeFont);
            parameters[30].Value = CommFunction.ColorToString(S1TimeFontColor);
            parameters[31].Value = CommFunction.PointToString(S1TimeLocation);
            parameters[32].Value = CommFunction.PointToString(S1TitleLocation);

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SettingsScreen1 set ");
            strSql.Append("ID=@ID,");
            strSql.Append("SaveTime=@SaveTime,");
            strSql.Append("SettingName=@SettingName,");
            strSql.Append("S1Title=@S1Title,");
            strSql.Append("S1TitleFont=@S1TitleFont,");
            strSql.Append("S1TitleFontColor=@S1TitleFontColor,");
            strSql.Append("S1TitleHeight=@S1TitleHeight,");
            strSql.Append("S1TableHeaderFont=@S1TableHeaderFont,");
            strSql.Append("S1TableHeaderFontColor=@S1TableHeaderFontColor,");
            strSql.Append("S1TableHeaderBColor=@S1TableHeaderBColor,");
            strSql.Append("S1TableHeaderHeight=@S1TableHeaderHeight,");
            strSql.Append("S1TableFont=@S1TableFont,");
            strSql.Append("S1TableFontColor=@S1TableFontColor,");
            strSql.Append("S1TableLineColor=@S1TableLineColor,");
            strSql.Append("S1TablePageSpeed=@S1TablePageSpeed,");
            strSql.Append("S1TablePageSize=@S1TablePageSize,");
            strSql.Append("S1TableDataSyn=@S1TableDataSyn,");
            strSql.Append("S1TableAutoSizeColumns=@S1TableAutoSizeColumns,");
            strSql.Append("S1TableBorderStyle=@S1TableBorderStyle,");
            strSql.Append("S1TableBorderWidth=@S1TableBorderWidth,");
            strSql.Append("S1TableShowColumns=@S1TableShowColumns,");
            strSql.Append("S1Affiche=@S1Affiche,");
            strSql.Append("S1AfficheFont=@S1AfficheFont,");
            strSql.Append("S1AfficheFontColor=@S1AfficheFontColor,");
            strSql.Append("S1AfficheHeight=@S1AfficheHeight,");
            strSql.Append("S1DataFlag=@S1DataFlag,");
            strSql.Append("S1TableContextHeight=@S1TableContextHeight,");
            strSql.Append("S1AfficheSpend=@S1AfficheSpend,");
            strSql.Append("S1AfficheDirection=@S1AfficheDirection,");
            strSql.Append("S1TimeFont=@S1TimeFont,");
            strSql.Append("S1TimeFontColor=@S1TimeFontColor,");
            strSql.Append("S1TimeLocation=@S1TimeLocation,");
            strSql.Append("S1TitleLocation=@S1TitleLocation");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@ID", OleDbType.Integer, 4),
                                              new OleDbParameter("@SaveTime", OleDbType.Date),
                                              new OleDbParameter("@SettingName", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1Title", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableHeaderFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderBColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableHeaderHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableLineColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TablePageSpeed", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TablePageSize", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableDataSyn", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableAutoSizeColumns", OleDbType.Boolean, 1),
                                              new OleDbParameter("@S1TableBorderStyle", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TableBorderWidth", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1TableShowColumns", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1Affiche", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1AfficheHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1DataFlag", OleDbType.Integer, 4),
                                              new OleDbParameter("S1TableContextHeight", OleDbType.Integer, 4),
                                              new OleDbParameter("@S1AfficheSpend",OleDbType.Integer,4),
                                              new OleDbParameter("@S1AfficheDirection",OleDbType.Integer,4),
                                              new OleDbParameter("@S1TimeFont", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TimeFontColor", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TimeLocation", OleDbType.VarChar, 5000),
                                              new OleDbParameter("@S1TitleLocation",OleDbType.VarChar,5000) 
                                          };
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = S1Title;
            parameters[4].Value = CommFunction.FontToString(S1TitleFont);
            parameters[5].Value = CommFunction.ColorToString(S1TitleFontColor);
            parameters[6].Value = S1TitleHeight;
            parameters[7].Value = CommFunction.FontToString(S1TableHeaderFont);
            parameters[8].Value = CommFunction.ColorToString(S1TableHeaderFontColor);
            parameters[9].Value = CommFunction.ColorToString(S1TableHeaderBColor);
            parameters[10].Value = S1TableHeaderHeight;
            parameters[11].Value = CommFunction.FontToString(S1TableFont);
            parameters[12].Value = CommFunction.ColorToString(S1TableFontColor);
            parameters[13].Value = CommFunction.ColorToString(S1TableLineColor);
            parameters[14].Value = S1TablePageSpeed;
            parameters[15].Value = S1TablePageSize;
            parameters[16].Value = S1TableDataSyn;
            parameters[17].Value = S1TableAutoSizeColumns;
            parameters[18].Value = (int)S1TableBorderStyle;
            parameters[19].Value = S1TableBorderWidth;
            parameters[20].Value = S1TableShowColumnsString;
            parameters[21].Value = S1Affiche;
            parameters[22].Value = CommFunction.FontToString(S1AfficheFont);
            parameters[23].Value = CommFunction.ColorToString(S1AfficheFontColor);
            parameters[24].Value = S1AfficheHeight;
            parameters[25].Value = S1DataFlag;
            parameters[26].Value = S1TableContextHeight;
            parameters[27].Value = S1AfficheSpend;
            parameters[28].Value = S1AfficheDirection;
            parameters[29].Value = CommFunction.FontToString(S1TimeFont);
            parameters[30].Value = CommFunction.ColorToString(S1TimeFontColor);
            parameters[31].Value = CommFunction.PointToString(S1TimeLocation);
            parameters[32].Value = CommFunction.PointToString(S1TitleLocation);

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SettingsScreen1 ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = id;

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters) > 0;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select ID,SaveTime,SettingName,S1Title,S1TitleFont,S1TitleFontColor,S1TitleHeight,S1TableHeaderFont,S1TableHeaderFontColor,S1TableHeaderBColor,S1TableHeaderHeight,S1TableFont,S1TableFontColor,S1TableLineColor,S1TablePageSpeed,S1TablePageSize,S1TableDataSyn,S1TableAutoSizeColumns,S1TableBorderStyle,S1TableBorderWidth,S1TableShowColumns,S1Affiche,S1AfficheFont,S1AfficheFontColor,S1AfficheHeight ");
            strSql.Append("select * ");
            strSql.Append(" FROM SettingsScreen1 ");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = id;

            DataSet ds = AccessHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count <= 0) return;
            if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
            {
                ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SaveTime"].ToString() != "")
            {
                SaveTime = DateTime.Parse(ds.Tables[0].Rows[0]["SaveTime"].ToString());
            }
            SettingName = ds.Tables[0].Rows[0]["SettingName"].ToString();
            S1Title = ds.Tables[0].Rows[0]["S1Title"].ToString();
            S1TitleFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TitleFont"].ToString());
            S1TitleFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TitleFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TitleHeight"].ToString() != "")
            {
                S1TitleHeight = int.Parse(ds.Tables[0].Rows[0]["S1TitleHeight"].ToString());
            }
            S1TableHeaderFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TableHeaderFont"].ToString());
            S1TableHeaderFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableHeaderFontColor"].ToString());
            S1TableHeaderBColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableHeaderBColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TableHeaderHeight"].ToString() != "")
            {
                S1TableHeaderHeight = int.Parse(ds.Tables[0].Rows[0]["S1TableHeaderHeight"].ToString());
            }
            S1TableFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TableFont"].ToString());
            S1TableFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableFontColor"].ToString());
            S1TableLineColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TableLineColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TablePageSpeed"].ToString() != "")
            {
                S1TablePageSpeed = int.Parse(ds.Tables[0].Rows[0]["S1TablePageSpeed"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TablePageSize"].ToString() != "")
            {
                S1TablePageSize = int.Parse(ds.Tables[0].Rows[0]["S1TablePageSize"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TableDataSyn"].ToString() != "")
            {
                S1TableDataSyn = int.Parse(ds.Tables[0].Rows[0]["S1TableDataSyn"].ToString());
            }
            if (ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString() != "")
            {
                if ((ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString() == "1") || (ds.Tables[0].Rows[0]["S1TableAutoSizeColumns"].ToString().ToLower() == "true"))
                {
                    S1TableAutoSizeColumns = true;
                }
                else
                {
                    S1TableAutoSizeColumns = false;
                }
            }


            S1TableBorderStyle = (frmLEDScreen1.TableBorderType)int.Parse(ds.Tables[0].Rows[0]["S1TableBorderStyle"].ToString());
            if (ds.Tables[0].Rows[0]["S1TableBorderWidth"].ToString() != "")
            {
                S1TableBorderWidth = int.Parse(ds.Tables[0].Rows[0]["S1TableBorderWidth"].ToString());
            }
            S1TableShowColumnsString = ds.Tables[0].Rows[0]["S1TableShowColumns"].ToString();
            S1Affiche = ds.Tables[0].Rows[0]["S1Affiche"].ToString();
            S1AfficheFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1AfficheFont"].ToString());
            S1AfficheFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1AfficheFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1AfficheHeight"].ToString() != "")
            {
                S1AfficheHeight = int.Parse(ds.Tables[0].Rows[0]["S1AfficheHeight"].ToString());
            }

            S1DataFlag = Convert.ToInt32(ds.Tables[0].Rows[0]["S1DataFlag"].ToString());
            S1TableContextHeight = Convert.ToInt32(ds.Tables[0].Rows[0]["S1TableContextHeight"].ToString());
            if (ds.Tables[0].Rows[0]["S1AfficheSpend"].ToString() != string.Empty)
            {
                S1AfficheSpend = int.Parse(ds.Tables[0].Rows[0]["S1AfficheSpend"].ToString().Trim());
            }
            if (ds.Tables[0].Rows[0]["S1AfficheDirection"].ToString() != string.Empty)
            {
                S1AfficheDirection = int.Parse(ds.Tables[0].Rows[0]["S1AfficheDirection"].ToString().Trim());
            }

            S1TimeFont = CommFunction.StringToFont(ds.Tables[0].Rows[0]["S1TimeFont"].ToString());
            S1TimeFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["S1TimeFontColor"].ToString());
            if (ds.Tables[0].Rows[0]["S1TimeLocation"].ToString() != string.Empty)
            {
                S1TimeLocation = CommFunction.StringToPoint(ds.Tables[0].Rows[0]["S1TimeLocation"].ToString().Trim());
            }

            if (ds.Tables[0].Rows[0]["S1TitleLocation"].ToString() != string.Empty)
            {
                S1TitleLocation = CommFunction.StringToPoint(ds.Tables[0].Rows[0]["S1TitleLocation"].ToString().Trim());
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM SettingsScreen1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return AccessHelper.Query(strSql.ToString());
        }

        #endregion  Method
    }
}