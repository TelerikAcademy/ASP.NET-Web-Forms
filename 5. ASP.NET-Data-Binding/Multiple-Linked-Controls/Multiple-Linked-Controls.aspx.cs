using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiple_Linked_Controls
{
    public partial class Multiple_Linked_Controls : System.Web.UI.Page
    {
        private List<Car> cars = new List<Car>
        {
            new Car() { Category = "Car", Brand = "BMV", Model = "320" },
            new Car() { Category = "Car", Brand = "BMV", Model = "520" },
            new Car() { Category = "Car", Brand = "Audi", Model = "A4" },
            new Car() { Category = "Car", Brand = "Audi", Model = "A5" },
            new Car() { Category = "Car", Brand = "Mazda", Model = "2" },
            new Car() { Category = "Car", Brand = "Mazda", Model = "4" },
            new Car() { Category = "Car", Brand = "Mercedes", Model = "SLK" },

            new Car() { Category = "Jeep", Brand = "BMV", Model = "x5" },
            new Car() { Category = "Jeep", Brand = "BMV", Model = "x6" },
            new Car() { Category = "Jeep", Brand = "Audi", Model = "320" },
            new Car() { Category = "Jeep", Brand = "Audi", Model = "320" },
            new Car() { Category = "Jeep", Brand = "Land Rover", Model = "1" },
            new Car() { Category = "Jeep", Brand = "Land Rover", Model = "2" },

            new Car() { Category = "Truck", Brand = "Kamaz", Model = "1" },
            new Car() { Category = "Truck", Brand = "Zil", Model = "2" },
            new Car() { Category = "Truck", Brand = "Mercedes", Model = "3" },
        };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["categories"] = GetCategories().ToArray();

            if (!IsPostBack)
            {
                var categories = ((string[])ViewState["categories"]).Select(x => new ListItem(x)).ToArray();
                this.DropDownListCategory.Items.AddRange(categories);
                this.DropDownListCategory.DataBind();
            }

            var brands = ViewState["brands"];
            if (brands != null && this.DropDownListBrand.SelectedIndex == 0)
            {
                this.DropDownListBrand.DataSource = ((string[])brands).Select(x => new ListItem(x)).ToArray();
                this.DropDownListBrand.DataBind();
            }
        }

        protected void SearchButton_Command(object sender, CommandEventArgs e)
        {
            string category = this.DropDownListCategory.SelectedValue;
            string brand = this.DropDownListBrand.SelectedValue;

            IEnumerable<Car> result = this.cars
                .Where(x => x.Category == category && x.Brand == brand);

            this.ListViewCars.DataSource = result;
            this.ListViewCars.DataBind();
        }

        protected void DropDownListCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listView = sender as DropDownList;
            if (listView == null)
            {
                return;
            }

            ViewState["brands"] = GetBrandsByCategory(listView.SelectedValue).ToArray();
        }

        private IEnumerable<string> GetCategories()
        {
            return this.cars.Select(x => x.Category).Distinct();
        }

        private IEnumerable<string> GetBrandsByCategory(string selectedCategory)
        {
            return this.cars
               .Where(x => x.Category == selectedCategory)
               .Select(x => x.Brand)
               .Distinct();
        }
    }
}