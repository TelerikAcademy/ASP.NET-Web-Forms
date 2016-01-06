<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Strongly_Typed_Session_Wrapper.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="" ID="lblIsLogged" runat="server" ForeColor="Red" />
        </div>
        <div>
            Person Id:
            <asp:TextBox runat="server" ID="tbPersonId"></asp:TextBox>
        </div>
        <div>
            Person Name:
            <asp:TextBox runat="server" ID="tbName"></asp:TextBox>
        </div>
        <div>
            Person Age:
            <asp:TextBox runat="server" ID="tbAge"></asp:TextBox>
        </div>
        <div>
            Email validated:
            <asp:CheckBox runat="server" ID="chkEmailValidated"></asp:CheckBox>
        </div>
        <div>
            <asp:Button Text="Store person details" runat="server" ID="btnSavePersonDetails" OnClick="btnSavePersonDetails_Click" />
        </div>
    </form>
</body>
</html>
