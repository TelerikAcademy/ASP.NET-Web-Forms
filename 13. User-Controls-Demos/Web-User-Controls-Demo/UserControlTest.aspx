<%@ Page Language="C#" AutoEventWireup="true"
  Inherits="UserControlTest" Codebehind="UserControlTest.aspx.cs" %>

<%@ Register src="WelcomeLabel.ascx" tagname="WelcomeLabel"
  tagprefix="userControls" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>User Control Test</title>
</head>

<body>

<form id="formUserControls" runat="server">
    <userControls:WelcomeLabel ID="WelcomeLabelPeter" runat="server"
        name="Peter" color="Red" alternateColor="Blue" />
    <br />
    <userControls:WelcomeLabel ID="WelcomeLabelMaria" runat="server"
        name="Maria" color="#555555" alternateColor="#999999" />
</form>

</body>

</html>
