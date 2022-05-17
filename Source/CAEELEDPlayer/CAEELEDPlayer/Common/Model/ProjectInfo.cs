using System;
using System.Collections.Generic;
using System.Text;

namespace CAEELEDPlayer.Common.Model
{
    public class ProjectInfo
    {
        // 项目唯一ID
        //private String _id;

        //public String id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        // 项目唯一编号
        private String _code;

        public String code
        {
            get { return _code; }
            set { _code = value; }
        }

        // 项目名称
        private String _projectName;

        public String projectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        // 归属地
        private String _area;

        public String area
        {
            get { return _area; }
            set { _area = value; }
        }

        // 产权类型
        private String _property;

        public String property
        {
            get { return _property; }
            set { _property = value; }
        }
        //private String _propertyInfo;

        //public String propertyInfo
        //{
        //    get { return _propertyInfo; }
        //    set { _propertyInfo = value; }
        //}

        // 挂牌价格
        private String _releasePrice;

        public String releasePrice
        {
            get { return _releasePrice; }
            set { _releasePrice = value; }
        }

        // 挂牌比例
        private String _releaseRatio;

        public String releaseRatio
        {
            get { return _releaseRatio; }
            set { _releaseRatio = value; }
        }

        // 挂牌起始日期
        private String _startTime;

        public String startTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        // 挂牌结束日期
        private String _endTime;

        public String endTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        // 交易状态
        private String _status;

        public String status
        {
            get { return _status; }
            set { _status = value; }
        }
        //private String _statusInfo;

        //public String statusInfo
        //{
        //    get { return _statusInfo; }
        //    set { _statusInfo = value; }
        //}

        // 是否需要缴纳保证金
        //private String _captureFlag;

        //public String captureFlag
        //{
        //    get { return _captureFlag; }
        //    set { _captureFlag = value; }
        //}

        // 保证金金额
        private String _captureBalance;

        public String captureBalance
        {
            get { return _captureBalance; }
            set { _captureBalance = value; }
        }

        // 更新标识，用于标识该条数据是0：新增、1：更新、2：删除
        //private String _flag;

        //public String flag
        //{
        //    get { return _flag; }
        //    set { _flag = value; }
        //}
        //private String _flagInfo;

        //public String flagInfo
        //{
        //    get { return _flagInfo; }
        //    set { _flagInfo = value; }
        //}

        //// 首次获取数据标识，0：是、1：否，首次获取数据时将获得完整数据，否则将只获得变更或增量数据
        //private String _firstFlag;

        //public String firstFlag
        //{
        //    get { return _firstFlag; }
        //    set { _firstFlag = value; }
        //}

        //// 序列
        //private long _synchroId;

        //public long synchroId
        //{
        //    get { return _synchroId; }
        //    set { _synchroId = value; }
        //}
        //// 同步时间
        //private String _synchroTime;

        //public String synchroTime
        //{
        //    get { return _synchroTime; }
        //    set { _synchroTime = value; }
        //}
        //// 同步方式
        //private String _synchroType;

        //public String synchroType
        //{
        //    get { return _synchroType; }
        //    set { _synchroType = value; }
        //}
        //// 同步ip
        //private String _ip;

        //public String ip
        //{
        //    get { return _ip; }
        //    set { _ip = value; }
        //}

        //// 同步标志
        //private String _isNew;

        //public String isNew
        //{
        //    get { return _isNew; }
        //    set { _isNew = value; }
        //}

        //// 竞价开始时间
        //private String _buyStartTime;

        //public String buyStartTime
        //{
        //    get { return _buyStartTime; }
        //    set { _buyStartTime = value; }
        //}

        //// 竞价结束时间
        //private String _buyEndTime;

        //public String buyEndTime
        //{
        //    get { return _buyEndTime; }
        //    set { _buyEndTime = value; }
        //}

        //// 底价
        //private String _basePrice;

        //public String basePrice
        //{
        //    get { return _basePrice; }
        //    set { _basePrice = value; }
        //}

        //// 竞价阶梯
        //private String _priceStep;

        //public String priceStep
        //{
        //    get { return _priceStep; }
        //    set { _priceStep = value; }
        //}

    }
}
