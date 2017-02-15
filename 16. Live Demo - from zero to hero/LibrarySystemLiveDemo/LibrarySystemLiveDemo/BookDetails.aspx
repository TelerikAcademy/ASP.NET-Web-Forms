<%@ Page Language="C#" AutoEventWireup="true"
    MasterPageFile="~/Site.Master"
    CodeBehind="BookDetails.aspx.cs"
    Inherits="LibrarySystemLiveDemo.BookDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView runat="server" ID="FormViewBookDetails" ItemType="LibrarySystemLiveDemo.Data.Models.Book" SelectMethod="FormViewBookDetails_GetItem">
        <ItemTemplate>
            <header>
                <h1><%: Title %></h1>
                <p class="book-title"><%#: Item.Title %></p>
                <p class="book-author"><i>by <%#: Item.Author %></i></p>
                <p class="book-isbn"><i>ISBN <%#: Item.ISBN %></i></p>
                <p class="book-isbn">
                    <i>Web site: 
                    <a href="<%#: Item.WebSite %>"><%#: Item.WebSite %></a></i>
                </p>
            </header>
            <div class="row-fluid">
                <div class="span12 book-description">
                    <p><%#: Item.Description %></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

    <div class="back-link">
        <a href="/books">Back to books</a>
    </div>

</asp:Content>