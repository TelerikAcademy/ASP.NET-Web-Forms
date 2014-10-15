<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServerControls.aspx.cs" Inherits="Web_Server_Controls.WebServerControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Web Server Controls - Example</title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:Label ID="LabelResult" runat="server" Text="" Visible="false" />
        <asp:TextBox ID="TextBoxInput" runat="server" />
        <asp:Button ID="ButtonSubmit" runat="server" 
            Text="Submit" OnClick="ButtonSubmit_Click" />
    </form>
</body>
</html>
