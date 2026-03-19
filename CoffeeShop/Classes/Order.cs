using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************
 
        Represent the the Orders table
 
**********************************************/

namespace CoffeeShop.Classes
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public double TotalCost { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderDateTime = DateTime.Now;
            CustomerName = string.Empty;
            CustomerEmail = string.Empty;
            OrderItems = new List<OrderItem>();
        }

        public void CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.ItemPrice;
            }
            TotalCost = (double)total;
        }

        public int GetTotalItems()
        {
            int totalItems = 0;
            foreach (var item in OrderItems)
            {
                totalItems += item.Quantity;
            }
            return totalItems;
        }
    }
}
