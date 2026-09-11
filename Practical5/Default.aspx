<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="Practical5._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Academic Calendar & Leave Management System</h2>

    <h3>Select Leave Date</h3>

    <asp:Calendar
        ID="Calendar1"
        runat="server">
    </asp:Calendar>

    <br />

    <asp:Button
        ID="btnSelectDate"
        runat="server"
        Text="Select Date"
        OnClick="btnSelectDate_Click" />

    <br /><br />

    <asp:Label
        ID="lblSelectedDate"
        runat="server">
    </asp:Label>

    <br /><br />

    <asp:Button
        ID="btnApplyLeave"
        runat="server"
        Text="Apply Leave"
        OnClick="btnApplyLeave_Click" />

</form>

</body>
</html>