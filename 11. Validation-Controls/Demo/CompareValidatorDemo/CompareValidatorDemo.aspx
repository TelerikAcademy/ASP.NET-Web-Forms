<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Compare Validator Demo</title>
</head>

<body>
    <form id="formCompareValidator" runat="server" defaultbutton="ButtonSubmit">
        Password:
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator  ID="RequiredFieldValidatorPassword" ControlToValidate="TextBoxPassword" runat="server" Display="Dynamic" Text="Required Field" ErrorMessage="Password field is required!" ForeColor="Red" EnableClientScript="False" /><br />
        Password (repeat):
        <asp:TextBox ID="TextBoxRepeatPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatPassword" ControlToValidate="TextBoxRepeatPassword" runat="server" Display="Dynamic" Text="Required Field" ErrorMessage="Repeat Password field is required!" ForeColor="Red" EnableClientScript="False" />

        <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
            ControlToCompare="TextBoxPassword"
            ControlToValidate="TextBoxRepeatPassword" Display="Dynamic"
            ErrorMessage="Password doesn't match!" ForeColor="Red" EnableClientScript="False"></asp:CompareValidator>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" />
        <br />
        * Note: due to a design flaw in the CompareValidator, when the second control
        is empty or contains whitespace only, the form is considered valid.
        <asp:ValidationSummary runat="server" ForeColor="Red" />
    </form>
</body>

</html>
