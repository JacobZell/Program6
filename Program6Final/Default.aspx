<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Program6Final.LoggedIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LoginView ID="LoginView1" runat="server">
                    <LoggedInTemplate>
                        <asp:Button ID="Button2" runat="server" Text="Change Password" />
                    </LoggedInTemplate>
                    <AnonymousTemplate>
                        Information for Anonymous Users.
                    </AnonymousTemplate>
                    <RoleGroups>
                        <asp:RoleGroup Roles="Admin">
                            <ContentTemplate>
                                This is for Admin.
                                <asp:Button ID="btnRole" runat="server" OnClick="btnRole_Click" Text="Role Management" />
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Change Password" />
                            </ContentTemplate>
                        </asp:RoleGroup>
                        <asp:RoleGroup Roles="Student">
                            <ContentTemplate>
                                This is for Cool People.
                            </ContentTemplate>
                        </asp:RoleGroup>
                    </RoleGroups>
                </asp:LoginView>
    </form>
</body>
</html>
