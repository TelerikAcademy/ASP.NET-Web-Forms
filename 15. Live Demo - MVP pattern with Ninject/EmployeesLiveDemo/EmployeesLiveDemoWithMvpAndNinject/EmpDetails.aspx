<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs"
    Inherits="EmployeesLiveDemoWithMvpAndNinject.EmpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView runat="server" ID="DetailsView" AutoGenerateRows="false">
        <ItemTemplate>
            <div>
                <%# Eval("FirstName") %>
                <br />
                <%# Eval("LastName") %>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
