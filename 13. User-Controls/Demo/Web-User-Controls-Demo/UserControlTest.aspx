<%@ Page Language="C#" AutoEventWireup="true"
    Inherits="UserControlTest" CodeBehind="UserControlTest.aspx.cs" %>

<%@ Register Src="~/WelcomeLabel.ascx" TagPrefix="userControls"
    TagName="WelcomeLabel" %>



<!DOCTYPE html>

<html>

<head runat="server">
    <title>User Control Test</title>
</head>

<body>

    <form id="formUserControls" runat="server">
        <userControls:WelcomeLabel runat="server" ID="WelcomeLabel"
            Name="Evlogi" Color="Red" AlternateColor="Blue" />
        <%--<userControls:WelcomeLabel ID="WelcomeLabelPeter" runat="server"
        name="Peter" color="Red" alternateColor="Blue" />--%>
        <br />
        <userControls:WelcomeLabel ID="WelcomeLabelMaria" runat="server"
            Name="Maria" Color="#555555" AlternateColor="#999999" />

    </form>

</body>

</html>
