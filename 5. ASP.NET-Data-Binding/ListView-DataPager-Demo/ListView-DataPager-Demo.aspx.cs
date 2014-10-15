using System;
using System.Collections.Generic;

namespace ListView_DataPager_Demo
{
	public partial class ListView_DataPager_Demo : System.Web.UI.Page
	{
		private List<Product> products = new List<Product>()
		{ 
			new Product() { Name="Beer Ariana", Price = 0.86m },
			new Product() { Name="Vodka Sobieski", Price = 24.20m },
			new Product() { Name="Rakiya Grozdova", Price = 8.50m },
			new Product() { Name="Jack Daniel's", Price = 36.40m },
			new Product() { Name="Beer Zagorka", Price = 1.16m },
			new Product() { Name="Beer Tuborg", Price = 1.24m },
			new Product() { Name="Vodka Absolute", Price = 13.70m },
		};		

		protected void Page_Load(object sender, EventArgs e)
		{
            this.ListViewProducts.DataSource = this.products;
            this.DataBind();
		}
	}
}
