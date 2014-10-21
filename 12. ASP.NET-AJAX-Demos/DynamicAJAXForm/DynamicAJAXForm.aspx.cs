using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace DynamicAJAXForm
{
    public partial class DynamicAJAXForm : System.Web.UI.Page
    {
        protected void RadioButtonBeer_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBeers.Visible = true;
            this.PanelWines.Visible = false;
            ShowSelectedDrinks();
        }

        protected void RadioButtonWine_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelWines.Visible = true;
            this.PanelBeers.Visible = false;
            ShowSelectedDrinks();
        }

        protected void CheckBoxListBeers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedDrinks();
        }

        protected void CheckBoxListWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedDrinks();
        }

        private void ShowSelectedDrinks()
        {
            this.LiteralFavoriteDrink.Text = "(none)";
            if (this.RadioButtonBeer.Checked)
            {
                this.LiteralFavoriteDrink.Text = RadioButtonBeer.Text;
                this.LiteralSelectedDrinks.Text =
                    ExtractSelectedItemsAsString(this.CheckBoxListBeers);
            }
            else if (this.RadioButtonWine.Checked)
            {
                this.LiteralFavoriteDrink.Text = RadioButtonWine.Text;
                this.LiteralSelectedDrinks.Text =
                    ExtractSelectedItemsAsString(this.CheckBoxListWines);
            }
            this.PanelResults.Visible = true;
        }

        private static IList<string> ExtractSelectedItems(ListControl itemsControl)
        {
            List<string> selectedItems = new List<string>();
            for (int i = 0; i < itemsControl.Items.Count; i++)
            {
                ListItem item = itemsControl.Items[i];
                if (item.Selected)
                {
                    selectedItems.Add(item.Text);
                }
            }
            return selectedItems;
        }

        private static string ExtractSelectedItemsAsString(ListControl itemsControl)
        {
            IList<string> selectedItems = ExtractSelectedItems(itemsControl);
            string result = "(none)";
            if (selectedItems.Count > 0)
            {
                result = String.Join(", ", selectedItems);
            }
            return result;
        }
    }
}