<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Register.aspx.cs"
    Inherits="SiteMap_and_Navigation.RegisterPage" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="MainContent" runat="server">
    <h1>User Registration</h1>
    <p>Register Your Account</p>
    <asp:Label runat="server" AssociatedControlID="TextBoxUsername">Username:</asp:Label>
    <asp:TextBox ID="TextBoxUsername" runat="server" />
    <br/>
    <asp:Label runat="server" AssociatedControlID="TextBoxPassword">Password:</asp:Label>
    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" />
    <br/>
    <asp:Label runat="server" AssociatedControlID="DropDownListRole">Role:</asp:Label>
    <asp:DropDownList ID="DropDownListRole" runat="server">
        <asp:ListItem Value="users" />
        <asp:ListItem Value="admins" />
    </asp:DropDownList>
    <br/>
    <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
    <span class="error-message">
        <asp:Literal runat="server" ID="LiteralErrorMessage" Mode="Encode" />
    </span>
</asp:Content>
