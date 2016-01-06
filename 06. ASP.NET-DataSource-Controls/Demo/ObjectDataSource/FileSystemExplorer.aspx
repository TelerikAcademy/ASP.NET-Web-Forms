<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FileSystemExplorer.aspx.cs"
    Inherits="ObjectDataSource.FileSystemExplorer" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ObjectDataSource: File System Explorer</title>
    <link href="Site.css" rel="stylesheet" />
</head>

<body>
    <form id="FormMain" runat="server">

        <p>
            Root Folder: <asp:TextBox ID="TextBoxFolderPath" 
                runat="server" Text="C:\WINDOWS" />
            <asp:Button ID="ButtonChangeRootFolder" runat="server"
                OnClick="SetRootFolderButton_Click" Text="Change" />
            <asp:CustomValidator ID="ValidatorFolder" runat="server"
                ControlToValidate="TextBoxFolderPath"  
                ErrorMessage="Invalid folder!"
                OnServerValidate="ValidatorFolder_ServerValidate" />
        </p>

        <asp:ObjectDataSource ID="ObjectDataSourceFileSystem" runat="server"
            SelectMethod="GetAllFiles" TypeName="ObjectDataSource.FileSystemManager">
            <SelectParameters>
                <asp:Parameter DefaultValue="C:\WINDOWS" Name="folder" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

        <asp:GridView ID="GridViewFileSystem" runat="server"
            DataSourceID="ObjectDataSourceFileSystem"
            AllowPaging="true" AllowSorting="true"
            AutoGenerateColumns="False">
            <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" 
                ReadOnly="True" SortExpression="Name" />
            <asp:BoundField DataField="Length" HeaderText="Length" 
                ReadOnly="True" SortExpression="Length" />
            <asp:BoundField DataField="DirectoryName" 
                HeaderText="DirectoryName" ReadOnly="True"
                SortExpression="DirectoryName" />
            <asp:CheckBoxField DataField="IsReadOnly" 
                HeaderText="IsReadOnly" SortExpression="IsReadOnly" />
            <asp:BoundField DataField="CreationTime" 
                HeaderText="CreationTime" SortExpression="CreationTime" />
            </Columns>
        </asp:GridView>

    </form>
</body>

</html>
