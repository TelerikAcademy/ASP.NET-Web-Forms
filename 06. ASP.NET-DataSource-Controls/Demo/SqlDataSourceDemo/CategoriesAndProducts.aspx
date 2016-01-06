<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="CategoriesAndProducts.aspx.cs"
    Inherits="SqlDataSourceDemo.CategoriesAndProducts" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>SqlDataSource: Categories and Products</title>
</head>

<body>
    <asp:SqlDataSource ID="SqlDataSourceCategories" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
        SelectCommand="SELECT * FROM [Categories]">
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSourceProducts" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
        SelectCommand="SELECT ProductName, UnitPrice, CategoryID FROM [Products]">
    </asp:SqlDataSource>

    <form id="FormMain" runat="server">

        <h2>Northwind Categories</h2>

        <asp:GridView ID="GridViewCategories" runat="server" PageSize="5"
            DataSourceID="SqlDataSourceCategories" DataKeyNames="CategoryID"
            AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
            OnSelectedIndexChanged="GridViewCategories_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CategoryName" 
                    HeaderText="Category Name" SortExpression="CategoryName" />
                <asp:BoundField DataField="Description" 
                    HeaderText="Description" SortExpression="Description" />
            </Columns>
        </asp:GridView>

        <h2>Northwind Products (<asp:Literal ID="LiteralCategory"
            runat="server" Mode="Encode">All Categories</asp:Literal>)</h2>

        <asp:Repeater ID="RepeaterProducts" runat="server"
            DataSourceID="SqlDataSourceProducts">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    Product: <%#: Eval("ProductName") %>,
                    Price: <%#: Eval("UnitPrice") %>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>            
        </asp:Repeater>

    </form>
</body>

</html>
