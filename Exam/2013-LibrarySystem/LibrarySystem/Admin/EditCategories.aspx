<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="LibrarySystem.Admin.EditCategories" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewCategories" ItemType="LibrarySystem.Models.Category" SelectMethod="ListViewCategories_GetData" DeleteMethod="ListViewCategories_DeleteItem" UpdateMethod="ListViewCategories_UpdateItem" DataKeyNames="ID" InsertMethod="ListViewCategories_InsertItem" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <table class="gridview" cellspacing="0" rules="all" border="1" id="MainContent_GridViewCategories" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <th scope="col">
                            <asp:LinkButton Text="Caterory Name" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="Name" />
                        </th>
                        <th scope="col">Action</th>
                    </tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    <tr>
                        <td colspan="2">
                            <asp:DataPager runat="server" ID="DataPagerCategories" PagedControlID="ListViewCategories" PageSize="5">
                                <Fields>
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                            <asp:LinkButton runat="server" ID="LinkButtonInsert" Text="Insert" OnClick="LinkButtonInsert_Click" CssClass="btn btn-primary pull-right" ></asp:LinkButton>
                        </td>
                    </tr>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Name %></td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Save" CommandName="Update" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Insert" CommandName="Insert" />
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                </td>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
