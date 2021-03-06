using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CAEELEDPlayer.Common.Model;
using Newtonsoft.Json;

namespace CAEELEDPlayer.Common
{
    public class RequestData
    {
        public static string splitChar = "|@|";

        public static List<T> GetData<T>(string strCmd, int iScreenNo)
        {
            try
            {
                List<ResponseData> listData = GetData(strCmd, iScreenNo);

                if (listData == null || listData.Count <=0)
                    return null;

                string ResultData = listData[0].Content;

                List<T> modelist = new List<T>();
                modelist = JavaScriptConvert.DeserializeObject<List<T>>(ResultData);
                return modelist;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return null;
            }
        }        
        
        public static List<ResponseData> GetData(string strCmd, int iScreenNo)
        {
            try
            {
                string strUrl = string.Empty;
                string ResultData = string.Empty;
                switch (iScreenNo)
                {
                    case 1:
                        strUrl = ConfigReader.RequestSource;
                        ResultData = File.ReadAllText(Path.Combine(Application.StartupPath, "s1.txt"),Encoding.Default);
                        break;
                    case 2:
                        strUrl = ConfigReader.RequestSource2;
                        HttpWebRequest dHttp = (HttpWebRequest)WebRequest.Create(string.Format(strUrl, strCmd));
                        dHttp.Timeout = 10000; // 10 secs
                        dHttp.UserAgent = "Led Client";

                        HttpWebResponse dWebResponse = (HttpWebResponse)dHttp.GetResponse();

                        Encoding enc = Encoding.GetEncoding("utf-8"); // Windows default Code Page

                        StreamReader loResponseStream = new StreamReader(dWebResponse.GetResponseStream(), enc);
                        ResultData = loResponseStream.ReadToEnd();
                        dWebResponse.Close();
                        loResponseStream.Close();
                        break;
                    default:
                        return null;
                }
                
                

                List<ResponseData> listData = new List<ResponseData>();
                if (ResultData != null && ResultData.Length > 0)
                {
                    string[] strResult = ResultData.Split(new string[] {splitChar}, StringSplitOptions.RemoveEmptyEntries);

                    if (strResult != null && strResult.Length > 0)
                    {
                        foreach (string s in strResult)
                        {
                            if (s.Length > 4)
                            {
                                ResponseData model = new ResponseData();
                                int iCmd = 0;
                                Int32.TryParse(s.Substring(0, 4), out iCmd);
                                model.Cmd = iCmd;
                                model.Content = s.Remove(0, 4);
                                listData.Add(model);
                            }
                        }
                    }
                }

                return listData;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return null;
            }
        }
    }
}
