<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login"
    Codebehind="Login.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Login Page</title>
</head>

<body>
    <form id="FormLogin" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    Username:
                </td> 
                <td>
                    <asp:TextBox ID="tbUsername" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td> 
                <td>
                    <asp:TextBox ID="tbPassword" runat="server"
                        TextMode="Password" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="right">
                    <asp:Button ID="btnLogin" runat="server" Text="Login"
                        OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <h1>
                        <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
                    </h1>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>

</html>
