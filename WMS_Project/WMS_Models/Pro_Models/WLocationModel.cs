using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WLocationModel
	 {

		//WLocationModel
		/// <summary>
		/// 库位Id
		/// </summary>
		public Guid WLocation_ID { get; set; }
		/// <summary>
		/// 库位编号
		/// </summary>
		public string WLocation_Num { get; set; }
		/// <summary>
		/// 库位名称
		/// </summary>
		public string WLocation_Name { get; set; }
		/// <summary>
		/// 库位类型
		/// </summary>
		public string WLocation_TypeID { get; set; }
		/// <summary>
		/// 所属仓库
		/// </summary>
		public string WLocation_WID { get; set; }
		/// <summary>
		/// 是否禁用
		/// </summary>
		public string WLocation_IsUse { get; set; }
		/// <summary>
		/// 创建库位时间
		/// </summary>
		public DateTime WLocation_Ctime { get; set; }
		/// <summary>
		/// 转型后的创建库位时间
		/// </summary>
		public string WLocationCtime { get; set; }
	}
}
