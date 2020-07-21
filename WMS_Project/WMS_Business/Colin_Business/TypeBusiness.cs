using System;
using System.Collections.Generic;
using System.Text;
using WMS_DataAccess.Colin_DataAccess;
using WMS_Models.Pro_Models;

namespace WMS_Business.Colin_Business
{
    public class TypeBusiness
    {
        SqlDbHelper dal = new SqlDbHelper();
        //添加
        public int Add<T>(T t) where T : class, new()
        {
            return dal.Add<T>(t);
        }
        //显示
        public List<T> Show<T>() where T : class, new()
        {
            return dal.Show<T>();
        }
 


    }
}
