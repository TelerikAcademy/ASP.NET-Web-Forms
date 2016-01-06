<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="LibrarySystem.BookDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:FormView runat="server" ID="FormViewBookDetails" ItemType="LibrarySystem.Models.Book" SelectMethod="FormViewBookDetails_GetItem">
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
        <a href="/">Back to books</a>
    </div>
</asp:Content>
