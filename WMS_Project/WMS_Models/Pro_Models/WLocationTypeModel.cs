using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WLocationTypeModel
	 {
		//WLocationModel
		/// <summary>
		/// 库位类型Id
		/// </summary>
		public Guid WLocationType_ID { get; set; }
		/// <summary>
		/// 库位类型名称
		/// </summary>
		public string WLocationType_Name { get; set; }

	}
}
