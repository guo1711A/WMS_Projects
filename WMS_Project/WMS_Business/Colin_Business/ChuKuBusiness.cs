using System;
using System.Collections.Generic;
using System.Text;
using WMS_DataAccess.Colin_DataAccess;
using WMS_Models.Pro_Models;

namespace WMS_Business.Colin_Business
{
    public class ChuKuBusiness:TypeBusiness
    {
        SqlDbHelper sqlDb = new SqlDbHelper();
        //添加
        //public int Insert(PutStorageModel m,List<PutStorageModel> res)
        //{
        //    int sql = sqlDb.Add(m);
        //    foreach (var item in res)
        //    {
        //        sql += sqlDb.Add(item);
        //    } 
        //    return sql;
        //}


    }
}
