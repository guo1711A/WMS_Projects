using System;
using System.Collections.Generic;
using System.Text;

namespace WMS_Business.Hanna_Buniness
{
    public interface IBLL
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <typeparam name="T">模型名称</typeparam>
        /// <param name="t">model的别名</param>
        /// <returns></returns>
        int Add<T>(T t) where T : class, new();
        /// <summary>
        /// 显示
        /// </summary>
        /// <typeparam name="T">模型名称</typeparam>
        /// <returns></returns>
        List<T> Show<T>() where T : class, new();
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T">查询条件？？</typeparam>
        /// <typeparam name="M">模型名称</typeparam>
        /// <param name="sql"></param>
        /// <param name="m">模型</param>
        /// <returns></returns>
        List<T> Search<T, M>(string sql, M m) where T : class where M : class, new();
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        int Delete(string sql);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        int Update(string sql);
    }
}
