<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="Employee.aspx.cs" Inherits="EmployeesLiveDemoWithMvpAndNinject.Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:HyperLinkField
                HeaderText="First Name"
                DataTextField="FirstName"
                DataNavigateUrlFields="EmployeeID"
                DataNavigateUrlFormatString="~/EmpDetails.aspx?id={0}" />
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" OnClick="Unnamed_Click" Text="Send mail" />
</asp:Content>
