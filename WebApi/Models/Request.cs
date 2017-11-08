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
        [DataMember]
        public bool HasError { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>The error desc.</value>
        [DataMember]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        /// <value>The error code.</value>
        [DataMember]
        public int ErrorCode { get; set; }
    }

    /// <summary>
    /// 查询请求参数
    /// </summary>
    [Serializable]
    [DataContract]
    public class QueryRequest<T>
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

        /// <summary>
        /// 分页信息
        /// </summary>
        /// <value>The page.</value>
        [DataMember]
        public RequestPage Page{ get; set; }

        /// <summary>
        /// 请求排序
        /// </summary>
        /// <value>The sorts.</value>
        [DataMember]
        public List<Sort> Sorts { get; set; }
    }

    /// <summary>
    /// 查询返回结果
    /// </summary>
    [Serializable]
    [DataContract]
    public class QueryResponse<T>:Response
    {
        /// <summary>
        /// 返回对象
        /// </summary>
        /// <value>The body.</value>
        [DataMember]
        public T Body { get; set; }

        /// <summary>
        /// 返回分页信息
        /// </summary>
        /// <value>The page.</value>
        [DataMember]
        public ResponsePage Page { get; set; }
    }

    /// <summary>
    /// 请求分页信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class RequestPage{
        /// <summary>
        /// 每页大小
        /// </summary>
        /// <value>The size of the page.</value>
        [DataMember]
        public int PageSize { get; set; }

        /// <summary>
        /// 请求页码
        /// </summary>
        /// <value>The index of the page.</value>
        [DataMember]
        public int PageIndex { get; set; }
    }

    /// <summary>
    /// 返回分页信息
    /// </summary>
    [Serializable]
    [DataContract]
    public class ResponsePage
    {
        /// <summary>
        /// 每页大小
        /// </summary>
        /// <value>The size of the page.</value>
        [DataMember]
        public int PageSize { get; set; }

        /// <summary>
        /// 请求页码
        /// </summary>
        /// <value>The index of the page.</value>
        [DataMember]
        public int PageIndex { get; set; }

        /// <summary>
        /// 总共数量
        /// </summary>
        /// <value>The total count.</value>
        [DataMember]
        public int TotalCount { get; set; }
    }

    /// <summary>
    /// 请求排序
    /// </summary>
    [Serializable]
    [DataContract]
    public class Sort
    {
        /// <summary>
        /// 是否倒序
        /// </summary>
        /// <value><c>true</c> if is desc; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool IsDesc { get; set; }

        /// <summary>
        /// 排序字段名称
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name { get; set; }
    }
}
