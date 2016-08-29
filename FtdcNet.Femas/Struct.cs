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
    /// Convert Native Ftdc struct ptr to Managed object
    /// </summary>
    public static class Conv
    {
        /// <summary>
        /// Marshal IntPtr to Struct/Class 
        /// </summary>
        public static T P2S<T>(IntPtr ptr) where T : class
        {
            return Marshal.PtrToStructure(ptr, typeof(T)) as T;
        }
    }

    /// <summary>
    /// 系统用户登录请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string ProtocolInfo;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 数据中心代码
        /// </summary>
        public int DataCenterID;

        /// <summary>
        /// 客户端运行文件大小
        /// </summary>
        public int UserProductFileSize;

    };

    /// <summary>
    /// 系统用户登录应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserLoginField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// 用户最大本地报单号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxOrderLocalID;

        /// <summary>
        /// 交易系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string TradingSystemName;

        /// <summary>
        /// 数据中心代码
        /// </summary>
        public int DataCenterID;

        /// <summary>
        /// 会员私有流当前长度
        /// </summary>
        public int PrivateFlowSize;

        /// <summary>
        /// 交易员私有流当前长度
        /// </summary>
        public int UserFlowSize;

    };

    /// <summary>
    /// 用户登出请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLogoutField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 用户登出响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserLogoutField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 强制用户退出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForceUserExitField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 用户口令修改
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 旧密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;

        /// <summary>
        /// 新密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;

    };

    /// <summary>
    /// 输入报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOrderField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 系统报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string OrderSysID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 指定通过此席位序号下单
        /// </summary>
        public int SeatNo;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 用户本地报单号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 用户自定义域
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string UserCustom;

    };

    /// <summary>
    /// 报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderActionField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string OrderSysID;

        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 本次撤单操作的本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderActionLocalID;

        /// <summary>
        /// 被撤订单的本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

        /// <summary>
        /// 报单操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

    };

    /// <summary>
    /// 内存表导出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMemDbField
    {
        /// <summary>
        /// 内存表名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string MemTableName;

    };

    /// <summary>
    /// 用户请求出入金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcstpUserDepositField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 出入金方向
        /// </summary>
        public EnumAccountDirectionType AmountDirection;

        /// <summary>
        /// 用户本地报单号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

    };

    /// <summary>
    /// 用户主次席出入金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcstpTransferMoneyField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 出入金方向
        /// </summary>
        public EnumAccountDirectionType AmountDirection;

        /// <summary>
        /// 用户本地报单号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

        /// <summary>
        /// 银行机构代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BankID;

        /// <summary>
        /// 银行转账密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string BankPasswd;

        /// <summary>
        /// 主席转账密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string AccountPasswd;

    };

    /// <summary>
    /// 响应信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInfoField
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 报单查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string OrderSysID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

    };

    /// <summary>
    /// 成交查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 合约查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ProductID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 合约查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInstrumentField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 品种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ProductID;

        /// <summary>
        /// 品种名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string ProductName;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 交割年份
        /// </summary>
        public int DeliveryYear;

        /// <summary>
        /// 交割月
        /// </summary>
        public int DeliveryMonth;

        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;

        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;

        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;

        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;

        /// <summary>
        /// 数量乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 报价单位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 币种
        /// </summary>
        public EnumCurrencyType Currency;

        /// <summary>
        /// 多头限仓
        /// </summary>
        public int LongPosLimit;

        /// <summary>
        /// 空头限仓
        /// </summary>
        public int ShortPosLimit;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 昨结算
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 合约交易状态
        /// </summary>
        public EnumInstrumentStatusType InstrumentStatus;

        /// <summary>
        /// 创建日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;

        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 到期日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 开始交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;

        /// <summary>
        /// 最后交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;

        /// <summary>
        /// 挂牌基准价
        /// </summary>
        public double BasisPrice;

        /// <summary>
        /// 当前是否交易
        /// </summary>
        public int IsTrading;

        /// <summary>
        /// 基础商品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;

        /// <summary>
        /// 基础商品乘数
        /// </summary>
        public int UnderlyingMultiple;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 执行价
        /// </summary>
        public double StrikePrice;

        /// <summary>
        /// 期权类型
        /// </summary>
        public EnumOptionsTypeType OptionsType;

    };

    /// <summary>
    /// 合约状态
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentStatusField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 品种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ProductID;

        /// <summary>
        /// 品种名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string ProductName;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 交割年份
        /// </summary>
        public int DeliveryYear;

        /// <summary>
        /// 交割月
        /// </summary>
        public int DeliveryMonth;

        /// <summary>
        /// 限价单最大下单量
        /// </summary>
        public int MaxLimitOrderVolume;

        /// <summary>
        /// 限价单最小下单量
        /// </summary>
        public int MinLimitOrderVolume;

        /// <summary>
        /// 市价单最大下单量
        /// </summary>
        public int MaxMarketOrderVolume;

        /// <summary>
        /// 市价单最小下单量
        /// </summary>
        public int MinMarketOrderVolume;

        /// <summary>
        /// 数量乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 报价单位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 币种
        /// </summary>
        public EnumCurrencyType Currency;

        /// <summary>
        /// 多头限仓
        /// </summary>
        public int LongPosLimit;

        /// <summary>
        /// 空头限仓
        /// </summary>
        public int ShortPosLimit;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 昨结算
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 合约交易状态
        /// </summary>
        public EnumInstrumentStatusType InstrumentStatus;

        /// <summary>
        /// 创建日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;

        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 到期日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 开始交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;

        /// <summary>
        /// 最后交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;

        /// <summary>
        /// 挂牌基准价
        /// </summary>
        public double BasisPrice;

        /// <summary>
        /// 当前是否交易
        /// </summary>
        public int IsTrading;

        /// <summary>
        /// 基础商品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;

        /// <summary>
        /// 基础商品乘数
        /// </summary>
        public int UnderlyingMultiple;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 执行价
        /// </summary>
        public double StrikePrice;

        /// <summary>
        /// 期权类型
        /// </summary>
        public EnumOptionsTypeType OptionsType;

    };

    /// <summary>
    /// 投资者资金查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorAccountField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

    };

    /// <summary>
    /// 投资者资金应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInvestorAccountField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 上次结算准备金
        /// </summary>
        public double PreBalance;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结手续费
        /// </summary>
        public double FrozenFee;

        /// <summary>
        /// 冻结权利金
        /// </summary>
        public double FrozenPremium;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Fee;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 多头冻结的保证金
        /// </summary>
        public double LongFrozenMargin;

        /// <summary>
        /// 空头冻结的保证金
        /// </summary>
        public double ShortFrozenMargin;

        /// <summary>
        /// 多头占用保证金
        /// </summary>
        public double LongMargin;

        /// <summary>
        /// 空头占用保证金
        /// </summary>
        public double ShortMargin;

        /// <summary>
        /// 当日释放保证金
        /// </summary>
        public double ReleaseMargin;

        /// <summary>
        /// 动态权益
        /// </summary>
        public double DynamicRights;

        /// <summary>
        /// 今日出入金
        /// </summary>
        public double TodayInOut;

        /// <summary>
        /// 占用保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 期权权利金收支
        /// </summary>
        public double Premium;

        /// <summary>
        /// 风险度
        /// </summary>
        public double Risk;

    };

    /// <summary>
    /// 可用投资者查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserInvestorField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 可用投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserInvestorField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

    };

    /// <summary>
    /// 交易编码查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingCodeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易编码查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspTradingCodeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 客户代码权限
        /// </summary>
        public EnumTradingRightType ClientRight;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public EnumIsActiveType IsActive;

    };

    /// <summary>
    /// 交易所查询请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

    };

    /// <summary>
    /// 交易所查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 交易所名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeName;

    };

    /// <summary>
    /// 投资者持仓查询请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 投资者持仓查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInvestorPositionField
    {
        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 占用保证金
        /// </summary>
        public double UsedMargin;

        /// <summary>
        /// 今持仓量
        /// </summary>
        public int Position;

        /// <summary>
        /// 今日持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public int YdPosition;

        /// <summary>
        /// 昨日持仓成本
        /// </summary>
        public double YdPositionCost;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 开仓冻结持仓
        /// </summary>
        public int FrozenPosition;

        /// <summary>
        /// 平仓冻结持仓
        /// </summary>
        public int FrozenClosing;

        /// <summary>
        /// 冻结的权利金
        /// </summary>
        public double FrozenPremium;

        /// <summary>
        /// 最后一笔成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string LastTradeID;

        /// <summary>
        /// 最后一笔本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LastOrderLocalID;

        /// <summary>
        /// 币种
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Currency;

    };

    /// <summary>
    /// 合规参数查询请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryComplianceParamField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

    };

    /// <summary>
    /// 合规参数查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspComplianceParamField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 每日最大报单笔
        /// </summary>
        public int DailyMaxOrder;

        /// <summary>
        /// 每日最大撤单笔
        /// </summary>
        public int DailyMaxOrderAction;

        /// <summary>
        /// 每日最大错单笔
        /// </summary>
        public int DailyMaxErrorOrder;

        /// <summary>
        /// 每日最大报单手
        /// </summary>
        public int DailyMaxOrderVolume;

        /// <summary>
        /// 每日最大撤单手
        /// </summary>
        public int DailyMaxOrderActionVolume;

    };

    /// <summary>
    /// 用户查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserField
    {
        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string StartUserID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string EndUserID;

    };

    /// <summary>
    /// 用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户登录密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public EnumIsActiveType IsActive;

        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UserName;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

        /// <summary>
        /// 营业部
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Department;

        /// <summary>
        /// 授权功能集
        /// </summary>
        public EnumGrantFuncSetType GrantFuncSet;

        /// <summary>
        /// 修改用户编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SetUserID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CommandDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CommandTime;

    };

    /// <summary>
    /// 投资者手续费率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorFeeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 投资者手续费率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorFeeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 品种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ProductID;

        /// <summary>
        /// 开仓手续费按比例
        /// </summary>
        public double OpenFeeRate;

        /// <summary>
        /// 开仓手续费按手数
        /// </summary>
        public double OpenFeeAmt;

        /// <summary>
        /// 平仓手续费按比例
        /// </summary>
        public double OffsetFeeRate;

        /// <summary>
        /// 平仓手续费按手数
        /// </summary>
        public double OffsetFeeAmt;

        /// <summary>
        /// 平今仓手续费按比例
        /// </summary>
        public double OTFeeRate;

        /// <summary>
        /// 平今仓手续费按手数
        /// </summary>
        public double OTFeeAmt;

        /// <summary>
        /// 每笔订单收取的申报费
        /// </summary>
        public double PerOrderAmt;

        /// <summary>
        /// 每笔撤单收取的申报费
        /// </summary>
        public double PerCancelAmt;

    };

    /// <summary>
    /// 投资者保证金率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorMarginField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 投资者保证金率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorMarginField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 品种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ProductID;

        /// <summary>
        /// 多头占用保证金按比例
        /// </summary>
        public double LongMarginRate;

        /// <summary>
        /// 多头保证金按手数
        /// </summary>
        public double LongMarginAmt;

        /// <summary>
        /// 空头占用保证金按比例
        /// </summary>
        public double ShortMarginRate;

        /// <summary>
        /// 空头保证金按手数
        /// </summary>
        public double ShortMarginAmt;

    };

    /// <summary>
    /// 成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradeField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 下单席位号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string SeatID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 用户编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 下单用户编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string OrderUserID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string OrderSysID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 成交价格
        /// </summary>
        public double TradePrice;

        /// <summary>
        /// 成交数量
        /// </summary>
        public int TradeVolume;

        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 清算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 本次成交手续费
        /// </summary>
        public double UsedFee;

        /// <summary>
        /// 本次成交占用保证金
        /// </summary>
        public double UsedMargin;

        /// <summary>
        /// 本次成交占用权利金
        /// </summary>
        public double Premium;

        /// <summary>
        /// 持仓表今持仓量
        /// </summary>
        public int Position;

        /// <summary>
        /// 持仓表今日持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 资金表可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 资金表占用保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 资金表冻结的保证金
        /// </summary>
        public double FrozenMargin;

    };

    /// <summary>
    /// 报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 系统报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string OrderSysID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 指定通过此席位序号下单
        /// </summary>
        public int SeatNo;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 用户本地报单号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserOrderLocalID;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 用户自定义域
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string UserCustom;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 最初下单用户编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string OrderUserID;

        /// <summary>
        /// 客户号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 下单席位号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string SeatID;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 撤单用户编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string CancelUserID;

        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeRemain;

    };

    /// <summary>
    /// 数据流回退
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcFlowMessageCancelField
    {
        /// <summary>
        /// 序列系列号
        /// </summary>
        public int SequenceSeries;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 数据中心代码
        /// </summary>
        public int DataCenterID;

        /// <summary>
        /// 回退起始序列号
        /// </summary>
        public int StartSequenceNo;

        /// <summary>
        /// 回退结束序列号
        /// </summary>
        public int EndSequenceNo;

    };

    /// <summary>
    /// 信息分发
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDisseminationField
    {
        /// <summary>
        /// 序列系列号
        /// </summary>
        public int SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

    };

    /// <summary>
    /// 出入金结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorAccountDepositResField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 资金帐号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 资金流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AccountSeqNo;

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 出入金方向
        /// </summary>
        public EnumAccountDirectionType AmountDirection;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 结算准备金
        /// </summary>
        public double Balance;

    };

    /// <summary>
    /// 报价录入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputQuoteField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易系统返回的系统报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string QuoteSysID;

        /// <summary>
        /// 用户设定的本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserQuoteLocalID;

        /// <summary>
        /// 飞马向交易系统报的本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 买方买入数量
        /// </summary>
        public int BidVolume;

        /// <summary>
        /// 买方开平标志
        /// </summary>
        public EnumOffsetFlagType BidOffsetFlag;

        /// <summary>
        /// 买方投机套保标志
        /// </summary>
        public EnumHedgeFlagType BidHedgeFlag;

        /// <summary>
        /// 买方买入价格
        /// </summary>
        public double BidPrice;

        /// <summary>
        /// 卖方卖出数量
        /// </summary>
        public int AskVolume;

        /// <summary>
        /// 卖方开平标志
        /// </summary>
        public EnumOffsetFlagType AskOffsetFlag;

        /// <summary>
        /// 卖方投机套保标志
        /// </summary>
        public EnumHedgeFlagType AskHedgeFlag;

        /// <summary>
        /// 卖方卖出价格
        /// </summary>
        public double AskPrice;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 用户自定义域
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string UserCustom;

        /// <summary>
        /// 拆分出来的买方用户本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidUserOrderLocalID;

        /// <summary>
        /// 拆分出来的卖方用户本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskUserOrderLocalID;

    };

    /// <summary>
    /// 报价通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRtnQuoteField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易系统返回的系统报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string QuoteSysID;

        /// <summary>
        /// 用户设定的本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserQuoteLocalID;

        /// <summary>
        /// 飞马向交易系统报的本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;

        /// <summary>
        /// 买方买入数量
        /// </summary>
        public int BidVolume;

        /// <summary>
        /// 买方开平标志
        /// </summary>
        public EnumOffsetFlagType BidOffsetFlag;

        /// <summary>
        /// 买方投机套保标志
        /// </summary>
        public EnumHedgeFlagType BidHedgeFlag;

        /// <summary>
        /// 买方买入价格
        /// </summary>
        public double BidPrice;

        /// <summary>
        /// 卖方卖出数量
        /// </summary>
        public int AskVolume;

        /// <summary>
        /// 卖方开平标志
        /// </summary>
        public EnumOffsetFlagType AskOffsetFlag;

        /// <summary>
        /// 卖方投机套保标志
        /// </summary>
        public EnumHedgeFlagType AskHedgeFlag;

        /// <summary>
        /// 卖方卖出价格
        /// </summary>
        public double AskPrice;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 用户自定义域
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string UserCustom;

        /// <summary>
        /// 拆分出来的买方用户本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidUserOrderLocalID;

        /// <summary>
        /// 拆分出来的卖方用户本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskUserOrderLocalID;

        /// <summary>
        /// 买方系统报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BidOrderSysID;

        /// <summary>
        /// 卖方系统报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string AskOrderSysID;

        /// <summary>
        /// 报价单状态
        /// </summary>
        public EnumQuoteStatusType QuoteStatus;

        /// <summary>
        /// 插入时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

    };

    /// <summary>
    /// 报价操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQuoteActionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易系统返回的系统报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string QuoteSysID;

        /// <summary>
        /// 用户设定的被撤的本地报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserQuoteLocalID;

        /// <summary>
        /// 用户向飞马报的本地撤消报价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserQuoteActionLocalID;

        /// <summary>
        /// 报单操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 用户自定义域
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string UserCustom;

    };

    /// <summary>
    /// 询价请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqForQuoteField
    {
        /// <summary>
        /// 询价编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ReqForQuoteID;

        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 询价时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ReqForQuoteTime;

    };

    /// <summary>
    /// 行情基础属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 昨结算
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

    };

    /// <summary>
    /// 行情静态属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataStaticField
    {
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 今结算
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

    };

    /// <summary>
    /// 行情最新成交属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataLastMatchField
    {
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

    };

    /// <summary>
    /// 行情最优价属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBestPriceField
    {
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;

    };

    /// <summary>
    /// 行情申买二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid23Field
    {
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;

    };

    /// <summary>
    /// 行情申卖二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk23Field
    {
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;

    };

    /// <summary>
    /// 行情申买四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid45Field
    {
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;

    };

    /// <summary>
    /// 行情申卖四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk45Field
    {
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;

    };

    /// <summary>
    /// 行情更新时间属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataUpdateTimeField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

    };

    /// <summary>
    /// 深度行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepthMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算组代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 昨结算
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 今结算
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public int BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public int AskVolume1;

        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public int BidVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public int BidVolume3;

        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public int AskVolume2;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public int AskVolume3;

        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public int BidVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public int BidVolume5;

        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public int AskVolume4;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public int AskVolume5;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

    };

    /// <summary>
    /// 订阅合约的相关信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSpecificInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 申请组合
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputMarginCombActionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 交易用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 用户本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string UserActionLocalID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 组合数量
        /// </summary>
        public int CombVolume;

        /// <summary>
        /// 组合动作方向
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

    };

    /// <summary>
    /// 交易编码组合持仓查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorCombPositionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

    };

    /// <summary>
    /// 交易编码组合持仓查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInvestorCombPositionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 组合持仓
        /// </summary>
        public int CombPosition;

        /// <summary>
        /// 冻结组合持仓
        /// </summary>
        public int CombFrozenPosition;

        /// <summary>
        /// 组合一手释放的保证金
        /// </summary>
        public double CombFreeMargin;

    };

    /// <summary>
    /// 组合规则
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarginCombinationLegField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;

        /// <summary>
        /// 优先级
        /// </summary>
        public byte Priority;

    };

    /// <summary>
    /// 交易编码单腿持仓查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorLegPositionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;

    };

    /// <summary>
    /// 交易编码单腿持仓查询应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInvestorLegPositionField
    {
        /// <summary>
        /// 经纪公司编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ExchangeID;

        /// <summary>
        /// 投资者编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string InvestorID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 19)]
        public string ClientID;

        /// <summary>
        /// 单腿合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 多头持仓
        /// </summary>
        public int LongPosition;

        /// <summary>
        /// 空头持仓
        /// </summary>
        public int ShortPosition;

        /// <summary>
        /// 多头占用保证金
        /// </summary>
        public double LongMargin;

        /// <summary>
        /// 空头占用保证金
        /// </summary>
        public double ShortMargin;

        /// <summary>
        /// 多头冻结持仓
        /// </summary>
        public int LongFrozenPosition;

        /// <summary>
        /// 空头冻结持仓
        /// </summary>
        public int ShortFrozenPosition;

        /// <summary>
        /// 多头冻结保证金
        /// </summary>
        public double LongFrozenMargin;

        /// <summary>
        /// 空头冻结保证金
        /// </summary>
        public double ShortFrozenMargin;

    };

}; // end of namespace
