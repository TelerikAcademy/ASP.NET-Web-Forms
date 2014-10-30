<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NewsSite.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %></h1>

    <asp:ListView runat="server" ID="ListViewPopularArticles" ItemType="NewsSite.Models.Article" SelectMethod="ListViewPopularArticles_GetData">
        <LayoutTemplate>
            <h2>Most popular articles</h2>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
        </LayoutTemplate>
        <ItemTemplate>
            <ItemTemplate>
            <div class="row">
                <h3><asp:hyperlink navigateurl='<%# "~/ViewArticle?id=" + Item.ID %>' runat="server" Text="<%#: Item.Title %>" /> <small><%#: Item.Category.Name %></small></h3>
                <p>
                    <%# Item.Content.Length > 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content  %>
                </p>
                <p>Likes: <%#: Item.Likes.Sum(l => l.Value) %></p>
                <div>
                    <i>by <%#: Item.Author.UserName ?? "" %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
        </ItemTemplate>
    </asp:ListView>

    <asp:ListView runat="server" ID="ListViewCategories" ItemType="NewsSite.Models.Category" SelectMethod="ListViewCategories_GetData" GroupItemCount="2">
        <LayoutTemplate>            
            <h2>All categories</h2>
            <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-md-6">
                <h3><%#: Item.Name %></h3>
                <asp:ListView runat="server" ID="ListViewArticles" ItemType="NewsSite.Models.Article" DataSource="<%# Item.Articles.OrderByDescending(a => a.DateCreated).Take(3) %>">
                    <LayoutTemplate>
                        <ul>
                            <li runat="server" id="itemPlaceHolder"></li>
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink NavigateUrl='<%# "~/ViewArticle?id=" + Item.ID %>' runat="server" Text="<%# GetTitle(Item) %>" />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No articles.
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
