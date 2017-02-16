<%@ Page Language="C#" AutoEventWireup="true"
    MasterPageFile="~/Site.Master"
    CodeBehind="Books.aspx.cs"
    Inherits="LibrarySystemLiveDemo.Books" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel runat="server" DefaultButton="LinkButtonSearch" CssClass="row">
        <h1><%: this.Title %></h1>
        <div class="search-button">
            <div class="form-search">
                <div class="input-append">
                    <asp:TextBox runat="server" ID="TextBoxSearchParam" type="text" name="q" class="col-md-3 search-query" placeholder="Search by book title / author..."></asp:TextBox>
                    <asp:LinkButton runat="server" ID="LinkButtonSearch"
                        OnClick="LinkButtonSearch_Click" CssClass="btn  btn-primary" Text="Search"></asp:LinkButton>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:ListView runat="server"
        ID="ListViewCategories"
        ItemType="LibrarySystemLiveDemo.Data.Models.Category"
        SelectMethod="ListViewCategories_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Name %></h2>
                <asp:ListView runat="server" ID="RepeaterBooks" ItemType="LibrarySystemLiveDemo.Data.Models.Book" DataSource="<%# Item.Books %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:HyperLink NavigateUrl='<%# string.Format("~/bookdetails.aspx?id={0}", Item.Id) %>' runat="server" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>' />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No books in this category.
                   
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
