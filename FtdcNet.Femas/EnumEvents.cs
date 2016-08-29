/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/27 10:29:02
/////////////////////////////////////////////////////////////////////////

using System;

namespace Femas
{

    // 注意，注意：所有索引值必须与c语言enums.h中的值一一对应，否则回调将会错乱

    /// <summary>
    /// 所有的OnErrRtnXXXX回调事件
    /// </summary>
    public enum EnumOnErrRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///报单录入错误回报, ThostFtdcInputOrderField
        /// </summary>
        OnErrRtnOrderInsert,
        /// <summary>
        ///报单操作错误回报, ThostFtdcOrderActionField
        /// </summary>
        OnErrRtnOrderAction,
        /// <summary>
        ///报价录入错误回报, ThostFtdcInputQuoteField
        /// </summary>
        OnErrRtnQuoteInsert,
        /// <summary>
        ///报价撤单错误回报, ThostFtdcOrderActionField
        /// </summary>
        OnErrRtnQuoteAction,
    };

    /// <summary>
    /// 所有的OnFrontXXXX回调事件
    /// </summary>
    public enum EnumOnFrontType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
        /// </summary>
        OnFrontConnected,
        /// <summary>
        ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
        ///@param nReason 错误原因
        ///        0x1001 网络读失败
        ///        0x1002 网络写失败
        ///        0x2001 接收心跳超时
        ///        0x2002 发送心跳失败
        ///        0x2003 收到错误报文, int
        /// </summary>
        OnFrontDisconnected,
    };

    /// <summary>
    /// 所有的OnPackageXXXX回调事件
    /// </summary>
    public enum EnumOnPackageType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///报文回调开始通知。当API收到一个报文后，首先调用本方法，然后是各数据域的回调，最后是报文回调结束通知。
        ///@param nTopicID 主题代码（如私有流、公共流、行情流等）
        ///@param nSequenceNo 报文序号, int
        /// </summary>
        OnPackageStart,
        /// <summary>
        ///报文回调结束通知。当API收到一个报文后，首先调用报文回调开始通知，然后是各数据域的回调，最后调用本方法。
        ///@param nTopicID 主题代码（如私有流、公共流、行情流等）
        ///@param nSequenceNo 报文序号, int
        /// </summary>
        OnPackageEnd,
    };

    /// <summary>
    /// 所有的OnRspXXXX回调事件
    /// </summary>
    public enum EnumOnRspType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///错误应答, ThostFtdcRspInfoField
        /// </summary>
        OnRspError,
        /// <summary>
        ///风控前置系统用户登录应答, ThostFtdcRspUserLoginField
        /// </summary>
        OnRspUserLogin,
        /// <summary>
        ///用户退出应答, ThostFtdcRspUserLogoutField
        /// </summary>
        OnRspUserLogout,
        /// <summary>
        ///订阅主题应答, ThostFtdcDisseminationField
        /// </summary>
        OnRspSubscribeTopic,
        /// <summary>
        ///主题查询应答, ThostFtdcDisseminationField
        /// </summary>
        OnRspQryTopic,
        /// <summary>
        ///订阅合约的相关信息, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspSubMarketData,
        /// <summary>
        ///退订合约的相关信息, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspUnSubMarketData,
        /// <summary>
        ///用户密码修改应答, ThostFtdcUserPasswordUpdateField
        /// </summary>
        OnRspUserPasswordUpdate,
        /// <summary>
        ///报单录入应答, ThostFtdcInputOrderField
        /// </summary>
        OnRspOrderInsert,
        /// <summary>
        ///报单操作应答, ThostFtdcOrderActionField
        /// </summary>
        OnRspOrderAction,
        /// <summary>
        ///报价录入应答, ThostFtdcInputQuoteField
        /// </summary>
        OnRspQuoteInsert,
        /// <summary>
        ///报价操作应答, ThostFtdcQuoteActionField
        /// </summary>
        OnRspQuoteAction,
        /// <summary>
        ///询价请求应答, ThostFtdcReqForQuoteField
        /// </summary>
        OnRspForQuote,
        /// <summary>
        ///客户申请组合应答, ThostFtdcInputMarginCombActionField
        /// </summary>
        OnRspMarginCombAction,
        /// <summary>
        ///用户请求出入金应答, ThostFtdcstpUserDepositField
        /// </summary>
        OnRspUserDeposit,
        /// <summary>
        ///用户主次席出入金应答, ThostFtdcstpTransferMoneyField
        /// </summary>
        OnRspTransferMoney,
        /// <summary>
        ///报单查询应答, ThostFtdcOrderField
        /// </summary>
        OnRspQryOrder,
        /// <summary>
        ///成交单查询应答, ThostFtdcTradeField
        /// </summary>
        OnRspQryTrade,
        /// <summary>
        ///可用投资者账户查询应答, ThostFtdcRspUserInvestorField
        /// </summary>
        OnRspQryUserInvestor,
        /// <summary>
        ///交易编码查询应答, ThostFtdcRspTradingCodeField
        /// </summary>
        OnRspQryTradingCode,
        /// <summary>
        ///投资者资金账户查询应答, ThostFtdcRspInvestorAccountField
        /// </summary>
        OnRspQryInvestorAccount,
        /// <summary>
        ///合约查询应答, ThostFtdcRspInstrumentField
        /// </summary>
        OnRspQryInstrument,
        /// <summary>
        ///交易所查询应答, ThostFtdcRspExchangeField
        /// </summary>
        OnRspQryExchange,
        /// <summary>
        ///投资者持仓查询应答, ThostFtdcRspInvestorPositionField
        /// </summary>
        OnRspQryInvestorPosition,
        /// <summary>
        ///合规参数查询应答, ThostFtdcRspComplianceParamField
        /// </summary>
        OnRspQryComplianceParam,
        /// <summary>
        ///投资者手续费率查询应答, ThostFtdcInvestorFeeField
        /// </summary>
        OnRspQryInvestorFee,
        /// <summary>
        ///投资者保证金率查询应答, ThostFtdcInvestorMarginField
        /// </summary>
        OnRspQryInvestorMargin,
        /// <summary>
        ///交易编码组合持仓查询应答, ThostFtdcRspInvestorCombPositionField
        /// </summary>
        OnRspQryInvestorCombPosition,
        /// <summary>
        ///交易编码单腿持仓查询应答, ThostFtdcRspInvestorLegPositionField
        /// </summary>
        OnRspQryInvestorLegPosition,
    };

    /// <summary>
    /// 所有的OnRtnXXXX回调事件
    /// </summary>
    public enum EnumOnRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///深度行情通知, ThostFtdcDepthMarketDataField
        /// </summary>
        OnRtnDepthMarketData,
        /// <summary>
        ///数据流回退通知, ThostFtdcFlowMessageCancelField
        /// </summary>
        OnRtnFlowMessageCancel,
        /// <summary>
        ///成交回报, ThostFtdcTradeField
        /// </summary>
        OnRtnTrade,
        /// <summary>
        ///报单回报, ThostFtdcOrderField
        /// </summary>
        OnRtnOrder,
        /// <summary>
        ///合约交易状态通知, ThostFtdcInstrumentStatusField
        /// </summary>
        OnRtnInstrumentStatus,
        /// <summary>
        ///账户出入金回报, ThostFtdcInvestorAccountDepositResField
        /// </summary>
        OnRtnInvestorAccountDeposit,
        /// <summary>
        ///报价回报, ThostFtdcRtnQuoteField
        /// </summary>
        OnRtnQuote,
        /// <summary>
        ///询价回报, ThostFtdcReqForQuoteField
        /// </summary>
        OnRtnForQuote,
        /// <summary>
        ///增加组合规则通知, ThostFtdcMarginCombinationLegField
        /// </summary>
        OnRtnMarginCombinationLeg,
        /// <summary>
        ///客户申请组合确认, ThostFtdcInputMarginCombActionField
        /// </summary>
        OnRtnMarginCombAction,
        /// <summary>
        ///用户请求出入金, ThostFtdcstpUserDepositField
        /// </summary>
        OnRtnUserDeposit,
    };

}; // end of namespace
