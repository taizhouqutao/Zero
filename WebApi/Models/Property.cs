using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebApi.Models
{
    /// <summary>
    /// 属性
    /// </summary>
    [Serializable]
    [DataContract]
    public class Property
    {
        /// <summary>
        /// 属性编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        /// <value>The name of the property.</value>
        [DataMember]
        public string PropertyName{ get; set; }

        /// <summary>
        /// 是否隐私
        /// </summary>
        /// <value>The is privacy.</value>
        [DataMember]
        public int IsPrivacy{ get; set; }

        /// <summary>
        /// 控件类型
        /// </summary>
        /// <value>The type of the control.</value>
        [DataMember]
        public int ControlType{ get; set; }

        /// <summary>
        /// 是否可空
        /// </summary>
        /// <value>The alow null.</value>
        [DataMember]
        public int AlowNull{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>The create time.</value>
        [DataMember]
        public DateTime CreateTime{ get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        /// <value>The edit time.</value>
        [DataMember]
        public DateTime EditTime{ get; set; }
    }

    /// <summary>
    /// 属性添加
    /// </summary>
    [Serializable]
    [DataContract]
    public class PropertyAdd
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        /// <value>The name of the property.</value>
        [DataMember]
        public string PropertyName { get; set; }

        /// <summary>
        /// 是否隐私
        /// </summary>
        /// <value>The is privacy.</value>
        [DataMember]
        public int IsPrivacy { get; set; }

        /// <summary>
        /// 控件类型
        /// </summary>
        /// <value>The type of the control.</value>
        [DataMember]
        public int ControlType { get; set; }

        /// <summary>
        /// 是否可空
        /// </summary>
        /// <value>The alow null.</value>
        [DataMember]
        public int AlowNull { get; set; }

        /// <summary>
        /// 属性值集合
        /// </summary>
        /// <value>The property items.</value>
        [DataMember]
        public List<PropertyItem> PropertyItems { get; set; }
    }

    /// <summary>
    /// 属性值
    /// </summary>
    [Serializable]
    [DataContract]
    public class PropertyItem
    {
        /// <summary>
        /// 属性值
        /// </summary>
        /// <value>The value.</value>
        [DataMember]
        public string Value{ get; set; }
    }

    /// <summary>
    /// 属性编辑
    /// </summary>
    [Serializable]
    [DataContract]
    public class PropertyEdit
    {
        /// <summary>
        /// 属性编码
        /// </summary>
        /// <value>The sys no.</value>
        [DataMember]
        public int SysNo { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        /// <value>The name of the property.</value>
        [DataMember]
        public string PropertyName { get; set; }

        /// <summary>
        /// 是否隐私
        /// </summary>
        /// <value>The is privacy.</value>
        [DataMember]
        public int IsPrivacy { get; set; }

        /// <summary>
        /// 控件类型
        /// </summary>
        /// <value>The type of the control.</value>
        [DataMember]
        public int ControlType { get; set; }

        /// <summary>
        /// 是否可空
        /// </summary>
        /// <value>The alow null.</value>
        [DataMember]
        public int AlowNull { get; set; }

        /// <summary>
        /// 属性值集合
        /// </summary>
        /// <value>The property items.</value>
        [DataMember]
        public List<PropertyItem> PropertyItems { get; set; }
    }
}
