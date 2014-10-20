<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsEditor.aspx.cs" Inherits="EntityDataSourceDemo.ProductsEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products Editor</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:EntityDataSource ID="EntityDataSourceProducts" runat="server" 
            ConnectionString="name=NorthwindEntities"
            Include="Supplier, Category" 
            DefaultContainerName="NorthwindEntities" EnableUpdate="True" 
            EntitySetName="Products" EnableFlattening="False">
        </asp:EntityDataSource>

        <asp:EntityDataSource ID="EntityDataSourceSuppliers" runat="server" 
            ConnectionString="name=NorthwindEntities"
            DefaultContainerName="NorthwindEntities" 
            EntitySetName="Suppliers" EnableFlattening="False">
        </asp:EntityDataSource>
    
        <asp:EntityDataSource ID="EntityDataSourceCategories" runat="server" 
            ConnectionString="name=NorthwindEntities"
            DefaultContainerName="NorthwindEntities" 
            EntitySetName="Categories" EnableFlattening="False">
        </asp:EntityDataSource>
    
        <asp:ListView ID="ListViewProducts" runat="server" 
            DataSourceID="EntityDataSourceProducts" 
            ItemType="EntityDataSourceDemo.Product"
            DataKeyNames="ProductID">
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" 
                            CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" 
                            CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td><%# Item.ProductID %></td>
                    <td>
                        <asp:TextBox ID="ProductNameTextBox" runat="server" 
                            Text='<%# BindItem.ProductName %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListSupplier" runat="server" 
                            DataSourceID="EntityDataSourceSuppliers"
                            DataValueField="SupplierID"
                            DataTextField="CompanyName"
                            SelectedValue="<%# BindItem.SupplierID %>"
                            AppendDataBoundItems="true">
                            <asp:ListItem Text="(no supplier)" Value="" />
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListCategory" runat="server" 
                            DataSourceID="EntityDataSourceCategories"
                            DataValueField="CategoryID"
                            DataTextField="CategoryName"
                            SelectedValue="<%# BindItem.CategoryID %>" AppendDataBoundItems="true">
                            <asp:ListItem Text="(no category)" Value="" />
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="QuantityPerUnitTextBox" runat="server" 
                            Text='<%# BindItem.QuantityPerUnit %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UnitPriceTextBox" runat="server" 
                            Text='<%# BindItem.UnitPrice %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UnitsInStockTextBox" runat="server" 
                            Text='<%# BindItem.UnitsInStock %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="UnitsOnOrderTextBox" runat="server" 
                            Text='<%# BindItem.UnitsOnOrder %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ReorderLevelTextBox" runat="server" 
                            Text='<%# BindItem.ReorderLevel %>' />
                    </td>
                    <td>
                        <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                            Checked='<%# BindItem.Discontinued %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:Button ID="EditButton" runat="server" 
                            CommandName="Edit" Text="Edit" />
                    </td>
                    <td><%#: Item.ProductID %></td>
                    <td><%#: Item.ProductName %></td>
                    <td><%#: (Item.Supplier != null) ? Item.Supplier.CompanyName : "" %></td>
                    <td><%#: (Item.Category != null) ? Item.Category.CategoryName : "" %></td>
                    <td><%#: Item.QuantityPerUnit %></td>
                    <td><%#: Item.UnitPrice %></td>
                    <td><%#: Item.UnitsInStock %></td>
                    <td><%#: Item.UnitsOnOrder %></td>
                    <td><%#: Item.ReorderLevel %></td>
                    <td>
                        <asp:CheckBox ID="DiscontinuedCheckBox" runat="server" 
                            Checked='<%# Eval("Discontinued") %>' Enabled="false" />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th runat="server"></th>
                                    <th runat="server">Product ID</th>
                                    <th runat="server">Product Name</th>
                                    <th runat="server">Supplier</th>
                                    <th runat="server">Category</th>
                                    <th runat="server">Quantity Per Unit</th>
                                    <th runat="server">Unit Price</th>
                                    <th runat="server">Units in Stock</th>
                                    <th runat="server">Units on Order</th>
                                    <th runat="server">Reorder Level</th>
                                    <th runat="server">Discontinued</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    
    </div>
    </form>
</body>
</html>
