<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="EditCustomer.aspx.cs" Inherits="GridViewDemo.EditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Edit Customer</title>
</head>

<body>
    <form id="FormEditCustomer" runat="server">
       <h1>Edit customer</h1>
       CustomerID:
       <asp:Literal Text="text" runat="server" id="LiteralCustomerId" Mode="Encode" />
    </form>
</body>

</html>
