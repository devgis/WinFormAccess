using System;

namespace CAEELEDPlayer.Common.Model
{
    /// <summary>
    /// 修改项目基本信息的字段值
    /// </summary>
    public class ProjectFiled
    {
        private string _endTime;
        /// <summary>
        /// 竞拍结束时间
        /// </summary>
        public string endTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
    }
}
