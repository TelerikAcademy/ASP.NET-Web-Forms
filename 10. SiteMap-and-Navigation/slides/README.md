<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Site Maps and Navigation
##  Using ASP.NET Navigation Controls and Site Maps
<div class="signature">
    <p class="signature-course">Telerik Software Academy</p>
    <p class="signature-initiative">http://academy.telerik.com </p>
    <a href = "ASP.NET Web Forms" class="signature-link">ASP.NET Web Forms</a>
</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents 
- Site Navigation and Site Maps
- Web.sitemap
- Menu, TreeView, SiteMapPath Controls
- SiteMapDataSource

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Site Navigation

<!-- attr: { showInPresentation:true, style:'' } -->
# Site Navigation
- Site maps and navigation controls provide an easy way to create navigation in ASP.NET
  - `Site map`
    - Describes the logical structure of a site 
    - Built in support for XML Site Map
  - Object model 
    - Programming API for accessing the Site Map
  - `SiteMapDataSource`
    - Used for data binding

<!-- attr: { showInPresentation:true, style:'' } -->
# What is Site Map?
- `Site Map`
  - A way to describe and store the logical structure of the site
  - A tree-like data structure
- Visual Studio and ASP.NET support Site Maps stored in XML files
- To use another storage mechanism you must use a custom `SiteMapProvider`

<!-- attr: { showInPresentation:true, style:'' } -->
# XML Site Map
- Create an XML file named `Web.sitemap` in the application root
  - Automatically detected by the default ASP.NET `SiteMapProvider`
- Add a `siteMapNode` element for each page in your Web site
  - Nest `siteMapNode` elements to create a hierarchy
- Should have only one root `siteMapNode` element 

<!-- attr: { showInPresentation:true, style:'' } -->
# Web.sitemap – Example

```xml
&#60;?xml version="1.0" encoding="utf-8" ?&#62;
&#60;siteMap&#62; 
  &#60;siteMapNode title="Home" description="Home"
    url="~/Default.aspx"&#62;
    &#60;siteMapNode title="Products" description=
      "Our products" url="~/Products.aspx" /&#62;
    &#60;siteMapNode title="Hardware" description=
      "Hardware choices" url="~/Hardware.aspx" /&#62;
    &#60;siteMapNode title="Software" description=
      "Software choices" url="~/Software.aspx" /&#62; 
  &#60;/siteMapNode&#62;
  …
&#60;/siteMap&#62;
```

<!-- attr: { showInPresentation:true, style:'' } -->
# siteMapNode Attributes
- `Title `– a friendly name of the node (page)
- `Description `– used as a tool tip description in Site Map controls
- `URL `– the URL of the page
  - Usually starting with "`~/`" meaning the application root

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size: 44px' } -->
# Site Map Controls 
- Site Map Controls 
<br><br>
  - `Menu`
  - `TreeView`
  - `SiteMapPath`

<img class="slide-image" src="imgs/site-map-controls.png" style="width:90%; top:7%; left:0%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Site Navigation & Controls

<img class="slide-image" src="imgs/site-nav-and-controls.png" style="width:90%; top:20%; left:5%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Menu Control
- The `<asp:Menu>` is a fully functional menu
- Customizable visual styles
  - Images, effects, direction, …
  - But it puts inline CSS styles
- Two modes
  - `Static` – all of the menu is visible 
  - `Dynamic` – visible only when the mouse pointer is over some of the  `MenuItem`-s 

<!-- attr: { showInPresentation:true, style:'' } -->
# Menu Control (2)
- `StaticDisplayLevels`
  - The number of statically displayedlevels starting from the root
- `MaximumDynamicDisplay`
  - The number of dynamically displayed levels after the last of the static ones
- Element `onclick()` event
  - Navigation to another page
  - Postback to the same page

<!-- attr: { showInPresentation:true, style:'' } -->
# TreeView Control
- `TreeView` is a control used to display data in a hierarchical view
- Supports settings for various images and visual adjustments
- Supports navigation and postback
- We can create nodes at design time or through code behind
  - We can fill the nodes on demand (when there is lots of data)
- Used together with `SiteMapDataSource`

<!-- attr: { showInPresentation:true, style:'' } -->
# SiteMapPath Control
- Allows the user to see where he is in the site hierarchy
- Displayed in a straightforward fashion
- We can set:
  - `PathDirection` – `RootToCurrent `and `CurrentToRoot`
  - `PathSeparator` – a separator between the levels in the hierarchy
  - `ParentLevelsDisplayed` – how many parent elements to display

<!-- attr: { showInPresentation:true, style:'' } -->
# SiteMapDataSource
- `SiteMapPath` has integrated support for Site Map (it reads automatically `Web.sitemap`)
- A `SiteMapDataSource` object is used to bind the `Web.sitemap` to a navigation control
  - First drop one on the page
  - Set the `DataSourceID` property of the bound control to point to the `SiteMapDataSource`
  - `ShowStartingNode` – show hide the root

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Navigation Controls -->
##  [Demo]()

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Site Maps and Security
##  Navigation based on Users and Roles

<!-- attr: { showInPresentation:true, style:'' } -->
# Navigation and Security
  - To hide all restricted pages from the navigation menu put the following in `Web.config`:
  - To filter menu items based on logged in user / role use the `OnMenuItemDataBound` event

```xml
&#60;siteMap defaultProvider="secureProvider"&#62;
  &#60;providers&#62;
    &#60;add name="secureProvider"
        type="System.Web.XmlSiteMapProvider"
        siteMapFile="Web.sitemap"
        securityTrimmingEnabled="true" /&#62;
  &#60;/providers&#62;
&#60;/siteMap&#62;
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Filtering the Menu Items
  - Filtering the menu items loaded from `Web.sitemap` base on custom logic:

```cs
protected void NavigationMenu_MenuItemDataBound(
  object sender, MenuEventArgs e)
{
  if (ShouldRemoveItem(e.Item.Text))
  {
    e.Item.Parent.ChildItems.Remove(e.Item);
  }
}
private bool ShouldRemoveItem(string menuText)
{
  // Custom filtering logic …
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
<!-- # Site Maps and Security -->
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Site Maps and Navigation

<img class="slide-image" src="imgs/questions.png" style="width:80%; top:15%; left:10%" />
<div style="position: absolute; bottom: 1em; right: 0; font-size: 26px;">http://academy.telerik.com</div>