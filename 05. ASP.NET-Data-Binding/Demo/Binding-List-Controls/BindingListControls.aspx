<%@ Page Language="C#" AutoEventWireup="true"
  CodeBehind="BindingListControls.aspx.cs"
  Inherits="Binding_List_Controls.BindingListControls" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Binding List Controls - Demo</title>
    <link rel="Stylesheet" href="Site.css" type="text/css" />
</head>

<body>
    <form id="formMain" runat="server">
        <h1>Navigation Menu</h1>
        <asp:BulletedList ID="BulletedListMenu" runat="server" DisplayMode="HyperLink"
            DataTextField="Text" DataValueField="Url"></asp:BulletedList>

        <h1>List Controls</h1>
        <table id="layoutTable">
            <tr>
                <td>Choose town from the ListBox:</td>
                <td><asp:ListBox ID="ListBoxTowns" runat="server"></asp:ListBox></td>
            </tr>
            <tr>
                <td>Select your gender from the DropDownList:</td>
                <td><asp:DropDownList ID="DropDownListGender" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Select your favourite food from the CheckBoxList:</td>
                <td><asp:CheckBoxList ID="CheckBoxListFood" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:CheckBoxList></td>
            </tr>
            <tr>
                <td>Select how you will pay from the RadioButtonList:</td>
                <td><asp:RadioButtonList ID="RadioButtonListPayment" runat="server"
                    DataTextField="Text" DataValueField="ID"></asp:RadioButtonList></td>
            </tr>
            <tr>
                <td colspan="2" id="submitButtonCell">
                    <asp:Button ID="ButtonSubmit" runat="server"
                        Text="Process Form Data" onclick="ButtonSubmit_Click" />
                </td>
            </tr>
            <tr id="ResultsRow" runat="server" visible="false">
                <td colspan="2">
                    <asp:Literal ID="LiteralResult" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </form>
</body>

</html>
