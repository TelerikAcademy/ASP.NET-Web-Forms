<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Master_Details.Default" Culture="en-CA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <asp:EntityDataSource ID="edsCustomers" runat="server" ConnectionString="name=NorthwindEntities" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Customers">
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="edsOrders" runat="server" ConnectionString="name=NorthwindEntities" Include="Shipper" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Orders" Where="it.CustomerID=@CustID" OrderBy="it.OrderDate">
        <WhereParameters>
            <asp:ControlParameter ControlID="ListBoxCustomers" Type="String" Name="CustID" />
        </WhereParameters>
    </asp:EntityDataSource>

    <asp:EntityDataSource ID="edsOrderDetails" runat="server" ConnectionString="name=NorthwindEntities" Include="Product" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Order_Details" Where="it.OrderID=@OrderID" EnableDelete="True" EnableInsert="True" EnableUpdate="True">
        <WhereParameters>
            <asp:ControlParameter ControlID="GridViewOrders" Type="Int32" Name="OrderID" />
        </WhereParameters>
    </asp:EntityDataSource>

    <form id="form1" runat="server">
        <div>
            <h1>Customers</h1>
            <asp:ListBox ID="ListBoxCustomers" runat="server" DataSourceID="edsCustomers" Rows="10" AutoPostBack="true" DataTextField="CompanyName" DataValueField="CustomerID" OnSelectedIndexChanged="ListBoxCustomers_SelectedIndexChanged"></asp:ListBox>

            <asp:FormView ID="FormViewCustomer" runat="server" DataSourceID="edsCustomers" DataKeyNames="CustomerID">
                <ItemTemplate>
                    Company Name:
                    <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Bind("CompanyName") %>' />
                    <br />
                    Contact Name:
                    <asp:Label ID="ContactNameLabel" runat="server" Text='<%# Bind("ContactName") %>' />
                    <br />

                    Contact Title:
                    <asp:Label ID="ContactTitleLabel" runat="server" Text='<%# Bind("ContactTitle") %>' />
                    <br />
                    Address:
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address") %>' />
                    <br />
                    City:
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                    <br />
                    Region:
                    <asp:Label ID="RegionLabel" runat="server" Text='<%# Bind("Region") %>' />
                    <br />
                    Postal Code:
                    <asp:Label ID="PostalCodeLabel" runat="server" Text='<%# Bind("PostalCode") %>' />
                    <br />
                    Country:
                    <asp:Label ID="CountryLabel" runat="server" Text='<%# Bind("Country") %>' />
                    <br />
                    Phone:
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    Fax:
                    <asp:Label ID="FaxLabel" runat="server" Text='<%# Bind("Fax") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>

            <asp:DetailsView runat="server" ID="DetailsVeiwCustomer" DataKeyNames="CustomerID" Visible="false">
            </asp:DetailsView>

            <h1 runat="server" id="headerOrders" visible="false">Orders</h1>
            <asp:GridView ID="GridViewOrders" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID" DataSourceID="edsOrders" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridViewOrders_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="true" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate" DataFormatString="{0:G}" />
                    <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" SortExpression="ShippedDate" />
                    <asp:BoundField DataField="Shipper.CompanyName" HeaderText="Ship Via" SortExpression="Shipper.CompanyName" />
                    <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                    <asp:BoundField DataField="ShipName" HeaderText="Ship Name" SortExpression="ShipName" />
                    <asp:BoundField DataField="ShipAddress" HeaderText="Ship Address" SortExpression="ShipAddress" />
                    <asp:BoundField DataField="ShipCity" HeaderText="Ship City" SortExpression="ShipCity" />
                    <asp:BoundField DataField="ShipRegion" HeaderText="Ship Region" SortExpression="ShipRegion" />
                    <asp:BoundField DataField="ShipPostalCode" HeaderText="Ship Postal Code" SortExpression="ShipPostalCode" />
                    <asp:BoundField DataField="ShipCountry" HeaderText="Ship Country" SortExpression="ShipCountry" />
                </Columns>
            </asp:GridView>

            <h1 runat="server" id="headerOrderDetails" visible="false">Order Details</h1>

            <asp:ListView ID="lvOrderDetails" runat="server" DataSourceID="edsOrderDetails" OnSorting="lvOrderDetails_Sorting" ItemType="Master_Details.Order_Detail" GroupItemCount="3" DataKeyNames="OrderID,ProductID" OnSelectedIndexChanged="lvOrderDetails_SelectedIndexChanged">
                <LayoutTemplate>
                    <table runat="server">
                        <tr>
                            <td colspan="3">
                                <asp:Button runat="server" ID="btnSortByPrice" CommandName="Sort" CommandArgument="UnitPrice" Text="Sort by Price" />
                                <asp:Button runat="server" ID="btnSortByQuantity" CommandName="Sort" CommandArgument="Quantity" Text="Sort by Quantity" />
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                                <asp:DataPager ID="DataPager1" runat="server" PageSize="3">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                        <asp:NumericPagerField />
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>

                <EditItemTemplate>
                    <td runat="server" style="background-color: #008A8C; color: #FFFFFF;">OrderID:
                        <asp:Label ID="OrderIDLabel1" runat="server" Text='<%# Eval("OrderID") %>' />
                        <br />
                        ProductID:                        
                        <asp:Label ID="ProductIDLabel1" runat="server" Text='<%# Eval("ProductID") %>' />
                        <br />
                        UnitPrice:
                        <asp:TextBox ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' />
                        <br />
                        Quantity:
                        <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                        <br />
                        Discount:
                        <asp:TextBox ID="DiscountTextBox" runat="server" Text='<%# Bind("Discount") %>' />
                        <br />
                        Product:                        
                        <asp:Label ID="ProductTextBox" runat="server" Text='<%# Eval("Product.ProductName") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br />
                    </td>
                </EditItemTemplate>

                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>

                <EmptyItemTemplate>
                    <td runat="server" />
                </EmptyItemTemplate>

                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>

                <InsertItemTemplate>
                    <td runat="server" style="">OrderID:
                        <asp:TextBox ID="OrderIDTextBox" runat="server" Text='<%# Bind("OrderID") %>' />
                        <br />
                        ProductID:
                        <asp:TextBox ID="ProductIDTextBox" runat="server" Text='<%# Bind("ProductID") %>' />
                        <br />
                        UnitPrice:
                        <asp:TextBox ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' />
                        <br />
                        Quantity:
                        <asp:TextBox ID="QuantityTextBox" runat="server" Text='<%# Bind("Quantity") %>' />
                        <br />
                        Discount:
                        <asp:TextBox ID="DiscountTextBox" runat="server" Text='<%# Bind("Discount") %>' />
                        <br />
                        Order:
                        <asp:TextBox ID="OrderTextBox" runat="server" Text='<%# Bind("Order") %>' />
                        <br />
                        Product:
                        <asp:TextBox ID="ProductTextBox" runat="server" Text='<%# Bind("Product") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br />
                    </td>
                </InsertItemTemplate>

                <ItemTemplate>
                    <td runat="server" style="background-color: #DCDCDC; color: #000000;">OrderID:
                        <asp:Label ID="OrderIDLabel" runat="server" Text='<%# Eval("OrderID") %>'></asp:Label>
                        <br />
                        ProductID:
                        <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                        <br />
                        UnitPrice:
                        <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                        <br />
                        Quantity:
                        <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                        <br />
                        Discount:
                        <asp:Label ID="DiscountLabel" runat="server" Text='<%# Eval("Discount") %>' />
                        <br />
                        Product:
                        <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product.ProductName") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br />
                    </td>
                </ItemTemplate>

                <AlternatingItemTemplate>
                    <td runat="server" style="background-color: #FFF8DC;">OrderID:
                        <asp:Label ID="OrderIDLabel" runat="server" Text='<%# Eval("OrderID") %>' />
                        <br />
                        ProductID:
                        <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                        <br />
                        UnitPrice:
                        <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                        <br />
                        Quantity:
                        <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                        <br />
                        Discount:
                        <asp:Label ID="DiscountLabel" runat="server" Text='<%# Eval("Discount") %>' />
                        <br />
                        Product:
                        <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product.ProductName") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br />
                    </td>
                </AlternatingItemTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">OrderID:
                        <asp:Label ID="OrderIDLabel" runat="server" Text='<%# Eval("OrderID") %>' />
                        <br />
                        ProductID:
                        <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                        <br />
                        UnitPrice:
                        <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                        <br />
                        Quantity:
                        <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
                        <br />
                        Discount:
                        <asp:Label ID="DiscountLabel" runat="server" Text='<%# Eval("Discount") %>' />
                        <br />
                        Order:
                        <asp:Label ID="OrderLabel" runat="server" Text='<%# Eval("Order") %>' />
                        <br />
                        Product:
                        <asp:Label ID="ProductLabel" runat="server" Text='<%# Eval("Product") %>' />
                        <br />
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <br />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        <br />
                    </td>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
