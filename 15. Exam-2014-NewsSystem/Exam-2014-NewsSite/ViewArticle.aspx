<%@ Page Title="View Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="NewsSite.ViewArticle" %>

<%@ Register Src="~/Controls/LikeControl.ascx" TagPrefix="uc" TagName="LikeControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewArticle" ItemType="NewsSite.Models.Article" SelectMethod="FormViewArticle_GetItem">
        <ItemTemplate>
                        
            <uc:LikeControl runat="server" ID="LikeControl"
                Value="<%# GetLikes(Item) %>"
                CurrentUserVote="<%# GetCurrentUserVote(Item) %>"
                DataID="<%# Item.ID %>"
                OnLike="LikeControl_Like" />
            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
            <p><%#: Item.Content %></p>
            <p>
                <span>Author: <%#: Item.Author.UserName %></span>
                <span class="pull-right"><%#: Item.DateCreated %></span>
            </p>
        </ItemTemplate>
    </asp:FormView>

</asp:Content>
