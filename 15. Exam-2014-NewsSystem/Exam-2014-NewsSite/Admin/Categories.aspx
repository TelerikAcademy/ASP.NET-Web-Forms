<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="NewsSite.Admin.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewCategories" ItemType="NewsSite.Models.Category" SelectMethod="ListViewCategories_GetData" DeleteMethod="ListViewCategories_DeleteItem" InsertMethod="ListViewCategories_InsertItem" UpdateMethod="ListViewCategories_UpdateItem" DataKeyNames="ID" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" CssClass="btn btn-default" ID="ButtonSortbyName" Text="Sort by Name" CommandName="Sort" CommandArgument="Name" />
            </div>
            <div runat="server" id="itemPlaceholder"></div>

        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%#: Item.Name %></div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Edit" CssClass="btn btn-info" CommandName="Edit" CausesValidation="false" />
                <asp:LinkButton runat="server" ID="LinkButton1" Text="Delete" CssClass="btn btn-danger" CommandName="Delete" CausesValidation="false" />
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxCategoryName" Text="<%# BindItem.Name %>" ValidationGroup="InsertCategory" />
                    <asp:RequiredFieldValidator Text="*" ErrorMessage="Name is required!" ControlToValidate="TextBoxCategoryName" ValidationGroup="EditCategory" runat="server" ForeColor="Red" />
                    <asp:RegularExpressionValidator Text="*" ErrorMessage="Maximum name length is 150" ControlToValidate="TextBoxCategoryName" ValidationGroup="EditCategory" runat="server" ValidationExpression="[0-9a-zA-Z]{,150}" ForeColor="Red" />
                </div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-success" CommandName="Update" ValidationGroup="EditCategory" CausesValidation="true" />
                <asp:LinkButton runat="server" ID="LinkButton1" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false" />
            </div>
        </EditItemTemplate>
        <InsertItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox runat="server" ID="TextBoxCategoryName" Text="<%#: BindItem.Name %>" />
                    <asp:RequiredFieldValidator Text="*" ErrorMessage="Name is required!" ControlToValidate="TextBoxCategoryName" ValidationGroup="InsertCategory" ForeColor="Red" runat="server" />             
                    <asp:RegularExpressionValidator Text="*" ErrorMessage="Maximum name length is 150" ControlToValidate="TextBoxCategoryName" ValidationGroup="InsertCategory" runat="server" ValidationExpression="[0-9a-zA-Z]{,150}" ForeColor="Red" />
                    <asp:CustomValidator Text="*" ErrorMessage="Name exist in database!" ControlToValidate="TextBoxCategoryName" runat="server" ValidationGroup="InsertCategory" ForeColor="Red" />
                </div>
                <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-info" CommandName="Insert" CausesValidation="true" ValidationGroup="InsertCategory" />
                <asp:LinkButton runat="server" ID="ButtonCancel" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" />
            </div>
        </InsertItemTemplate>
    </asp:ListView>

    <asp:Label runat="server" ID="LabelValidation" ForeColor="Red" />
    <div class="row">
        <asp:DataPager runat="server" ID="DataPageCategories" PagedControlID="ListViewCategories" PageSize="5">
            <Fields>
                <asp:NextPreviousPagerField ShowNextPageButton="false" ShowPreviousPageButton="true" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowNextPageButton="true" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>
    </div>
    <asp:ValidationSummary runat="server" ShowValidationErrors="true" ValidationGroup="EditCategory" ForeColor="Red" />
    <asp:ValidationSummary runat="server" ShowValidationErrors="true" ValidationGroup="InsertCategory" ForeColor="Red" />
</asp:Content>
