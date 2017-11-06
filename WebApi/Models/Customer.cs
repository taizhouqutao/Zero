using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    /// <summary>
    /// 客户导入
    /// </summary>
    [Serializable]
    public class CustomerSave
    {
        /// <summary>
        /// 客户名称
        /// </summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户昵称
        /// </summary>
        /// <value>The name of the nick.</value>
        public string NickName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>The cellphone no.</value>
        public string CellphoneNo { get; set; }

        /// <summary>
        /// 第三方来源
        /// </summary>
        /// <value>The source sys no.</value>
        public string SourceSysNo { get; set; }
    }

    /// <summary>
    /// 客户设置属性
    /// </summary>
    [Serializable]
    public class CustomerSetProperty
    {
        /// <summary>
        /// 客户系统编码
        /// </summary>
        /// <value>The customer sys no.</value>
        public int CustomerSysNo { get; set; }

        /// <summary>
        /// 客户属性
        /// </summary>
        /// <value>The propertys.</value>
        public List<PropertySet> Propertys { get; set; }
    }

    /// <summary>
    /// 属性设置
    /// </summary>
    [Serializable]
    public class PropertySet
    {
        /// <summary>
        /// 属性系统编码
        /// </summary>
        /// <value>The property sys no.</value>
        public int PropertySysNo { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        /// <value>The property values.</value>
        public string PropertyValue { get; set; }
    }

}
