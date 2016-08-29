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
    /// 交易接口
    /// </summary>
    public class FtdcTdAdapter : IDisposable
    {
        /// <summary>
        /// Native Object Pointer
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        public event OnErrRtnEventHandler OnErrRtnEvent;

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
        ///创建TraderApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        /// </summary>
        public FtdcTdAdapter(string pszFlowPath)
        {
            Handle = Interop.TdCreateApi(pszFlowPath);
            if (Handle == IntPtr.Zero)
                throw new Exception("TdCreateApi Failed!");
            this.CbOnErrRtnDelegate = this.CbOnErrRtnFunc;
            this.CbOnFrontDelegate = this.CbOnFrontFunc;
            this.CbOnPackageDelegate = this.CbOnPackageFunc;
            this.CbOnRspDelegate = this.CbOnRspFunc;
            this.CbOnRtnDelegate = this.CbOnRtnFunc;
            Interop.TdRegisterCallback(Handle, this.CbOnErrRtnDelegate, this.CbOnFrontDelegate, this.CbOnPackageDelegate, this.CbOnRspDelegate, this.CbOnRtnDelegate, IntPtr.Zero);
        }


        /// <summary>
        ///获取系统版本号
        ///@param nMajorVersion 主版本号
        ///@param nMinorVersion 子版本号
        ///@return 系统标识字符串
        /// </summary>
        public static string GetVersion(ref int nMajorVersion, ref int nMinorVersion)
        {
            return Marshal.PtrToStringAnsi(Interop.TdGetVersion(ref nMajorVersion, ref nMinorVersion));
        }

        /// <summary>
        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        /// </summary>
        public void Release()
        {
            if (Handle != IntPtr.Zero)
            {
                Interop.TdDestroyApi(Handle);
                Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        /// </summary>
        public void Init()
        {
            Interop.TdInit(Handle);
        }

        /// <summary>
        ///获取当前交易日
        ///@retrun 获取到的交易日
        ///@remark 只有登录成功后,才能得到正确的交易日
        /// </summary>
        public string GetTradingDay()
        {
            return Marshal.PtrToStringAnsi(Interop.TdGetTradingDay(Handle));
        }

        /// <summary>
        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        /// </summary>
        public void RegisterFront(string pszFrontAddress)
        {
            Interop.TdRegisterFront(Handle, pszFrontAddress);
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
            Interop.TdRegisterNameServer(Handle, pszNsAddress);
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
            return Interop.TdRegisterCertificateFile(Handle, pszCertFileName, pszKeyFileName, pszCaFileName, pszKeyFilePassword);
        }

        /// <summary>
        ///订阅私有流。
        ///@param nResumeType 私有流重传方式
        ///        USTP_TERT_RESTART:从本交易日开始重传
        ///        USTP_TERT_RESUME:从上次收到的续传
        ///        USTP_TERT_QUICK:只传送登录后私有流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        /// </summary>
        public void SubscribePrivateTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePrivateTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///订阅公共流。
        ///@param nResumeType 公共流重传方式
        ///        USTP_TERT_RESTART:从本交易日开始重传
        ///        USTP_TERT_RESUME:从上次收到的续传
        ///        USTP_TERT_QUICK:只传送登录后公共流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
        /// </summary>
        public void SubscribePublicTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePublicTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///订阅交易员流。
        ///@param nResumeType 交易员流重传方式
        ///        USTP_TERT_RESTART:从本交易日开始重传
        ///        USTP_TERT_RESUME:从上次收到的续传
        ///        USTP_TERT_QUICK:只传送登录后交易员流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到交易员流的数据。
        /// </summary>
        public void SubscribeUserTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribeUserTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///订阅询价流。
        ///@param nResumeType 交易员流重传方式
        ///        USTP_TERT_RESTART:从本交易日开始重传
        ///        USTP_TERT_RESUME:从上次收到的续传
        ///        USTP_TERT_QUICK:只传送登录后交易员流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到交易员流的数据。
        /// </summary>
        public void SubscribeForQuote(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribeForQuote(Handle, (int)nResumeType);
        }

        /// <summary>
        ///设置心跳超时时间。
        ///@param timeout 心跳超时时间(秒)
        /// </summary>
        public void SetHeartbeatTimeout(uint timeout)
        {
            Interop.TdSetHeartbeatTimeout(Handle, timeout);
        }

        /// <summary>
        ///打开请求日志文件
        ///@param pszReqLogFileName 请求日志文件名
        ///@return 0 操作成功
        ///@return -1 打开日志文件失败
        /// </summary>
        public int OpenRequestLog(string pszReqLogFileName)
        {
            return Interop.TdOpenRequestLog(Handle, pszReqLogFileName);
        }

        /// <summary>
        ///打开应答日志文件
        ///@param pszRspLogFileName 应答日志文件名
        ///@return 0 操作成功
        ///@return -1 打开日志文件失败
        /// </summary>
        public int OpenResponseLog(string pszRspLogFileName)
        {
            return Interop.TdOpenResponseLog(Handle, pszRspLogFileName);
        }

        /// <summary>
        ///风控前置系统用户登录请求
        /// </summary>
        public int ReqUserLogin(ThostFtdcReqUserLoginField pReqUserLogin, int nRequestID)
        {
            return Interop.TdReqUserLogin(Handle, pReqUserLogin, nRequestID);
        }

        /// <summary>
        ///用户退出请求
        /// </summary>
        public int ReqUserLogout(ThostFtdcReqUserLogoutField pReqUserLogout, int nRequestID)
        {
            return Interop.TdReqUserLogout(Handle, pReqUserLogout, nRequestID);
        }

        /// <summary>
        ///用户密码修改请求
        /// </summary>
        public int ReqUserPasswordUpdate(ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
            return Interop.TdReqUserPasswordUpdate(Handle, pUserPasswordUpdate, nRequestID);
        }

        /// <summary>
        ///报单录入请求
        /// </summary>
        public int ReqOrderInsert(ThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
            return Interop.TdReqOrderInsert(Handle, pInputOrder, nRequestID);
        }

        /// <summary>
        ///报单操作请求
        /// </summary>
        public int ReqOrderAction(ThostFtdcOrderActionField pOrderAction, int nRequestID)
        {
            return Interop.TdReqOrderAction(Handle, pOrderAction, nRequestID);
        }

        /// <summary>
        ///请求报价录入
        /// </summary>
        public int ReqQuoteInsert(ThostFtdcInputQuoteField pInputQuote, int nRequestID)
        {
            return Interop.TdReqQuoteInsert(Handle, pInputQuote, nRequestID);
        }

        /// <summary>
        ///报价操作请求
        /// </summary>
        public int ReqQuoteAction(ThostFtdcQuoteActionField pQuoteAction, int nRequestID)
        {
            return Interop.TdReqQuoteAction(Handle, pQuoteAction, nRequestID);
        }

        /// <summary>
        ///客户询价请求
        /// </summary>
        public int ReqForQuote(ThostFtdcReqForQuoteField pReqForQuote, int nRequestID)
        {
            return Interop.TdReqForQuote(Handle, pReqForQuote, nRequestID);
        }

        /// <summary>
        ///客户申请组合请求
        /// </summary>
        public int ReqMarginCombAction(ThostFtdcInputMarginCombActionField pInputMarginCombAction, int nRequestID)
        {
            return Interop.TdReqMarginCombAction(Handle, pInputMarginCombAction, nRequestID);
        }

        /// <summary>
        ///用户请求出入金
        /// </summary>
        public int ReqUserDeposit(ThostFtdcstpUserDepositField pstpUserDeposit, int nRequestID)
        {
            return Interop.TdReqUserDeposit(Handle, pstpUserDeposit, nRequestID);
        }

        /// <summary>
        ///用户主次席出入金
        /// </summary>
        public int ReqTransferMoney(ThostFtdcstpTransferMoneyField pstpTransferMoney, int nRequestID)
        {
            return Interop.TdReqTransferMoney(Handle, pstpTransferMoney, nRequestID);
        }

        /// <summary>
        ///报单查询请求
        /// </summary>
        public int ReqQryOrder(ThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
            return Interop.TdReqQryOrder(Handle, pQryOrder, nRequestID);
        }

        /// <summary>
        ///成交单查询请求
        /// </summary>
        public int ReqQryTrade(ThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
            return Interop.TdReqQryTrade(Handle, pQryTrade, nRequestID);
        }

        /// <summary>
        ///可用投资者账户查询请求
        /// </summary>
        public int ReqQryUserInvestor(ThostFtdcQryUserInvestorField pQryUserInvestor, int nRequestID)
        {
            return Interop.TdReqQryUserInvestor(Handle, pQryUserInvestor, nRequestID);
        }

        /// <summary>
        ///交易编码查询请求
        /// </summary>
        public int ReqQryTradingCode(ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
            return Interop.TdReqQryTradingCode(Handle, pQryTradingCode, nRequestID);
        }

        /// <summary>
        ///投资者资金账户查询请求
        /// </summary>
        public int ReqQryInvestorAccount(ThostFtdcQryInvestorAccountField pQryInvestorAccount, int nRequestID)
        {
            return Interop.TdReqQryInvestorAccount(Handle, pQryInvestorAccount, nRequestID);
        }

        /// <summary>
        ///合约查询请求
        /// </summary>
        public int ReqQryInstrument(ThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
            return Interop.TdReqQryInstrument(Handle, pQryInstrument, nRequestID);
        }

        /// <summary>
        ///交易所查询请求
        /// </summary>
        public int ReqQryExchange(ThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
            return Interop.TdReqQryExchange(Handle, pQryExchange, nRequestID);
        }

        /// <summary>
        ///投资者持仓查询请求
        /// </summary>
        public int ReqQryInvestorPosition(ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorPosition(Handle, pQryInvestorPosition, nRequestID);
        }

        /// <summary>
        ///订阅主题请求
        /// </summary>
        public int ReqSubscribeTopic(ThostFtdcDisseminationField pDissemination, int nRequestID)
        {
            return Interop.TdReqSubscribeTopic(Handle, pDissemination, nRequestID);
        }

        /// <summary>
        ///合规参数查询请求
        /// </summary>
        public int ReqQryComplianceParam(ThostFtdcQryComplianceParamField pQryComplianceParam, int nRequestID)
        {
            return Interop.TdReqQryComplianceParam(Handle, pQryComplianceParam, nRequestID);
        }

        /// <summary>
        ///主题查询请求
        /// </summary>
        public int ReqQryTopic(ThostFtdcDisseminationField pDissemination, int nRequestID)
        {
            return Interop.TdReqQryTopic(Handle, pDissemination, nRequestID);
        }

        /// <summary>
        ///投资者手续费率查询请求
        /// </summary>
        public int ReqQryInvestorFee(ThostFtdcQryInvestorFeeField pQryInvestorFee, int nRequestID)
        {
            return Interop.TdReqQryInvestorFee(Handle, pQryInvestorFee, nRequestID);
        }

        /// <summary>
        ///投资者保证金率查询请求
        /// </summary>
        public int ReqQryInvestorMargin(ThostFtdcQryInvestorMarginField pQryInvestorMargin, int nRequestID)
        {
            return Interop.TdReqQryInvestorMargin(Handle, pQryInvestorMargin, nRequestID);
        }

        /// <summary>
        ///交易编码组合持仓查询请求
        /// </summary>
        public int ReqQryInvestorCombPosition(ThostFtdcQryInvestorCombPositionField pQryInvestorCombPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorCombPosition(Handle, pQryInvestorCombPosition, nRequestID);
        }

        /// <summary>
        ///交易编码单腿持仓查询请求
        /// </summary>
        public int ReqQryInvestorLegPosition(ThostFtdcQryInvestorLegPositionField pQryInvestorLegPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorLegPosition(Handle, pQryInvestorLegPosition, nRequestID);
        }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        protected void CbOnErrRtnFunc(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo)
        {
            if (OnErrRtnEvent != null)
                OnErrRtnEvent(this, new OnErrRtnEventArgs(type, pParam, pRspInfo));
        }
        private Interop.CbOnErrRtnEvent CbOnErrRtnDelegate;


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

