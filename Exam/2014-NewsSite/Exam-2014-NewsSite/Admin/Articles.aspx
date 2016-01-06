<%@ Page Title="Edit Articles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="NewsSite.Admin.Articles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewArticles" ItemType="NewsSite.Models.Article" DataKeyNames="ID" SelectMethod="ListViewArticles_GetData" InsertMethod="ListViewArticles_InsertItem" UpdateMethod="ListViewArticles_UpdateItem" DeleteMethod="ListViewArticles_DeleteItem" InsertItemPosition="LastItem" OnSorting="ListViewArticles_Sorting">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" ID="ButtonSortByTitle" CssClass="col-md-2 btn btn-default" Text="Sort by Title" CommandArgument="Title" CommandName="Sort" />
                <asp:LinkButton runat="server" ID="ButtonSortByDate" CssClass="col-md-2 btn btn-default" Text="Sort by Date" CommandArgument="DateCreated" CommandName="Sort" />
                <asp:LinkButton runat="server" ID="ButtonSortByCategory" CssClass="col-md-2 btn btn-default" Text="Sort by Category" CommandArgument="Category.Name" CommandName="Sort" />
                <asp:LinkButton runat="server" ID="ButtonSortByLikes" CssClass="col-md-2 btn btn-default" Text="Sort by Likes" CommandArgument="Likes.Count" CommandName="Sort" />
            </div>
            <div runat="server" id="itemPlaceHolder"></div>
            <div class="row">
                <asp:DataPager runat="server" ID="DataPagerArticles" PagedControlID="ListViewArticles" PageSize="5">
                    <Fields>
                        <asp:NextPreviousPagerField ShowNextPageButton="false" ShowPreviousPageButton="true" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ShowNextPageButton="true" ShowPreviousPageButton="false" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <h3><%#: Item.Title %>
                    <asp:LinkButton runat="server" ID="ButtonEditArticle" CssClass="btn btn-info " Text="Edit" CommandName="Edit" />
                    <asp:LinkButton runat="server" ID="ButtonDeleteArticle" CssClass="btn btn-danger" Text="Delete" CommandName="Delete" />
                </h3>
                <p>Category: <%#: Item.Category.Name %></p>
                <p>
                    <%#: Item.Content.Length > 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content  %>
                </p>
                <p>Likes count: <%#: Item.Likes.Count %></p>
                <div>
                    <i>by <%#: Item.Author.UserName ?? "" %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <h3>
                    <asp:TextBox runat="server" ID="TextBoxEditTitle" Text="<%# BindItem.Title %>" />
                    <asp:RequiredFieldValidator ErrorMessage="Title is required" ValidationGroup="EditArticle" ControlToValidate="TextBoxEditTitle" ForeColor="Red" runat="server" />
                    <asp:LinkButton runat="server" ID="ButtonEditArticle" CssClass="btn btn-success" Text="Save" CommandName="Update" CausesValidation="true" ValidationGroup="EditArticle" />
                    <asp:LinkButton runat="server" ID="ButtonDeleteArticle" CssClass="btn btn-danger" Text="Cancel" CommandName="Cancel" CausesValidation="false" />
                </h3>
                <p>
                    <asp:DropDownList runat="server" ID="DropDownListCategories"
                        SelectedValue="<%#: BindItem.CategoryID %>" DataTextField="Name" DataValueField="ID" SelectMethod="DropDownListCategories_GetData" />
                <p>
                    <asp:TextBox runat="server" ID="TextBoxEditContent" Text="<%# BindItem.Content %>" TextMode="MultiLine" Rows="6" Width="100%" /><asp:RequiredFieldValidator ErrorMessage="Content is required" ValidationGroup="EditArticle" ControlToValidate="TextBoxEditContent" ForeColor="Red" runat="server" />
                </p>
                <div>
                    <i>by <%#: this.User.Identity.GetUserName() %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </EditItemTemplate>
        <InsertItemTemplate>
            <a href="#" id="buttonShowInsertPanel" class="btn btn-info pull-right" onclick="(function (ev) { $('#panelInsertArticle').show(); $('#buttonShowInsertPanel').hide(); }())">Insert new Article</a>
            <div id="panelInsertArticle" style="display: none;">

                <div class="row">
                    <h3>Title: 
                    <asp:TextBox runat="server" ID="TextBoxInsertTitle" Width="300" Text="<%#: BindItem.Title %>"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Title is required!" ValidationGroup="InsertArticle" ControlToValidate="TextBoxInsertTitle" ForeColor="Red" runat="server" />
                    </h3>
                    <p>
                        Category: 
                    <asp:DropDownList runat="server" ID="DropDownListCategories" ItemType="NewsSite.Models.Category" DataTextField="Name" SelectedValue="<%#: BindItem.CategoryID %>" DataValueField="ID" SelectMethod="DropDownListCategories_GetData">
                    </asp:DropDownList>
                    </p>
                    <p>
                        Content: 
                    <asp:TextBox runat="server" ID="TextBoxInsertContent" Width="300" TextMode="MultiLine" Text="<%#: BindItem.Content %>" Rows="6"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Content is Required!" ValidationGroup="InsertArticle" ControlToValidate="TextBoxInsertContent" ForeColor="Red" runat="server" />
                    </p>
                    <div>
                        <asp:LinkButton runat="server" ID="ButtonInsertArticle" CssClass="btn btn-success" CommandName="Insert" Text="Insert" CausesValidation="true" ValidationGroup="InsertArticle" />
                        <asp:LinkButton runat="server" ID="LinkButton1" CssClass="btn btn-danger" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                    </div>
                </div>
            </div>
        </InsertItemTemplate>
    </asp:ListView>

</asp:Content>
