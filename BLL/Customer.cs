﻿using System;
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
		private readonly WebApi.DAL.Customer dal=new WebApi.DAL.Customer();
		public Customer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SysNo)
		{
			return dal.Exists(SysNo);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebApi.Model.Customer model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebApi.Model.Customer model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SysNo)
		{
			
			return dal.Delete(SysNo);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SysNolist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(SysNolist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebApi.Model.Customer GetModel(int SysNo)
		{
			
			return dal.GetModel(SysNo);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebApi.Model.Customer GetModelByCache(int SysNo)
		{
			
			string CacheKey = "CustomerModel-" + SysNo;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SysNo);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WebApi.Model.Customer)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebApi.Model.Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebApi.Model.Customer> DataTableToList(DataTable dt)
		{
			List<WebApi.Model.Customer> modelList = new List<WebApi.Model.Customer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebApi.Model.Customer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
