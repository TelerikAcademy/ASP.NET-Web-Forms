<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="LikesDemo.Posts" %>

<%@ Register Src="~/Controls/LikeControl.ascx" TagPrefix="uc" TagName="LikeControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewPosts"
        ItemType="LikesDemo.Models.Post"
        SelectMethod="ListViewPosts_GetData">
        <ItemTemplate>
            <h2><%#: Item.Title %></h2>
            <p><%#: Item.Content %></p>
            <uc:LikeControl runat="server" ID="LikeControl"
                LikesValue="<%# GetLikesValue(Item) %>"
                OnLike="LikeControl_Like"
                DataID="<%# Item.ID %>"
                UserVote="<%# GetUserVote(Item) %>" />
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
