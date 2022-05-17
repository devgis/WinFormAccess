using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using CAEELEDPlayer.Common.Model;
using Newtonsoft.Json;

namespace CAEELEDPlayer.Common
{
    public class Screen1Data
    {
        static FormControl frm = FormControl.CreateInstance();
        
        public static List<ProjectInfo> GetProjectInfo()
        {
            return RequestData.GetData<ProjectInfo>("1001", 1);
        }

        public static void GetProjectInfo(string ResultData)
        {
            try
            {
                List<ProjectInfo> modelist = new List<ProjectInfo>();

                modelist = JavaScriptConvert.DeserializeObject<List<ProjectInfo>>(ResultData);
                frm.FScreen1.AddData(modelist);
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// ÆÁÄ»ÇÐ»»
        /// </summary>
        /// <param name="ResultData"></param>
        public static void TabScreen(string ResultData)
        {
            if (ResultData.Length > 0)
            {
                ResultData = ResultData.TrimStart('[').TrimEnd(']');
                frm.FConsole.TabScreen(ResultData);
            }
        }
        
    }
}
