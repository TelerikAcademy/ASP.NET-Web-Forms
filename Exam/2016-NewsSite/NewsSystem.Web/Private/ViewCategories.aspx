<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCategories.aspx.cs" Inherits="NewsSystem.Web.Private.ViewCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="gvCategories"
        ItemType="NewsSystem.Data.Models.Category"
        DataKeyNames="Id"
        SelectMethod="gvCategories_GetData"
        AutoGenerateColumns="false"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        UpdateMethod="gvCategories_UpdateItem"
        DeleteMethod="gvCategories_DeleteItem">
        <Columns>
            <asp:BoundField SortExpression="Name" DataField="Name" HeaderText="Sort by name" />
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-info" />
            <asp:CommandField ShowDeleteButton="true" ControlStyle-CssClass="btn btn-danger" />
        </Columns>
    </asp:GridView>
    <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Category name is mandatory!" ControlToValidate="tbInsert" runat="server" />
    <br />
    <asp:TextBox runat="server" ID="tbInsert" />
    <asp:Button Text="Insert" ID="btnInsert" runat="server" OnClick="btnInsert_Click" CssClass="btn btn-info" />
    <asp:Button Text="Cancel" ID="btnCancel" runat="server" OnClick="Button1_Click" CssClass="btn btn-danger" />
</asp:Content>
