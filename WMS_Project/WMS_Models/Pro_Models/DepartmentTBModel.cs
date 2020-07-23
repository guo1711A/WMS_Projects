using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class DepartmentTBModel
	 {
		//DepartmentTBModel
		/// <summary>
		/// 表Id
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// 部门名称
		/// </summary>
		public string DepartmentName { get; set; }
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime { get; set; }
	}
}
