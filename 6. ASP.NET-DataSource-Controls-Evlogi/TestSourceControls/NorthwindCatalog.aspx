<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NorthwindCatalog.aspx.cs" Inherits="TestSourceControls.NorthwindCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:EntityDataSource ID="DataSourceCustomers" runat="server" ConnectionString="name=NorthwindEntities"            DefaultContainerName="NorthwindEntities"
          EntitySetName="Customers" Select="it.[CustomerID], it.[CompanyName]">
        </asp:EntityDataSource>
        <asp:ListBox ID="ListViewCustomers" runat="server" DataTextField="CompanyName" DataValueField="CustomerID" DataSourceID="DataSourceCustomers" Rows="10"></asp:ListBox>
    </form>
</body>
</html>
