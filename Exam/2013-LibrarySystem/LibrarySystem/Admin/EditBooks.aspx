<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditBooks.aspx.cs" Inherits="LibrarySystem.Admin.EditBooks" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="GridViewBooks" ItemType="LibrarySystem.Models.Book" SelectMethod="GridViewBooks_GetData" UpdateMethod="GridViewBooks_UpdateItem" DeleteMethod="GridViewBooks_DeleteItem" AllowSorting="True" AllowPaging="True" PageSize="5" AutoGenerateColumns="false" DataKeyNames="ID">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
            <asp:BoundField DataField="WebSite" HeaderText="Web Site" SortExpression="WebSite" />
            <asp:BoundField DataField="Category.Name" HeaderText="Category" SortExpression="Category.Name" />
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>

    <div runat="server" id="btnWrapper">
        <asp:LinkButton Text="Insert" ID="LinkButtonInsert" runat="server" OnClick="LinkButtonInsert_Click" />
    </div>

    <asp:UpdatePanel runat="server" ID="UpdatePanelInsertBook" CssClass="panel">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="LinkButtonInsert" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:FormView runat="server" ID="FormViewIsertBook" DefaultMode="Insert" ItemType="LibrarySystem.Models.Book"
                InsertMethod="FormViewIsertBook_InsertItem" Visible="false">
                <InsertItemTemplate>
                    <h2>Create New Book</h2>
                    <div>
                        <span>Title:</span>
                        <asp:TextBox runat="server" ID="TextBoxBookTitleCreate" placeholder="Enter book title ..." Text=" <%#: BindItem.Title %>">                           
                        </asp:TextBox>
                    </div>
                    <div>
                        <span>Author(s):</span>
                        <asp:TextBox runat="server" ID="TextBoxAuthorCreate" placeholder="Enter book author / authors ..." Text=" <%#: BindItem.Author %>">                           
                        </asp:TextBox>
                    </div>
                    <div>
                        <span>ISBN:</span>
                        <asp:TextBox runat="server" ID="TextBoxISBNCreate" placeholder="Enter book ISBN ..." Text=" <%#: BindItem.ISBN %>">                           
                        </asp:TextBox>
                    </div>
                    <div>
                        <span>Web site:</span>
                        <asp:TextBox runat="server" ID="TextBoxWebSiteCreate" placeholder="Enter book web site ..." Text=" <%#: BindItem.WebSite %>">                           
                        </asp:TextBox>
                    </div>
                    <div>
                        <span>Description:</span>
                        <asp:TextBox runat="server" ID="TextBoxDescriptionCreate" placeholder="Enter book description ..." Text=" <%#: BindItem.Description %>" TextMode="MultiLine" Height="160">
                        </asp:TextBox>
                    </div>
                    <div>
                        <span>Category:</span>
                        <asp:DropDownList runat="server" ID="DropDownListCategoriesCreate" DataTextField="Name" DataValueField="ID" ItemType="LibrarySystem.Models.Category" SelectedValue="<%#: BindItem.CategoryID %>" SelectMethod="DropDownListCategoriesCreate_GetData">
                        </asp:DropDownList>
                    </div>
                    <asp:LinkButton runat="server" ID="LinkButtonCreate" CssClass="link-button" Text="Create" CommandName="Insert"  />
                    <asp:LinkButton runat="server" ID="LinkButtonCancel" CssClass="link-button" Text="Cancel" CommandName="Cancel" PostBackUrl="~/Admin/EditBooks.aspx" />
                </InsertItemTemplate>
            </asp:FormView>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
