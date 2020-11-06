<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleManagement.aspx.cs" Inherits="Program6Final.RoleManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Role Manager</h1>
        <asp:ListBox ID="ListBox1" Runat="server" Width="208px">
        </asp:ListBox>
        <br />
        <asp:Button ID="btnAddRole" Runat="server" Text="Add Role" 
            OnClick="Button1_Click" Width="79px" />
        <asp:TextBox ID="txtAddRole" Runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDeleteRole" Runat="server" Text="Delete Role" 
            OnClick="DeleteButton_Click" Width="77px" />
        <br />
        <br />
        <br />
        <br />

        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>

        <br />
        <asp:Button ID="btnAddUser" runat="server" Text="Add User to Role" OnClick="Button3_Click" />
        <asp:Button ID="btnDeleteUser" runat="server" Text="Delete User from Role" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
    </form>
</body>
</html>
