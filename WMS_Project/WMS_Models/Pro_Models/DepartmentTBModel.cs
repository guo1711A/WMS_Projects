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
		/// ��Id
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// ��������
		/// </summary>
		public string DepartmentName { get; set; }
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime CreateTime { get; set; }
	}
}
