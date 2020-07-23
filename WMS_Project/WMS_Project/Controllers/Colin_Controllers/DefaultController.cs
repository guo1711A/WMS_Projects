﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WMS_Business.Colin_Business;
using WMS_DataAccess.Colin_DataAccess;
using WMS_Models.Pro_Models;

namespace WMS_Project.Controllers.Colin_Controllers
{
    //api/default/CPShow 
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        TypeBusiness bll = new TypeBusiness(); 
        //显示类别
        [HttpGet]
        public List<ProductTypeModel> LBShow()
        {
            return bll.Show<ProductTypeModel>();
        }
        //显示规格
        [HttpGet] 
        public List<SpecificationModel> GGShow()
        {
            return bll.Show<SpecificationModel>();
        }
        //显示存储单位
        [HttpGet]
        public List<UnitStorageModel> CCShow()
        {
            return bll.Show<UnitStorageModel>();
        }
        //显示产品包装
        [HttpGet]
        public List<PackagingTypeModel> BZShow()
        {
            return bll.Show<PackagingTypeModel>();
        }
        //显示状态
        [HttpGet]
        public List<StateModel> ZTShow()
        {
            return bll.Show<StateModel>();
        }
        //显示仓库
        [HttpGet]
        public List<JlibraryModel> CKShow()
        {
            return bll.Show<JlibraryModel>();
        }
        //显示产品表
        [HttpGet]
        public List<ProductsTBModel> CPShow()
        { 
            return bll.Show<ProductsTBModel>();
        }   
        //产品表分页
        [HttpGet]
        public ActionResult<ProductsTBModel> Pager(int PageSize, int PageIndex)
        {
            IDbConnection db = AbstrtionDAL.GetSql();
            var param = new DynamicParameters();
            param.Add("@TabeName", "ProductsTB");
            param.Add("@FileName", "*");
            param.Add("@Orderby", "Prid");
            param.Add("@where", "");
            param.Add("@PageSize", PageSize);
            param.Add("@PageIndex", PageIndex);
            int total = 0;
            param.Add("@TableCount", 0, DbType.Int32, ParameterDirection.Output);
            //  db.Query<List<StudentModels>>("Proc_Pager",)
            var res2 = db.Query<ProductsTBModel>("FenYe", param, null, true, null, CommandType.StoredProcedure).ToList();//res2.Count = 80
            total = param.Get<int>("@TableCount");  //Execute count = 80
            return Ok(new { data = res2, total = total });
        }
        //删除产品表
        [HttpPost]
        public int Delete(ProductsTBModel id)
        {
            return bll.Delete(id);
        }
        //添加产品表
        [HttpPost]
        public int Add(ProductsTBModel m)
        {
            return bll.Add(m);
        } 
        



        ////修改
        //[HttpPost]
        //public int Update(UserInfoModel m)
        //{
        //    return bll.Upt(m);
        //}
        ////修改反填
        //[HttpGet]
        //public UserInfoModel UpdateShow(string m)
        //{
        //    return bll.UptShow(m);
        //}
    }
}