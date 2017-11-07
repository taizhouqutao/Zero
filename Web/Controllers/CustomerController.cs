using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Maticsoft.Common;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        BLL.Customer bllcustomer = new BLL.Customer();
        /// <summary>
        /// 保存第三方客户信息
        /// </summary>
        /// <returns>客户系统编码</returns>
        /// <param name="Customer">客户导入实体</param>
        [HttpPost]
        public int SaveCustomer(CustomerSave Customer)
        {
            if (string.IsNullOrEmpty(Customer.SourceSysNo)) throw new Exception("SourceSysNo不能为空");
            var Model = bllcustomer.GetModelList(string.Format("SourceSysNo='{0}'", PageValidate.SqlTextClear(Customer.SourceSysNo))).FirstOrDefault();
            if (Model == null)
            {
                return bllcustomer.AddWithSysNo(new WebApi.Model.Customer()
                {
                    CellphoneNo = Customer.CellphoneNo ?? "",
                    CreateTime = DateTime.Now,
                    CustomerName = Customer.CustomerName ?? "",
                    SourceSysNo = Customer.SourceSysNo ?? "",
                    EditTime = DateTime.Now,
                    NickName = Customer.NickName ?? "",
                    JsonString = "",
                    Status = 1,
                });
            }
            else
            {
                Model.CellphoneNo = Customer.CellphoneNo ?? "";
                Model.CustomerName = Customer.CustomerName ?? "";
                Model.NickName = Customer.NickName ?? "";
                Model.EditTime = DateTime.Now;
                bllcustomer.Update(Model);
                return Model.SysNo;
            }
        }
    }
}
