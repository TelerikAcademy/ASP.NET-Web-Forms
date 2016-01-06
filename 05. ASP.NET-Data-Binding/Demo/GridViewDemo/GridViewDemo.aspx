<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="GridViewDemo.aspx.cs"
  Inherits="GridViewDemo.GridViewDemo" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>GridView - Demo</title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:GridView ID="GridViewCustomers" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" DataKeyNames="ID"
            onpageindexchanging="GridViewCustomers_PageIndexChanging"
            onselectedindexchanged="GridViewCustomers_SelectedIndexChanged" 
            onrowdatabound="GridViewCustomers_RowDataBound">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="EMail" HeaderText="E-Mail" />
                <asp:CheckBoxField DataField="IsSenior" HeaderText="Senior?" />
                <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="EditCustomer.aspx?id={0}" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="LabelSelectedItem" runat="server"></asp:Label>
    </form>
</body>

</html>
