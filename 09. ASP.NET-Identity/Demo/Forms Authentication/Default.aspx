<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Default" Codebehind="Default.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Main Application Page</title>
</head>

<body>
    <form id="FormMain" runat="server">
    <div>
        <h1>
           <asp:Label ID="lblMessage" runat="server" Text="Welcome, " ></asp:Label>
        </h1>
        <asp:Button ID="btnLoguot" runat="server" OnClick="btnLoguot_Click" Text="Logout" />
    </div>
    </form>
</body>

</html>
