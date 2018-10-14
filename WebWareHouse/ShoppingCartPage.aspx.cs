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
    public partial class ShoppingCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        public void FillData()
        {
            Web webObj = new Web();

            GridViewShoppingCart.DataSource = webObj.DisplayCartBooks();
            GridViewShoppingCart.DataBind();
        }

        protected void GridViewShoppingCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string idValue = GridViewShoppingCart.DataKeys[e.RowIndex].Value.ToString();
            int id = Convert.ToInt32(idValue);

            Web webObj = new Web();
            webObj.Id = id;

            GridViewShoppingCart.DataSource = webObj.DeleteBook();
            GridViewShoppingCart.DataBind();
        }
    }
}