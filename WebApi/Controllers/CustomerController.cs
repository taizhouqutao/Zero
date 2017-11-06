using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
namespace WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        /// <summary>
        /// 保存第三方客户信息
        /// </summary>
        /// <returns>The customer.</returns>
        /// <param name="Customer">Customer.</param>
        [HttpPost]
        public int SaveCustomer(CustomerSave Customer)
        {
            return 1;
        }
    }
}
