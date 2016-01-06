<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="WebFormTestNimericBox.aspx.cs" 
    Inherits="UserControlsExample.WebFormTestNimericBox" %>

<%@ Register src="NumericBox.ascx" tagname="NumericBox"
    tagprefix="userControls" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Test Numeric Box</title>
</head>

<body>
    <form id="form" runat="server">
        <userControls:NumericBox runat="server" 
            ID="NumberixBoxAge" Value="50" 
            OnValueChanged="NumberixBoxAge_ValueChanged" />
        
        <asp:Label ID="LabelInfo" runat="server" Visible ="false"/>
    </form>
</body>

</html>
