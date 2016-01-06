<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" %>

<asp:Content ID="ContentPage" runat="server"
    ContentPlaceHolderID="ContentPlaceHolderPageContent">
    <h1 id="welcome-text">Welcome to our Telerik Academy community web site</h1>
    <asp:HyperLink runat="server" NavigateUrl="~/Users/UsersHome.aspx" 
        Text="Users Area" CssClass="users-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Admin/AdminHome.aspx"
         Text="Admin Area" CssClass="administrators-icon"/>
</asp:Content>
