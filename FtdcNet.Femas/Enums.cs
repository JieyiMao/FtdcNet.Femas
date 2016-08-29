/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/27 10:29:02
/////////////////////////////////////////////////////////////////////////

using System;

namespace Femas
{
    /// <summary>
    /// THOST_TE_RESUME_TYPE, 公共流重传方式
    /// </summary>
    public enum EnumTeResumeType : byte
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME,
        THOST_TERT_QUICK
    };

    /// <summary>
    /// TFtdcUstpVolumeConditionType是一个成交量类型类型
    /// </summary>
    public enum EnumVolumeConditionType : byte
    {
        /// <summary>
        /// 任何数量
        /// </summary>
        AV = (byte)'1',

        /// <summary>
        /// 最小数量
        /// </summary>
        MV = (byte)'2',

        /// <summary>
        /// 全部数量
        /// </summary>
        CV = (byte)'3'
    };

    /// <summary>
    /// TFtdcUstpForceCloseReasonType是一个强平原因类型
    /// </summary>
    public enum EnumForceCloseReasonType : byte
    {
        /// <summary>
        /// 非强平
        /// </summary>
        NotForceClose = (byte)'0',

        /// <summary>
        /// 资金不足
        /// </summary>
        LackDeposit = (byte)'1',

        /// <summary>
        /// 客户超仓
        /// </summary>
        ClientOverPositionLimit = (byte)'2',

        /// <summary>
        /// 会员超仓
        /// </summary>
        MemberOverPositionLimit = (byte)'3',

        /// <summary>
        /// 持仓非整数倍
        /// </summary>
        NotMultiple = (byte)'4'
    };

    /// <summary>
    /// TFtdcUstpInstrumentStatusType是一个合约交易状态类型
    /// </summary>
    public enum EnumInstrumentStatusType : byte
    {
        /// <summary>
        /// 开盘前
        /// </summary>
        BeforeTrading = (byte)'0',

        /// <summary>
        /// 非交易
        /// </summary>
        NoTrading = (byte)'1',

        /// <summary>
        /// 连续交易
        /// </summary>
        Continous = (byte)'2',

        /// <summary>
        /// 集合竞价报单
        /// </summary>
        AuctionOrdering = (byte)'3',

        /// <summary>
        /// 集合竞价价格平衡
        /// </summary>
        AuctionBalance = (byte)'4',

        /// <summary>
        /// 集合竞价撮合
        /// </summary>
        AuctionMatch = (byte)'5',

        /// <summary>
        /// 收盘
        /// </summary>
        Closed = (byte)'6'
    };

    /// <summary>
    /// TFtdcUstpOffsetFlagType是一个开平标志类型
    /// </summary>
    public enum EnumOffsetFlagType : byte
    {
        /// <summary>
        /// 开仓
        /// </summary>
        Open = (byte)'0',

        /// <summary>
        /// 平仓
        /// </summary>
        Close = (byte)'1',

        /// <summary>
        /// 强平
        /// </summary>
        ForceClose = (byte)'2',

        /// <summary>
        /// 平今
        /// </summary>
        CloseToday = (byte)'3',

        /// <summary>
        /// 平昨
        /// </summary>
        CloseYesterday = (byte)'4'
    };

    /// <summary>
    /// TFtdcUstpOrderPriceTypeType是一个报单价格条件类型
    /// </summary>
    public enum EnumOrderPriceTypeType : byte
    {
        /// <summary>
        /// 任意价
        /// </summary>
        AnyPrice = (byte)'1',

        /// <summary>
        /// 限价
        /// </summary>
        LimitPrice = (byte)'2',

        /// <summary>
        /// 最优价
        /// </summary>
        BestPrice = (byte)'3',

        /// <summary>
        /// 五档价
        /// </summary>
        FiveLevelPrice = (byte)'4'
    };

    /// <summary>
    /// TFtdcUstpOrderStatusType是一个报单状态类型
    /// </summary>
    public enum EnumOrderStatusType : byte
    {
        /// <summary>
        /// 全部成交
        /// </summary>
        AllTraded = (byte)'0',

        /// <summary>
        /// 部分成交还在队列中
        /// </summary>
        PartTradedQueueing = (byte)'1',

        /// <summary>
        /// 部分成交不在队列中
        /// </summary>
        PartTradedNotQueueing = (byte)'2',

        /// <summary>
        /// 未成交还在队列中
        /// </summary>
        NoTradeQueueing = (byte)'3',

        /// <summary>
        /// 未成交不在队列中
        /// </summary>
        NoTradeNotQueueing = (byte)'4',

        /// <summary>
        /// 撤单
        /// </summary>
        Canceled = (byte)'5',

        /// <summary>
        /// 订单已报入交易所未应答
        /// </summary>
        AcceptedNoReply = (byte)'6'
    };

    /// <summary>
    /// TFtdcUstpUserTypeType是一个用户类型类型
    /// </summary>
    public enum EnumUserTypeType : byte
    {
        /// <summary>
        /// 自然人
        /// </summary>
        Person = (byte)'1',

        /// <summary>
        /// 理财产品
        /// </summary>
        Product = (byte)'2',

        /// <summary>
        /// 期货公司管理员
        /// </summary>
        Manager = (byte)'3',

        /// <summary>
        /// 席位
        /// </summary>
        Seat = (byte)'4'
    };

    /// <summary>
    /// TFtdcUstpTradingRightType是一个交易权限类型
    /// </summary>
    public enum EnumTradingRightType : byte
    {
        /// <summary>
        /// 可以交易
        /// </summary>
        Allow = (byte)'0',

        /// <summary>
        /// 只能平仓
        /// </summary>
        CloseOnly = (byte)'1',

        /// <summary>
        /// 不能交易
        /// </summary>
        Forbidden = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpTimeConditionType是一个有效期类型类型
    /// </summary>
    public enum EnumTimeConditionType : byte
    {
        /// <summary>
        /// 立即完成，否则撤销
        /// </summary>
        IOC = (byte)'1',

        /// <summary>
        /// 本节有效
        /// </summary>
        GFS = (byte)'2',

        /// <summary>
        /// 当日有效
        /// </summary>
        GFD = (byte)'3',

        /// <summary>
        /// 指定日期前有效
        /// </summary>
        GTD = (byte)'4',

        /// <summary>
        /// 撤销前有效
        /// </summary>
        GTC = (byte)'5',

        /// <summary>
        /// 集合竞价有效
        /// </summary>
        GFA = (byte)'6'
    };

    /// <summary>
    /// TFtdcUstpOrderSourceType是一个报单来源类型
    /// </summary>
    public enum EnumOrderSourceType : byte
    {
        /// <summary>
        /// 来自参与者
        /// </summary>
        Participant = (byte)'0',

        /// <summary>
        /// 来自管理员
        /// </summary>
        Administrator = (byte)'1',

        /// <summary>
        /// 报价单拆分出来的买单或卖单
        /// </summary>
        QuoteSplit = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpDirectionType是一个买卖方向类型
    /// </summary>
    public enum EnumDirectionType : byte
    {
        /// <summary>
        /// 买
        /// </summary>
        Buy = (byte)'0',

        /// <summary>
        /// 卖
        /// </summary>
        Sell = (byte)'1'
    };

    /// <summary>
    /// TFtdcUstpCurrencyType是一个币种类型
    /// </summary>
    public enum EnumCurrencyType : byte
    {
        /// <summary>
        /// 人民币
        /// </summary>
        RMB = (byte)'1',

        /// <summary>
        /// 美元
        /// </summary>
        UDOLLAR = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpAccountDirectionType是一个出入金方向类型
    /// </summary>
    public enum EnumAccountDirectionType : byte
    {
        /// <summary>
        /// 入金
        /// </summary>
        In = (byte)'1',

        /// <summary>
        /// 出金
        /// </summary>
        Out = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpHedgeFlagType是一个投机套保标志类型
    /// </summary>
    public enum EnumHedgeFlagType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3',

        /// <summary>
        /// 做市商
        /// </summary>
        MarketMaker = (byte)'4',

        /// <summary>
        /// 匹配所有的值
        /// </summary>
        AllValue = (byte)'9'
    };

    /// <summary>
    /// TFtdcUstpActionFlagType是一个操作标志类型
    /// </summary>
    public enum EnumActionFlagType : byte
    {
        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'0',

        /// <summary>
        /// 挂起
        /// </summary>
        Suspend = (byte)'1',

        /// <summary>
        /// 激活
        /// </summary>
        Active = (byte)'2',

        /// <summary>
        /// 修改
        /// </summary>
        Modify = (byte)'3'
    };

    /// <summary>
    /// TFtdcUstpPositionTypeType是一个持仓类型类型
    /// </summary>
    public enum EnumPositionTypeType : byte
    {
        /// <summary>
        /// 净持仓
        /// </summary>
        Net = (byte)'1',

        /// <summary>
        /// 综合持仓
        /// </summary>
        Gross = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpOptionsTypeType是一个期权类型类型
    /// </summary>
    public enum EnumOptionsTypeType : byte
    {
        /// <summary>
        /// 非期权
        /// </summary>
        NotOptions = (byte)'0',

        /// <summary>
        /// 看涨
        /// </summary>
        CallOptions = (byte)'1',

        /// <summary>
        /// 看跌
        /// </summary>
        PutOptions = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpIsActiveType是一个是否活跃类型
    /// </summary>
    public enum EnumIsActiveType : byte
    {
        /// <summary>
        /// 不活跃
        /// </summary>
        NoActive = (byte)'0',

        /// <summary>
        /// 活跃
        /// </summary>
        Active = (byte)'1'
    };

    /// <summary>
    /// TFtdcUstpGrantFuncSetType是一个授权功能号类型
    /// </summary>
    public enum EnumGrantFuncSetType : byte
    {
        /// <summary>
        /// 正常交易
        /// </summary>
        Trading = (byte)'0',

        /// <summary>
        /// 只能平仓
        /// </summary>
        CloseOnly = (byte)'1',

        /// <summary>
        /// 禁止交易
        /// </summary>
        CanotTrade = (byte)'2'
    };

    /// <summary>
    /// TFtdcUstpQuoteStatusType是一个报价单状态类型类型
    /// </summary>
    public enum EnumQuoteStatusType : byte
    {
        /// <summary>
        /// 在飞马中还未进入交易系统
        /// </summary>
        Inited_InFEMAS = (byte)'0',

        /// <summary>
        /// 已经报入交易系统中
        /// </summary>
        Accepted_InTradingSystem = (byte)'1',

        /// <summary>
        /// 已经撤掉单腿
        /// </summary>
        Canceled_SingleLeg = (byte)'2',

        /// <summary>
        /// 已经全部撤掉
        /// </summary>
        Canceled_All = (byte)'3',

        /// <summary>
        /// 已经有单腿成交
        /// </summary>
        Traded_SingleLeg = (byte)'4',

        /// <summary>
        /// 已经全部成交
        /// </summary>
        Traded_All = (byte)'5',

        /// <summary>
        /// 错误的撤消报价请求
        /// </summary>
        Error_QuoteAction = (byte)'6'
    };

    /// <summary>
    /// TFtdcUstpCombDirectionType是一个申请保证金组合指令方向类型
    /// </summary>
    public enum EnumCombDirectionType : byte
    {
        /// <summary>
        /// 申请组合
        /// </summary>
        Combine = (byte)'0',

        /// <summary>
        /// 申请拆分组合
        /// </summary>
        UnCombine = (byte)'1'
    };

}; // end of namespace
