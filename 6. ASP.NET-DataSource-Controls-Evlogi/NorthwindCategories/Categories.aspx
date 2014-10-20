<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="NorthwindCategories.Categories" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:SqlDataSource ID="SqlDataSourceCategories" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"></asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [UnitPrice], [CategoryID], [ProductName] FROM [Alphabetical list of products]"></asp:SqlDataSource>

    <form id="form1" runat="server">
        <div>
            <h2>Northwind Categories</h2>
            <asp:GridView ID="GridViewCategories" runat="server" AutoGenerateColumns="False" DataKeyNames="CategoryID" DataSourceID="SqlDataSourceCategories2" AllowPaging="True" PageSize="5" AllowSorting="True" OnSelectedIndexChanged="GridViewCategories_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSourceCategories2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT * FROM [Categories]"></asp:SqlDataSource>

        </div>

        <h2>Northwind Products (<asp:Literal runat="server" ID="ltSelectedCategory" Mode="Encode">All Categories</asp:Literal>)</h2>
        <asp:Repeater ID="RepeaterProducts" runat="server" DataSourceID="SqlDataSourceProducts">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>Product: <%# Eval("ProductName") %>,
                    Price: <%# Eval("UnitPrice") %>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
