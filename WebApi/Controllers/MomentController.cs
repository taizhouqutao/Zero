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
    /// 朋友圈模块API接口
    /// </summary>
    public class MomentController : ApiController
    {
        /// <summary>
        /// 添加朋友圈
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse<int> AddMoment(ActionRequest<MomentAdd> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 点赞
        /// </summary>
        /// <returns>The moment good.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse SetMomentGood(ActionRequest<MomentSetGood> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 点赞
        /// </summary>
        /// <returns>The moment reply.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse SetMomentReply(ActionRequest<MomentSetReply> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 设置已读
        /// </summary>
        /// <returns>The moment read.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse SetMomentRead(ActionRequest<MomentSetRead> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 朋友圈删除
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse DelMoment(ActionRequest<MomentDel> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 朋友圈删除回复
        /// </summary>
        /// <returns>The moment reply.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public ActionResponse DelMomentReply(ActionRequest<MomentDelReply> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 获取朋友圈未读消息列表
        /// </summary>
        /// <returns>The moment.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<List<MomentCustomerDetail>> GetMomentUnReads(QueryRequest<MomentUnReadQuery> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 获取朋友圈列表
        /// </summary>
        /// <returns>The moments.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<List<Moment>> GetMoments(QueryRequest<MomentQuery> Moment)
        {
            throw new Exception("待实现");
        }

        /// <summary>
        /// 获取朋友圈详情
        /// </summary>
        /// <returns>The moments.</returns>
        /// <param name="Moment">Moment.</param>
        [HttpPost]
        public QueryResponse<Moment> GetMomentBySysNo(QueryRequest<MomentSysNo> Moment)
        {
            throw new Exception("待实现");
        }
    }
}
