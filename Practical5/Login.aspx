<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practical5.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Login</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Login</h2>

    <asp:Label
        ID="lblUsername"
        runat="server"
        Text="Username:">
    </asp:Label>

    <asp:TextBox
        ID="txtUsername"
        runat="server">
    </asp:TextBox>

    <br /><br />

    <asp:Label
        ID="lblPassword"
        runat="server"
        Text="Password:">
    </asp:Label>

    <asp:TextBox
        ID="txtPassword"
        runat="server"
        TextMode="Password">
    </asp:TextBox>

    <br /><br />

    <asp:CheckBox
        ID="chkRemember"
        runat="server"
        Text="Remember Username">
    </asp:CheckBox>

    <br /><br />

    <asp:Button
        ID="btnLogin"
        runat="server"
        Text="Login"
        OnClick="btnLogin_Click">
    </asp:Button>

    <br /><br />

    <asp:Label
        ID="lblMessage"
        runat="server">
    </asp:Label>

</form>

</body>
</html>