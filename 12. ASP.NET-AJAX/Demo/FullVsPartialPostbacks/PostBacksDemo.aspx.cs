using System;
using System.Linq;
using System.Data;
using FullVsPartialPostbacks;

public partial class PostBacksDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CountriesDataContext context = new CountriesDataContext();
            DropDownListCountries.DataSource = context.Countries;
            DropDownListCountries.DataBind();
            RebindTowns();
        }
    }

    protected void DropDownListCountries_Changed(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
        RebindTowns();
    }

    private void RebindTowns()
    {
        int countryId = int.Parse(DropDownListCountries.SelectedValue);
        CountriesDataContext context = new CountriesDataContext();
        var towns =
            from town in context.Towns
            where town.CountryID == countryId
            select town;
        DropDownListTowns.DataSource = towns;
        DropDownListTowns.DataBind();
    }

    protected void ButtonPartialPostBack_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(3000);
    }
}