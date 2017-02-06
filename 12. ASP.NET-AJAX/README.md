<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAX – Basics
<div class="signature">
    <p class="signature-course">ASP.NET Web Forms</p>
    <p class="signature-initiative">Telerik Software Academy</p>
    <a href="http://academy.telerik.com" class="signature-link">http://academy.telerik.com</a>
</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
- What is AJAX?
  - AJAX Concept
  - ASP.NET AJAX Framework
- ASP.NET AJAX Server Controls
  - `ScriptManager`, `UpdatePanel`
  - `Timer`, `UpdateProgress`
  - `Triggers`
- ASP.NET AJAX Control Toolkit

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What is AJAX?

<!-- attr: { showInPresentation:true, style:'' } -->
# What is AJAX?
- `AJAX `=` A`synchronous `J`avaScript `A`nd `X`ML 
  - Allows updating parts of a Web page at runtime
  - Approach for developing dynamic Web sites
  - Not a particular technology
- There are over 50 AJAX frameworks

http://en.wikipedia.org/wiki/List_of_Ajax_frameworks
- ASP.NET AJAX is Microsoft’s AJAX framework
  - Part of ASP.NET and .NET Framework
  - Supported by Visual Studio

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What is AJAX? (2)
- `AJAX` enables you to pass information between a Web browser and Web server without refreshing the entire Web page
  - Done by asynchronous JavaScript HTTP requests and dynamic page updates

<img class="slide-image" src="imgs/browser-server.png" style="width:80%; top:50%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# AJAX Technology Components
- `DHTML + DOM`
  - Browser DOM manipulated through JavaScript
    - Used to dynamically display and interact with the page contents
  - CSS stylesheets for formatting
- `XMLHttpRequest` object 
  - Exchange data asynchronously with the Web server through asynchronous HTTP requests
  - Any data format could be used: HTML fragments, text fragments, XML, JSON, etc.

<!-- attr: { showInPresentation:true, style:'' } -->
# AJAX Styles
- Two different styles of AJAX:
  - `Partial page rendering`
    - Loading of HTML fragment and showing it inside a `&#60;div&#62;`
    - Implemented with `UpdatePanel` in ASP.NET
  - `JSON service`
    - Loading JSON object from the server and client-side processing it with JavaScript / jQuery
    - Implemented as WCF + jQuery AJAX

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAX Framework

<!-- attr: { showInPresentation:true, style:'' } -->
# What is ASP.NET AJAX?
- `ASP.NET AJAX `is AJAX development framework from Microsoft
  - Standard part of .NET Framework
  - Allows quickly creating highly interactive Web applications, easy-to-use, highly productive
  - Supports both popular approaches:
    - Server-centric (partial page rendering)
    - Client-centric (client-side control rendering)
  - Works on all modern browsers: Internet Explorer, Firefox, Safari, Chrome, Opera

<!-- attr: { showInPresentation:true, style:'' } -->
- ASP.NET AJAX Server Extensions
- AJAX
- Server Controls
- App Services Bridge
- Asynchronous Communication

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAX Architecture

<img class="slide-image" src="imgs/asp-ajax-architecture.png" style="width:80%; top:10%; left:10%" />

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAX Server Controls

<!-- attr: { showInPresentation:true, style:'' } -->
<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# ASP.NET AJAX Server Controls
- `ASP.NET AJAX server controls` allow easily build rich experiences with ASP.NET
  - Application UI and core logic still run on server
  - Avoid need to master the JavaScript and asynchronous programming
- Use AJAX techniques to reduce full round trips
- Enable incremental page UI updates 
  - Examples: data navigation and editing, form validation, auto refresh, auto-complete, etc.

<!-- attr: { showInPresentation:true, style:'' } -->
# ScriptManager Control
- `&#60;asp:ScriptManager&#62;` control
  - Manages:
    -  AJAX components
    - Partial page rendering
    - Client requests and server responses on ASP.NET server pages. 
  - Only one manager control per `.aspx` page
  - Automates the JavaScript callbacks
  - Required once in the page to enable AJAX

<!-- attr: { showInPresentation:true, style:'' } -->
# UpdatePanel Control
- `&#60;asp:UpdatePanel&#62;` control
  - Easily define "updatable" regions of a page
  - Implements the server-side AJAX approach (partial page rendering)
  - Server roundtrips become asynchronous 

