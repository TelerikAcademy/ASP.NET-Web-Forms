<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="ModelBindingExample.aspx.cs" 
    Inherits="ModelBindingDemo.ModelBindingExample"
    Culture="en-CA" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Model Binding - Demo</title>
    <link href="Site.css" rel="stylesheet" />
</head>

<body>
    <form id="FormMain" runat="server">
        <asp:GridView ID="GridViewProducts" runat="server"
            SelectMethod="GridViewProducts_GetData"
            UpdateMethod="GridViewProducts_UpdateItem"
            ItemType="ModelBindingDemo.Product"
            AllowPaging="True" AllowSorting="True"
            DataKeyNames="ProductID"
            AutoGenerateEditButton="true" 
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Product" SortExpression="ProductName" />
                <asp:BoundField DataField="Supplier.CompanyName" HeaderText="Supplier" />
                <asp:BoundField DataField="Category.CategoryName" HeaderText="Category" />
                <asp:BoundField DataField="QuantityPerUnit" HeaderText="Quantity Per Unit" SortExpression="QuantityPerUnit" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice" DataFormatString="{0:c}" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="Units in Stock" SortExpression="UnitsInStock" />
                <asp:BoundField DataField="UnitsOnOrder" HeaderText="Units on Order" SortExpression="UnitsOnOrder" />
                <asp:BoundField DataField="ReorderLevel" HeaderText="Reorder Level" SortExpression="ReorderLevel" />
                <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
            </Columns>            
        </asp:GridView>
    </form>
</body>

</html>
