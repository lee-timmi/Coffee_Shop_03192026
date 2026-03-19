using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************
 
        Represent the the MenuItem table
 
**********************************************/

namespace CoffeeShop.Classes
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal RetailPrice { get; set; }
        // Possibly image 
        public string ImageUrl { get; set; }
        public int Calories { get; set; }
        public int Fat { get; set; }
        public int Carbs { get; set; }
        public int Sugar { get; set; }
        public string Ingredients { get; set; }
        public int TotalQuantitySold { get; set; }


        public MenuItem()
        {
            // Default constructor
            Title = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            ImageUrl = string.Empty;
            Ingredients = string.Empty;
        }

        public MenuItem(string title, string category, decimal retailPrice)
        { 
            Title = title;
            Category = category;
            RetailPrice = retailPrice;

            Description = string.Empty;
            ImageUrl = string.Empty;
            Ingredients = string.Empty;
        }

        public string GetMenuItemInfo()
        {
            return $"Title: {Title} - Category: {Category} - Price: {RetailPrice:C}";
        }

        public override string ToString()
        {
            return GetMenuItemInfo();
        }

    }
}
