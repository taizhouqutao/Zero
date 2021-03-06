﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.BP.ActionBP;
using WebApi.BP.QueryBP;

namespace WebApi.Controllers
{
    /// <summary>
    /// 客户模块API接口
    /// </summary>
    public class CustomerController : ApiController
    {

        /// <summary>
        /// 保存第三方客户信息
        /// </summary>
        /// <returns>客户系统编码</returns>
        /// <param name="Customer">客户导入实体</param>
        [HttpPost]
        public ActionResponse<int> SaveCustomer(ActionRequest<CustomerSave> Customer)
        {
            ActionResponse<int> result = new ActionResponse<int>();
            try
            {
                result.Body = CustomerActionBP.SaveCustomer(Customer);
            }
            catch(Exception ex){
                result.HasError = true;
                result.ErrorDesc = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 设置客户属性
        /// </summary>
        /// <returns>The customer property.</returns>
        /// <param name="Customer">Customer.</param>
        [HttpPost]
        public ActionResponse SetCustomerProperty(ActionRequest<CustomerSetProperty> Customer)
        {
            ActionResponse result = new ActionResponse();
            try
            {
                CustomerActionBP.SetCustomerProperty(Customer);
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ErrorDesc = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 属性添加（客户）
        /// </summary>
        /// <returns>The customer property.</returns>
        /// <param name="Property">Property.</param>
        [HttpPost]
        public ActionResponse AddProperty(ActionRequest<PropertyAdd> Property)
        {
            ActionResponse result = new ActionResponse();
            try
            {
                CustomerActionBP.AddProperty(Property);
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ErrorDesc = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 属性编辑（客户）
        /// </summary>
        /// <returns>The property.</returns>
        /// <param name="Property">Property.</param>
        [HttpPost]
        public ActionResponse EditProperty(ActionRequest<PropertyEdit> Property)
        {
            ActionResponse result = new ActionResponse();
            try
            {
                CustomerActionBP.EditProperty(Property);
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ErrorDesc = ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 获取属性列表（客户）
        /// </summary>
        /// <returns>属性列表（客户）</returns>
        /// <param name="Query">Query.</param>
        [HttpPost]
        public QueryResponse<List<Property>> GetPropertys(QueryRequest Query)
        {
            QueryResponse<List<Property>> result = new QueryResponse<List<Property>>();
            try
            {
                ResponsePage Paging;
                result.Body=CustomerQueryBP.GetPropertys(Query,out Paging);
                result.Page = Paging;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ErrorDesc = ex.Message;
            }
            return result;
        }
    }
}
