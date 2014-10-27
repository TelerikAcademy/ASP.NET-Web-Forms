<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LikeControl.ascx.cs" Inherits="LikesDemo.Controls.LikeControl" %>

<asp:Button runat="server" ID="ButtonLike" Text="Like" CommandName="Like" CommandArgument="<%# this.DataID %>" OnCommand="ButtonLike_Command" />
<asp:Label runat="server" ID="LableLikesCount" />
<asp:Button runat="server" ID="ButtonHate" Text="Hate" CommandName="Hate" CommandArgument="<%# this.DataID %>" OnCommand="ButtonLike_Command" />