using System;
using System.Collections.Generic;
using System.Text;

namespace WMS_DataAccess.Colin_DataAccess
{
    public interface  IDA
    {
        //添加
        int Add<T>(T t) where T : class, new();
        //显示
        List<T> Show<T>(string sql) where T : class, new();
        //查询
        List<T> Search<T, M>(string sql, M m) where T : class where M : class, new();
        //删除
        int Delete(string sql);
        //修改
        int Update(string sql);
    }
}
