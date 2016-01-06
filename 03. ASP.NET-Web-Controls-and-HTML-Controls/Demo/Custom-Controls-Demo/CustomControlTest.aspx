<%@ Page Language="C#" AutoEventWireup="true" Inherits="CustomControlTest" 
  Codebehind="CustomControlTest.aspx.cs" %>
<%@ Register TagPrefix="aspSample" Namespace="Custom_Controls_Demo" 
  Assembly="Custom-Controls-Demo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Custom Controls - Demo</title>
</head>

<body>
    <form id="formMain" runat="server">
        <aspSample:WelcomeLabel Text="Hello" ID="WelcomeLabel" 
              runat="server" BackColor="Wheat" ForeColor="SaddleBrown" />
    </form>
</body>

</html>
