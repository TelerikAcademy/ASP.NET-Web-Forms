<%@ Page Language="C#" AutoEventWireup="true" Inherits="TimerDemo"
    Codebehind="TimerDemo.aspx.cs" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
    "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <title>ASP.NET AJAX Demo - Timer</title>
    <link rel="Stylesheet" type="text/css" href="Site.css" />
</head>

<body>
    <form id="FormTimer" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <p>This text is not updated by the partial rendering.</p>
        <asp:UpdatePanel runat='server' ID='UpdatePanelTime' UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TimerTimeRefresh" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                AJAX Timer updates per 3 seconds:
                <%= DateTime.Now.ToString("hh:mm:ss") %>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Timer ID="TimerTimeRefresh" runat="Server" Interval="3000" />
        <p>This text is also not updated.</p>
    </form>
</body>

</html>
