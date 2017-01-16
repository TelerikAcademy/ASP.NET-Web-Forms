<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Forms – Intro
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic01.png" style="top:32.52%; left:11.59%; width:19.09%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic02.png" style="top:53.30%; left:59.88%; width:43.08%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic03.png" style="top:35.48%; left:38.28%; width:39.07%; z-index:-1" /> -->
<article class="signature">
	<p class="signature-course"></p>
	<p class="signature-initiative"></p>
	<a href="" class="signature-link"></a>
</article>



<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Introduction to ASP.NET Web Forms](#intro)
- [Web Forms Basic Components](#components)
- [ASP.NET Sumator – Demo](#sumator)
- [ASP.NET Page Execution Model](#execution)
- [Postbacks and VIEWSTATE](#viewstate)
- [ASP.NET Page Directives](#directives)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic04.png" style="top:23.14%; left:85.61%; width:17.19%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:50.25%; left:85.61%; width:17.19%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:59.94%; left:22.46%; width:43.08%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Introduction toASP.NET Web Forms -->


<!-- attr: { id:'intro', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="intro"></a> What is ASP.NET Web Forms?
- **ASP.NET Web Forms**
  - Web application development framework
    - Renders HTML content at the server-side
    - Combines C# with HTML for dynamic content
    - Component-based, event-driven model
  - Created by from Microsoft in 2002
  - Powerful, but complicated, very mature
  - Weak control over the output HTML
  - Web Form == composition of nested controls in ASPX page


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Forms Benefits
- Separate presentation from code
  - Code behind, unlike PHP (mixed code + HTML)
- Component-based development (like JSF)
  - Event-driven architecture
  - Object-oriented approach
- Code compilation (instead of  interpreter)
- Built-in state management (session, app, …)
- Many others (data binding, validation, master pages, user controls, authentication, etc.)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Forms Architecture

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic41.png" style="top:19.94%; left:12.46%; width:83.08%; z-index:-1" /> -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# HTML vs. ASP.NET Web Forms
- Traditional Web pages (static HTML)
  - Consist of static HTML, images, styles, etc.
  - Execute code on the client side (JavaScript)
  - Need lots of AJAX to become dynamic
- ASP.NET Web Forms
  - Execute code on the server and render HTML
  - Extensive use of server-side components
  - Allow easy integration with databases


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASPX: Separate Visualization from Business Logic
- Old-fashioned Web development mixes HTML and programming code in single file (like PHP)
  - Hard to read, understand and maintain
  - Often leads to spaghetti code
- ASP.NET Web Forms splits the Web pages into two parts:
  - **.aspx** file containing HTML for visualization
  - "**Code behind**" files (**.aspx.cs**) containing the presentation logic for particular page


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
<!-- # ASPX: Separate Visualization from Business Logic -->
- Class generated from the **.aspx** file does not derive directly from **Page** class
- Derives from class defined in the "code behind", where it is easy to add methods, event handlers, etc.
- Using "code behind" separates the presentation logic from UI visualization
- System.Web.UI.Page
- TestForm.aspx.cs
- TestForm.aspx




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET Web FormsBasic Components -->


<!-- attr: { id:'components', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="components"></a> Web Forms Basic Components
- **Web Forms**
  - XML-based files describing the Web UI
- **Web Control**
  - The smallest part we can use in our Web application (e.g. text box)
- **"Code behind"**
  - Contains the server-side C# code behind pages
- **Web.config**
  - Contains ASP.NET application configuration


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Web Forms
- An **ASP.NET Web Form** is a programmable Web page (**.aspx** file)
  - Acts as a Web-based user interface (UI) of the ASP.NET Web Forms applications
  - XML-based language, like XHTML
  - Consists of HTML, C# code and controls
  - Executed at the server-side by ASP.NET
  - Rendered to HTML by the ASP.NET runtime
  - Have complex execution model (many steps)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Form – _Example_
- The functionality of the Web form is defined by attributes: **Page**, **Codebehind**, **Inherits**

```cs
<%@ Page Language="C#"
  Codebehind="TestWebForm.aspx.cs"
  Inherits="FirstApp.TestWebForm" %>
<!DOCTYPE html>
<html>
  <head><title>First WebForm</title></head>
    <form ID="FormTest" runat="server" …>
      <asp:Label ID="lbl" runat="server">…</asp:Label>
      <asp:TextBox ID="textCustomerName" runat="server"
        Text="Customer Name: ">…</asp:TextBox>
      <asp:Button ID="btn" runat="server" …></asp:Button>
    </form>
</html>
```

<div class="fragment balloon" style="top:12.07%; left:64.35%; width:38.79%">Always put **ID="…"** and **runat="server"** for the ASP.NET controls!</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Controls
- ASP.NET **Web controls** are the smallest component part
- Deliver fast and easy component-oriented development process
- HTML abstraction, but has server-side properties and events
  - Rendered as HTML (+ CSS + scripts)

```cs
<asp:Button runat="server" ID="btn"
   Text="Click me!" OnClick="btn_Click" />
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Web.config
- The configuration file for ASP.NET application
- Text based XML document
- **Web.config** defines:
  - Connection strings to any DB used by app
  - Security settings and membership settings
  - Whether debugging is allowed

```cs
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.web>
  </system.web>
</configuration>
```

<div class="fragment balloon" style="top:63.62%; left:51.13%; width:45.80%">Minimal Web.config should look like this</div>
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:16.34%; left:86.49%; width:19.61%; z-index:-1" /> -->


<!-- attr: { id:'sumator', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="sumator"></a> Your First ASP.NET Web Forms Application – Sumator
- Steps to create a simple ASP.NET Web application:
  - Start Visual Studio
  - Create “New Web Application”
  - Add two text fields, a button and a label
  - Handle **Button.Click** and implement logic to sum of the values from the text fields
  - Display the results in the label


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# ASP.NET Sumator
## [Demo]()-->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:54.51%; left:65.50%; width:36.14%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:52.79%; left:10.57%; width:21.28%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:53.99%; left:35.56%; width:26.27%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET Execution Model -->


<!-- attr: { id:'execution', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="execution"></a> ASP.NET Execution Model
- First call to particular page

<img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:20.28%; left:20.56%; width:67.04%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET Execution Model -->
- Any other call after the first

<img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:20.28%; left:20.56%; width:67.46%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The ASP.NET Controls Tree
- When requested an ASP.NET Web form is parsed by ASP.NET and converted to a tree
  - Also called a **controls tree** (XML tags are turned into a tree of controls)

<img class="slide-image" showInPresentation="true" src="imgs\pic42.png" style="top:40.28%; left:20.56%; width:67.46%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Page Lifecycle
- At each request to a Web Form:
  - The form is created (a page instance)
  - The VIEWSTATE is restored (the state of each control, sent from the browser)
  - The page and control events are executed
  - The VIEWSTATE is saved in a hidden field
  - The form is rendered as HTML
  - The form is unloaded (destroyed)
- Important: page instances do not survive the next HTTP request!


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Page Lifecycle Events
- Web forms and controls have lifecycle events:
	1. **PreInit**
	1. **Init**
	1. **Load** (load data from DB)
	1. (control events are executed here, e.g. **Click**)
	1. **PreRender**
	1. **Render**
	1. **Unload**


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# ASP.NET Page Lifecycle-->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:11.76%; left:30.23%; width:50.83%; z-index:-1" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# ASP.NET Page Lifecycle
## [Demo]()-->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Postbacks and VIEWSTATE -->
<!-- ## What is a Postback? What is aVIEWSTATE? How It Works? -->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic26.png" style="top:40.14%; left:24.52%; width:59.61%; z-index:-1" /> -->


<!-- attr: { id:'viewstate', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="viewstate"></a> Page Postbacks and VIEWSTATE
- **VIEWSTATE** preserves the state of a Web control into a serialized, encrypted hidden field
- **Postback** in ASP.NET means submitting a Web form to the server (i.e. **HTTP POST** request)
  - Executed when a server-side event is raised
    - E.g. a button is clicked or a checkbox is checked
  - VIEWSTATE preserves the page and controls state
    - Almost all control properties: color, position, width, height, etc.
    - The text in the control is posted with the form


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!--# How Does VIEWSTATE Work?-->

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic27.png" style="top:9.82%; left:10.29%; width:80.51%; z-index:-1" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# VIEWSTATE
## [Demo]()-->



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET Page Directives -->


<!-- attr: { id:'directives', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="directives"></a> ASP.NET Page Directives
- Provide control over many options affecting the compilation and execution of the web form
- Important directives:
  - **@Page** – main directive of the page
  - **@Import** – imports a namespace into the page
  - **@Assembly** – attaches an assembly to the form when it is compiled
  - **@OutputCache** – controls the ability of the forms to use cache
  - **@Register** – registers a user control to be used in a web form


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# The @Page Directive
- Defines a form-specific (**.aspx** file) attributes used by the ASP.NET runtime
- Important attributes:
  - **AutoEventWireup** – auto-bind the controls' events to appropriate methods in the code
  - **Culture** – a culture used at page generation
  - **UICulture** – a culture for the data visualization
  - **Language** – code language (C#, VB.NET, …)
  - **Codebehind** – the code-behind file


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # The @Page Directive -->
- Important attributes:
  - **Debug** – whether the page is compiled with debug symbols in it
  - **EnableSessionState** – whether a session is supported
  - **EnableViewState** – whether to use "view state" or not
  - **ErrorPage** – a page to which to redirect in case of unhandled exception


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Web Forms – Intro
- http://academy.telerik.com


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- "Web Design with HTML 5, CSS 3 and JavaScript" course @ Telerik Academy
    - html5course.telerik.com
  - Telerik Software Academy
    - academy.telerik.com
  - Telerik Academy @ Facebook
    - facebook.com/TelerikAcademy
  - Telerik Software Academy Forums
    - forums.academy.telerik.com
