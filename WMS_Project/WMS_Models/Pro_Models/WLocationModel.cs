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
		/// ��λId
		/// </summary>
		public Guid WLocation_ID { get; set; }
		/// <summary>
		/// ��λ���
		/// </summary>
		public string WLocation_Num { get; set; }
		/// <summary>
		/// ��λ����
		/// </summary>
		public string WLocation_Name { get; set; }
		/// <summary>
		/// ��λ����
		/// </summary>
		public string WLocation_TypeID { get; set; }
		/// <summary>
		/// �����ֿ�
		/// </summary>
		public string WLocation_WID { get; set; }
		/// <summary>
		/// �Ƿ����
		/// </summary>
		public string WLocation_IsUse { get; set; }
		/// <summary>
		/// ������λʱ��
		/// </summary>
		public DateTime WLocation_Ctime { get; set; }
		/// <summary>
		/// ת�ͺ�Ĵ�����λʱ��
		/// </summary>
		public string WLocationCtime { get; set; }
	}
}
