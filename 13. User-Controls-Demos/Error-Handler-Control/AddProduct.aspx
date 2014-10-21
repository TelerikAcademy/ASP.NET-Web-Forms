<%@ Page Title="Add Product" Language="C#"
    MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AddProduct.aspx.cs"
    Inherits="Error_Handler_Control.AddProduct" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add a Product</h1>
    <asp:Button Text="Add a Product (Successfully)" runat="server" 
    ID="ButtonAddSuccess" onclick="ButtonAddSuccess_Click" />
    <asp:Button Text="Add a Product (Error)" runat="server" ID="ButtonAddError" 
    onclick="ButtonAddError_Click" />
</asp:Content>
