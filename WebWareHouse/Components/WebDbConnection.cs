using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebWareHouse.Components
{
    public class WebDbConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            return conn;
        }
    }
}