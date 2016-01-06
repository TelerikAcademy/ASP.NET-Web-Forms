<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="DetailsViewDemo.aspx.cs"
  Inherits="GridViewDemo.DetailsViewDemo" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>DetailsView - Demo</title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:DetailsView ID="DetailsViewCustomer" runat="server" 
            AutoGenerateRows="true" AllowPaging="True" 
            onpageindexchanging="DetailsViewCustomer_PageIndexChanging">            
        </asp:DetailsView>
    </form>
</body>

</html>
