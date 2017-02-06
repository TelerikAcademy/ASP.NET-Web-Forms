<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET State Management
##  Session State, Application State, View State
<div class="signature">
    <p class="signature-course">Telerik Software Academy</p>
    <p class="signature-initiative">http://academy.telerik.com </p>
    <a href = "ASP.NET Web Forms" class="signature-link">ASP.NET Web Forms</a>
</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents 
- ASP.NET Intrinsic Objects
- State Management in Web Applications
  - Cookies
  - Hidden Fields
  - Parameterized Addresses
- ASP.NET State Management
  - Client side – View State
  - Server side – Application State, Session State	
- Manipulating the HTTP response headers

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Intrinsic Objects in ASP.NET
##  Session, Application, Request, Response, …

<!-- attr: { showInPresentation:true, style:'' } -->
# Intrinsic Objects in ASP.NET
- Intrinsic objects in ASP.NET are available in the context of any `Page` or `Control`
  - `Application` (`HttpApplication` class)
  - `Session` (`HttpSession` class)
  - `Request` (`HttpRequest` class)
  - `Response` (`HttpResponse` class)
  - `Server` (`HttpServerUtility` class)
  - `Context` (`HttpContext` class)
  - `Cache` (`System.Web.Caching.Cache` class)

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# HttpApplication
- `HttpApplication` keeps the application state
- Provides access to other intrinsic objects
  - Properties `Application`, `Context`, `Request`, `Response`, `Server`, `Session` etc.
- Provide events for:
  - Start of a new request
  - Authentication
  - Authorization
  - Working with the cache
  - End of a request

<!-- attr: { showInPresentation:true, style:'' } -->
# HttpRequest
- `HttpRequest` contains information about the current HTTP request (`Request` object)
  - `ApplicationPath` – root path on the server
  - `Browser` – type, platform, capabilities, etc.
  - `Cookies` – get the cookies collection
  - `HttpMethod` – `GET` / `POST`
  - `QueryString` – e.g. `?id=7&lang=en`
  - `ServerVariables` – IIS server settings
  - `Url` – the requested URL

<!-- attr: { showInPresentation:true, style:'' } -->
# HttpResponse
- `HttpResponse` contains information about the HTTP response (`Response` object)
  - `ContentType` – MIME type (e.g. `image/gif`)
  - `Charset` – response encoding, e.g. `UTF8`
  - `Cookies` – sets cookies
  - `Expires` – sets browser's cache expiration
  - `BufferOutput` – buffer or not the response
  - `ClearHeaders(…)`, `AddHeader(…)`
  - `Write(…)`, `BinaryWrite(…)`, `WriteFile(…)` – send text or binary data to the client

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# HttpServerUtility
- `HttpServerUtility` – helper methods for processing HTTP requests (`Server` object)
  - `HtmlEncode(…)` – escapes given HTML, e.g. "`<img>`" &rarr; "`&lt;img&gt;`"
  - `HtmlDecode(…)` – un-escapes escaped HTML
  - `UrlEncode(…)` – encode string for the  browser URL, e.g. "`+.net 4`" &rarr; "`%2B.net+4`"
  - `UrlDecode(…)` – decode url-encoded string
  - `MapPath(…)` – returns the server-side path for given resource given as relative path

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 43px' } -->
# Intrinsic Objects  – Examples

```cs
bool isSecureConnection =  Request.IsSecureConnection;

Application.Add("key", "value");

LabelResult.Text =  Server.UrlEncode("Did you try ASP.NET 4.0?");

Response.ContentType = "text/html";
Response.Charset = "UTF-8";

string imageFileName =  Server.MapPath("img/logo.gif");

string url = Request.Url;

string browserType = Request.Browser.Type;
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Intrinsic ASP.NET Objects -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# Redirecting to Another URL
- `Response.Redirect("Login.aspx")`
  - Client-side redirection (uses HTTP 302 Moved)
  - Asks the browser to request a new URL
  - Changes the URL address in the browser
- `Server.Transfer("WebTest.aspx")`
  - Server-side redirection
  - Keeps the URL in the browser
  - The browser does not even know about the redirection

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Client and Server Redirection
## Live Demo

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# State Management: Standard Mechanisms in Web Applications
##  Cookies, Hidden Fields, Parameterized Addresses

<!-- attr: { showInPresentation:true, style:'font-size: 40px' } -->
# State Managementin Web Applications
- The HTTP protocol is `stateless`
  - No built-in way to implement a stateful interaction (session / conversation)
- Preserving state between the HTTP requests:
  - Cookies (used by the ASP.NET session)
  - Hidden fields (used by the ASP.NET ViewState)
  - HTML5 local storage / session storage
  - Parameterized addresses (used to implement cookieless session in ASP.NET)

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 40px' } -->
# What is a Cookie?
- A small piece of information (up to 4KB)
  - Sent to a browser by the Web server
  - Saved locally at the client as a text file
  - Sent by the browser in all subsequent requests
- Sent as an HTTP header

- HTTP Response:

```
Set-Cookie: UserID=baj.ivan; path=/; domain=academy.com;
Expires=Wed, 14 Jun 2015 10:18:14 GMT 
```
- HTTP Request:

```
Cookie: UserID: baj.ivan;
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Cookie Properties
- Cookies is ASP.NET are represented by `HttpCookie` objects
  - `Expires`
    - Sets when the validity of the cookie expires
  - `Domain`
    - A domain to which the cookie belongs
  - `Path`
    - Sets the root directory of the cookie
  - `Secure` – transmit over encrypted channel
  - `HttpOnly` – no JavaScript access

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Working with Cookies
- For Web applications 
  - `System.Web.HttpCookie`
