using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.BP.ActionBP;
namespace WebApi.Controllers
{
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
    }
}
