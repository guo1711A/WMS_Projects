using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WarehouseTBModel
	 {
		//WarehouseTBModel
		/// <summary>
		/// �ֿ�ID
		/// </summary>
		public Guid Warehouse_ID { get; set; }
		/// <summary>
		/// �ֿ���
		/// </summary>
		public string Warehouse_Num { get; set; }
		/// <summary>
		/// �ֿ�����
		/// </summary>
		public string Warehouse_Name { get; set; }
		/// <summary>
		/// �ֿ�����Id
		/// </summary>
		public string Warehouse_TypeID { get; set; }
		/// <summary>
		/// �ֿ��Ƿ����
		/// </summary>
		public string Warehouse_IsUse { get; set; }
		/// <summary>
		/// �ֿ��ַ
		/// </summary>
		public string Warehouse_Address { get; set; }
		/// <summary>
		/// �ֿ����
		/// </summary>
		public string Warehouse_Area { get; set; }
		/// <summary>
		/// �����ֿ�ʱ��
		/// </summary>
		public DateTime Warehouse_Ctime { get; set; }
		/// <summary>
		/// �ֿ⸺��������
		/// </summary>
		public string Warehouse_Manager { get; set; }
		/// <summary>
		/// �ֿ⸺������ϵ�绰
		/// </summary>
		public string Warehouse_ManagerPhone { get; set; }
		/// <summary>
		/// �ֿ����޽���ʱ��
		/// </summary>
		public DateTime Warehouse_Etime { get; set; }
		/// <summary>
		/// �ֿ�����ʱ��
		/// </summary>
		public string Warehouse_Time { get; set; }
		/// <summary>
		/// �ֿ���������ID
		/// </summary>
		public string Warehouse_DepartID { get; set; }
		/// <summary>
		/// �ֿ����޿�ʼʱ��
		/// </summary>
		public DateTime Warehouse_Btime { get; set; }
	}
}
