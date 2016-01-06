<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiple-Linked-Controls.aspx.cs" Inherits="Multiple_Linked_Controls.Multiple_Linked_Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formMain" runat="server">
        <asp:DropDownList runat="server" ID="DropDownListCategory" OnSelectedIndexChanged="DropDownListCategory_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>all</asp:ListItem>            
        </asp:DropDownList>

        <asp:DropDownList runat="server" ID="DropDownListBrand" OnSelectedIndexChanged="DropDownListCategory_SelectedIndexChanged">
            <asp:ListItem>all</asp:ListItem>
        </asp:DropDownList>

        <asp:Button runat="server" ID="SearchButton" Text="Search" OnCommand="SearchButton_Command" />

        <asp:ListView runat="server" ID="ListViewCars" ItemType="Multiple_Linked_Controls.Car">
            <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </LayoutTemplate>

            <ItemTemplate>
                <div class="car-description">
                    <h3><%#: Item.Brand + ' ' + Item.Model %></h3>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
