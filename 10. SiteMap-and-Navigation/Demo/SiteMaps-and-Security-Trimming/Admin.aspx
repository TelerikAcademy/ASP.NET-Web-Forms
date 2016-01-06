<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Admin.aspx.cs"
    Inherits="SiteMap_and_Navigation.Admin" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Admin</h1>
    <p>This page is for administrators only!</p>
    <h1>Users</h1>
    <asp:BulletedList ID="BulletedListUsers" runat="server" DataTextField="Username" />
</asp:Content>
