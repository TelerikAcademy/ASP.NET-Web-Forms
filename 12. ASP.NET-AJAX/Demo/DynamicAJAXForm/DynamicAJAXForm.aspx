<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="DynamicAJAXForm.aspx.cs" Inherits="DynamicAJAXForm.DynamicAJAXForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <style type="text/css">
        .panel 
        {
            background: #F5F5F5;
            border: #999999 dotted 1px;
            padding: 5px;
        }
    </style>
    <title>Dynamic Form with Partial Rendering - Example</title>
</head>

<body>
    <form id="FormDynamic" runat="server">

        <asp:ScriptManager ID="ScriptManager" runat="server" />

        What is your favorite drink?<br />
        <asp:UpdatePanel ID="UpdatePanelFavoriteDrink" runat="server" class="panel"
            UpdateMode="Conditional">
            <ContentTemplate>
                <asp:RadioButton ID="RadioButtonBeer" runat="server" AutoPostBack="True" 
                    Text="Beer" oncheckedchanged="RadioButtonBeer_CheckedChanged" 
                    GroupName="GroupDrinks" />
                <asp:RadioButton ID="RadioButtonWine" runat="server" AutoPostBack="True" 
                    Text="Wine" oncheckedchanged="RadioButtonWine_CheckedChanged" 
                    GroupName="GroupDrinks" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />

        <asp:UpdatePanel ID="UpdatePanelBeersWines" runat="server">
            <ContentTemplate>
                <asp:Panel ID="PanelBeers" runat="server" Visible="false" class="panel">
                    Select your favorite beers:<br />
                    <asp:CheckBoxList ID="CheckBoxListBeers" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="CheckBoxListBeers_SelectedIndexChanged">
                        <asp:ListItem Text="Ariana" />
                        <asp:ListItem Text="Zagorka" />
                        <asp:ListItem Text="Shoumensko" />
                    </asp:CheckBoxList>
                </asp:Panel>
                <asp:Panel ID="PanelWines" runat="server" Visible="false" class="panel">
                    Select your favorite wines:<br />
                    <asp:CheckBoxList ID="CheckBoxListWines" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="CheckBoxListWines_SelectedIndexChanged">
                        <asp:ListItem Text="Merlo" />
                        <asp:ListItem Text="Cabernet Sauvignon" />
                    </asp:CheckBoxList>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />

        <asp:UpdatePanel ID="UpdatePanelResults" runat="server">
            <ContentTemplate>
                <asp:Panel ID="PanelResults" runat="server" Visible="false" class="panel">
                    Favorite drink: 
                    <asp:Literal ID="LiteralFavoriteDrink" runat="server" />
                    <br />
                    Selected drinks:
                    <asp:Literal ID="LiteralSelectedDrinks" runat="server" />
                    <br />
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>

    </form>
</body>

</html>
