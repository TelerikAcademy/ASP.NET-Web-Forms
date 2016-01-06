<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Products.aspx.cs"
    Inherits="SiteMap_and_Navigation.Products" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Products</h1>
    <p>Our products categories are:</p>
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="verticalMenu" 
        EnableViewState="False" IncludeStyleBlock="False" SkipLinkText=""
        DataSourceID="SiteMapDataSource">
    </asp:Menu>
    <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" 
        ShowStartingNode="False" StartingNodeOffset="1" />
</asp:Content>
