using System;

namespace CAEELEDPlayer.Common.Model
{
    /// <summary>
    /// 竞价项目状态变更通知
    /// </summary>
    public class ProjectStatus
    {
        private string _status;
        /// <summary>
        /// 状态
        /// </summary>
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _parm;
        /// <summary>
        /// 对于竞价结束，0表示竞拍失败，其他值表示成功，含义为竞拍成功的用户
        /// </summary>
        public string parm
        {
            get { return _parm; }
            set { _parm = value; }
        }
        
        
    }
}
