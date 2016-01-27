<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="NewsSystem.ViewArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="fvArticle"
        SelectMethod="fvArticle_GetItem"
        ItemType="NewsSystem.Models.Article">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">

                            <div>
                                <div class="like-control col-md-1">
                                    <newsSystem:LikeHate runat="server" ID="likeHateControl"/>
                                </div>
                            </div>
                            <h2><%#: Item.Title %> <small>Category: <%# Item.Category.Name %></small></h2>
                            <p>
                                <%#: Item.Content %>
                            </p>
                            <p>
                                <span>Author: <%#: Item.Author.UserName %></span>
                                <span class="pull-right"><%# Item.DateCreated %></span>
                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
