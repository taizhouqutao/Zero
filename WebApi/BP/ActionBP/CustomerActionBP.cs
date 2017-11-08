using System;
using System.Linq;
using Maticsoft.Common;
using WebApi.Models;

namespace WebApi.BP.ActionBP
{
    public class CustomerActionBP
    {
        private static BLL.Customer bllcustomer = new BLL.Customer();
        public static int SaveCustomer(ActionRequest<CustomerSave> Data)
        {
            if (string.IsNullOrEmpty(Data.Body.SourceSysNo)) throw new Exception("SourceSysNo不能为空");
            var Model = bllcustomer.GetModelList(string.Format("SourceSysNo='{0}'", PageValidate.SqlTextClear(Data.Body.SourceSysNo))).FirstOrDefault();
            if (Model == null)
            {
                return bllcustomer.AddWithSysNo(new WebApi.Model.Customer()
                {
                    CellphoneNo = Data.Body.CellphoneNo ?? "",
                    CreateTime = DateTime.Now,
                    CustomerName = Data.Body.CustomerName ?? "",
                    SourceSysNo = PageValidate.SqlTextClear(Data.Body.SourceSysNo),
                    EditTime = DateTime.Now,
                    NickName = Data.Body.NickName ?? "",
                    JsonString = "",
                    Status = 1, 
                });
            }
            else
            {
                Model.CellphoneNo = Data.Body.CellphoneNo ?? "";
                Model.CustomerName = Data.Body.CustomerName ?? "";
                Model.NickName = Data.Body.NickName ?? "";
                Model.EditTime = DateTime.Now;
                bllcustomer.Update(Model);
                return Model.SysNo;
            }
        }
    }
}
