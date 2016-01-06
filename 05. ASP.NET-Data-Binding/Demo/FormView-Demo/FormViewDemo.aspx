<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="FormViewDemo.aspx.cs"
  Inherits="FormView_Demo.FormViewDemo" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>FormView - Demo</title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:FormView ID="FormViewCustomer" runat="server" AllowPaging="True" 
            onpageindexchanging="FormViewCustomer_PageIndexChanging" DataKeyName="ID">
            <ItemTemplate>
                <h3><%#: Eval("FirstName") + " " + Eval("LastName") %></h3>
                <table border="0">
                    <tr>
                        <td>Phone:</td>
                        <td><%#: Eval("Phone")%></td>
                    </tr>
                    <tr>
                        <td>E-Mail:</td>
                        <td><%#: Eval("Email")%></td>
                    </tr>
                </table>
                <asp:LinkButton ID="EditButton" runat="server" CommandArgument="ID" OnCommand="EditButton_Command" Text="Edit"></asp:LinkButton>
                <hr />
            </ItemTemplate>
            <EditItemTemplate>
                <h3><%#: Eval("FirstName") + " " + Eval("LastName") %></h3>
                <table border="0">
                    <tr>
                        <td>Phone:</td>
                        <td><asp:TextBox ID="TextBoxPhone" runat="server" 
                            Text='<%# Eval("Phone") %>' /> </td>
                    </tr>
                    <tr>
                        <td>E-Mail:</td>
                        <td><asp:TextBox ID="TextBoxEmail" runat="server" 
                            Text='<%# Eval("Email") %>' /> </td>
                    </tr>
                </table>
                <hr />
            </EditItemTemplate>
        </asp:FormView>

        <asp:MultiView ID="MultiViewButtons" runat="server" ActiveViewIndex="0">
            <asp:View ID="ViewNormalMode" runat="server">
                <asp:LinkButton ID="LinkButtonEdit" runat="server" 
                    onclick="LinkButtonEdit_Click" Text="Edit" />
            </asp:View>
            <asp:View ID="ViewEditMode" runat="server">
                <asp:LinkButton ID="LinkButtonSave" runat="server" 
                    onclick="LinkButtonSave_Click" Text="Save" />
                <asp:LinkButton ID="LinkButtonCancel" runat="server" 
                    onclick="LinkButtonCancel_Click" Text="Cancel" />
            </asp:View>
        </asp:MultiView>
    </form>
</body>

</html>
