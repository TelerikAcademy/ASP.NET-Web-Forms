<%@ Page Language="C#" AutoEventWireup="true"
    Inherits="ApplicationState" Codebehind="ApplicationState.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>Application State - Demo</title>
</head>

<body>
    <form id="formApplicationState" runat="server">
        <div>
            <asp:Label ID="labelLoads" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="buttonAddLoad" runat="server" Text="Post Back"
              OnClick="buttonAddLoad_Click" />
        </div>
    </form>
</body>

</html>
