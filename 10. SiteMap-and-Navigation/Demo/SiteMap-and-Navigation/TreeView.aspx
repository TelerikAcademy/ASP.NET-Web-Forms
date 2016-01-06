<%@ Page Title="TreeView" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="TreeView.aspx.cs"
    Inherits="SiteMap_and_Navigation.TreeView" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>TreeView</h1>
    <p>This is a TreeView example:</p>
    <asp:TreeView ID="TreeViewSitePages" runat="server" 
        DataSourceID="SiteMapDataSource" SkipLinkText=""></asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" />
</asp:Content>