- For client applications
  - `System.Net.Cookie `
- `HttpRequest.Cookies `contains the cookies received by the server
- `HttpResponse.Cookies `containsthe cookies sent to the client

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Working with Cookies – Example
- Creating a cookie that will be sent to the client Web browser:

```cs
HttpCookie cookie = new HttpCookie("UserName", "baj.ivan");
Response.Cookies.Add(cookie);
```
- Reading a cookie received at the server:

```cs
HttpCookie cookie = Request.Cookies["UserName"];
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Cookies -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'font-size: 44px' } -->
# What are Hidden Fields?
- Hidden form fields keep information, not visible in the Web page, sent on form submit
  - ASP.NET `HiddenField` is a control, which renders as a standard HTML hidden field
  - Not visible in the browser, but you can use it to store information directly in the page

```html
&#60;input type="hidden" name="Language" value="English"&#62;
```
- Insecure, because malicious user can easily access hidden fields and tamper it
  - ASP.NET ViewState is encrypted for security


<!-- attr: { showInPresentation:true, style:'' } -->
# Local Storage / Session Storage
- HTML5 provides client-side local and session storage (through JavaScript)
  - `localStorage` – stores data long term
  - `sessionStorage` – stores data for one session
- Local data is stored per domain
  - E.g. `academy.telerik.com` and `facebook.com` have different storages
  
```javascript
localStorage.setItem('myColor', 'red');
var color = localStorage.getItem('myColor'); // -> 'red'
localStorage.removeItem('myColor');
```

<!-- attr: { showInPresentation:true, style:'font-size: 44px' } -->
# Parameterized Addresses
- Also known as `query strings`
- Setting the parameters in the URL of a page after the "`?`" sign:

```
http://asp.net/getstarted/default.aspx?tabid=61
```
- Reading a query parameter:
- Used to pass data from one page to another
- Insecure, because malicious user can copy or change the address

```cs
string selectedTabID = Request.QueryString["tabid"];
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET State Management

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET Based State Management
- Client side state
  - View state
- Server side state
  - Application state
  - Session state

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET Client Side State Management
##  ViewState

<!-- attr: { showInPresentation:true, style:'' } -->
# ViewState
- ViewState keeps the state of the controls over several consecutive requests to the same page (postbacks)
- Every change in the visualization of a control is saved in the ViewState
  - E.g. adding an element to a list control
-  Can save custom data defined by developers

```cs
lblUsername.Text = (string) ViewState["Username"];
ViewState["Username"] = txtUsername.Text.Trim();
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 44px' } -->
# ViewState – Behind the Scene
- Data saved in the `ViewState` is:
  - Serialized, encrypted and is sent to the client in a hidden form field:
  
```html
<input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE"
  value="/wEPDwUJODExMDE5NzY5D2QWAgIDD2QWAgIBDw8WA
  h4EVGV4dAUFS296bW9kZGR67yT0OasTSUMlwIXGj65FNx7ggA==" />
```
- At postback the `ViewState` is deserialized and the state of the controls is restored
  - To accomplish serialization the `ObjectStateFormatter `class is used
  - Encryption is based on machine key

<!-- attr: { showInPresentation:true, style:'font-size: 38px' } -->
# ViewState Configuration
- To disable `ViewState ` at page and/or control level

```aspx
&#60;!-- At page level --&#62;
&#60;%@ Page EnableViewState="false" %&#62;

&#60;!-- At control level --&#62;
&#60;asp:Label ID="labelName" Runat="server"
  Text="Software Academy" EnableViewState="False" /&#62;
