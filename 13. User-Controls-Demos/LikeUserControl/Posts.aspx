<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Posts.aspx.cs" Inherits="LikeUserControl.Posts" %>

<%@ Register Src="~/Controls/LikeControl.ascx" TagPrefix="uc" TagName="LikeControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewPosts" ItemType="LikeUserControl.Models.Post" SelectMethod="ListViewPosts_GetData">
        <ItemTemplate>
            <h3><span><%#: Item.ID %>. </span><%#: Item.Title %></h3>
            <p><%#: Item.Description %></p>

            <uc:LikeControl runat="server" ID="LikeControl" LikesCount="<%# Item.Likes.Sum(l => l.Value) %>" DataID="<%# Item.ID %>" UserVote="<%# CheckUserLike(Item.ID) %>" OnLike="LikeControl_Like" OnDisLike="LikeControl_DisLike" />
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