```html
&#60;asp:UpdatePanel id="UpdatePanelDemo" runat="server"&#62;
  &#60;ContentTemplate&#62;
    &#60;!-- This content can be dynamically updated --&#62;
    &#60;asp:Calendar id="CalendarDemo" runat= "server" /&#62;
  &#60;ContentTemplate&#62;
&#60;/asp:UpdatePanel&#62;
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Dynamic Forms with ASP.NET AJAX -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# UpdatePanel.UpdateMode
- `UpdatePanel.UpdateMode` property:
  - `UpdateMode` = `Always` (default)
    - Updates the panel for all postbacks that originate from the page (synchronous and asynchronous)
  - `UpdateMode` = `Conditional`
    - Updates the panel when something inside it is changed (by default `ChildrenAsTrigger=True`)
    - Or by calling `Update()` method explicitly
    - Or by triggers defined in the update panel

<!-- attr: { showInPresentation:true, style:'' } -->
# Triggers
- `Triggers `cause update of the `UpdatePanel`’s content on particular event
  - Can be controls inside or outside the panel

```html
&#60;asp:UpdatePanel ID="UpdatePanelWithTriggers"
    runat="server" UpdateMode="Conditional"&#62;
  &#60;Triggers&#62;
    &#60;asp:AsyncPostBackTrigger
       ControlID="TimerDemo" EventName="Tick" /&#62;
  &#60;/Triggers&#62;
  &#60;ContentTemplate&#62;
  &#60;/ContentTemplate&#62;
&#60;/asp:UpdatePanel&#62;
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Triggers (2)
- `AsyncPostBackTrigger`
  - Converts postbacks into async callbacks
  - Typically used to trigger updates when controls outside an `UpdatePanel` post back
  - If `ChildrenAsTriggers="false"`, can be used to specify which controls inside UpdatePanel should call back rather than post back
- `PostBackTrigger`
  - Lets controls inside `UpdatePanel` post back.
  - Typically used to allow certain controls to post back when `ChildrenAsTriggers="true"`

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Timer Control
- `<asp:Timer>` control
  - Added as a trigger of an update panel
  - Refreshes panel when timer interval expires

```html
<asp:Timer ID="TimerDemo" runat="server" Interval="5000">
</asp:Timer>
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # ASP.NET AJAX: UpdatePanel + Timer -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# UpdateProgress Control
- `&#60;asp:UpdateProgress&#62;` control
  - Shows status while an asynchronous postback is in progress
  - Button to cancel the request can be added

```html
&#60;asp:UpdateProgress ID="UpdateProgressDemo" 
    runat="server"&#62;
  &#60;ProgressTemplate&#62;
    Updating ...
  &#60;/ProgressTemplate&#62;
&#60;/asp:UpdateProgress&#62;
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Full vs. Partial Postbacks -->
##  [Demo]()

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAXControl Toolkit

<!-- attr: { showInPresentation:true, style:'' } -->
# ASP.NET AJAX Control Toolkit
- Collection of AJAX components
  - Ready-to-go samples
  - Comes with full source code and documentation
- SDK to simplify the creation and re-use custom AJAX-enabled ASP.NET controls
- Some controls:
  - `CascadingDropDown – ` link drop-downs, with asynchronous population and no postbacks
  - `CollaspiblePanel – `panels that collapse and expand without postbacks

<!-- attr: { showInPresentation:true, style:'' } -->
# ASP.NET AJAX Control Toolkit
- `ConfirmButton`: extender adding a confirm dialog to any `Button`, `LinkButton`, or `ImageButton` control 
- `DragPanel`: makes any panel into an object that you can drag around the page
- `ModalPopup`: shows a modal popup dialog
- ... and many more ...
- Home Page:
  - `https://www.devexpress.com/Products/AJAX-Control-Toolkit/`

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # AJAX Control Toolkit -->
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET AJAX Basics

<img class="slide-image" src="imgs/questions.png" style="width:80%; top:15%; left:10%" />
<div style="position: absolute; bottom: 1em; right: 0; font-size: 26px;">http://academy.telerik.com</div>
