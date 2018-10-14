using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWareHouse.Components;

namespace WebWareHouse
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string title = Request.QueryString["Title"].ToString();

                Web webObj = new Web();
                webObj.Title = title;

                DataTable dt = new DataTable();
                dt= webObj.SearchBook();

                if (dt.Rows.Count > 0)
                {
                    GridViewSearch.DataSource = webObj.SearchBook();
                    GridViewSearch.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('No Such Book Found');</script>");
                }
                
            }
        }
    }
}