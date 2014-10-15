<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="DataBindingSimpleExample.aspx.cs"
  Inherits="Data_Binding_Simple_Example.DataBindingSimpleExample" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Data Binding - Simple Example</title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:DropDownList ID="DropDownYesNo" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownYesNo_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="LabelSelectedYesNo" runat="server"></asp:Label>

        <br />
        <br />
        <br />

        <asp:ListBox ID="ListBoxTowns" runat="server" AutoPostBack="True"
            DataTextField="Name" DataValueField="ID"
            onselectedindexchanged="ListBoxTowns_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="LabelSelectedTown" runat="server"></asp:Label>
    </form>
</body>

</html>
