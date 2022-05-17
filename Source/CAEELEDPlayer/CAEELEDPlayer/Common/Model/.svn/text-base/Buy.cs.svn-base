using System;

namespace CAEELEDPlayer.Common.Model
{
    public class Buy
    {
        // 竞价编号ID
        private long _id;

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }

        // 竞价会员编号
        //private long _userId;

        //public long userId
        //{
        //    get { return _userId; }
        //    set { _userId = value; }
        //}
        // 竞价会员帐号
        //private String _account;

        //public String account
        //{
        //    get { return _account; }
        //    set { _account = value; }
        //}
        private String _userName;

        public String userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        // 项目编号
        //private long _projectId;

        //public long projectId
        //{
        //    get { return _projectId; }
        //    set { _projectId = value; }
        //}
        //private String _projectCode;

        //public String projectCode
        //{
        //    get { return _projectCode; }
        //    set { _projectCode = value; }
        //}
        // 项目名称
        //private String _projectName;

        //public String projectName
        //{
        //    get { return _projectName; }
        //    set { _projectName = value; }
        //}

        // 竞价时间
        private String _buyTime;

        public String buyTime
        {
            get { return _buyTime; }
            set { _buyTime = value; }
        }

        // 价格
        private String _buyPrice;

        public String buyPrice
        {
            get { return _buyPrice; }
            set { _buyPrice = value; }
        }
        //private String _buyPriceInfo;

        //public String buyPriceInfo
        //{
        //    get { return _buyPriceInfo; }
        //    set { _buyPriceInfo = value; }
        //}
        //private String _finalBuyPriceInfo;

        //public String finalBuyPriceInfo
        //{
        //    get { return _finalBuyPriceInfo; }
        //    set { _finalBuyPriceInfo = value; }
        //}

        //// 竞价方式
        //private String _buyType;

        //public String buyType
        //{
        //    get { return _buyType; }
        //    set { _buyType = value; }
        //}
        //private String _buyTypeInfo;

        //public String buyTypeInfo
        //{
        //    get { return _buyTypeInfo; }
        //    set { _buyTypeInfo = value; }
        //}

        //// 竞价时的IP地址
        //private String _ip;

        //public String ip
        //{
        //    get { return _ip; }
        //    set { _ip = value; }
        //}

        //// 备注
        //private String _remark;

        //public String remark
        //{
        //    get { return _remark; }
        //    set { _remark = value; }
        //}

        //private String _isOver;
        
        //public String isOver
        //{
        //    get{ return _isOver; }
        //    set{ _isOver = value; }
        //}
        
    }

    public class BuyInfo:Buy
    {
        public BuyInfo(int iSeqNo, Buy buy)
        {
            this._seqNumber = iSeqNo;
            base.id = buy.id;
            base.userName = buy.userName;
            base.buyPrice = buy.buyPrice;
            base.buyTime = buy.buyTime;
        }

        private int _seqNumber;
        /// <summary>
        /// 绑定的序号
        /// </summary>
        public int SeqNumber
        {
            get { return _seqNumber; }
            set { _seqNumber = value; }
        }
    }
}
