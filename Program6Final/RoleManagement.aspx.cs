using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Program6Final
{
    public partial class RoleManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListBoxDataBind();
                DropDownListDataBind();
            }
            GridViewDataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(txtAddRole.Text.ToString());
            ListBoxDataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void ListBoxDataBind()
        {
            ListBox1.DataSource = Roles.GetAllRoles();
            ListBox1.DataBind();
        }

        protected void DropDownListDataBind()
        {
            DropDownList1.DataSource = Membership.GetAllUsers();
            DropDownList1.DataBind();
        }
        protected void GridViewDataBind()
        {
            GridView1.DataSource = Membership.GetAllUsers();
            GridView1.DataBind();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected == true)
                {
                    Roles.DeleteRole(li.ToString());
                }
            }
            ListBoxDataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(DropDownList1.SelectedValue,
               ListBox1.SelectedValue);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Roles.RemoveUserFromRole(DropDownList1.SelectedValue,
                ListBox1.SelectedValue);
        }
    }
}