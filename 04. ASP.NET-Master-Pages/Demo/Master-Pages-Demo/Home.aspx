<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Home.aspx.cs"
    Inherits="MasterPageDemo.Home" %>

<asp:Content ID="ContentHeader" runat="server" ContentPlaceHolderID="ContentPlaceHolderHeader">
    <meta name="author" content="Nakov" />
</asp:Content>

<asp:Content ID="ContentMain" runat="server" ContentPlaceHolderID="ContentPlaceHolderMain">
    <h1>Home</h1>
    <p>Welcome to our great web site!</p>
</asp:Content>
