using System;
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
    /// 钱包模块API接口
    /// </summary>
    public class MoneyController: ApiController
    {
        /// <summary>
        /// 获取客户钱包
        /// </summary>
        /// <returns>The money by customer.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<Money> GetMoneyByCustomer(QueryRequest<MoneyQuery> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 获取钱包流水
        /// </summary>
        /// <returns>The money logs.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<List<MoneyLog>> GetMoneyLogs(QueryRequest<MoneyLogQuery> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 获取钱包充值接口，返回微信/支付宝表单（支持微信公众号支付，支付宝H5支付）
        /// </summary>
        /// <returns>The money recharge URL.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<string> GetMoneyRechargeUrl(QueryRequest<MoneyRecharge> Moment)
        {
            throw new Exception("待实现");
        }
    }
}
