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
		/// 
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

