<%@ Page Language="C#" AutoEventWireup="true" Inherits="PostBacksDemo"
    CodeBehind="PostBacksDemo.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN"
    "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <link href="Site.css" rel="stylesheet" type="text/css" />
    <title>ASP.NET AJAX Partial vs Full Postbacks Demo</title>
</head>

<body>
    <form id="formDemo" runat="server">
    
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    
    <div class="panel">
        ASP.NET Regular controls causing full postback:
        <br />
        <asp:DropDownList ID="DropDownListFullPostBack" runat="server" AutoPostBack="true">
            <asp:ListItem Text="Item 1" />
            <asp:ListItem Text="Item 2" />
            <asp:ListItem Text="Item 3" />
        </asp:DropDownList>
        &nbsp; &nbsp;
        <asp:Button ID="ButtonFullPostBack" runat="server" Text="Full Post Back" />
        <br />
    </div>

    <asp:UpdatePanel ID="UpdatePanelCountriesTowns" UpdateMode="Conditional"
        runat="server" class="panel">
        <ContentTemplate>
            Controls inside an update panel causing partial postback:
            <br />
            <asp:DropDownList ID="DropDownListCountries" runat="server"
                DataTextField="Name" DataValueField="CountryID"
                AutoPostBack="true" OnSelectedIndexChanged="DropDownListCountries_Changed">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownListTowns" runat="server"
                DataTextField="Name" DataValueField="TownID">
            </asp:DropDownList>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    
    More controls inside another update panel (causing partial postback,
    showing a progress indicator):
    
    <br />    
    <asp:UpdateProgress ID="UpdateProgressDemo" runat="server">
        <ProgressTemplate>
            Updating ...
        </ProgressTemplate>
    </asp:UpdateProgress>
    
    <asp:UpdatePanel ID="UpdatePanelInfo" runat="server"
        UpdateMode="Conditional" class="panel">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DropDownListCountries"
                EventName="SelectedIndexChanged" />
        </Triggers>
        <ContentTemplate>
            Server Time:
            <%= DateTime.Now.ToString("HH:mm:ss") %>
            <br />
            <asp:Button ID="ButtonPartialPostBack" runat="server"
                Text="Partial Post Back" OnClick="ButtonPartialPostBack_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>

</html>
