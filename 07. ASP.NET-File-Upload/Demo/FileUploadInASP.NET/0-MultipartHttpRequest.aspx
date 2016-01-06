<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="0-MultipartHttpRequest.aspx.cs" Inherits="FileUploadInASP.NET._0_MultipartHttpRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="multipartrequest" enctype="multipart/form-data" runat="server">
        <asp:TextBox runat="server" ID="FirstName" Text="Name" />
        <asp:FileUpload runat="server" ID="FirstFile" />
        <asp:TextBox runat="server" ID="SecondName" Text="Name" />
        <asp:FileUpload runat="server" ID="SecondFile" />
        <asp:TextBox runat="server" ID="ThirdName" Text="Name" />
        <asp:FileUpload runat="server" ID="ThirdFile" />
        <asp:Button runat="server" Text="Upload" ID="Submit" OnClick="Submit_Click" />
    </form>
</body>
</html>
