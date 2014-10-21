<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="NumericBox.ascx.cs"
    Inherits="UserControlsExample.NumericBox" %>
<asp:TextBox ID="TextBoxNumber" runat="server" ReadOnly="True" Width="62px">1</asp:TextBox>
<asp:Button ID="ButtonIncrease" runat="server" Text="+" 
    onclick="ButtonIncrease_Click" />
<asp:Button ID="ButtonDecrease" runat="server" Text="-" 
    onclick="ButtonDecrease_Click" style="width: 20px" />

