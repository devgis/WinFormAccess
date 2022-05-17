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
        /// ������Ŀ������Ϣ
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
        /// ������Ա��Ϣ
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
        /// ���۽���
        /// </summary>
        /// <param name="result">������ʾ���۳ɹ����ɹ��Ļ���ֵΪ���ĳɹ��û�����1��ʾ����ʧ��</param>
        private static void ProjectEnd(string result)
        {
            frm.FScreen2.EndBuy(result);
        }
        
        /// <summary>
        /// ���۵ȴ�
        /// </summary>
        private static void ProjectWait()
        {
            frm.FScreen2.WaitBuy();
        }
        
        
        /// <summary>
        /// ���ۿ�ʼ
        /// </summary>
        private static void ProjectStart()
        {
            frm.FScreen2.StartBuy();
        }
        
        /// <summary>
        /// ������ͣ
        /// </summary>
        private static void ProjectSuspend()
        {
            frm.FScreen2.SuspendBuy();
        }
        
        /// <summary>
        /// ���ۻָ�
        /// </summary>
        private static void ProjectRecover()
        {
            frm.FScreen2.RecoverBuy();
        }
               
        /// <summary>
        /// ����״̬�ı�
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
            Wait = 0, //�ȴ�����
            Active = 1, //��ʼ����
            Suspend = 2, //��ͣ����
            Recover = 3, //�ָ�����
            End = 4 //��������
        }

        /// <summary>
        /// �ı������Ϣ���ֶ�ֵ
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
