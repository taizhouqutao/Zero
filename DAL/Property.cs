using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebApi.DAL
{
	/// <summary>
	/// 数据访问类:Property
	/// </summary>
	public partial class Property
	{
		public Property()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("SysNo", "T_Property"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SysNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Property");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)			};
			parameters[0].Value = SysNo;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebApi.Model.Property model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Property(");
			strSql.Append("SysNo,PropertyName,PropertyType,IsPrivacy,ControlType,AlowNull,Status,CreateTime,EditTime,JsonString)");
			strSql.Append(" values (");
			strSql.Append("@SysNo,@PropertyName,@PropertyType,@IsPrivacy,@ControlType,@AlowNull,@Status,@CreateTime,@EditTime,@JsonString)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11),
					new MySqlParameter("@PropertyName", MySqlDbType.VarChar,100),
					new MySqlParameter("@PropertyType", MySqlDbType.Int32,11),
					new MySqlParameter("@IsPrivacy", MySqlDbType.Int32,11),
					new MySqlParameter("@ControlType", MySqlDbType.Int32,11),
					new MySqlParameter("@AlowNull", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@EditTime", MySqlDbType.DateTime),
					new MySqlParameter("@JsonString", MySqlDbType.Text)};
			parameters[0].Value = model.SysNo;
			parameters[1].Value = model.PropertyName;
			parameters[2].Value = model.PropertyType;
			parameters[3].Value = model.IsPrivacy;
			parameters[4].Value = model.ControlType;
			parameters[5].Value = model.AlowNull;
			parameters[6].Value = model.Status;
			parameters[7].Value = model.CreateTime;
			parameters[8].Value = model.EditTime;
			parameters[9].Value = model.JsonString;

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
		public bool Update(WebApi.Model.Property model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Property set ");
			strSql.Append("PropertyName=@PropertyName,");
			strSql.Append("PropertyType=@PropertyType,");
			strSql.Append("IsPrivacy=@IsPrivacy,");
			strSql.Append("ControlType=@ControlType,");
			strSql.Append("AlowNull=@AlowNull,");
			strSql.Append("Status=@Status,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("EditTime=@EditTime,");
			strSql.Append("JsonString=@JsonString");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PropertyName", MySqlDbType.VarChar,100),
					new MySqlParameter("@PropertyType", MySqlDbType.Int32,11),
					new MySqlParameter("@IsPrivacy", MySqlDbType.Int32,11),
					new MySqlParameter("@ControlType", MySqlDbType.Int32,11),
					new MySqlParameter("@AlowNull", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
					new MySqlParameter("@EditTime", MySqlDbType.DateTime),
					new MySqlParameter("@JsonString", MySqlDbType.Text),
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)};
			parameters[0].Value = model.PropertyName;
			parameters[1].Value = model.PropertyType;
			parameters[2].Value = model.IsPrivacy;
			parameters[3].Value = model.ControlType;
			parameters[4].Value = model.AlowNull;
			parameters[5].Value = model.Status;
			parameters[6].Value = model.CreateTime;
			parameters[7].Value = model.EditTime;
			parameters[8].Value = model.JsonString;
			parameters[9].Value = model.SysNo;

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
			strSql.Append("delete from T_Property ");
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
			strSql.Append("delete from T_Property ");
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
		public WebApi.Model.Property GetModel(int SysNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SysNo,PropertyName,PropertyType,IsPrivacy,ControlType,AlowNull,Status,CreateTime,EditTime,JsonString from T_Property ");
			strSql.Append(" where SysNo=@SysNo ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@SysNo", MySqlDbType.Int32,11)			};
			parameters[0].Value = SysNo;

			WebApi.Model.Property model=new WebApi.Model.Property();
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
		public WebApi.Model.Property DataRowToModel(DataRow row)
		{
			WebApi.Model.Property model=new WebApi.Model.Property();
			if (row != null)
			{
				if(row["SysNo"]!=null && row["SysNo"].ToString()!="")
				{
					model.SysNo=int.Parse(row["SysNo"].ToString());
				}
				if(row["PropertyName"]!=null)
				{
					model.PropertyName=row["PropertyName"].ToString();
				}
				if(row["PropertyType"]!=null && row["PropertyType"].ToString()!="")
				{
					model.PropertyType=int.Parse(row["PropertyType"].ToString());
				}
				if(row["IsPrivacy"]!=null && row["IsPrivacy"].ToString()!="")
				{
					model.IsPrivacy=int.Parse(row["IsPrivacy"].ToString());
				}
				if(row["ControlType"]!=null && row["ControlType"].ToString()!="")
				{
					model.ControlType=int.Parse(row["ControlType"].ToString());
				}
				if(row["AlowNull"]!=null && row["AlowNull"].ToString()!="")
				{
					model.AlowNull=int.Parse(row["AlowNull"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SysNo,PropertyName,PropertyType,IsPrivacy,ControlType,AlowNull,Status,CreateTime,EditTime,JsonString ");
			strSql.Append(" FROM T_Property ");
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
			strSql.Append("select count(1) FROM T_Property ");
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
			strSql.Append(")AS Row, T.*  from T_Property T ");
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
			parameters[0].Value = "T_Property";
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

