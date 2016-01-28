<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LikeHateControl.ascx.cs" Inherits="NewsSystem.Web.Controls.LikeHateControl" %>

<asp:UpdatePanel ID="upLikeHate" runat="server">
    <ContentTemplate>
        <asp:Button Text="Like" ID="btnLike" OnClick="btnLike_Click" runat="server" CssClass="btn btn-default" />
        <asp:Button Text="Hate" ID="btnHate" OnClick="btnHate_Click" runat="server" CssClass="btn btn-default" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnLike" EventName="Click"/>
        <asp:AsyncPostBackTrigger ControlID="btnHate" EventName="Click"/>
    </Triggers>
</asp:UpdatePanel>