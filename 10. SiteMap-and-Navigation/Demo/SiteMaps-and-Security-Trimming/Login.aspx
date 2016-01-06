<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="SiteMap_and_Navigation.LoginPage" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Login</h1>
    <asp:Login ID="LoginForm" runat="server" />
</asp:Content>
