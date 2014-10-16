<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4-KendoUIUpload.aspx.cs" Inherits="FileUploadInASP.NET._4_KendoUIUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/kendo.common.min.css" rel="stylesheet" />
    <link href="styles/kendo.default.min.css" rel="stylesheet" />
    <script src="scripts/jquery.min.js"></script>
    <script src="scripts/kendo.web.min.js"></script>
</head>
<body>
    <input name="uploaded" id="uploaded" type="file" runat="server" />

    <script>
        $(document).ready(function () {
            $("#uploaded").kendoUpload({
                async: {
                    saveUrl: "Upload",
                    removeUrl: "Remove",
                    autoUpload: true,
                }
            });
        });
    </script>
</body>
</html>
