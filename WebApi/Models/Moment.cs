using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebApi.Models
{
    /// <summary>
    /// 朋友圈
    /// </summary>
    [Serializable]
    [DataContract]
    public class Moment
    {
        /// <summary>
        /// 系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }

        /// <summary>
        /// 发起者客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }

        /// <summary>
        /// 朋友圈内容
        /// </summary>
        /// <value>The content.</value>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// 自定义json
        /// </summary>
        /// <value>The json object.</value>
        [DataMember]
        public string JsonObj { get; set; }

        /// <summary>
        /// 朋友圈活动客户
        /// </summary>
        /// <value>The moment customer details.</value>
        [DataMember]
        public List<MomentCustomerDetailBasic> MomentCustomerDetails { get; set; }
    }

    /// <summary>
    /// 朋友圈添加
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentAdd
    {
        /// <summary>
        /// 发起者客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }

        /// <summary>
        /// 朋友圈内容
        /// </summary>
        /// <value>The content.</value>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// 自定义json
        /// </summary>
        /// <value>The json object.</value>
        [DataMember]
        public string JsonObj { get; set; }
    }

    /// <summary>
    /// 朋友圈删除
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentDel
    {
        /// <summary>
        /// 朋友圈系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈删除回复
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentDelReply
    {
        /// <summary>
        /// 朋友圈活动客户记录系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int MomentCustomerDetailSysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈点赞
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetGood
    {
        /// <summary>
        /// 朋友圈系统编码
        /// </summary>
        /// <value>The moment sys no.</value>
        [DataMember]
        public int MomentSysNo { get; set; }

        /// <summary>
        /// 发起者客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈回复
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetReply
    {
        /// <summary>
        /// 朋友圈系统编码
        /// </summary>
        /// <value>The moment sys no.</value>
        [DataMember]
        public int MomentSysNo { get; set; }

        /// <summary>
        /// 发起者客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }

        /// <summary>
        /// 接受者客户系统编码
        /// </summary>
        /// <value>To customer sys no.</value>
        [DataMember]
        public int ToCustomerSysNo { get; set; }

        /// <summary>
        /// 活动内容
        /// </summary>
        /// <value>The content.</value>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// 活动类型（1:留言，2:点赞）
        /// </summary>
        /// <value>The type of the active.</value>
        [DataMember]
        public int ActiveType { get; set; }
    }

    /// <summary>
    /// 朋友圈设置已读
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetRead
    {
        /// <summary>
        /// 客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈获取未读数量查询
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentUnReadQuery
    {
        /// <summary>
        /// 客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈活动客户
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentCustomerDetailBasic
    {
        /// <summary>
        /// 朋友圈活动客户记录系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }
        /// <summary>
        /// 活动客户编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        /// <value>The name of the customer.</value>
        [DataMember]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        /// <value>The name of the nick.</value>
        [DataMember]
        public string NickName { get; set; }

        /// <summary>
        /// 活动内容
        /// </summary>
        /// <value>The content.</value>
        [DataMember]
        public string Content { get; set; }

        /// <summary>
        /// 活动类型（1:留言，2:点赞）
        /// </summary>
        /// <value>The type of the active.</value>
        [DataMember]
        public int ActiveType { get; set; }

    }

    /// <summary>
    /// 朋友圈活动客户
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentCustomerDetail:MomentCustomerDetailBasic
    {
        /// <summary>
        /// 朋友圈内容
        /// </summary>
        /// <value>The content.</value>
        [DataMember]
        public string MainContent { get; set; }

        /// <summary>
        /// 自定义json
        /// </summary>
        /// <value>The json object.</value>
        [DataMember]
        public string MainJsonObj { get; set; }
    }

    /// <summary>
    /// 朋友圈实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentQuery
    {
        /// <summary>
        /// 客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        [DataMember]
        public int CustomerSysNo { get; set; }
    }

    /// <summary>
    /// 朋友圈系统编码实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSysNo
    {
        /// <summary>
        /// 朋友圈系统编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }
    }
}
