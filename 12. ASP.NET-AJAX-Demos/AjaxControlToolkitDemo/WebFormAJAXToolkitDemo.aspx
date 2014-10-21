<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="WebFormAJAXToolkitDemo.aspx.cs"
    Inherits="AjaxControlToolkitDemo.WebFormAJAXToolkitDemo"
%>

<%@ Register Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="ajaxtoolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>

<body>
    <form id="formMain" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <ajaxtoolkit:Editor ID="Editor" runat="server" />
    </form>
</body>

</html>
