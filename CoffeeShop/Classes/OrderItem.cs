using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************
 
        Represent the the OrderItems table
 
**********************************************/

namespace CoffeeShop.Classes
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int MenuItemID { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Subtotal { get; set; }



        // Calculation
        public decimal TotalPrice
        {
            get
            {
                return Quantity * ItemPrice;
            }
        }

        public OrderItem() 
        { 
            Title = string.Empty;
        }

        public override string ToString()
        {
            return $"{Title} x {Quantity} @ {ItemPrice:C} = {TotalPrice:C}";
        }
    }
}
