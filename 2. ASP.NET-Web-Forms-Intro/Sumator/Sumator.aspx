<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Sumator.aspx.cs"
    Inherits="Sumator.Sumator" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ASP.NET Web Forms Sumator</title>
</head>

<body>
    <form id="formSumator" runat="server">
    <h1>Sumator</h1>
    First number:
    <asp:TextBox ID="TextBoxFirstNum" runat="server"></asp:TextBox>
    <br />
    Second number:  
    <asp:TextBox ID="TextBoxSecondNum" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonCalculateSum" runat="server" 
        onclick="ButtonCalculateSum_Click" Text="Calculate Sum" />
    <br />
    Sum:
    <asp:TextBox ID="TextBoxSum" runat="server"></asp:TextBox>
    </form>
</body>

</html>
