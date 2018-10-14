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
    public partial class AdminDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            double special = Convert.ToDouble(txtSpecial.Text);

            Web webObj = new Web();
            webObj.Title = title;
            webObj.Price = price;
            webObj.Special = special;

            Response.Write("<script>alert('Book Added Successfully');</script>");
            AdminGridView.DataSource = webObj.AddBookAdmin();
            AdminGridView.DataBind();

            
        }

        public void FillData()
        {
            Web webObj = new Web();

            AdminGridView.DataSource = webObj.DisplayBooks();
            AdminGridView.DataBind();
        }

        protected void AdminGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AdminGridView.PageIndex = e.NewPageIndex;
            this.FillData();
        }

        protected void AdminGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            AdminGridView.EditIndex = e.NewEditIndex;
            this.FillData();
        }

        protected void AdminGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            bool result;

            //string title = ((TextBox)AdminGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            //double price = Convert.ToDouble((TextBox)AdminGridView.Rows[e.RowIndex].Cells[2].Controls[0]);
            //double special = Convert.ToDouble((TextBox)AdminGridView.Rows[e.RowIndex].Cells[3].Controls[0]);

            Web webObj = new Web();
            webObj.Id = Convert.ToInt32(AdminGridView.Rows[e.RowIndex].Cells[0].Text);
            webObj.Title = ((TextBox)AdminGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            webObj.Price = Convert.ToSingle(((TextBox)AdminGridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            webObj.Special = Convert.ToSingle(((TextBox)AdminGridView.Rows[e.RowIndex].Cells[3].Controls[0]).Text);

            result = webObj.UpdateAdminBook();

            if (result == true) 
            {
                Response.Write("<script>alert('Book Details Updated Successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Details Not Updated');</script>");
            } 
        }

        protected void AdminGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            AdminGridView.EditIndex = -1;
            this.FillData();
        }

        protected void AdminGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection connectObj = new SqlConnection();
            connectObj = WebDbConnection.GetSqlConnection();
            connectObj.Open();

            int id = Convert.ToInt32(AdminGridView.DataKeys[e.RowIndex].Values["boo_id"].ToString());

            string deleteQuery = "delete from wms_books where boo_id=@id";

            SqlCommand cmdDelete = new SqlCommand(deleteQuery, connectObj);
            cmdDelete.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adapt = new SqlDataAdapter(cmdDelete);

            DataTable dt = new DataTable();
            adapt.Fill(dt);

            AdminGridView.DataSource = dt;
            AdminGridView.DataBind();
        }
    }
}