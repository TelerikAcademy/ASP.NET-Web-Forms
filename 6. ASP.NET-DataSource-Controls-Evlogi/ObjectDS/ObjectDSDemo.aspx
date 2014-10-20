<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectDSDemo.aspx.cs" Inherits="ObjectDS.ObjectDSDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridViewFiles" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="ObjectDataSourceFiles">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSourceFiles" runat="server" SelectMethod="GetAllFiles" TypeName="ObjectDS.FileSystemManager">
            <SelectParameters>
                <asp:Parameter DefaultValue="C:\Windows" Name="path" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
