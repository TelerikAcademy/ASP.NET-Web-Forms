<%@ Page Language="C#" AutoEventWireup="true" Inherits="RedirectPage" 
  Codebehind="RedirectPage.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Redirection - Demo</title>
</head>

<body>
    <form id="formClientRedirect" runat="server">
    <div>
        <asp:Button ID="buttonServerRedirect" runat="server"
          Text="Server Redirect" OnClick="buttonServerRedirect_Click"/>
        <asp:Button ID="buttonRedirect" runat="server"
          Text="Client Redirect" OnClick="buttonRedirect_Click"/>
    </div>
    </form>
</body>

</html>
