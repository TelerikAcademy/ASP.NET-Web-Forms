<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticles.aspx.cs" Inherits="NewsSystem.Private.ViewArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="lvArticles" runat="server"
        DataKeyNames="Id"
        ItemType="NewsSystem.Models.Article"
        SelectMethod="lvArticles_GetData"
        DeleteMethod="lvArticles_DeleteItem"
        UpdateMethod="lvArticles_UpdateItem"
        InsertMethod="lvArticles_InsertItem"
        InsertItemPosition="None">
        <LayoutTemplate>
            <asp:HyperLink NavigateUrl="?orderBy=Title" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=DateCreated" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Category.Name" Text="Sort by Category" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Likes.Count()" Text="Sort by Likes" runat="server" CssClass="btn btn-md-2 btn-default" />

            <div class="row" id="itemPlaceholder" runat="server"></div>
            <br />
            <br />
            <asp:DataPager runat="server" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>

            <asp:Button Text="Insert new article" runat="server" OnClick="Unnamed_Click" CssClass="btn btn-info pull-right" />
        </LayoutTemplate>
        <ItemTemplate>
            <h3><%#: Item.Title %>
                <asp:Button Text="Edit" CommandName="Edit" runat="server" CssClass="btn btn-info" />
                <asp:Button Text="Delete" CommandName="Delete" runat="server" CssClass="btn btn-danger" />
            </h3>
            <p>Category: <%#: Item.Category.Name %></p>
            <p><%#: Item.Content.Length >= 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content %></p>
            <p>Likes: <%# Item.Likes.Count %></p>
            <i>by <%#: Item.Author.UserName %> on <%# Item.DateCreated %></i>
        </ItemTemplate>
        <InsertItemTemplate>
            <h3>Title:
                <asp:TextBox Text="<%# BindItem.Title %>" ID="tbInsertArticle" runat="server" />
            </h3>
            <p>
                Category:
                <asp:DropDownList
                    ID="ddlInsertCategory"
                    runat="server"
                    DataTextField="Name"
                    DataValueField="Id"
                    SelectMethod="ddlInsertCategory_GetData"
                    SelectedValue="<%# BindItem.CategoryId %>">
                </asp:DropDownList>
            </p>
            <p>
                Content:
                <asp:TextBox Text="<%# BindItem.Content %>" ID="tbContent" runat="server" TextMode="MultiLine" Rows="8" />
            </p>
            <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
            <asp:Button Text="Cancel" runat="server" CssClass="btn btn-danger" />
        </InsertItemTemplate>
        <EditItemTemplate>
            <h3>
                <asp:TextBox Text="<%# BindItem.Title %>" ID="tbInsertArticle" runat="server" />
            </h3>
            <p>
                <asp:DropDownList
                    ID="ddlInsertCategory"
                    runat="server"
                    DataTextField="Name"
                    DataValueField="Id"
                    SelectMethod="ddlInsertCategory_GetData"
                    SelectedValue="<%# BindItem.CategoryId %>">
                </asp:DropDownList>
            </p>
            <p>
                <asp:TextBox Text="<%# BindItem.Content %>" ID="tbContent" runat="server" TextMode="MultiLine" Rows="8" Width="100%" />
            </p>
            <asp:Button Text="Save" CommandName="Update" runat="server" CssClass="btn btn-success" />
            <asp:Button Text="Cancel" runat="server" CssClass="btn btn-danger" />
        </EditItemTemplate>
    </asp:ListView>
</asp:Content>
