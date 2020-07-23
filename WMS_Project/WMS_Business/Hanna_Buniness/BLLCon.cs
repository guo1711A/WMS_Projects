using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WMS_Business.Hanna_Buniness
{
    public abstract class BLLCon
    {
        public static string con = "Data Source=192.168.43.236;Initial Catalog=WMSDB;User ID=sa;password=1234";
        public static IDbConnection GetSql()
        {
            IDbConnection connection = new SqlConnection(con);
            if (connection.State!=ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
