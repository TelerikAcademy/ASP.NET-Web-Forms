<%@ Page Language="C#" AutoEventWireup="true" Inherits="Cookies" Codebehind="Cookies.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Cookies - Demo</title>
</head>

<body>
    <form id="formCookies" runat="server">
    <div>
        <asp:Label ID="LabelLoggedIn" runat="server" Text="Not logged"></asp:Label>
        <br />
    </div>
    <div>
        <asp:Button ID="ButtonLogMe" runat="server" Text="Log Me" OnClick="buttonLogMe_Click" />
    </div>
    </form>
</body>
</html>
