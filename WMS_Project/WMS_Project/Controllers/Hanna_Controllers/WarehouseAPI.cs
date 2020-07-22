using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS_Models;
using WMS_Business;

namespace WMS_Project.Controllers.Hanna_Controllers
{
    [Route("api")]
    [ApiController]
    public class WarehouseAPI : ControllerBase
    {
        /// <summary>
        /// 实例化bll
        /// </summary>
        WMS_Business.Hanna_Buniness.Business business = new WMS_Business.Hanna_Buniness.Business();
        /// <summary>
        /// 仓库管理信息
        /// </summary>
        /// <returns></returns>
        [Route("whshowall")]
        [HttpGet]
        public List<WMS_Models.Hanna_Model.WarehouseTBModel> WarehouseShowAll()
        {
            return business.warehouseShow();
        }
        /// <summary>
        /// 仓库管理
        /// 部门下拉框绑定
        /// </summary>
        /// <returns></returns>
        [Route("waredepbind")]
        [HttpGet]
        public List<WMS_Models.Pro_Models.DepartmentTBModel> departmentBind()
        {
            return business.departmentBind();
        }
        /// <summary>
        /// 仓库管理
        /// 部门下拉框绑定
        /// </summary>
        /// <returns></returns>
        [Route("wlshowall")]
        [HttpGet]
        public List<WMS_Models.Hanna_Model.WLocationModel> departmentTBShow()
        {
            return business.locationShow();
        }

    }
}
