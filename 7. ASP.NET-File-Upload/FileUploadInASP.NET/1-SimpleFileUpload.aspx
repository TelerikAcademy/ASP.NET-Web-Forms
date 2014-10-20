<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1-SimpleFileUpload.aspx.cs" Inherits="FileUploadInASP.NET.SimpleFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FileUploadForm" runat="server">
        <asp:FileUpload ID="FileUploadControl" runat="server" />
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
        <br />
        <br />
        <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " />
    </form>
</body>
</html>
