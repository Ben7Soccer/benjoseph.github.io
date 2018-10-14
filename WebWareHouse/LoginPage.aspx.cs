using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWareHouse.Components;

namespace WebWareHouse
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool result;
            User useObj = new User();
            useObj.Username = txtUsername.Text;
            useObj.Password = txtPassword.Text;

            Session["Username"] = txtUsername.Text;

            result = useObj.GetAccessibility();

            if (txtUsername.Text == "")
            {
                Response.Write("<script>alert('Please Enter The Username');</script>");
            }
            else if (txtPassword.Text == "")
            {
                Response.Write("<script>alert('Please Enter The Password');</script>");
            }
            else
            {
                if (result == true)
                {
                    Response.Redirect("HomePage.aspx");
                    //Session.RemoveAll();
                }
                else
                {
                    Response.Write("<script>alert('Please Check The Username Or Password');</script>");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool result;
            User useObj = new User();
            useObj.Username = txtUsername.Text;
            useObj.Password = txtPassword.Text;

            Session["Username"] = txtUsername.Text;

            result = useObj.GetAccessibilityAdmin();

            if (txtUsername.Text == "")
            {
                Response.Write("<script>alert('Please Enter The Username');</script>");
            }
            else if (txtPassword.Text == "")
            {
                Response.Write("<script>alert('Please Enter The Password');</script>");
            }
            else
            {
                if (result == true)
                {
                    Response.Redirect("AdminHome.aspx");                    
                }
                else
                {
                    Response.Write("<script>alert('Please Check The Username Or Password');</script>");
                }
            }
        }
    }
}
