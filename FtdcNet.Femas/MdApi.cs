/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/27 10:29:02
/////////////////////////////////////////////////////////////////////////



using System;
using System.Runtime.InteropServices;


namespace Femas
{
    /// <summary>
    /// 行情接口
    /// </summary>
    public class FtdcMdAdapter : IDisposable
    {
        /// <summary>
        /// Native Object Pointer
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        public event OnFrontEventHandler OnFrontEvent;

        /// <summary>
        /// 处理所有的OnPackage****回调事件
        /// </summary>
        public event OnPackageEventHandler OnPackageEvent;

        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        public event OnRspEventHandler OnRspEvent;

        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        public event OnRtnEventHandler OnRtnEvent;

        /// <summary>
        ///创建MduserApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        /// </summary>
        public FtdcMdAdapter(string pszFlowPath)
        {
            Handle = Interop.MdCreateApi(pszFlowPath);
            if (Handle == IntPtr.Zero)
                throw new Exception("MdCreateApi Failed!");
            this.CbOnFrontDelegate = this.CbOnFrontFunc;
            this.CbOnPackageDelegate = this.CbOnPackageFunc;
            this.CbOnRspDelegate = this.CbOnRspFunc;
            this.CbOnRtnDelegate = this.CbOnRtnFunc;
            Interop.MdRegisterCallback(Handle, this.CbOnFrontDelegate, this.CbOnPackageDelegate, this.CbOnRspDelegate, this.CbOnRtnDelegate, IntPtr.Zero);
        }


        /// <summary>
        ///获取系统版本号
        ///@param nMajorVersion 主版本号
        ///@param nMinorVersion 子版本号
        ///@return 系统标识字符串
        /// </summary>
        public static string GetVersion(ref int nMajorVersion, ref int nMinorVersion)
        {
            return Marshal.PtrToStringAnsi(Interop.MdGetVersion(ref nMajorVersion, ref nMinorVersion));
        }

