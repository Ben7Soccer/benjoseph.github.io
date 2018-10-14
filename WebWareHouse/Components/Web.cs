using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebWareHouse.Components
{
    public class Web
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public double Special
        {
            get;
            set;
        }

        public DataTable DisplayBooks()
        {
            string selectQuery = "select * from wms_books";

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            data.Fill(dt);

            return dt;
        }

        public DataTable DisplayCartBooks()
        {
            string selectQuery = "select * from wms_cart";

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            data.Fill(dt);

            return dt;
        }

        public DataTable DeleteBook()
        {
            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string deleteQuery = "delete from wms_cart where car_id=@Id";

            SqlCommand cmdDelete = new SqlCommand(deleteQuery, connectObj);
            cmdDelete.Parameters.AddWithValue("@Id", Id);

            SqlDataAdapter adapt = new SqlDataAdapter(cmdDelete);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            return dt;
        }

        public bool InsertBook()
        {
            bool result;
            int rowsAffected = 0;

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string insertQuery = "insert into wms_cart(car_title,car_price,car_special) select boo_title,boo_price,boo_special from wms_books where boo_id=@Id";

            SqlCommand cmdInsert = new SqlCommand(insertQuery, connectObj);
            cmdInsert.Parameters.AddWithValue("@Id", Id);

            SqlDataAdapter adapt = new SqlDataAdapter(cmdInsert);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            rowsAffected = cmdInsert.ExecuteNonQuery();

            connectObj.Close();

            if (rowsAffected == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public DataTable BindDetailsView()
        {
            string selectQuery = "select boo_id AS Id,boo_title AS Title,boo_price AS Price,boo_special AS Special from wms_books where boo_id=@Id";

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);
            cmd.Parameters.AddWithValue("@Id", Id);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapt.Fill(dt);

            connectObj.Close();

            return dt;
        }

        public DataTable SearchBook()
        {
            string selectQuery = "select * from wms_books where boo_title=@Title";

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, connectObj);
            cmd.Parameters.AddWithValue("@Title", Title);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapt.Fill(dt);

            connectObj.Close();

            return dt;
        }

        public DataTable AddBookAdmin()
        {            
            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string insertQuery = "insert into wms_books(boo_title,boo_price,boo_special) values(@Title,@Price,@Special)";

            SqlCommand cmdInsert = new SqlCommand(insertQuery, connectObj);
            cmdInsert.Parameters.AddWithValue("@Title", Title);
            cmdInsert.Parameters.AddWithValue("@Price", Price);
            cmdInsert.Parameters.AddWithValue("@Special", Special);

            SqlDataAdapter adapt = new SqlDataAdapter(cmdInsert);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            return dt;
        }

        public bool UpdateAdminBook()
        {
            bool result;
            int rowsAffected = 0;

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string updateQuery = "update wms_books SET boo_title=@Title,boo_price=@Price,boo_Special=@Special where boo_id=@Id";

            SqlCommand cmdUpdate = new SqlCommand(updateQuery, connectObj);
            cmdUpdate.Parameters.AddWithValue("@Title", Title);
            cmdUpdate.Parameters.AddWithValue("@Price", Price);
            cmdUpdate.Parameters.AddWithValue("@Special", Special);
            cmdUpdate.Parameters.AddWithValue("Id", Id);
            
            rowsAffected = cmdUpdate.ExecuteNonQuery();

            if (rowsAffected > 0)
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