using System;
using System.Collections.Generic;
using System.Text;

namespace WMS_Models.Hanna_Model
{
    public class WLocationModel
	{       
		//WarehouseTBModel
		/// <summary>
		/// 仓库ID
		/// </summary>
		//public Guid Warehouse_ID { get; set; }
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string Warehouse_Num { get; set; }
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string Warehouse_Name { get; set; }
		/// <summary>
		/// 仓库类型Id
		/// </summary>
		public string Warehouse_TypeID { get; set; }
		/// <summary>
		/// 仓库是否禁用
		/// </summary>
		public string Warehouse_IsUse { get; set; }
		/// <summary>
		/// 仓库地址
		/// </summary>
		public string Warehouse_Address { get; set; }
		/// <summary>
		/// 仓库面积
		/// </summary>
		public string Warehouse_Area { get; set; }
		/// <summary>
		/// 创建仓库时间
		/// </summary>
		public DateTime Warehouse_Ctime { get; set; }
		/// <summary>
		/// 仓库负责人名称
		/// </summary>
		public string Warehouse_Manager { get; set; }
		/// <summary>
		/// 仓库负责人联系电话
		/// </summary>
		public string Warehouse_ManagerPhone { get; set; }
		/// <summary>
		/// 仓库租赁结束时间
		/// </summary>
		public DateTime Warehouse_Etime { get; set; }
		/// <summary>
		/// 仓库租赁时间
		/// </summary>
		public string Warehouse_Time { get; set; }
		/// <summary>
		/// 仓库所属部门ID
		/// </summary>
		public string Warehouse_DepartID { get; set; }
		/// <summary>
		/// 仓库租赁开始时间
		/// </summary>
		public DateTime Warehouse_Btime { get; set; }



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



		//WLocationModel
		/// <summary>
		/// 库位类型Id
		/// </summary>
		//public Guid WLocationType_ID { get; set; }
		/// <summary>
		/// 库位类型名称
		/// </summary>
		public string WLocationType_Name { get; set; }

	}
}
