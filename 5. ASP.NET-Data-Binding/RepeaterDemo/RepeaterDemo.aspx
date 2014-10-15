<%@ Page Language="C#" AutoEventWireup="true"
  Inherits="RepeaterDemo" Codebehind="RepeaterDemo.aspx.cs" %>

<!DOCTYPE html>

<html>

<head>
    <title>Repeater - Demo</title>
</head>

<body>
    <form id="formRepeaterDemo" runat="server">
        
        <h3>Using Repeater to show the sites as plain text using DataBinder.Eval(...)</h3>
        <asp:Repeater ID="RepeaterSites" runat="server">
            <ItemTemplate>
                <%#: DataBinder.Eval(Container.DataItem, "Id") %>,
                <%#: DataBinder.Eval(Container.DataItem, "Name") %>,
                <%#: DataBinder.Eval(Container.DataItem, "URL") %>,
                <%#: DataBinder.Eval(Container.DataItem, "ImageURL") %>
                <br />
            </ItemTemplate>
        </asp:Repeater>

        <h3>Using Repeater to show the sites as unordered list using Eval(...)</h3>
        <asp:Repeater ID="RepeaterTemplatedList" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <a href="<%#: Eval("URL") %>"><%#: Eval("Name") %></a>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>

        <h3>Using Repeater to show the sites as images using strongly-typed binding (Item.PropertyPath)</h3>
        <asp:Repeater ID="RepeaterImages" runat="server" ItemType="Site">
            <ItemTemplate>
                <p><a href='<%#: Item.URL %>'><img src='<%#: Item.ImageURL %>'
                    border="0" alt='<%#: Item.Name %>' style="width:300px" /></a></p>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>

</html>
