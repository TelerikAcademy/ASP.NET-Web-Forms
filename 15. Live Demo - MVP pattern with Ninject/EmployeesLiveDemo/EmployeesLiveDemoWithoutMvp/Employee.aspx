<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Employee.aspx.cs"
    MasterPageFile="~/Site1.Master"
    Inherits="EmployeesLiveDemoWithoutMvp.Employee" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:HyperLinkField
                HeaderText="First Name"
                DataTextField="FirstName"
                DataNavigateUrlFields="EmployeeID"
                DataNavigateUrlFormatString="~/EmpDetails.aspx?id={0}" />
        </Columns>
    </asp:GridView>
</asp:Content>