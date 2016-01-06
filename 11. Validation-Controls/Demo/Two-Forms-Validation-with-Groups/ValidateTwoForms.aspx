<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidateTwoForms.aspx.cs" Inherits="TwoFormsValidation.ValidateTwoForms" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="PanelSerachByNames" runat="server" 
            GroupingText="Search by names">
            <asp:Label Text="First Name:" runat="server" ID="LabelFirstName" 
                AssociatedControlID="TextBoxFirstName" />
            <asp:TextBox ID="TextBoxFirstName" runat="server" 
                ValidationGroup="ValidationGroupNames"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" 
                ControlToValidate="TextBoxFirstName" ErrorMessage="RequiredFieldValidator" 
                ValidationGroup="ValidationGroupNames">Required field!</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelLastName" runat="server" 
                AssociatedControlID="TextBoxLastName" Text="Last Name:" />
&nbsp;<asp:TextBox ID="TextBoxLastName" runat="server" 
                ValidationGroup="ValidationGroupNames"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" 
                ControlToValidate="TextBoxLastName" ErrorMessage="RequiredFieldValidator" 
                ValidationGroup="ValidationGroupNames">Required field!</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="ButtonSearchByNames" runat="server" Text="Search" 
                onclick="ButtonSearchByNames_Click" />
        </asp:Panel>
        <br />
    
    </div>
    
        <asp:Panel ID="PanelSerachByTown" runat="server" 
        GroupingText="Search by town">
            <asp:Label Text="Town:" runat="server" ID="LabelTown" 
                AssociatedControlID="TextBoxTown" />
            <asp:TextBox ID="TextBoxTown" runat="server" 
                ValidationGroup="ValidationGroupTown"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorTown" runat="server" 
                ControlToValidate="TextBoxTown" ErrorMessage="RequiredFieldValidator" 
                ValidationGroup="ValidationGroupTown">Required field!</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="ButtonSearchByTown" runat="server" Text="Search" 
                onclick="ButtonSearchByTown_Click" />
        </asp:Panel>
        <asp:Label ID="LabelIsValid" runat="server"></asp:Label>
    </form>
</body>
</html>
