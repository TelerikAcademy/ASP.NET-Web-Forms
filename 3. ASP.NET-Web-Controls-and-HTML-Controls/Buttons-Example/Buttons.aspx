<%@ Page Language="C#" AutoEventWireup="true" Inherits="Buttons" Codebehind="Buttons.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Buttons - Example</title>
</head>

<body>
    <form id="formMain" runat="server">
        
        <asp:Button ID="ButtonExamplå" 
            runat="server" 
            CommandName="ButtonNormalCmd" 
            OnClick="OnBtnClick"
            OnCommand="OnCommand" 
            Text="Normal Button" />
        
        <br />

        <asp:LinkButton ID="LinkButtonExample"
            runat="server"
            CommandName="LinkButtonCmd"
            OnClick="OnBtnClick"
            Text="Link Button"
            OnCommand="OnCommand"/>
        
        <br />

        <asp:ImageButton ID="ImageButtonExample"
            runat="server"
            CommandName="ImageButtonCmd"
            ImageUrl="~/images/DotNet_Logo_Small.gif"
            OnCommand="OnCommand"
            OnClick="OnBtnClick" />        
        
        <br />

        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>

    </form>
</body>

</html>
