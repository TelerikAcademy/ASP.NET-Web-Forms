<%@ Page Title="List Products" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ListProducts.aspx.cs"
    Inherits="Error_Handler_Control.ListProducts" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h1>List of Products</h1>
    <ul>
        <li>Beer "Zagorka"</li>
        <li>Vodka "Targovishte"</li>
        <li>Sausages "Stara Planina"</li>
    </ul>
    <asp:Button Text="Reload Products" runat="server" ID="ButtonRefresh" 
    onclick="ButtonRefresh_Click" />
</asp:Content>
