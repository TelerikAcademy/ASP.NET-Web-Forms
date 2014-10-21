<%@ Control Language="C#" AutoEventWireup="true"
  CodeBehind="WelcomeLabel.ascx.cs"
  Inherits="Custom_Controls_Demo.WelcomeLabel" %>

<script type="text/javascript">
    function changeColor(sender, color) {
        sender.style.color = color;
    }
    function restoreColor(sender, color) {
        sender.style.color = color;
    }
</script>

<asp:Label ID="LabelWelcome" runat="server" />
