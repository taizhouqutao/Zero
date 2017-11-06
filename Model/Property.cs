/**  版本信息模板在安装目录下，可自行修改。
* Property.cs
*
* 功 能： N/A
* 类 名： Property
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/11/6 23:31:21   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace WebApi.Model
{
	/// <summary>
	/// Property:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Property
	{
		public Property()
		{}
		#region Model
		private int _sysno;
		private string _propertyname;
		private int? _propertytype;
		private int? _isprivacy;
		private int? _controltype;
		private int? _alownull;
		private int? _status;
		private DateTime? _createtime;
		private DateTime? _edittime;
		private string _jsonstring;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int SysNo
		{
			set{ _sysno=value;}
			get{return _sysno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PropertyName
		{
			set{ _propertyname=value;}
			get{return _propertyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PropertyType
		{
			set{ _propertytype=value;}
			get{return _propertytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsPrivacy
		{
			set{ _isprivacy=value;}
			get{return _isprivacy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ControlType
		{
			set{ _controltype=value;}
			get{return _controltype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AlowNull
		{
			set{ _alownull=value;}
			get{return _alownull;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EditTime
		{
			set{ _edittime=value;}
			get{return _edittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JsonString
		{
			set{ _jsonstring=value;}
			get{return _jsonstring;}
		}
		#endregion Model

	}
}

