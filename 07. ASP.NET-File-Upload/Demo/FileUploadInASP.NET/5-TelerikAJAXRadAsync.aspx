<%@ Page Language="C#" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns='http://www.w3.org/1999/xhtml'>
<head runat="server">
    <title>Multiple File Selection functionality of ASP.NET Upload | RadAsyncUpload Demo</title>
</head>

<body>
    <form id="form" runat="server">
        
        <telerik:RadScriptManager ID="RadScriptManager" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
                </asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
                </asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        
        <telerik:RadAsyncUpload ID="RadAsyncUpload" runat="server" Skin="Black" MultipleFileSelection="Automatic" TargetFolder="Uploaded_Files">
        </telerik:RadAsyncUpload>
        <br />
        
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClientClick="UploadButton_Click"/>
    </form>
</body>
</html>
