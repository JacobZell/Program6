using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Program6Final
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(Login1.UserName.Trim(), Login1.Password.Trim()))
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName.Trim(), false);
                Label1.Visible = true;
                Label1.Text = "You are logged on.";
            }
            else
            {
                MembershipUser user = Membership.GetUser(Login1.UserName.Trim());
                Label1.Visible = true;
                Label1.Text = "Locked out value:" + user.IsLockedOut.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}