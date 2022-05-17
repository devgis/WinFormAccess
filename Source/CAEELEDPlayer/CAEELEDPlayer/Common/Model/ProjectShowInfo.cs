using System;

namespace CAEELEDPlayer.Common.Model
{
    public class ProjectShowInfo
    {
        // ��ĿΨһID
        //private String _id;

        //public String id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        // ��ĿΨһ���
        private String _code;

        public String code
        {
            get { return _code; }
            set { _code = value; }
        }

        // ��Ŀ����
        private String _projectName;

        public String projectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        // ������
        private String _area;

        public String area
        {
            get { return _area; }
            set { _area = value; }
        }

        // ��Ȩ����
        private String _property;

        public String property
        {
            get { return _property; }
            set { _property = value; }
        }

        // ���Ƽ۸�
        private String _releasePrice;

        public String releasePrice
        {
            get { return _releasePrice; }
            set { _releasePrice = value; }
        }

        // ���Ʊ���
        private String _releaseRatio;

        public String releaseRatio
        {
            get { return _releaseRatio; }
            set { _releaseRatio = value; }
        }

        // ������ʼ����
        private String _startTime;

        public String startTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        // ���ƽ�������
        private String _endTime;

        public String endTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        // ��Ŀ״̬
        //private String _status;

        //public String status
        //{
        //    get { return _status; }
        //    set { _status = value; }
        //}

        // �Ƿ���Ҫ���ɱ�֤��
        //private String _captureFlag;

        //public String captureFlag
        //{
        //    get { return _captureFlag; }
        //    set { _captureFlag = value; }
        //}

        // ��֤����
        //private String _captureBalance;

        //public String captureBalance
        //{
        //    get { return _captureBalance; }
        //    set { _captureBalance = value; }
        //}

        // ���±�ʶ�����ڱ�ʶ����������0��������1�����¡�2��ɾ��
        //private String _flag;

        //public String flag
        //{
        //    get { return _flag; }
        //    set { _flag = value; }
        //}

        // // �״λ�ȡ���ݱ�ʶ��0���ǡ�1�����״λ�ȡ����ʱ������������ݣ�����ֻ��ñ������������
        // private String firstFlag;

        // ����
        //private long _synchroId;

        //public long synchroId
        //{
        //    get { return _synchroId; }
        //    set { _synchroId = value; }
        //}

        // ͬ��ʱ��
        //private String _synchroTime;

        //public String synchroTime
        //{
        //    get { return _synchroTime; }
        //    set { _synchroTime = value; }
        //}

        // ͬ����ʽ
        //private String _synchroType;

        //public String synchroType
        //{
        //    get { return _synchroType; }
        //    set { _synchroType = value; }
        //}

        // ͬ��ip
        //private String _ip;

        //public String ip
        //{
        //    get { return _ip; }
        //    set { _ip = value; }
        //}

        // ͬ����־
        //private String _isNew;

        //public String isNew
        //{
        //    get { return _isNew; }
        //    set { _isNew = value; }
        //}

        // ���ۿ�ʼʱ��
        private String _buyStartTime;

        public String buyStartTime
        {
            get { return _buyStartTime; }
            set { _buyStartTime = value; }
        }

        // ���۽���ʱ��
        private String _buyEndTime;

        public String buyEndTime
        {
            get { return _buyEndTime; }
            set { _buyEndTime = value; }
        }

        // �׼�
        private String _basePrice;

        public String basePrice
        {
            get { return _basePrice; }
            set { _basePrice = value; }
        }

        // ���۽���
        private String _priceStep;

        public String priceStep
        {
            get { return _priceStep; }
            set { _priceStep = value; }
        }

        private string _projectInfo;
        /// <summary>
        /// ��Ŀ��Ϣ����
        /// </summary>
        public string projectInfo
        {
            get { return _projectInfo; }
            set { _projectInfo = value; }
        }

        private string _serverTime;
        /// <summary>
        /// ����˵�ǰʱ�䣬��ʽ��YYYYMMDDHHMISS
        /// </summary>
        public string serverTime
        {
            get { return _serverTime; }
            set { _serverTime = value; }
        }

        private string _modeKey;
        /// <summary>
        /// ����ģʽ
        /// </summary>
        public string modeKey
        {
            get { return _modeKey; }
            set { _modeKey = value; }
        }

        private string _reserveBasePrice;
        /// <summary>
        /// �����׼�
        /// </summary>
        public string reserveBasePrice
        {
            get { return _reserveBasePrice; }
            set { _reserveBasePrice = value; }
        }

    }
}