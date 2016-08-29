/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/27 10:29:02
/////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Femas
{
    [System.Security.SuppressUnmanagedCodeSecurity]
    static unsafe class Interop
    {
        static Interop()
        {
            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dir = Path.Combine(assemblyDirectory, Environment.Is64BitProcess ? "x64" : "x86");
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                // Can't work, since LD_LIBRARY_PATH will not reload 
                Environment.SetEnvironmentVariable("LD_LIBRARY_PATH", dir + ":" + Environment.GetEnvironmentVariable("LD_LIBRARY_PATH"));
            else
                Environment.SetEnvironmentVariable("PATH", dir + ";" + Environment.GetEnvironmentVariable("PATH"));
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnErrRtnEvent(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnFrontEvent(IntPtr pObject, EnumOnFrontType type, int nReason);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnPackageEvent(IntPtr pObject, EnumOnPackageType type, int nTopicID, int nSequenceNo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRspEvent(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRtnEvent(IntPtr pObject, EnumOnRtnType type, IntPtr pParam);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterCallback(IntPtr pApi, CbOnFrontEvent c1, CbOnPackageEvent c2, CbOnRspEvent c3, CbOnRtnEvent c4, IntPtr pObject);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterCallback(IntPtr pApi, CbOnErrRtnEvent c1, CbOnFrontEvent c2, CbOnPackageEvent c3, CbOnRspEvent c4, CbOnRtnEvent c5, IntPtr pObject);


        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdCreateApi(string pszFlowPath);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdGetVersion(ref int nMajorVersion, ref int nMinorVersion);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdInit(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdGetTradingDay(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterNameServer(IntPtr pApi, string pszNsAddress);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdRegisterCertificateFile(IntPtr pApi, string pszCertFileName, string pszKeyFileName, string pszCaFileName, string pszKeyFilePassword);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdSubscribeMarketDataTopic(IntPtr pApi, int nTopicID, int nResumeType);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdSubMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdUnSubMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdSetHeartbeatTimeout(IntPtr pApi, uint timeout);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLogin, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogout(IntPtr pApi, ThostFtdcReqUserLogoutField pReqUserLogout, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqSubscribeTopic(IntPtr pApi, ThostFtdcDisseminationField pDissemination, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqQryTopic(IntPtr pApi, ThostFtdcDisseminationField pDissemination, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqSubMarketData(IntPtr pApi, ThostFtdcSpecificInstrumentField pSpecificInstrument, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUnSubMarketData(IntPtr pApi, ThostFtdcSpecificInstrumentField pSpecificInstrument, int nRequestID);



        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdCreateApi(string pszFlowPath);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdGetVersion(ref int nMajorVersion, ref int nMinorVersion);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdInit(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdGetTradingDay(IntPtr pApi);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterNameServer(IntPtr pApi, string pszNsAddress);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdRegisterCertificateFile(IntPtr pApi, string pszCertFileName, string pszKeyFileName, string pszCaFileName, string pszKeyFilePassword);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePrivateTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePublicTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribeUserTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribeForQuote(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSetHeartbeatTimeout(IntPtr pApi, uint timeout);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdOpenRequestLog(IntPtr pApi, string pszReqLogFileName);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdOpenResponseLog(IntPtr pApi, string pszRspLogFileName);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLogin, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogout(IntPtr pApi, ThostFtdcReqUserLogoutField pReqUserLogout, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserPasswordUpdate(IntPtr pApi, ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderInsert(IntPtr pApi, ThostFtdcInputOrderField pInputOrder, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderAction(IntPtr pApi, ThostFtdcOrderActionField pOrderAction, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQuoteInsert(IntPtr pApi, ThostFtdcInputQuoteField pInputQuote, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQuoteAction(IntPtr pApi, ThostFtdcQuoteActionField pQuoteAction, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqForQuote(IntPtr pApi, ThostFtdcReqForQuoteField pReqForQuote, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqMarginCombAction(IntPtr pApi, ThostFtdcInputMarginCombActionField pInputMarginCombAction, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserDeposit(IntPtr pApi, ThostFtdcstpUserDepositField pstpUserDeposit, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqTransferMoney(IntPtr pApi, ThostFtdcstpTransferMoneyField pstpTransferMoney, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOrder(IntPtr pApi, ThostFtdcQryOrderField pQryOrder, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTrade(IntPtr pApi, ThostFtdcQryTradeField pQryTrade, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryUserInvestor(IntPtr pApi, ThostFtdcQryUserInvestorField pQryUserInvestor, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingCode(IntPtr pApi, ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorAccount(IntPtr pApi, ThostFtdcQryInvestorAccountField pQryInvestorAccount, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrument(IntPtr pApi, ThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchange(IntPtr pApi, ThostFtdcQryExchangeField pQryExchange, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPosition(IntPtr pApi, ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqSubscribeTopic(IntPtr pApi, ThostFtdcDisseminationField pDissemination, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryComplianceParam(IntPtr pApi, ThostFtdcQryComplianceParamField pQryComplianceParam, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTopic(IntPtr pApi, ThostFtdcDisseminationField pDissemination, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorFee(IntPtr pApi, ThostFtdcQryInvestorFeeField pQryInvestorFee, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorMargin(IntPtr pApi, ThostFtdcQryInvestorMarginField pQryInvestorMargin, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorCombPosition(IntPtr pApi, ThostFtdcQryInvestorCombPositionField pQryInvestorCombPosition, int nRequestID);

        [DllImport("ftdc2c_femas", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorLegPosition(IntPtr pApi, ThostFtdcQryInvestorLegPositionField pQryInvestorLegPosition, int nRequestID);


    }
}

