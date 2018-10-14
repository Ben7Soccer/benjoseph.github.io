using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWareHouse.Components;

namespace WebWareHouse
{
    public partial class BookDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!IsPostBack) 
            {
                BindDetailsView();
            }
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        public void BindDetailsView()
        {
            string idValue = Request.QueryString["name"];
            int id = Convert.ToInt32(idValue);

            Web webObj = new Web();
            webObj.Id = id;

            DetailsViewBook.DataSource = webObj.BindDetailsView();
            DetailsViewBook.DataBind();

        }

        protected void DetailsViewBook_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void DetailsViewBook_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
        {

        }

        protected void DetailsViewBook_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            string idValue = Request.QueryString["name"];
            int id = Convert.ToInt32(idValue);
            //int rowsAffected = 0;

            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            string insertQuery = "insert into wms_cart(car_title,car_price,car_special) select boo_title,boo_price,boo_special from wms_books where boo_id=@Id";

            SqlCommand cmdInsert = new SqlCommand(insertQuery, connectObj);
            cmdInsert.Parameters.AddWithValue("@Id", id);

            SqlDataAdapter adapt = new SqlDataAdapter(cmdInsert);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

           /*rowsAffected = cmdInsert.ExecuteNonQuery();

            connectObj.Close();

            if (rowsAffected > 0) 
            {
                lblAddedMessage.Text = "Book Added To Cart";
            }
            else
            {
                lblAddedMessage.Text = "Book Not Added";
            }*/

            /*bool result;
            string idValue = Request.QueryString["name"];
            int id = Convert.ToInt32(idValue);

            Web webObj = new Web();
            webObj.Id = id;

            result = webObj.InsertBook();

            if (result == true)
            {
                ScriptManager.RegisterStartupScript(this, GetType(),"ServerControlScript", "alert(\"Book Added To Cart\");", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", "alert(\"Book Not Added\");", true);
            }    */
        }
    }
}