```
- `ViewState` support encryption:

```aspx
&#60;%@ Page ViewStateEncryptionMode="Always" %&#62;
```
- To save the `ViewState` at the server we can use `SessionPageStatePersister `

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET Server Side State Management
##  Application State and Session State

<!-- attr: { showInPresentation:true, style:'' } -->
# Application State
- The application state is shared storage of information at application level
  - Store information in the memory of the server
  - `Application` – a single object for all clients
- `HttpApplicationState`
  - A dictionary collection accessed through `HttpContext `or `Page`
- Available through all phases of the application lifecycle

<!-- attr: { showInPresentation:true, style:'font-size: 44px' } -->
# Application State (2)
- In order to have synchronized access we use the `Lock() `and `Unlock()`methods
- `Application State` is rarely used in the real world (unlike the cache) 
  - Using a database is a better choice
- Useful place to store small amounts of often-used data that is the shared for all users

```cs
Application.Lock();
Application["Users"] = (int) Application["Users"] + 1;
Application.UnLock();
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # ASP.NET Application State -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# Session State
- Storage of information at user level (different one for each user)
- The session is active:
  - Till the user closes the browser or
  - A certain period expires (20 minutes for example)
- Every session is identified by a unique `SessionID`
  - Created at first entry in the site
  - Transmitted in a `cookie` by default

<!-- attr: { showInPresentation:true, style:'font-size: 44px' } -->
# Session State (2)
- The `HttpSessionState `dictionary collection is used through  `HttpContext `or `Page`

```cs
Session["username"] = "pesho";
string = (string) Session["username"];
```
- To handle events fired when a session is started or ended we use  `Session_OnStart `and `Session_OnEnd `in the `Global.asax `file
- To deny/restrict  access to the session

```aspx
<%@ Page EnableSessionState="False" %>
<%@ Page EnableSessionState="ReadOnly" %>
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Session Configuration
- We can configure various aspects of the session mechanism
- Use the `sessionState `section in `Web.config`
- Example:

```xml
<system.web>
  <sessionState 
    cookieless="true" mode="InProc" 
    timeout="60" cookieName="MySite" />
</system.web>
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Session Configuration (2)
- Important attributes
  - `Timeout `
    - A period for which the session is active
  - `Mode`
    - Where the session is stored – in the current process, SQL Server, external state server
  - `Cookieless`
  - A session that doesn’t use cookies – the `SessionID` is sent as a parameter in the URL

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # ASP.NET Session State -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# State Management – Recommendations
- Use a wrapper class over the session
  - Put all session data in a property inside this wrapper class
  - All session data should be serializable
- Don’t save too much information in the `Session`
- Don’t save lots of information in the `ViewState`

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Manipulating the HTTP Response Headers

<!-- attr: { showInPresentation:true, style:'' } -->
# The HTTP Response Headers
- HTTP headers are part of the server response
  - Allow the server to pass additional information about the response
    - Page content, MIME type, encoding, caching mode, cookies, HTTP response codes, etc.
  - Provide information about the server to the client Web browser
- Accessible from code behind through `Response.Headers `collection
  - If the body contents is started to render, headers cannot be modified

<!-- attr: { showInPresentation:true, style:'' } -->
# Manipulating the HTTP Response Headers
- Some widely-used response headers:
  - `HeaderEncoding `– sets header encoding
  - 	`Headers `– read only collection of headers
  - `ContentType `– MIME type of the output 
  - 	`Expires `– numbers of minutes before page cached in browser expires 
  - 	`StatusCode `– HTTP status code of the output
  - 	`AppendHeader() `– adds an HTTP header to the output stream

<!-- attr: { showInPresentation:true, style:'' } -->
# Manipulating the HTTP Response Headers – Example
- Downloading image file generated at the server by an ASP.NET page:

```cs
Response.Clear();
Bitmap generatedImage = new Bitmap(200, 200);     
Graphics gr = Graphics.FromImage(generatedImage);
gr.FillRectangle(Brushes.MediumSeaGreen, 0, 0, 200, 200);
gr.FillPie(Brushes.Yellow, 25, 25,150, 150, 0, 45);
gr.FillPie(Brushes.Green, 25, 25, 150, 150, 45, 315);
Response.ContentType = "image/gif";
generatedImage.Save(Response.OutputStream,ImageFormat.Gif);
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Dynamically Generate Image in ASP.NET Page -->
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET State Management

<img class="slide-image" src="imgs/questions.png" style="width:80%; top:10%; left:10%" />
<div style="position: absolute; bottom: 1em; right: 0; font-size: 26px;">http://academy.telerik.com</div>