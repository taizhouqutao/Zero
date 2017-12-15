using System;
using System.Runtime.Serialization;

namespace WebApi.Models
{
    /// <summary>
    /// 用户钱包
    /// </summary>
    [Serializable]
    [DataContract]
    public class Money
    {
        /// <summary>
        /// 钱包系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }

        /// <summary>
        /// 钱包余额
        /// </summary>
        /// <value>The blance amount.</value>
        [DataMember]
        public decimal BlanceAmount { get; set; }
    }

    /// <summary>
    /// 用户钱包查询
    /// </summary>
    [Serializable]
    [DataContract]
    public class MoneyQuery
    {
        /// <summary>
        /// 客户编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo{ get; set; }
    }

    /// <summary>
    /// 钱包日志流水
    /// </summary>
    [Serializable]
    [DataContract]
    public class MoneyLog
    {
        /// <summary>
        /// 钱包日志流水编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        /// <value>The amount.</value>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// 来源钱包编码
        /// </summary>
        /// <value>The money from sys no.</value>
        [DataMember]
        public int MoneyFromSysNo { get; set; }

        /// <summary>
        /// 目标钱包编码
        /// </summary>
        /// <value>The money from sys no.</value>
        [DataMember]
        public int MoneyToSysNo { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        /// <value>The money to sys no.</value>
        [DataMember]
        public int ActionType { get; set; }

        /// <summary>
        /// 交易描述
        /// </summary>
        /// <value>The action desc.</value>
        [DataMember]
        public string ActionDesc { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>The action desc.</value>
        [DataMember]
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>The create time.</value>
        [DataMember]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        /// <value>The active status.</value>
        [DataMember]
        public int ActiveStatus{ get; set; }
    }

    /// <summary>
    /// 钱包日志流水查询
    /// </summary>
    [Serializable]
    [DataContract]
    public class MoneyLogQuery
    {
        /// <summary>
        /// 钱包编码
        /// </summary>
        /// <value>The money sys no.</value>
        [DataMember]
        public int MoneySysNo { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        /// <value>The start date.</value>
        [DataMember]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        /// <value>The end date.</value>
        [DataMember]
        public DateTime EndDate { get; set; }
    }

    /// <summary>
    /// 钱包充值
    /// </summary>
    [Serializable]
    [DataContract]
    public class MoneyRecharge
    {
        /// <summary>
        /// 目标钱包
        /// </summary>
        /// <value>The money sys no.</value>
        [DataMember]
        public int MoneySysNo { get; set; }

        /// <summary>
        /// 充值资金
        /// </summary>
        /// <value>The amount.</value>
        [DataMember]
        public decimal Amount { get; set; }

        /// <summary>
        /// 支付方式（1微信公众号，2支付宝h5）
        /// </summary>
        /// <value>The type of the pay.</value>
        [DataMember]
        public int PayType { get; set; }
    }
}
