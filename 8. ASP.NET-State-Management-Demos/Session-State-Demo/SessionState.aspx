<%@ Page Language="C#" AutoEventWireup="true" Inherits="SessionState"
    Codebehind="SessionState.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Session State - Demo</title>
</head>

<body>
    <form id="formSessionState" runat="server">
        <div>
            <asp:Label ID="LabelPageLoads" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="ButtonAddLoad" runat="server" Text="Post Back"
                OnClick="buttonAddLoad_Click" />
        </div>
    </form>
</body>

</html>
