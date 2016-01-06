<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="EFDataSource-Master-Details.aspx.cs" 
    Inherits="EntityDataSourceListBox.EFDataSourceMasterDetails"
    Culture="en-CA" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Master-Details Navigation (EntityDataSource + Filters)</title>
    <link href="Styles.css" rel="stylesheet" />
</head>

<body>
    <form id="FormMain" runat="server">
    
        <h1>Customers</h1>

        <asp:EntityDataSource ID="EntityDataSourceCustomers" runat="server" 
            ConnectionString="name=NorthwindEntities" 
            DefaultContainerName="NorthwindEntities"             
            EntitySetName="Customers" 
            EnableFlattening="false" />
        
        <asp:ListBox ID="ListBoxCustomers" runat="server"
            DataSourceID="EntityDataSourceCustomers" 
            DataTextField="CompanyName" DataValueField="CustomerID" 
            Rows="10" AutoPostBack="True" 
            OnSelectedIndexChanged="ListBoxCustomers_SelectedIndexChanged" />

        <asp:FormView ID="FormViewCustomer" runat="server" 
            DataSourceID="EntityDataSourceCustomers"
            ItemType="EFDataSourceMasterDetailsDemo.Customer">
            <ItemTemplate>
                Company Name: <%#: Item.CompanyName %> <br />
                Contact Name: <%#: Item.ContactName %> <br />
                Contact Title: <%#: Item.ContactTitle %> <br />
                Address: <%#: Item.Address %> <br />
                City: <%#: Item.City %> <br />
                Region: <%#: Item.Region %> <br />
                Postal Code: <%#: Item.PostalCode %> <br />
                Country: <%#: Item.Country %> <br />
                Phone: <%#: Item.Phone %> <br />
                Fax: <%#: Item.Fax %>
            </ItemTemplate>
        </asp:FormView>

        <h1>Orders</h1>

        <asp:EntityDataSource ID="EntityDataSourceOrders" runat="server" 
            ConnectionString="name=NorthwindEntities" 
            DefaultContainerName="NorthwindEntities" 
            EntitySetName="Orders" Include="Shipper"
            Where="it.CustomerID=@CustID">
            <WhereParameters>
                <asp:ControlParameter Name="CustID" Type="String"
                    ControlID="ListBoxCustomers" />
            </WhereParameters>
        </asp:EntityDataSource>

        <asp:GridView ID="GridViewOrders" runat="server" 
            DataSourceID="EntityDataSourceOrders"
            AutoGenerateColumns="False" DataKeyNames="OrderID"
            AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate" />
                <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" SortExpression="ShippedDate" />
                <asp:BoundField DataField="Shipper.CompanyName" HeaderText="Ship Via" SortExpression="ShipVia" />
                <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                <asp:BoundField DataField="ShipName" HeaderText="Ship Name" SortExpression="ShipName" />
                <asp:BoundField DataField="ShipAddress" HeaderText="Ship Address" SortExpression="ShipAddress" />
                <asp:BoundField DataField="ShipCity" HeaderText="Ship City" SortExpression="ShipCity" />
                <asp:BoundField DataField="ShipRegion" HeaderText="Ship Region" SortExpression="ShipRegion" />
                <asp:BoundField DataField="ShipPostalCode" HeaderText="Ship Postal Code" SortExpression="ShipPostalCode" />
                <asp:BoundField DataField="ShipCountry" HeaderText="Ship Country" SortExpression="ShipCountry" />
            </Columns>
        </asp:GridView>
    
        <h1>Order Details</h1>

        <asp:EntityDataSource ID="EntityDataSourceOrderDetails" runat="server"
            ConnectionString="name=NorthwindEntities" 
            DefaultContainerName="NorthwindEntities" 
            EntitySetName="Order_Details" Include="Product"
            Where="it.OrderID=@OrderID" EnableFlattening="False">
            <WhereParameters>
                <asp:ControlParameter Name="OrderID" Type="Int32"
                    ControlID="GridViewOrders" />
            </WhereParameters>
        </asp:EntityDataSource>

        <asp:DataList id="DataListOrderDetails" runat="server"
            DataSourceID="EntityDataSourceOrderDetails"
            RepeatLayout="Table" RepeatDirection="Horizontal" 
            RepeatColumns="6" CellSpacing="15">
            <ItemTemplate>
                <div>Product: <%#: Eval("Product.ProductName") %></div>
                <div>Price: <%#: Eval("UnitPrice", "{0:c}") %></div>
                <div>Quantity: <%#: Eval("Quantity") %></div>
                <div>Discount: <%#: Eval("Discount") %></div>
            </ItemTemplate>
            <ItemStyle BackColor="Tan" />
            <AlternatingItemStyle BackColor="Gainsboro" />
      </asp:DataList>

    </form>
</body>

</html>
