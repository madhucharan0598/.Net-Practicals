<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApplyLeave.aspx.cs"
    Inherits="Practical5.ApplyLeave"
    UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Apply Leave</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Apply Leave</h2>

    <asp:Label
        ID="lblWelcome"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Label
        ID="lblDate"
        runat="server">
    </asp:Label>

    <hr />

    <h3>Enter Leave Details</h3>

    <asp:Label
        ID="lblLeaveType"
        runat="server"
        Text="Leave Type:">
    </asp:Label>

    <asp:DropDownList
        ID="ddlLeaveType"
        runat="server">

        <asp:ListItem Text="Casual Leave"
            Value="Casual Leave">
        </asp:ListItem>

        <asp:ListItem Text="Medical Leave"
            Value="Medical Leave">
        </asp:ListItem>

        <asp:ListItem Text="On Duty"
            Value="On Duty">
        </asp:ListItem>

    </asp:DropDownList>

    <br /><br />

    <asp:Label
        ID="lblReason"
        runat="server"
        Text="Reason:">
    </asp:Label>

    <br />

    <asp:TextBox
        ID="txtReason"
        runat="server"
        TextMode="MultiLine"
        Rows="4"
        Columns="40">
    </asp:TextBox>

    <br />

    <asp:RequiredFieldValidator
        ID="rfvReason"
        runat="server"
        ControlToValidate="txtReason"
        ErrorMessage="Please enter reason.">
    </asp:RequiredFieldValidator>

    <br /><br />

    <asp:Button
        ID="btnApply"
        runat="server"
        Text="Apply Leave"
        OnClick="btnApply_Click">
    </asp:Button>

    <hr />

    <h3>Leave Details</h3>

    <asp:Label
        ID="lblResult"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Button
        ID="btnLogout"
        runat="server"
        Text="Logout"
        OnClick="btnLogout_Click">
    </asp:Button>

</form>

</body>
</html>
