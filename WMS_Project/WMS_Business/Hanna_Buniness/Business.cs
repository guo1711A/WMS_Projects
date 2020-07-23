using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using WMS_Models;
using Dapper;

namespace WMS_Business.Hanna_Buniness
{
    public class Business
    {
        BusinessHelper helper = new BusinessHelper();
        //链接数据库字符串
        string con = "Data Source=192.168.43.236;Initial Catalog=WMSDB;User ID=sa;password=1234";
        /// <summary>
        /// 显示仓库管理信息
        /// 此model是全部信息组合model
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Hanna_Model.WarehouseTBModel> warehouseQuery()
        {
            return helper.Show<WMS_Models.Hanna_Model.WarehouseTBModel>().ToList();
        }
        public List<WMS_Models.Hanna_Model.WarehouseTBModel> warehouseShow()
        {
            using (SqlConnection connection=new SqlConnection(con))
            {
                connection.Open();
                string sql = $"select a.Warehouse_Num,a.Warehouse_Name,a.Warehouse_Ctime,b.WarehouseType_Name,c.DepartmentName,a.Warehouse_IsUse,a.Warehouse_Address,a.Warehouse_Area,a.Warehouse_Manager,a.Warehouse_ManagerPhone from WarehouseTB a join WarehouseType b on a.Warehouse_TypeID = b.WarehouseType_ID join DepartmentTB c on a.Warehouse_DepartID = c.Id";
                return connection.Query<WMS_Models.Hanna_Model.WarehouseTBModel>(sql).ToList();
            }
        }
        /// <summary>
        /// 仓库管理
        /// 部门下拉框绑定
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Pro_Models.DepartmentTBModel> departmentBind()
        {
                return helper.Show<WMS_Models.Pro_Models.DepartmentTBModel>().ToList();
        }
        /// <summary>
        /// 仓库管理
        /// 仓库类型下拉框绑定
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Pro_Models.WarehouseTypeModel> warehouseTypeBind()
        {
            return helper.Show<WMS_Models.Pro_Models.WarehouseTypeModel>().ToList();
        }
        /// <summary>
        /// 库位管理
        /// 仓库名称下拉框绑定
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Pro_Models.WarehouseTBModel> warehouseTBBind()
        {
            return helper.Show<WMS_Models.Pro_Models.WarehouseTBModel>().ToList();
        }
        /// <summary>
        /// 库位信息展示
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Hanna_Model.WLocationModel> locationShow()
        {
            using (SqlConnection connection=new SqlConnection(con))
            {
                connection.Open();
                string sql = $"select a.WLocation_Num,a.WLocation_Name,b.WLocationType_Name,c.Warehouse_Name,a.WLocation_IsUse,a.WLocation_Ctime from WLocation a join WLocationType b on a.WLocation_TypeID = b.WLocationType_ID join WarehouseTB c on a.WLocation_WID = c.Warehouse_ID";
                return connection.Query<WMS_Models.Hanna_Model.WLocationModel>(sql).ToList();
            }
        }

    }
}
