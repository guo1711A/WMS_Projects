using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WarehouseTypeModel
	 {
		//WarehouseTypeModel
		/// <summary>
		/// 仓库类型Id
		/// </summary>
		public Guid WarehouseType_ID { get; set; }
		/// <summary>
		/// 仓库类型名称
		/// </summary>
		public string WarehouseType_Name { get; set; }
	}
}
