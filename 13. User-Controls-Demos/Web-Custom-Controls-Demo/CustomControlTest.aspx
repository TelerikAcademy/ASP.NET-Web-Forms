<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="CustomControlTest.aspx.cs"
    Inherits="Web_Custom_Controls_Demo.CustomControlTest" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Test Custom Cpontrol (SEO Plugin)</title>
</head>

<body>
    <form id="form" runat="server">
        <h1>Test the custom control "SEO Plugin"</h1>
        <p>View the page source to see the SEO tags.</p>

        <seo:SEOPlugin runat="server" ID="SEOPlugin"
          TitleSuffix=" | Telerik Academy Demos" 
          MetaDescription="This is a demo of ASP.NET custom conrols"
          MetaKeywords="demo, ASP.NET, custom contorls, SEO, plugin" />

    </form>
</body>

</html>
