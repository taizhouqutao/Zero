using System;
namespace WebApi.Model
{
	/// <summary>
	/// Customer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Customer
	{
		public Customer()
		{}
		#region Model
		private int _sysno;
		private string _customername;
		private string _nickname;
		private string _cellphoneno;
		private int? _status;
		private DateTime? _createtime;
		private DateTime? _edittime;
		private string _jsonstring;
		private string _sourcesysno;
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
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NickName
		{
			set{ _nickname=value;}
			get{return _nickname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CellphoneNo
		{
			set{ _cellphoneno=value;}
			get{return _cellphoneno;}
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
		/// <summary>
		/// 
		/// </summary>
		public string SourceSysNo
		{
			set{ _sourcesysno=value;}
			get{return _sourcesysno;}
		}
		#endregion Model

	}
}

