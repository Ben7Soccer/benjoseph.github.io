using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWareHouse.Components;

namespace WebWareHouse
{
    public partial class DatabasePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public void FillData()
        {
            Web webObj = new Web();
            
            BookGridView.DataSource= webObj.DisplayBooks();
            BookGridView.DataBind();
        }

        protected void BookGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
        }

        protected void BookGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = BookGridView.SelectedValue.ToString();
            Response.Redirect("BookDetailsPage.aspx?name=" + name);            
        }

        protected void BookGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            BookGridView.PageIndex = e.NewPageIndex;
            this.FillData();
        }
    }
}