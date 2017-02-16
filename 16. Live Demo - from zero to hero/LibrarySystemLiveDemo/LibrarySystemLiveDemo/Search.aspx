<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs"
    MasterPageFile="~/Site.Master"
     Inherits="LibrarySystemLiveDemo.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <h1><%: Title %>
            <asp:Literal runat="server" ID="LiteralSearchQuery" Mode="Encode"></asp:Literal></h1>
    </div>

    <asp:Repeater runat="server" ID="Reapeater" ItemType="LibrarySystemLiveDemo.Data.Models.Book" SelectMethod="Reapeater_GetData">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <asp:HyperLink NavigateUrl='<%# string.Format("~/bookdetails.aspx?id={0}", Item.Id) %>' runat="server" ID="HyperLinkBook" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>' />
                (Category: <%#: Item.Category.Name %>)                 
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>

    <div class="back-link">
        <a href="/books">Back to books</a>
    </div>
</asp:Content>