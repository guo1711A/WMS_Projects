using System;
using System.Collections.Generic;
using System.Text;
using WMS_Models;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace WMS_Business.Hanna_Buniness
{
    public class BusinessHelper:IBLL
    {
        public IDbConnection con = BLLCon.GetSql();
        /// <summary>
        /// 添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add<T>(T t) where T : class, new()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete<T>(T t) where T : class, new()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Deletes(string sql)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="sql"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public List<T> Search<T, M>(string sql, M m)
            where T : class
            where M : class, new()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> Show<T>() where T : class, new()
        {
            Type type = typeof(T);
            //SQL语句
            string sql = "";
            //表名
            string TableName = "";
            TableName = type.Name.Replace("Model", "");
            sql = $"select * from {TableName}";
            return con.Query<T>(sql).ToList();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update<T>(T t) where T : class, new()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Updates(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
