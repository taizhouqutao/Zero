using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace WebApi.Models
{
    /// <summary>
    /// 操作请求参数
    /// </summary>
    [Serializable]
    [DataContract]
    public class ActionRequest<T>
    {
        /// <summary>
        /// AppKey
        /// </summary>
        /// <value>The app key.</value>
        [DataMember]
        public string AppKey { get; set; }

        /// <summary>
        /// AppToken
        /// </summary>
        /// <value>The app token.</value>
        [DataMember]
        public string AppToken { get; set; }

        /// <summary>
        /// Sign
        /// </summary>
        /// <value>The sign.</value>
        [DataMember]
        public string Sign { get; set; }

        /// <summary>
        /// 请求对象
        /// </summary>
        /// <value>The body.</value>
        [DataMember]
        public T Body { get; set; }
    }

    /// <summary>
    /// 操作返回结果
    /// </summary>
    [Serializable]
    [DataContract]
    public class ActionResponse<T>:Response
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        /// <value>The body.</value>
        [DataMember]
        public T Body { get; set; }

    }

    /// <summary>
    /// 返回信息基类
    /// </summary>
    [Serializable]
    [DataContract]
    public class Response
    {
        /// <summary>
        /// 是否有错
        /// </summary>
        /// <value><c>true</c> if has error; otherwise, <c>false</c>.</value>
        public bool HasError { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>The error desc.</value>
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        /// <value>The error code.</value>
        public int ErrorCode { get; set; }
    }
}
