<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="ListView-DataPager-Demo.aspx.cs"
  Inherits="ListView_DataPager_Demo.ListView_DataPager_Demo" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ListView and DataPager - Demo</title>
    <link href="Site.css" rel="stylesheet" />
</head>

<body>
    <form id="formMain" runat="server">
        <asp:ListView ID="ListViewProducts" runat="server"
            ItemType="ListView_DataPager_Demo.Product">
            <LayoutTemplate>
                <h3>Products</h3>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
            </LayoutTemplate>

            <ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>

            <ItemTemplate>
                <div class="product-description">
                    <h4><%#: Item.Name %></h4>
                    Price: <%#: String.Format("{0:c}", Item.Price) %>
                </div>
            </ItemTemplate>
        </asp:ListView>

        <asp:DataPager ID="DataPagerCustomers" runat="server"
            PagedControlID="ListViewProducts" PageSize="3"
            QueryStringField="page">
            <Fields>
                <asp:NextPreviousPagerField ShowFirstPageButton="true"
                    ShowNextPageButton="false" ShowPreviousPageButton="false" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowLastPageButton="true"
                    ShowNextPageButton="false" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>
    </form>
</body>

</html>
