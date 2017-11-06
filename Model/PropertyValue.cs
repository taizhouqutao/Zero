using System;
namespace WebApi.Model
{
	/// <summary>
	/// PropertyValue:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PropertyValue
	{
		public PropertyValue()
		{}
		#region Model
		private int _sysno;
		private int? _propertysysno;
		private string _value;
		private int? _status;
		private DateTime? _createtime;
		private DateTime? _edittime;
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
		public int? PropertySysNo
		{
			set{ _propertysysno=value;}
			get{return _propertysysno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Value
		{
			set{ _value=value;}
			get{return _value;}
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
		#endregion Model

	}
}

