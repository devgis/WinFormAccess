using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CAEELEDPlayer.Common
{
    public class CommFunction
    {
        public static string ColorToString(Color color)
        {
            return string.Format("{0},{1},{2},{3}", color.A, color.R, color.G, color.B);//从四个 ARGB 分量（alpha、红色、绿色和蓝色）
        }

        public static Color StringToColor(string colorstr)
        {
            if (string.IsNullOrEmpty(colorstr))
            {
                return Color.Gray;
            }
            string[] val = colorstr.Split(',');
            return val.Length == 4
                       ? Color.FromArgb(int.Parse(val[0]), int.Parse(val[1]), int.Parse(val[2]), int.Parse(val[3]))
                       : Color.Gray;
        }
        
        public static string PointToString(Point p)
        {
            return p.X + "," + p.Y;
        }
        
        public static Point StringToPoint(string pointstr)
        {
            string[] strArr = pointstr.Split(',');
            return new Point(Int32.Parse(strArr[0]), Int32.Parse(strArr[1]));
        }
        
        public static string FontToString(Font font)
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}", font.Name, font.Size, (int)font.Unit,font.Bold,font.Italic,font.Underline,font.Strikeout);
        }

        public static Font StringToFont(string fontstr)
        {
            if (string.IsNullOrEmpty(fontstr))
            {
                return new Font("宋体", 10);
            }
            else
            {
                string[] f = fontstr.Split(',');
                if (f.Length != 7)
                {
                    return new Font("宋体", 10);
                }
                else
                {
                    Font font = new Font(f[0], float.Parse(f[1]), (GraphicsUnit) int.Parse(f[2]));
                    if (bool.Parse(f[3]))
                    {
                        font = new Font(font, FontStyle.Bold);
                    }

                    if (bool.Parse(f[4]))
                    {
                        font = new Font(font, FontStyle.Italic);
                    }

                    if (bool.Parse(f[5]))
                    {
                        font = new Font(font, FontStyle.Underline);
                    }

                    if (bool.Parse(f[6]))
                    {
                        font = new Font(font, FontStyle.Strikeout);
                    }
                    return font;
                }
            }
        }
        
        public static BorderStyle StringToBorderStyle(string strStyle)
        {
            BorderStyle bdStyle = BorderStyle.None;
            if (string.IsNullOrEmpty(strStyle))
            {
                return BorderStyle.None;
            }
            else
            {
                switch(strStyle)
                {
                    case "0":
                        bdStyle = BorderStyle.None;
                        break;
                    case "1":
                        bdStyle = BorderStyle.FixedSingle;
                        break;
                    case "2":
                        bdStyle = BorderStyle.Fixed3D;
                        break;
                    default:
                        bdStyle = BorderStyle.None;
                        break;
                }
            }
            return bdStyle;
        }

        public static string BorderStyleToString(BorderStyle bdStyle)
        {
            if (bdStyle == BorderStyle.None)
                return "0";
            else if (bdStyle == BorderStyle.FixedSingle)
                return "1";
            else if (bdStyle == BorderStyle.Fixed3D)
                return "2";
            else 
                return "";
        }

        public static void StringToFontList(List<Font> lTemp, string strTemp)
        {
            if (string.IsNullOrEmpty(strTemp))
            {
                return;
            }
            else
            {
                string[] strArr = strTemp.Split(';');
                foreach (string str1 in strArr)
                {
                    lTemp.Add(StringToFont(str1));
                }
            }
        }
        
        public static string FontListToString(List<Font> lTemp)
        {
            string strTemp = string.Empty;
            foreach(Font f in lTemp)
            {
                strTemp += FontToString(f) + ";";
            }
            if (strTemp.Length > 0)
                strTemp = strTemp.Substring(0, strTemp.Length - 1);
            return strTemp;
        }

        public static void StringToColorList(List<Color> lTemp, string strTemp)
        {
            if (string.IsNullOrEmpty(strTemp))
            {
                return;
            }
            else
            {
                string[] strArr = strTemp.Split(';');
                foreach (string str1 in strArr)
                {
                    lTemp.Add(StringToColor(str1));
                }
            }
        }
        
        public static string ColorListToString(List<Color> cTemp)
        {
            string strTemp = string.Empty;
            foreach(Color f in cTemp)
            {
                strTemp += ColorToString(f) + ";";
            }
            if (strTemp.Length > 0)
                strTemp = strTemp.Substring(0, strTemp.Length - 1);
            return strTemp;
        }

        public static void StringToDataGridViewList(List<DataGridViewColumn> lTemp, string strTemp)
        {
            if (string.IsNullOrEmpty(strTemp))
            {
                return;
            }
            else
            {
                string[] strArr = strTemp.Split(';');
                foreach (string str1 in strArr)
                {
                    string[] sp = str1.Split(',');
                    if (sp.Length != 3) continue;
                    DataGridViewColumn col = new DataGridViewColumn();
                    col.Name = sp[0];
                    col.Width = int.Parse(sp[1]);
                    col.Visible = bool.Parse(sp[2]);
                    lTemp.Add(col);
                }
            }
        }
        
        public static string DataGridViewListToString(List<DataGridViewColumn> colTemp)
        {
            string strTemp = string.Empty;
            if (colTemp.Count > 0)
            {
                foreach (DataGridViewColumn col in colTemp)
                {
                    strTemp += string.Format("{0},{1},{2};", col.Name, col.Width, col.Visible);
                }
                if (strTemp.Length > 0)
                    strTemp.Remove(strTemp.Length - 1, 1);
            }
            return strTemp;
        }

        /// <summary>
        /// 返回当前时间的星期几
        /// </summary>
        /// <param name="dt">当前时间</param>
        /// <returns>星期</returns>
        public  static  string  GetWeekOfDay(DateTime dt)
        {
            string WeekName = string.Empty;
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    WeekName = "星期天";
                    break;
                case DayOfWeek.Monday:
                    WeekName = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    WeekName = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    WeekName = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    WeekName = "星期四";
                    break;
                case DayOfWeek.Friday:
                    WeekName = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    WeekName = "星期六";
                    break;
            }
            return WeekName;
        }
    }
}