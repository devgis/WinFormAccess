using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CAEELEDPlayer.Common.Model;
using Newtonsoft.Json;

namespace CAEELEDPlayer.Common
{
    class Screen2Data
    {
        static FormControl frm = FormControl.CreateInstance();
        
        /// <summary>
        /// 竞价项目基本信息
        /// </summary>
        /// <param name="ResultData"></param>
        public static void GetProjectShowInfo(string ResultData)
        {
            try
            {
                List<ProjectShowInfo> modelList = new List<ProjectShowInfo>();

                modelList = JavaScriptConvert.DeserializeObject<List<ProjectShowInfo>>(ResultData);
                frm.FScreen2.BindProjectBaseInfo(modelList[0]);
            }
            catch(Exception ex)
            {
                return;
            }
        }

        /// <summary>
        /// 竞价人员信息
        /// </summary>
        /// <param name="ResultData"></param>
        public static void GetBuyInfo(string ResultData)
        {
            try
            {
                List<Buy> modelList = new List<Buy>();

                modelList = JavaScriptConvert.DeserializeObject<List<Buy>>(ResultData);
                frm.FScreen2.BindBuyDetail(modelList);
            }
            catch (Exception ex)
            {
                return;
            }
        }
        
        /// <summary>
        /// 竞价结束
        /// </summary>
        /// <param name="result">其他表示竞价成功，成功的话，值为竞拍成功用户名，1表示竞价失败</param>
        private static void ProjectEnd(string result)
        {
            frm.FScreen2.EndBuy(result);
        }
        
        /// <summary>
        /// 竞价等待
        /// </summary>
        private static void ProjectWait()
        {
            frm.FScreen2.WaitBuy();
        }
        
        
        /// <summary>
        /// 竞价开始
        /// </summary>
        private static void ProjectStart()
        {
            frm.FScreen2.StartBuy();
        }
        
        /// <summary>
        /// 竞价暂停
        /// </summary>
        private static void ProjectSuspend()
        {
            frm.FScreen2.SuspendBuy();
        }
        
        /// <summary>
        /// 竞价恢复
        /// </summary>
        private static void ProjectRecover()
        {
            frm.FScreen2.RecoverBuy();
        }
               
        /// <summary>
        /// 竞价状态改变
        /// </summary>
        public static void ChangeProjectStatus(string ResultData)
        {
            try
            {
                List<ProjectStatus> modelList = new List<ProjectStatus>();
                modelList = JavaScriptConvert.DeserializeObject<List<ProjectStatus>>(ResultData);
                
                if(modelList != null && modelList.Count > 0)
                {
                    int iStatus = 0;
                    ProjectStatus model = modelList[0];
                    if (Int32.TryParse(model.status, out iStatus))
                    {
                        switch (iStatus)
                        {
                            case (int)Status.Wait:
                                ProjectWait();
                                break;
                            case (int)Status.Active:
                                ProjectStart();
                                break;
                            case (int)Status.Suspend:
                                ProjectSuspend();
                                break;
                            case (int)Status.Recover:
                                ProjectRecover();
                                break;
                            case (int)Status.End:
                                ProjectEnd(model.parm);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        enum Status
        {
            Wait = 0, //等待竞价
            Active = 1, //开始竞价
            Suspend = 2, //暂停竞价
            Recover = 3, //恢复竞价
            End = 4 //结束竞价
        }

        /// <summary>
        /// 改变基本信息的字段值
        /// </summary>
        /// <param name="ResultData"></param>
        public static void ChangeProjectField(string ResultData)
        {
            try
            {
                List<ProjectFiled> modelList = new List<ProjectFiled>();

                modelList = JavaScriptConvert.DeserializeObject<List<ProjectFiled>>(ResultData);
                frm.FScreen2.ChangeFiled(modelList[0]);
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
