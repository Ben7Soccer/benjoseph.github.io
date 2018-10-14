using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWareHouse.Components;

namespace WebWareHouse.Layouts
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void lbtnDatabase_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(Session["Username"]);

            if (name == "Tom")
            {
                Response.Redirect("AdminDatabase.aspx");
            }
            else
            {
                Response.Redirect("DatabasePage.aspx");
            }
           
        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(Session["Username"]);

            if (name == "Tom")
            {
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
            
        }

        protected void lbtnShoppingCart_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(Session["Username"]);

            if (name == "Tom")
            {
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                Response.Redirect("ShoppingCartPage.aspx");
            }


            
        }

        protected void lbtnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            Response.Redirect("SearchPage.aspx?Title="+txtSearchBox.Text);
            /*string searchTitle = txtSearchBox.Text;

            Web webObj = new Web();
            webObj.Title = searchTitle;

            DataTable dt = new DataTable();
            dt = webObj.SearchBook();

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("SearchPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('No Such Book Found');</script>");
            }
            */

        }
    }
}