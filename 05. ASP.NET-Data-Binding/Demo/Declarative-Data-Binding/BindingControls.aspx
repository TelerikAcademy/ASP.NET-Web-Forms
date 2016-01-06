<%@ Page Language="C#" AutoEventWireup="true"
  Inherits="BindingControls"
  Codebehind="BindingControls.aspx.cs" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Declarative Data Binding Demo</title>
</head>

<body>
    <form id="FormBindingControls" runat="server">
        <asp:DropDownList ID="DropDownListOccupation" 
            AutoPostBack="true" runat="server">
            <asp:ListItem>Development Manager</asp:ListItem>
            <asp:ListItem>Developer</asp:ListItem>
            <asp:ListItem>QA Engineer &lt;script&gt;</asp:ListItem>
            <asp:ListItem>Front-End Developer</asp:ListItem>
        </asp:DropDownList>

        <p>
        You selected:
        <asp:Label ID="LabelSelectedValue" runat="server"
            Text="<%#: this.DropDownListOccupation.SelectedItem.Text %>" />
        </p>

        <p>
        Random number:
        <asp:Label ID="LabelRandom" runat="server"
            Text="<%# this.GetRandomNumber() %>" />
        </p>

        <p>
        Towns:
        <asp:ListBox ID="ListBoxTowns" runat="server"
            Rows="4" AutoPostBack="true" 
            DataSource="<%# this.Towns %>" />
        </p>

        <p>
        Manager:
        <asp:TextBox ID="TextBoxPerson" runat="server" ReadOnly="true"
            Text="<%# this.Manager.FirstName + ' ' +  this.Manager.LastName%>" />
        </p>

        <p>
        People (strongly-typed binding):
        <ul>
            <asp:Repeater ID="RepeaterPeople" runat="server" 
                DataSource="<%# GetPeople() %>" ItemType="Person">
                <ItemTemplate>
                    <li><%#: Item.FirstName %> <%#: Item.LastName %></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        </p>
    </form>
</body>

</html>
