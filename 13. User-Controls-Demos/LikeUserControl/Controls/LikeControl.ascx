<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LikeControl.ascx.cs" Inherits="LikeUserControl.Controls.LikeControl" %>

<div runat="server" id="likeWrapper" class="like-panel">
    <asp:UpdatePanel runat="server" ID="UpdatePanelLike" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:Button ID="ButtonLike" runat="server" Text="+" ToolTip="Like" CssClass="btn like" OnClick="ButtonLike_Click" />
            <asp:Label ID="LabelLikes" runat="server" Width="25"></asp:Label>
            <asp:Button ID="ButtonDislike" runat="server" Text="-" ToolTip="Dislike" CssClass="btn dis-like" OnClick="ButtonDislike_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
