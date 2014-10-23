<%@ Page Title="Books" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="LibrarySystem.Books" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1><%: this.Title %></h1>
        <div class="search-button">
            <div class="form-search">
                <div class="input-append">
                    <asp:TextBox runat="server" ID="TextBoxSearchParam" type="text" name="q" class="col-md-3 search-query" placeholder="Search by book title / author..."></asp:TextBox>
                    <asp:LinkButton runat="server" ID="LinkButtonSearch" OnClick="LinkButtonSearch_Click" CssClass="btn  btn-primary" Text="Search"></asp:LinkButton>
                </div>
            </div>
        </div>
    </div>


    <asp:ListView runat="server" ID="ListViewCategories" ItemType="LibrarySystem.Models.Category" SelectMethod="ListViewCategories_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>
                <asp:ListView runat="server" ID="RepeaterBooks" ItemType="LibrarySystem.Models.Book" DataSource="<%# Item.Books %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink NavigateUrl='<%# string.Format("~/BookDetails.aspx?id={0}", Item.ID) %>' runat="server" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>' />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No books in this category.
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <%--<asp:Repeater runat="server" ID="RepeaterCaterories" ItemType="LibrarySystem.Models.Category" SelectMethod="RepeaterCaterories_GetData">
        <ItemTemplate>
            <%#: Item.Name %>
        </ItemTemplate>
    </asp:Repeater>--%>
</asp:Content>
