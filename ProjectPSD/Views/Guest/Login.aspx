<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectPSD.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <div class="" style="width: 48rem; border: 1px solid black; display: flex; flex-direction: row">
         <form id="formLogin" runat="server">
            <div style="justify-content: center; align-items: center">
                <h1>Login</h1>
                <div>
                    <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
                    <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
                </div>
                <div>
                     <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                     <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                    <span>Remember me</span>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="Button" onclick="btnLogin_Click"/>
            </div>
        </form>
    </div>
</body>
</html>
