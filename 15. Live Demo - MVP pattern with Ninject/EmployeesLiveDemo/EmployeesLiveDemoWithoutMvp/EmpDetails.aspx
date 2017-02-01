<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="EmpDetails.aspx.cs"
    MasterPageFile="~/Site1.Master"
    Inherits="EmployeesLiveDemoWithoutMvp.EmpDetails" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
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
