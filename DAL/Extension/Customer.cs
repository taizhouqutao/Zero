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
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddWithSysNo(WebApi.Model.Customer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into T_Customer(");
            strSql.Append("CustomerName,NickName,CellphoneNo,Status,CreateTime,EditTime,JsonString,SourceSysNo)");
            strSql.Append(" values (");
            strSql.Append("@CustomerName,@NickName,@CellphoneNo,@Status,@CreateTime,@EditTime,@JsonString,@SourceSysNo)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@CustomerName", MySqlDbType.VarChar,100),
                    new MySqlParameter("@NickName", MySqlDbType.VarChar,100),
                    new MySqlParameter("@CellphoneNo", MySqlDbType.VarChar,100),
                    new MySqlParameter("@Status", MySqlDbType.Int32,11),
                    new MySqlParameter("@CreateTime", MySqlDbType.DateTime),
                    new MySqlParameter("@EditTime", MySqlDbType.DateTime),
                    new MySqlParameter("@JsonString", MySqlDbType.Text),
                    new MySqlParameter("@SourceSysNo", MySqlDbType.VarChar,100)};
            parameters[0].Value = model.CustomerName;
            parameters[1].Value = model.NickName;
            parameters[2].Value = model.CellphoneNo;
            parameters[3].Value = model.Status;
            parameters[4].Value = model.CreateTime;
            parameters[5].Value = model.EditTime;
            parameters[6].Value = model.JsonString;
            parameters[7].Value = model.SourceSysNo;

            int rows = DbHelperMySQL.ExecuteSqlWithSysNo(strSql.ToString(), parameters);
            return rows;
        }
    }
}
