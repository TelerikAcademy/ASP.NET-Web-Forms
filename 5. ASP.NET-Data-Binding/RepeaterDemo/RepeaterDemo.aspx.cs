using System;
using System.Collections.Generic;

public partial class RepeaterDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Site> sites = new List<Site>();
        sites.Add(new Site(1, "Telerik Software Academy",
            @"http://academy.telerik.com",
            @"http://academy.telerik.com/Sitefinity/WebsiteTemplates/MyTemplate/App_Themes/Academy/Images/telerik-academy-logo.jpg"));
        sites.Add(new Site(2, "Telerik Academy Students' Learning System", 
            @"http://telerikacademy.com",
            @"http://telerikacademy.com/Files/4e18d353-8e48-4730-9855-ca896ec11d29.png"));
        sites.Add(new Site(3, "Telerik Academy Forums",
            @"http://forums.academy.telerik.com",
            @"http://academy.telerik.com/images/default-album/programming-champion-telerik-academy.png"));
        sites.Add(new Site(3, "Telerik Academy Facebook Page",
            @"http://www.facebook.com/TelerikAcademy",
            @"http://academy.telerik.com/images/default-album/telerik-academyE49D1716EBCD.jpg"));

        RepeaterSites.DataSource = sites;
        RepeaterTemplatedList.DataSource = sites;
        RepeaterImages.DataSource = sites;
        DataBind();
    }
}
