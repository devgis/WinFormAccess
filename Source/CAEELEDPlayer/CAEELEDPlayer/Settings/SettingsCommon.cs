using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using CAEELEDPlayer.Common;
using System.Drawing;

namespace CAEELEDPlayer.Settings
{
    /// <summary>
    /// 类SettingsCommon。
    /// </summary>
    public class SettingsCommon
    {
        public SettingsCommon()
        { }
        #region Model
        private int _id = 0;
        private DateTime _savetime;
        private string _settingname;
        private int _screenx = 0;
        private int _screeny = 0;
        private int _screenh = 0;
        private int _screenw = 0;
        private Color _screencolor;
        private Color _screenfontcolor;
        private Color _screenlinecolor;
        private int _screenmargin = 0;
        private int _borderWidth = 0;

        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
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
        public int ScreenX
        {
            set { _screenx = value; }
            get { return _screenx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ScreenY
        {
            set { _screeny = value; }
            get { return _screeny; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ScreenH
        {
            set { _screenh = value; }
            get { return _screenh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ScreenW
        {
            set { _screenw = value; }
            get { return _screenw; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color ScreenColor
        {
            set { _screencolor = value; }
            get { return _screencolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color ScreenFontColor
        {
            set { _screenfontcolor = value; }
            get { return _screenfontcolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Color ScreenLineColor
        {
            set { _screenlinecolor = value; }
            get { return _screenlinecolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ScreenMargin
        {
            set { _screenmargin = value; }
            get { return _screenmargin; }
        }

        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SettingsCommon(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,SaveTime,SettingName,ScreenX,ScreenY,ScreenH,ScreenW,ScreenColor,ScreenFontColor,ScreenLineColor,ScreenMargin,BorderWidth ");
            strSql.Append(" FROM SettingsCommon ");
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
            if (ds.Tables[0].Rows[0]["ScreenX"].ToString() != "")
            {
                ScreenX = int.Parse(ds.Tables[0].Rows[0]["ScreenX"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenY"].ToString() != "")
            {
                ScreenY = int.Parse(ds.Tables[0].Rows[0]["ScreenY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenH"].ToString() != "")
            {
                ScreenH = int.Parse(ds.Tables[0].Rows[0]["ScreenH"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenW"].ToString() != "")
            {
                ScreenW = int.Parse(ds.Tables[0].Rows[0]["ScreenW"].ToString());
            }
            ScreenColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenColor"].ToString());
            ScreenFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenFontColor"].ToString());
            ScreenLineColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenLineColor"].ToString());
            if (ds.Tables[0].Rows[0]["ScreenMargin"].ToString() != "")
            {
                ScreenMargin = int.Parse(ds.Tables[0].Rows[0]["ScreenMargin"].ToString());
            }
            if (ds.Tables[0].Rows[0]["BorderWidth"].ToString() != "")
            {
                BorderWidth = int.Parse(ds.Tables[0].Rows[0]["BorderWidth"].ToString());
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SettingsCommon");
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
            strSql.Append("insert into SettingsCommon(");
            strSql.Append("ID,SaveTime,SettingName,ScreenX,ScreenY,ScreenH,ScreenW,ScreenColor,ScreenFontColor,ScreenLineColor,ScreenMargin,BorderWidth)");
            strSql.Append(" values (");
            strSql.Append("@ID,@SaveTime,@SettingName,@ScreenX,@ScreenY,@ScreenH,@ScreenW,@ScreenColor,@ScreenFontColor,@ScreenLineColor,@ScreenMargin,@BorderWidth)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@SaveTime", OleDbType.Date),
					new OleDbParameter("@SettingName", OleDbType.VarChar,50),
					new OleDbParameter("@ScreenX", OleDbType.Integer,4),
					new OleDbParameter("@ScreenY", OleDbType.Integer,4),
					new OleDbParameter("@ScreenH", OleDbType.Integer,4),
					new OleDbParameter("@ScreenW", OleDbType.Integer,4),
					new OleDbParameter("@ScreenColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenFontColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenLineColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenMargin", OleDbType.Integer,4),
					new OleDbParameter("@BorderWidth", OleDbType.Integer,4)};
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = ScreenX;
            parameters[4].Value = ScreenY;
            parameters[5].Value = ScreenH;
            parameters[6].Value = ScreenW;
            parameters[7].Value = CommFunction.ColorToString(ScreenColor);
            parameters[8].Value = CommFunction.ColorToString(ScreenFontColor);
            parameters[9].Value = CommFunction.ColorToString(ScreenLineColor);
            parameters[10].Value = ScreenMargin;
            parameters[11].Value = BorderWidth;

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SettingsCommon set ");
            strSql.Append("ID=@ID,");
            strSql.Append("SaveTime=@SaveTime,");
            strSql.Append("SettingName=@SettingName,");
            strSql.Append("ScreenX=@ScreenX,");
            strSql.Append("ScreenY=@ScreenY,");
            strSql.Append("ScreenH=@ScreenH,");
            strSql.Append("ScreenW=@ScreenW,");
            strSql.Append("ScreenColor=@ScreenColor,");
            strSql.Append("ScreenFontColor=@ScreenFontColor,");
            strSql.Append("ScreenLineColor=@ScreenLineColor,");
            strSql.Append("ScreenMargin=@ScreenMargin,");
            strSql.Append("BorderWidth=@BorderWidth");
            strSql.Append(" where ID=@ID ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4),
					new OleDbParameter("@SaveTime", OleDbType.Date),
					new OleDbParameter("@SettingName", OleDbType.VarChar,50),
					new OleDbParameter("@ScreenX", OleDbType.Integer,4),
					new OleDbParameter("@ScreenY", OleDbType.Integer,4),
					new OleDbParameter("@ScreenH", OleDbType.Integer,4),
					new OleDbParameter("@ScreenW", OleDbType.Integer,4),
					new OleDbParameter("@ScreenColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenFontColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenLineColor", OleDbType.VarChar,5000),
					new OleDbParameter("@ScreenMargin", OleDbType.Integer,4),
					new OleDbParameter("@BorderWidth", OleDbType.Integer,4)};
            parameters[0].Value = ID;
            parameters[1].Value = SaveTime;
            parameters[2].Value = SettingName;
            parameters[3].Value = ScreenX;
            parameters[4].Value = ScreenY;
            parameters[5].Value = ScreenH;
            parameters[6].Value = ScreenW;
            parameters[7].Value = CommFunction.ColorToString(ScreenColor);
            parameters[8].Value = CommFunction.ColorToString(ScreenFontColor);
            parameters[9].Value = CommFunction.ColorToString(ScreenLineColor);
            parameters[10].Value = ScreenMargin;
            parameters[11].Value = BorderWidth;

            return AccessHelper.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SettingsCommon ");
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
            strSql.Append("select ID,SaveTime,SettingName,ScreenX,ScreenY,ScreenH,ScreenW,ScreenColor,ScreenFontColor,ScreenLineColor,ScreenMargin,BorderWidth ");
            strSql.Append(" FROM SettingsCommon ");
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
            if (ds.Tables[0].Rows[0]["ScreenX"].ToString() != "")
            {
                ScreenX = int.Parse(ds.Tables[0].Rows[0]["ScreenX"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenY"].ToString() != "")
            {
                ScreenY = int.Parse(ds.Tables[0].Rows[0]["ScreenY"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenH"].ToString() != "")
            {
                ScreenH = int.Parse(ds.Tables[0].Rows[0]["ScreenH"].ToString());
            }
            if (ds.Tables[0].Rows[0]["ScreenW"].ToString() != "")
            {
                ScreenW = int.Parse(ds.Tables[0].Rows[0]["ScreenW"].ToString());
            }
            ScreenColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenColor"].ToString());
            ScreenFontColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenFontColor"].ToString());
            ScreenLineColor = CommFunction.StringToColor(ds.Tables[0].Rows[0]["ScreenLineColor"].ToString());
            if (ds.Tables[0].Rows[0]["ScreenMargin"].ToString() != "")
            {
                ScreenMargin = int.Parse(ds.Tables[0].Rows[0]["ScreenMargin"].ToString());
            }
            if (ds.Tables[0].Rows[0]["BorderWidth"].ToString() != "")
            {
                BorderWidth = int.Parse(ds.Tables[0].Rows[0]["BorderWidth"].ToString());
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM SettingsCommon ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return AccessHelper.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

