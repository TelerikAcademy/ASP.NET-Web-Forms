<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="EFDataSource-ListBox.aspx.cs" 
    Inherits="EntityDataSourceListBox.EFDataSource_ListBox" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ListBox bound to EntityDataSource</title>
</head>

<body>
    <form id="FormMain" runat="server">    
        <asp:EntityDataSource ID="EntityDataSourceCustomers" runat="server" 
            ConnectionString="name=NorthwindEntities" 
            DefaultContainerName="NorthwindEntities" 
            EntitySetName="Customers" />
        <asp:ListBox ID="ListBoxCustomers" runat="server" Rows="10"
            DataSourceID="EntityDataSourceCustomers" 
            DataTextField="CompanyName" DataValueField="CustomerID" />
    </form>
</body>

</html>
