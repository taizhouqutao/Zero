using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebApi.DAL
{
	/// <summary>
	/// 数据访问类:Customer
	/// </summary>
	public partial class Customer
	{
		public Customer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("SysNo", "T_Customer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SysNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Customer");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)			};
			parameters[0].Value = SysNo;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebApi.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Customer(");
			strSql.Append("SysNo,CustomerName,NickName,CellphoneNo,Status,CreateTime,EditTime,JsonString,SourceSysNo)");
			strSql.Append(" values (");
			strSql.Append("@SysNo,@CustomerName,@NickName,@CellphoneNo,@Status,@CreateTime,@EditTime,@JsonString,@SourceSysNo)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerName", MySqlDbType.VarChar,100),
					new MySqlParameter("@NickName", MySqlDbType.VarChar,100),
					new MySqlParameter("@CellphoneNo", MySqlDbType.VarChar,100),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@EditTime", MySqlDbType.DateTime),
					new MySqlParameter("@JsonString", MySqlDbType.Text),
					new MySqlParameter("@SourceSysNo", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.SysNo;
			parameters[1].Value = model.CustomerName;
			parameters[2].Value = model.NickName;
			parameters[3].Value = model.CellphoneNo;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.EditTime;
			parameters[7].Value = model.JsonString;
			parameters[8].Value = model.SourceSysNo;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebApi.Model.Customer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Customer set ");
			strSql.Append("CustomerName=@CustomerName,");
			strSql.Append("NickName=@NickName,");
			strSql.Append("CellphoneNo=@CellphoneNo,");
			strSql.Append("Status=@Status,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("EditTime=@EditTime,");
			strSql.Append("JsonString=@JsonString,");
			strSql.Append("SourceSysNo=@SourceSysNo");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CustomerName", MySqlDbType.VarChar,100),
					new MySqlParameter("@NickName", MySqlDbType.VarChar,100),
					new MySqlParameter("@CellphoneNo", MySqlDbType.VarChar,100),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@EditTime", MySqlDbType.DateTime),
					new MySqlParameter("@JsonString", MySqlDbType.Text),
					new MySqlParameter("@SourceSysNo", MySqlDbType.VarChar,100),
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)};
			parameters[0].Value = model.CustomerName;
			parameters[1].Value = model.NickName;
			parameters[2].Value = model.CellphoneNo;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.EditTime;
			parameters[6].Value = model.JsonString;
			parameters[7].Value = model.SourceSysNo;
			parameters[8].Value = model.SysNo;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SysNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Customer ");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)			};
			parameters[0].Value = SysNo;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string SysNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Customer ");
			strSql.Append(" where SysNo in ("+SysNolist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebApi.Model.Customer GetModel(int SysNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SysNo,CustomerName,NickName,CellphoneNo,Status,CreateTime,EditTime,JsonString,SourceSysNo from T_Customer ");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)			};
			parameters[0].Value = SysNo;

			WebApi.Model.Customer model=new WebApi.Model.Customer();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebApi.Model.Customer DataRowToModel(DataRow row)
		{
			WebApi.Model.Customer model=new WebApi.Model.Customer();
			if (row != null)
			{
				if(row["SysNo"]!=null && row["SysNo"].ToString()!="")
				{
					model.SysNo=int.Parse(row["SysNo"].ToString());
				}
				if(row["CustomerName"]!=null)
				{
					model.CustomerName=row["CustomerName"].ToString();
				}
				if(row["NickName"]!=null)
				{
					model.NickName=row["NickName"].ToString();
				}
				if(row["CellphoneNo"]!=null)
				{
					model.CellphoneNo=row["CellphoneNo"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["EditTime"]!=null && row["EditTime"].ToString()!="")
				{
					model.EditTime=DateTime.Parse(row["EditTime"].ToString());
				}
				if(row["JsonString"]!=null)
				{
					model.JsonString=row["JsonString"].ToString();
				}
				if(row["SourceSysNo"]!=null)
				{
					model.SourceSysNo=row["SourceSysNo"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SysNo,CustomerName,NickName,CellphoneNo,Status,CreateTime,EditTime,JsonString,SourceSysNo ");
			strSql.Append(" FROM T_Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_Customer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.SysNo desc");
			}
			strSql.Append(")AS Row, T.*  from T_Customer T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_Customer";
			parameters[1].Value = "SysNo";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