        /// <summary>
        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        /// </summary>
        public void Release()
        {
            if (Handle != IntPtr.Zero)
            {
                Interop.MdDestroyApi(Handle);
                Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        /// </summary>
        public void Init()
        {
            Interop.MdInit(Handle);
        }

        /// <summary>
        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        /// </summary>
        public string GetTradingDay()
        {
            return Marshal.PtrToStringAnsi(Interop.MdGetTradingDay(Handle));
        }

        /// <summary>
        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        /// </summary>
        public void RegisterFront(string pszFrontAddress)
        {
            Interop.MdRegisterFront(Handle, pszFrontAddress);
        }

        /// <summary>
        ///注册名字服务器网络地址
        ///@param pszNsAddress：名字服务器网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:12001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”12001”代表服务器端口号。
        ///@remark RegisterFront优先于RegisterNameServer
        /// </summary>
        public void RegisterNameServer(string pszNsAddress)
        {
            Interop.MdRegisterNameServer(Handle, pszNsAddress);
        }

        /// <summary>
        ///加载证书
        ///@param pszCertFileName 用户证书文件名
        ///@param pszKeyFileName 用户私钥文件名
        ///@param pszCaFileName 可信任CA证书文件名
        ///@param pszKeyFilePassword 用户私钥文件密码
        ///@return 0 操作成功
        ///@return -1 可信任CA证书载入失败
        ///@return -2 用户证书载入失败
        ///@return -3 用户私钥载入失败
        ///@return -4 用户证书校验失败
        /// </summary>
        public int RegisterCertificateFile(string pszCertFileName, string pszKeyFileName, string pszCaFileName, string pszKeyFilePassword)
        {
            return Interop.MdRegisterCertificateFile(Handle, pszCertFileName, pszKeyFileName, pszCaFileName, pszKeyFilePassword);
        }

        /// <summary>
        ///订阅市场行情。
        ///@param nTopicID 市场行情主题
        ///@param nResumeType 市场行情重传方式
        ///        USTP_TERT_RESTART:从本交易日开始重传
        ///        USTP_TERT_RESUME:从上次收到的续传(非订阅全部合约时，不支持续传模式)
        ///        USTP_TERT_QUICK:先传送当前行情快照,再传送登录后市场行情的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        /// </summary>
        public void SubscribeMarketDataTopic(int nTopicID, EnumTeResumeType nResumeType)
        {
            Interop.MdSubscribeMarketDataTopic(Handle, nTopicID, (int)nResumeType);
        }

        /// <summary>
        ///订阅合约行情。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int SubscribeMarketData(string[] ppInstrumentID)
        {
            return Interop.MdSubMarketData(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///退订合约行情。
        ///@param ppInstrumentID 合约ID
        ///@param nCount 要订阅/退订行情的合约个数
        ///@remark
        /// </summary>
        public int UnSubscribeMarketData(string[] ppInstrumentID)
        {
            return Interop.MdUnSubMarketData(Handle, ppInstrumentID, ppInstrumentID.Length);
        }

        /// <summary>
        ///设置心跳超时时间。
        ///@param timeout 心跳超时时间(秒)
        /// </summary>
        public void SetHeartbeatTimeout(uint timeout)
        {
            Interop.MdSetHeartbeatTimeout(Handle, timeout);
        }

        /// <summary>
        ///风控前置系统用户登录请求
        /// </summary>
        public int ReqUserLogin(ThostFtdcReqUserLoginField pReqUserLogin, int nRequestID)
        {
            return Interop.MdReqUserLogin(Handle, pReqUserLogin, nRequestID);
        }

        /// <summary>
        ///用户退出请求
        /// </summary>
        public int ReqUserLogout(ThostFtdcReqUserLogoutField pReqUserLogout, int nRequestID)
        {
            return Interop.MdReqUserLogout(Handle, pReqUserLogout, nRequestID);
        }

        /// <summary>
        ///订阅主题请求
        /// </summary>
        public int ReqSubscribeTopic(ThostFtdcDisseminationField pDissemination, int nRequestID)
        {
            return Interop.MdReqSubscribeTopic(Handle, pDissemination, nRequestID);
        }

        /// <summary>
        ///主题查询请求
        /// </summary>
        public int ReqQryTopic(ThostFtdcDisseminationField pDissemination, int nRequestID)
        {
            return Interop.MdReqQryTopic(Handle, pDissemination, nRequestID);
        }

        /// <summary>
        ///订阅合约的相关信息
        /// </summary>
        public int ReqSubMarketData(ThostFtdcSpecificInstrumentField pSpecificInstrument, int nRequestID)
        {
            return Interop.MdReqSubMarketData(Handle, pSpecificInstrument, nRequestID);
        }

        /// <summary>
        ///退订合约的相关信息
        /// </summary>
        public int ReqUnSubMarketData(ThostFtdcSpecificInstrumentField pSpecificInstrument, int nRequestID)
        {
            return Interop.MdReqUnSubMarketData(Handle, pSpecificInstrument, nRequestID);
        }

        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        protected void CbOnFrontFunc(IntPtr pObject, EnumOnFrontType type, int nReason)
        {
            if (OnFrontEvent != null)
                OnFrontEvent(this, new OnFrontEventArgs(type, nReason));
        }
        private Interop.CbOnFrontEvent CbOnFrontDelegate;


        /// <summary>
        /// 处理所有的OnPackage****回调事件
        /// </summary>
        protected void CbOnPackageFunc(IntPtr pObject, EnumOnPackageType type, int nTopicID, int nSequenceNo)
        {
            if (OnPackageEvent != null)
                OnPackageEvent(this, new OnPackageEventArgs(type, nTopicID, nSequenceNo));
        }
        private Interop.CbOnPackageEvent CbOnPackageDelegate;


        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        protected void CbOnRspFunc(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast)
        {
            if (OnRspEvent != null)
                OnRspEvent(this, new OnRspEventArgs(type, pParam, pRspInfo, nRequestID, bIsLast));
        }
        private Interop.CbOnRspEvent CbOnRspDelegate;


        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        protected void CbOnRtnFunc(IntPtr pObject, EnumOnRtnType type, IntPtr pParam)
        {
            if (OnRtnEvent != null)
                OnRtnEvent(this, new OnRtnEventArgs(type, pParam));
        }
        private Interop.CbOnRtnEvent CbOnRtnDelegate;



        public void Dispose()
        {
            this.Release();
        }

    }; // end of class

}; // end of namespace

