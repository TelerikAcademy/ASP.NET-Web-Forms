<%@ Page Language="C#" AutoEventWireup="true" Inherits="ChangePassword"
    Codebehind="ChangePassword.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Change Password</title>
</head>

<body>
    <form id="FormChangePassword" runat="server">
        <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99"
            BorderStyle="Solid" BorderWidth="1px" ContinueDestinationPageUrl="~/Default.aspx"
            Font-Names="Verdana" Font-Size="10pt" CancelDestinationPageUrl="~/Default.aspx">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        </asp:ChangePassword>    
    </form>
</body>

</html>
