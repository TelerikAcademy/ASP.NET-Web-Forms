<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LikeHateControl.ascx.cs" Inherits="NewsSystem.Controls.LikeHateControl" %>

<asp:UpdatePanel runat="server" ID="UpdatePanel">
    <ContentTemplate>
        <asp:Button Text="Like" ID="btnLike" OnClick="btnLike_Click" runat="server" />
        <asp:Button Text="Hate" ID="btnHate" OnClick="btnHate_Click" runat="server" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnLike" EventName="Click" />
        <asp:AsyncPostBackTrigger ControlID="btnHate" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>
