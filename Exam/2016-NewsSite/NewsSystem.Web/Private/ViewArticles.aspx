<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticles.aspx.cs" Inherits="NewsSystem.Web.Private.ViewArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="lvArticles"
        ItemType="NewsSystem.Data.Models.Article"
        DataKeyNames="Id"
        SelectMethod="lvArticles_GetData"
        UpdateMethod="lvArticles_UpdateItem"
        DeleteMethod="lvArticles_DeleteItem"
        InsertMethod="lvArticles_InsertItem"
        InsertItemPosition="None">
        <LayoutTemplate>
            <asp:HyperLink NavigateUrl="?orderBy=Title" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=DateCreated" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Category.Name" Text="Sort by Category" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Likes.Count()" Text="Sort by Likes" runat="server" CssClass="btn btn-md-2 btn-default" />
            <div runat="server" id="itemPlaceholder"></div>
            <asp:Button Text="Insert new article" runat="server" OnClick="Unnamed_Click" CssClass="btn btn-info pull-right" />
            <br />
            <br />
            <asp:DataPager runat="server" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
            <h2>
                <%#: Item.Title %>
                <asp:Button Text="Edit" CommandName="Edit" runat="server" CssClass="btn btn-info" />
                <asp:Button Text="Delete" CommandName="Delete" runat="server" CssClass="btn btn-danger" />
            </h2>
            <p>Category: <%#: Item.Category.Name %></p>
            <p><%#: Item.Content.Length > 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content %></p>
            <p><%# Item.Likes.Count() %></p>
            <i>by <%#: Item.Author.UserName %> on: <%# Item.DateCreated %></i>
        </ItemTemplate>
        <EditItemTemplate>
            <h2>
                <asp:TextBox runat="server" ID="tbEditTitle" Text="<%#: BindItem.Title %>" />
                <asp:Button Text="Save" CommandName="Update" runat="server" CssClass="btn btn-success" />
                <asp:Button Text="Cancel" CommandName="Cancel" runat="server" CssClass="btn btn-danger" />
            </h2>
            <p>
                <asp:DropDownList runat="server" ID="ddlCategories"
                    ItemType="NewsSystem.Data.Models.Category"
                    DataValueField="Id"
                    DataTextField="Name"
                    SelectedValue="<%# BindItem.CategoryId %>"
                    SelectMethod="ddlCategories_GetData" />
            </p>
            <p>
                <asp:TextBox runat="server" ID="tbEditContent" Text="<%#: BindItem.Content %>" TextMode="MultiLine" Rows="7" Width="100%" />
            </p>

        </EditItemTemplate>
        <InsertItemTemplate>
            <h3>Title:
                <asp:TextBox runat="server" ID="tbInsertTitle" Text="<%#: BindItem.Title %>" />
            </h3>
            <asp:RequiredFieldValidator ForeColor="Red" ErrorMessage="Title is required!" ControlToValidate="tbInsertTitle" runat="server" EnableClientScript="false" />
            <asp:CustomValidator ErrorMessage="Title too short!" ControlToValidate="tbInsertTitle" OnServerValidate="Unnamed_ServerValidate" runat="server" />
            <asp:RegularExpressionValidator ErrorMessage="Title contains bad symbols!" ControlToValidate="tbInsertTitle" ValidationExpression="^[a-z|A-Z]+" runat="server" EnableClientScript="false" />
            <p>
                Category:
                <asp:DropDownList runat="server" ID="ddlCategories"
                    ItemType="NewsSystem.Data.Models.Category"
                    DataValueField="Id"
                    DataTextField="Name"
                    SelectedValue="<%# BindItem.CategoryId %>"
                    SelectMethod="ddlCategories_GetData" />
            </p>
            <p>
                Content:
                <asp:TextBox runat="server" ID="tbEditContent" Text="<%#: BindItem.Content %>" TextMode="MultiLine" Rows="5" />
            </p>
            <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
            <asp:Button Text="Cancel" OnClick="Unnamed_Click1" runat="server" CssClass="btn btn-danger" />
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>
