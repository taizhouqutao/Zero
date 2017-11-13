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
       
    }

    /// <summary>
    /// 朋友圈添加
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentAdd
    {

    }

    /// <summary>
    /// 朋友圈删除
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentDel
    {

    }

    /// <summary>
    /// 朋友圈删除回复
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentDelReply
    {

    }

    /// <summary>
    /// 朋友圈点赞
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetGood
    {
        
    }

    /// <summary>
    /// 朋友圈回复
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetReply
    {

    }

    /// <summary>
    /// 朋友圈设置已读
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentSetRead
    {

    }

    /// <summary>
    /// 朋友圈获取未读数量查询
    /// </summary>
    [Serializable]
    [DataContract]
    public class MomentUnReadQuery
    {
        
    }

    [Serializable]
    [DataContract]
    public class MomentCustomerDetail
    {
        
    }
}
