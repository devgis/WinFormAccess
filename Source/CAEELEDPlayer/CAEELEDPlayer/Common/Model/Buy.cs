using System;

namespace CAEELEDPlayer.Common.Model
{
    public class Buy
    {
        // ���۱��ID
        private long _id;

        public long id
        {
            get { return _id; }
            set { _id = value; }
        }

        // ���ۻ�Ա���
        //private long _userId;

        //public long userId
        //{
        //    get { return _userId; }
        //    set { _userId = value; }
        //}
        // ���ۻ�Ա�ʺ�
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

        // ��Ŀ���
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
        // ��Ŀ����
        //private String _projectName;

        //public String projectName
        //{
        //    get { return _projectName; }
        //    set { _projectName = value; }
        //}

        // ����ʱ��
        private String _buyTime;

        public String buyTime
        {
            get { return _buyTime; }
            set { _buyTime = value; }
        }

        // �۸�
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

        //// ���۷�ʽ
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

        //// ����ʱ��IP��ַ
        //private String _ip;

        //public String ip
        //{
        //    get { return _ip; }
        //    set { _ip = value; }
        //}

        //// ��ע
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
        /// �󶨵����
        /// </summary>
        public int SeqNumber
        {
            get { return _seqNumber; }
            set { _seqNumber = value; }
        }
    }
}
