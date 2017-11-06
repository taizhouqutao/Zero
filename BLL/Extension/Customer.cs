using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WebApi.Model;
namespace WebApi.BLL
{
    /// <summary>
    /// Customer
    /// </summary>
    public partial class Customer
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddWithSysNo(WebApi.Model.Customer model)
        {
            return dal.AddWithSysNo(model);
        }
    }
}
