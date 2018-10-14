using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebWareHouse.Components
{
    public class User
    {
        public int Id
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool GetAccessibility()
        {
            bool result;
            int rowsAffected = 0;

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string selectQuery = "select * from wms_login where log_username=@username AND log_password=@password";

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            rowsAffected = cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool GetAccessibilityAdmin()
        {
            bool result;
            int rowsAffected = 0;

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string selectQuery = "select * from wms_adminlogin where adm_name=@username AND adm_password=@password";

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);
            cmd.Parameters.AddWithValue("@username", Username);
            cmd.Parameters.AddWithValue("@password", Password);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            rowsAffected = cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}