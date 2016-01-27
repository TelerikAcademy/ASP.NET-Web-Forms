<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCategories.aspx.cs" Inherits="NewsSystem.Private.ViewCategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="gvCategories"
        ItemType="NewsSystem.Models.Category"
        SelectMethod="gvCategories_GetData1"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        DataKeyNames="Id"
        AutoGenerateColumns="false"
        UpdateMethod="gvCategories_UpdateItem"
        DeleteMethod="gvCategories_DeleteItem">
        <Columns>
            <asp:BoundField SortExpression="Name" HeaderText="Name" DataField="Name" />
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-info" />
            <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" />
        </Columns>
    </asp:GridView>
    <asp:TextBox ID="tbInsertName" runat="server" />
    <asp:RequiredFieldValidator ErrorMessage="You cannot post an empty category!" ControlToValidate="tbInsertName" runat="server" />
    <asp:CustomValidator ErrorMessage="Category name too short!" OnServerValidate="Unnamed_ServerValidate" ControlToValidate="tbInsertName" runat="server" />
    <asp:Button Text="Insert" ID="btnInsert" runat="server" OnClick="btnInsert_Click" CssClass="btn btn-success" />
    <asp:Button Text="Cancel" ID="btnCancelInsert" runat="server" OnClick="Button1_Click" CssClass="btn btn-danger" />
</asp:Content>
