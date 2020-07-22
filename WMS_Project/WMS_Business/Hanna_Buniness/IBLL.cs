using System;
using System.Collections.Generic;
using System.Text;

namespace WMS_Business.Hanna_Buniness
{
    public interface IBLL
    {
        //添加
        int Add<T>(T t) where T : class, new();
        //显示
        List<T> Show<T>() where T : class, new();
        //查询
        List<T> Search<T, M>(string sql, M m) where T : class where M : class, new();
        //删除
        int Deletes(string sql);
        //修改
        int Updates(string sql);
        int Delete<T>(T t) where T : class, new();
        int Update<T>(T t) where T : class, new();

    }
}
