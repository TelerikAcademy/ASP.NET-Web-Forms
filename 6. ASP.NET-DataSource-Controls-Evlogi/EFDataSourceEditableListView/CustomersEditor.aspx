<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CustomersEditor.aspx.cs"
    Inherits="EntityDataSourceDemo.CustomersEditor" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>EntityDataSource - Demo</title>
    <link rel="Stylesheet" type="text/css" href="Styles.css" />
</head>

<body>
    <form id="FormMain" runat="server">
    
        <asp:EntityDataSource ID="EntityDataSourceCustomers" runat="server"
            EnableInsert="True" EnableUpdate="True" EnableDelete="True"
            ConnectionString="name=NorthwindEntities"
            DefaultContainerName="NorthwindEntities"
            EntitySetName="Customers"
            EnableFlattening="false">
        </asp:EntityDataSource>

        <asp:ListView ID="ListViewCustomers" runat="server" 
            DataSourceID="EntityDataSourceCustomers" 
            ItemType="EntityDataSourceDemo.Customer"
            DataKeyNames="CustomerID"
            InsertItemPosition="None"
            OnItemInserted="ListViewCustomers_ItemInserted">

            <LayoutTemplate>
                <span runat="server" id="itemPlaceholder" />
                <div class="pagerLine">
                    <asp:Button ID="ButtonInsertCustomer" Text="Insert" runat="server"
                        OnClick="ButtonInsertCustomer_Click" />                    |
                    <asp:DataPager ID="DataPagerCustomers" runat="server" PageSize="4">
                        <Fields>
                            <asp:NextPreviousPagerField ShowFirstPageButton="True" 
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ShowLastPageButton="True" 
                                ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </LayoutTemplate>

            <EmptyDataTemplate>
                <div>No data was returned.</div>
            </EmptyDataTemplate>

            <ItemTemplate>
                <div class="item">
                    Customer ID: <%#: Item.CustomerID %> <br />
                    Company Name: <%#: Item.CompanyName %> <br />
                    Contact Name: <%#: Item.ContactName %> <br />
                    Contact Title: <%#: Item.ContactTitle %> <br />
                    Address: <%#: Item.Address %> <br />
                    City: <%#: Item.City %> <br />
                    Region: <%#: Item.Region %> <br />
                    Postal Code: <%#: Item.PostalCode %> <br />
                    Country: <%#: Item.Country %> <br />
                    Phone: <%#: Item.Phone %> <br />
                    Fax: <%#: Item.Fax %> <br />
                    <asp:Button ID="ButtonEdit" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="ButtonDelete" runat="server" CommandName="Delete" Text="Delete" />
                </div>
            </ItemTemplate>

            <EditItemTemplate>
                <div class="editItem">
                    Customer ID: <%#: Item.CustomerID %>
                    <br />
                    Company Name:
                    <asp:TextBox ID="TextBoxCompanyName" runat="server" 
                        Text='<%# Bind("CompanyName") %>' />
                    <br />
                    Contact Name:
                    <asp:TextBox ID="TextBoxContactName" runat="server" Text='<%# BindItem.ContactName %>' />
                    <br />
                    Contact Title:
                    <asp:TextBox ID="TextBoxContactTitle" runat="server" Text='<%# BindItem.ContactTitle %>' />
                    <br />
                    Address:
                    <asp:TextBox ID="TextBoxAddress" runat="server" Text='<%# BindItem.Address %>' />
                    <br />
                    City:
                    <asp:TextBox ID="TextBoxCity" runat="server" Text='<%# BindItem.City %>' />
                    <br />
                    Region:
                    <asp:TextBox ID="TextBoxRegion" runat="server" Text='<%# BindItem.Region %>' />
                    <br />
                    Postal Code:
                    <asp:TextBox ID="TextBoxPostalCode" runat="server" Text='<%# BindItem.PostalCode %>' />
                    <br />
                    Country:
                    <asp:TextBox ID="TextBoxCountry" runat="server" Text='<%# BindItem.Country %>' />
                    <br />
                    Phone:
                    <asp:TextBox ID="TextBoxPhone" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    Fax:
                    <asp:TextBox ID="TextBoxFax" runat="server" Text='<%# Bind("Fax") %>' />
                    <br />
                    <asp:Button ID="ButtonUpdate" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </div>
            </EditItemTemplate>

            <InsertItemTemplate>
                <div class="insertItem">
                    Customer ID: 
                    <asp:TextBox ID="TextBoxCustomerID" runat="server" 
                        Text='<%# Bind("CustomerID") %>' MaxLength="5"/>
                    <asp:RequiredFieldValidator
                         ID="RequiredFieldValidatorCustomerID" runat="server"
                         ErrorMessage="Required field!" ControlToValidate="TextBoxCustomerID">
                    </asp:RequiredFieldValidator>
                    <br />
                    Company Name:
                    <asp:TextBox ID="TextBoxCompanyName" runat="server" Text='<%# Bind("CompanyName") %>' />
                    <br />
                    Contact Name:
                    <asp:TextBox ID="TextBoxContactName" runat="server" Text='<%# Bind("ContactName") %>' />
                    <br />
                    Contact Title:
                    <asp:TextBox ID="TextBoxContactTitle" runat="server" Text='<%# Bind("ContactTitle") %>' />
                    <br />
                    Address:
                    <asp:TextBox ID="TextBoxAddress" runat="server" Text='<%# Bind("Address") %>' />
                    <br />
                    City:
                    <asp:TextBox ID="TextBoxCity" runat="server" Text='<%# Bind("City") %>' />
                    <br />
                    Region:
                    <asp:TextBox ID="TextBoxRegion" runat="server" Text='<%# Bind("Region") %>' />
                    <br />
                    Postal Code:
                    <asp:TextBox ID="TextBoxPostalCode" runat="server" Text='<%# Bind("PostalCode") %>' />
                    <br />
                    Country:
                    <asp:TextBox ID="TextBoxCountry" runat="server" Text='<%# Bind("Country") %>' />
                    <br />
                    Phone:
                    <asp:TextBox ID="TextBoxPhone" runat="server" Text='<%# Bind("Phone") %>' />
                    <br />
                    Fax:
                    <asp:TextBox ID="TextBoxFax" runat="server" Text='<%# Bind("Fax") %>' />
                    <br />
                    <asp:Button ID="ButtonInsert" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Clear" />
                </div>
            </InsertItemTemplate>
        </asp:ListView>
    </form>
</body>

</html>
