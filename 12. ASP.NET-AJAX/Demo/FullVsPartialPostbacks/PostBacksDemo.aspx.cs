using System;
using System.Linq;
using System.Threading;

using FullVsPartialPostbacks;

public partial class PostBacksDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.Page.IsPostBack)
        {
            var context = new CountriesDataContext();
            this.DropDownListCountries.DataSource = context.Countries;
            this.DropDownListCountries.DataBind();
            this.RebindTowns();
        }
    }

    protected void DropDownListCountries_Changed(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        this.RebindTowns();
    }

    private void RebindTowns()
    {
        var countryId = int.Parse(this.DropDownListCountries.SelectedValue);
        var context = new CountriesDataContext();
        var towns =
            from town in context.Towns
            where town.CountryID == countryId
            select town;
        this.DropDownListTowns.DataSource = towns;
        this.DropDownListTowns.DataBind();
    }

    protected void ButtonPartialPostBack_Click(object sender, EventArgs e)
    {
        Thread.Sleep(3000);
    }
}