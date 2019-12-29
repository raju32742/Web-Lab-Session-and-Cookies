<%@ Page Language="C#" AutoEventWireup="true" CodeFile="success.aspx.cs" Inherits="success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelUN" runat="server" Text="User Name"></asp:Label>
        <br />
        <asp:Label ID="LabelEM" runat="server" Text="User Email"></asp:Label>
        <br />
        <asp:Button ID="Profile1" runat="server" Text="Update Profile"  onclick="Profile1_Click" />
        <br />
        <asp:Button ID="Logout" runat="server" Text="Logout"  onclick="Logout_Click"/>

    </div>
    </form>
</body>
</html>
