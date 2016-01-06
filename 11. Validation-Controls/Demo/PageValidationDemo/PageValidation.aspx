<%@ Page Language="C#" AutoEventWireup="true" Inherits="PageValidation"
    CodeBehind="PageValidation.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Page Validation Demo</title>
</head>

<body>
    <form id="FormMain" runat="server" defaultbutton="ButtonSubmit">
        <div>
            <asp:Label runat="server">
            Enter your email address:
            </asp:Label>
            <br />
            <asp:TextBox ID="TextBoxEmail" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorEmail"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An email address is required!"
                ControlToValidate="TextBoxEmail" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidatorEmail"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="Email address is incorrect!"
                ControlToValidate="TextBoxEmail" EnableClientScript="False"
                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}">
            </asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit"
                OnClick="ButtonSubmit_Click" />
            <asp:Label ID="LabelMessage" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>

</html>
