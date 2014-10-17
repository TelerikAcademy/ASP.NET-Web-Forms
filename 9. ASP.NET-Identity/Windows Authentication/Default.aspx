<%@ Page Language="C#" AutoEventWireup="true" Inherits="_Default" Codebehind="Default.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Windows Authentication - Demo</title>
</head>

<body>
    <form id="formMain" runat="server">
    <table>
        <tr>
            <td>Authenticated:</td>
            <td><span runat="server" id="spnAuthenticated"></span></td>
        </tr>
        <tr>
            <td>User Name:</td>
            <td><span runat="server" id="spnUserName"></span></td>
        </tr>
        <tr>
            <td>Authentication Type:</td>
            <td><span runat="server" id="spnAuthenticationType"></span></td>
        </tr>
    </table>
    </form>
</body>

</html>
