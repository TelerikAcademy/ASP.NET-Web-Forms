<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Introduction to ASP.NET
## ASP.NET, Architecture, Web Forms, MVC, Web API

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic00.png" style="top:53.03%; left:59.41%; width:43.64%; z-index:-1" /> -->

<article class="signature">
	<p class="signature-course"></p>
	<p class="signature-initiative"></p>
	<a href="" class="signature-link"></a>
</article>


<!-- section start -->
<!-- attr: { id:'', showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Introduction to ASP.NET](#intro)
  - [History, Components, Frameworks](#intro)
- [ASP.NET App Structure](#structure)
  - [Typical Files and Folders in ASP.NET Projects](#structure)
- [ASP.NET App Lifecycle](#lifecycle)
  - [Application Lifecycle, HTTP Modules,HTTP Handlers, Events, Controllers, Pages, …](#lifecycle)
- [ASP.NET Common Concepts](#commonConcepts)
  - [Classes & Namespaces, Web Sites & Web Apps](#commonConcepts)
- [ASP.NET 5](#core)

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic05.png" style="top:12.62%; left:85.59%; width:19.49%; z-index:-1" /> -->




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Introduction to ASP.NET -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic06.png" style="top:42.04%; left:4.68%; width:52.01%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic08.png" style="top:42.92%; left:50.53%; width:55.11%; z-index:-1" /> -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic07.png" style="top:74.19%; left:36.83%; width:36.38%; z-index:-1" /> -->


<!-- attr: { id:'intro', showInPresentation:true, hasScriptWrapper:true, style:"font-size: 0.9em" } -->
# <a id="intro"></a> History of ASP.NET
- At the beginning of Internet (up to 1997)
  - CGI, ISAPI (for C, C++), PHP
- Classic / Legacy ASP (1997-2002)
  - Based on VB Script, COM, ADO
- ASP.NET 1.0 (2002, January 16) – with .NET 1.0
- ASP.NET 1.1 (2003-2005) – based on .NET 1.1
- ASP.NET 2.0 (2005-2007) – based on .NET 2.0
- ASP.NET 3.5 (2007-2009) – LINQ to SQL, MVC
- ASP.NET 4.0 (2010) – Entity Framework, MVC
- ASP.NET 4.5 (2012) – One ASP.NET
- ASP.NET 4.6 (2015) – HTTP/2, Roslyn, fixes
- ASP.NET 5 (2016) – Redesigned

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic09.png" style="top:10.33%; left:82.91%; width:18.28%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# What is ASP.NET?
- ASP.NET is a stack of technologies to create web sites, web services and web applications

<img class="slide-image" showInPresentation="true" src="imgs\pic10.png" style="top:25.20%; left:6.72%; width:93.13%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET: Web Forms vs. MVC
- ASP.NET has two major frameworks for web application development
  - **ASP.NET Web Forms** ([read more](https://www.asp.net/web-forms))
    - The traditional component-based approach
    - Mixes the presentation and presentation logic
  - **ASP.NET MVC** ([read more](https://www.asp.net/mvc))
    - Modern approach, more clear and flexible
    - MVC architecture, like Ruby-on-Rails and Django
    - Testable and easy to use


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET: Web Pages, Web API
- **ASP.NET Web Pages** ([read more](http://www.asp.net/web-pages))
  - Lightweight framework to combine C# code with HTML to create dynamic web content
    - Similar to PHP
    - Uses the "Razor"
- **ASP.NET Web API** ([read more](http://www.asp.net/web-api))
  - Framework for building RESTful Web services
    - Write C# code to handle HTTP requests in REST style (GET / POST / PUT / DELETE requests)
    - Return JSON / XML as result

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic11.png" style="top:25.97%; left:80.16%; width:26.45%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET: SPA, SignalR
- **Single Page Applications (SPA)** (read more)
  - Combine ASP.NET Web API with client-side JS
  - Write a HTML5 single page apps with AngularJS / Knockout.js / other JS client-side framework
  - Client HTML5 code consumes Web API services
- **SignalR** (read more)
  - Real-time communication between client (JS) and server (C#) over HTTP through Web Sockets
    - Server C# code can invoke JS functions at the client
    - Client JS code can invoke C# methods at the server


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Simple Web Forms App
## Demo-->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Simple MVC  App
## Demo-->


<!-- section start -->
<!-- attr: { id:'structure', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="structure"></a>ASP.NET Application Structure
## Typical ApplicationStructure in ASP.NET

 <img class="slide-image" showInPresentation="true" src="imgs\pic15.png" style="top:9.13%; left:-17.68%; width:23.03%; z-index:-1" />
 <img class="slide-image" showInPresentation="true" src="imgs\pic14.png" style="top:9.09%; left:92.70%; width:24.03%; z-index:-1" />



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET App Structure
- **App_Start**
  - **BundleConfig** / **RoutesConfig**/ **IdentityConfig** / **Startup.cs**(OWIN)
- **App_Data**
- **Web.config**
- **Global.asax**
- **Content** and **Content\themes**
- **Scripts**, **img**,**fonts**
- **Models** / **Views** / **Controllers**
- **Site.Master** / **Site.Mobile.Master**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic16.png" style="top:0.71%; left:-23.68%; width:23.80%; z-index:-1" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# App_Start
- The **App_Start** folder
  - Holds global configuration logic
  - Classes that are used at application start-up
- **BundleConfig.cs** (read more)
  - Combines and optimizes CSS and JS files
- **FilterConfig.cs** (read more)
  - Configures filters in MVC / Web API apps
  - Configures pre-action and post-action behavior to the controller's action methods


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # App_Start -->
- **RouteConfig.cs** (read more)
  - Configures URL patterns and their handlers
  - Maps user-friendly URLs to certain page / controller
- **IdentityConfig.cs** / **Startup.Auth.cs**
  - Configures the membership authentication
    - Users, roles, login, logout, user management
  - OAuth login (cross-sites login, read more)
    - Facebook / Twitter / Microsoft / Google login


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# App_Data
- The **App_Data** directory holds the local data files of the Web application
  - E.g. **MyWebApp.mdf** + **MyWebApp.ldf**
  - E.g. **Countries.xml**
- The SQL Server "Local DB" (read more)
  - Local **.mdf** + **.ldb** files, attached at startup
  - SQL Server process started on demand
  - Database created on demand (if missing)
  - Great for development and testing


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Web.config
- **Web.config** is web app's configuration file
  - Holds settings like DB connection strings, HTTP handlers, modules, assembly bindings
  - Can hold custom application settings, e.g. credentials for external services
  - Changes in **Web.config** do not require rebuild
- You may have several **Web.config** files
  - One global for the application
  - Several for different folder in the application


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em'} -->
<!-- # Web.config -->
- **Web.config** inherits from the global **Web.config** and from **machine.config**
  - Global settings for all applications on the server
- **Web.Debug.config**
  - Local settings for debugging
  - E.g. local database instance for testing
- **Web.Release.config**
  - Production settings for real world deployment


```cs
C:\Windows\Microsoft.NET\Framework\v4.0.30319\Config\machine.config
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.7em' } -->
# Web.config – _Example_

```cs
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="entityFramework"
		type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection,
		EntityFramework, Version=6.0.0.0, Culture=neutral,
		PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=(LocalDb)\v11.0;
		AttachDbFilename=|DataDirectory|\aspnet.mdf;
		Initial Catalog=aspnet;Integrated Security=True"
		providerName="System.Data.SqlClient" />  </connectionStrings>
  <appSettings>
    <add key="webpages:Enabled" value="false" />
    <add key="ClientValidationEnabled" value="true" />
    <add key="UnobtrusiveJavaScriptEnabled" value="true" />
    …
  </appSettings>
  <system.web>
    <compilation debug="true" targetFramework="4.6.1" />
    …
  </system.web>
  <system.webServer> … </system.webServer>
  <runtime> … </runtime>
  <entityFramework> … </entityFramework>
</configuration>
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Global.asax
- **Global.asax** defines the HTTP application
  - Defines global application events like
    - **Application_Start**
    - **Application_BeginRequest**
    - **Application_EndRequest**
    - **Application_Error**
    - **…**
  - Typically invokes **BundleConfig**, **RouteConfig**, **FilterConfig**, etc.




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET App Lifecycle -->
<!-- ## Application Lifecycle, HTTP Modules,Handlers, Events, Controllers, Pages, … -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic17.png" style="top:40.88%; left:14.03%; width:79.34%; z-index:-1" /> -->


<!-- attr: { id:'lifecycle', showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.8em' } -->
# <a id="lifecycle"></a> ASP.NET App Lifecycle
- Step 1 creates Application object, Request, Response and Context objects to process the request
- Step 2 series of events called MHPM for short – Module, Handler, Page, Module Events
- * Source: http://www.codeproject.com/Articles/73728/ (by Shivprasad Koirala)

<img class="slide-image" showInPresentation="true" src="imgs\pic18.png" style="top:48.46%; left:8.42%; width:89.92%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
<!-- # ASP.NET App Lifecycle -->
- * Source: http://www.codeproject.com/Articles/73728/

<img class="slide-image" showInPresentation="true" src="imgs\pic19.png" style="top:20.10%; left:5.61%; width:95.21%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
<!-- # ASP.NET App Lifecycle -->
- * Source: http://www.codeproject.com/Articles/73728/

<img class="slide-image" showInPresentation="true" src="imgs\pic20.png" style="top:17.11%; left:7.11%; width:73.63%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
# HttpHandler
- * Source: http://www.codeproject.com/Articles/73728/
- HttpHandler – injects logic based in file extensions
- HttpHandler is an extension based processor

<img class="slide-image" showInPresentation="true" src="imgs\pic21.png" style="top:33.80%; left:20.58%; width:60.23%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
# HttpModule
- * Source: http://www.codeproject.com/Articles/73728/
- HttpModule – injects logic in the events of ASP.NET pipleline
- HttpModule is an event based processor

<img class="slide-image" showInPresentation="true" src="imgs\pic22.png" style="top:40.21%; left:5.61%; width:94.97%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
<!-- # ASP.NET App Lifecycle -->
- * Source: http://www.codeproject.com/Articles/73728/

<img class="slide-image" showInPresentation="true" src="imgs\pic23.png" style="top:15.02%; left:12.16%; width:81.98%; z-index:-1" />


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Application Lifecycle Events
- **HttpApplication** have a complex pipeline to the process HTTP requests (read more)
  - **Application_Start**
  - **Application_End**
  - **Application_Error**
  - **Application_BeginRequest**
  - **Application_EndRequest**
  - **Application_PreSendRequestHeaders**
  - **Application_ResolveRequestCache**
  - **Application_PreRequestHandlerExecute**

<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic24.png" style="top:22.04%; left:77.46%; width:26.63%; z-index:-1" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # App Lifecycle Events
## Demo -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.9em' } -->
# HTTP Handlers
- A "**HTTP handler**" is a process / C# codethat responses to HTTP requests
- Sample HTTP handler in C#:

```cs
public class TelerikAcademyHttpHandler : IHttpHandler
{
  public void ProcessRequest(HttpContext context)
  { context.Response.Write("I am а HTTP handler."); }
  public bool IsReusable
  { get { return false; } }
}
```

- Handler registration in **Web.config**:

```cs
<configuration><system.webServer><handlers>
  <add verb="*" path="*.academy" name="Academy's HTTP handler"
       type="TelerikAcademyHttpHandler"/>
</handlers></system.webServer></configuration>
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Writing a HTTP Handler
## Demo-->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# HTTP Modules
- **HTTP modules** can customize requests for resources that are serviced by ASP.NET
  - It can intercept all HTTP requests and apply a custom logic
- Steps to create an HTTP Module
  - Implement the **IHttpModule** interface
    - Subscribe to events you want to intercept, e.g. **HttpApplication.BeginRequest**
  - Register the HTTP module in **Web.config** in the **<modules>** section


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!--# Writing a HTTP Module
## Demo-->


<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET Common Concepts -->
<!-- ## Major Classes, Namespaces, Web Sites, Web Apps -->


<!-- attr: { id:'commonConcepts', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="commonConcepts"></a> ASP.NET Namespaces
- Major ASP.NET (4.6) namespaces
  - **System.Web**
    - Web application main classes like **HttpApplication**, **HttpContext**, **HttpRequest**, **HttpResponse**, **HttpSessionState**, …
  - **System.Web.Mvc**
    - MVC classes and framework components
  - **System.Web.UI (.WebControls)**
    - Web Forms UI controls (like **Button** and **Label**)


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# ASP.NET Classes
- **HttpApplication**
  - Base class for the ASP.NET Web apps(inherited in **Global.asax**)
- **HttpContext**
  - Encapsulates all HTTP-specific information about an individual HTTP request
- **HttpRequest**
  - Encapsulates an HTTP request
- **HttpResponse**
  - Encapsulates an HTTP response


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Web Site vs. Web Application
- Web Sites in VS
  - No project file(**.csproj** / **.sln**)
  - Code compiled dynamically at the Web server
  - Can be precompiled (into multiple assemblies)
- Web Apps in VS
  - Have project file(like any C# project)
  - Compilation produces an assembly: **bin\*.dll**
- Web apps are recommended ([read more](http://msdn.microsoft.com/en-us/library/dd547590.aspx))



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET 5 -->
<!-- ## The redesign of ASP.NET -->
<!-- <img class="slide-image" showInPresentation="true" src="imgs\pic33.png" style="top:38.09%; left:14.97%; width:77.58%; z-index:-1" /> -->


<!-- attr: { id:'core', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="core"></a> ASP.NET 5
- Open-source cross-platform framework for building modern cloud-based Web applications
  - Modular components with minimal overhead
  - Cross-platform (runs on Windows, Mac, Linux)
- Rewritten from the ground up
  - A lot of legacy code removed from the 15-years-old ASP.NET
  -  No longer based on System.Web.dll
    - Based on a set of granular and well factored NuGet packages


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style: 'font-size: 0.84em' } -->
# Main ASP.NET 5 Improvements
- New light-weight and modular HTTP request pipeline
- Ability to host on IIS or self-host in your own process
- Built on .NET Core
- Ships entirely as NuGet packages
- Integrated support for creating and using NuGet packages
- Single aligned web stack for Web UI and Web APIs
- Cloud-ready environment-based configuration
- Built-in support for dependency injection
- New tooling that simplifies modern web development
- Build and run cross-platform ASP.NET apps on Windows, Mac and Linux
- Open source and community focused


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # ASP.NET 5
## [Demo]()-->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Introduction to ASP.NET
- http://academy.telerik.com


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - csharpfundamentals.telerik.com
  - Telerik Software Academy
    - academy.telerik.com
  - Telerik Academy @ Facebook
    - facebook.com/TelerikAcademy
  - Telerik Software Academy Forums
    - forums.academy.telerik.com
