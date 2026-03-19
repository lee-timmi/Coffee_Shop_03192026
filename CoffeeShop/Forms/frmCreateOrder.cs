using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Classes;
using CoffeeShop.Controllers;
using MenuItem = CoffeeShop.Classes.MenuItem;

namespace CoffeeShop
{
    public partial class frmCreateOrder : Form
    {
        // ====== CLASS LEVEL variables
        // controllers to DB
        private MenuItemController menuItemController = new MenuItemController();
        private OrderController orderController = new OrderController();

        // Hold for customer ordering
        private List<OrderItem> currentOrder = new List<OrderItem>();

        // Tax Rate (10%)
        private const double rate = 0.10;


        // ======= Constructor
        public frmCreateOrder()
        {
            InitializeComponent();
            LoadMenuItem();
            UpdateOrderSummary();
        }

        // ========= HELPER METHODS
        private void LoadMenuItem()
        {
            try
            {
                List<MenuItem> menuItems = menuItemController.GetMenuItems();

                cboMenuItem_CNO.DisplayMember = "Title";
                cboMenuItem_CNO.ValueMember = "MenuItemID";
                cboMenuItem_CNO.DataSource = menuItems;

                if (menuItems.Count > 0)
                {
                    cboMenuItem_CNO.SelectedIndex = 0;
                    UpdateItemPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu items: {ex.Message}");
            }
        }

        private void UpdateItemPrice()
        {
            if (cboMenuItem_CNO.SelectedItem != null)
            {
                MenuItem selected = (MenuItem)cboMenuItem_CNO.SelectedItem;
                lblItemPrice_CNO.Text = $"Price: {selected.RetailPrice:C} each";
            }
        }

        private void AddToOrder()
        {
            if (cboMenuItem_CNO.SelectedItem == null)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            MenuItem selected = (MenuItem)cboMenuItem_CNO.SelectedItem;
            int quantity = (int)nudQuantity_CNO.Value;

            // Check for already placed order
            OrderItem alreadyExists = null;
            foreach (OrderItem item in currentOrder)
            {
                if (item.MenuItemID == selected.MenuItemID)
                {
                    alreadyExists = item;
                    break;
                }
            }
            if (alreadyExists != null)
            { // add more to the current existing
                alreadyExists.Quantity += quantity;
            }
            else
            {
                OrderItem newOrderItem = new OrderItem
                {
                    MenuItemID = selected.MenuItemID,
                    Title = selected.Title,
                    Quantity = quantity,
                    ItemPrice = selected.RetailPrice
                };
                currentOrder.Add(newOrderItem);
            }

            RefreshOrderList();
            UpdateOrderSummary();

            // reset qty to 1
            nudQuantity_CNO.Value = 1;
        }

        // remove selected item from order
        private void RemoveFromOrder()
        {
            if (lboOrderItems_CNO.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            // Get selected item
            OrderItem itemSelected = (OrderItem)lboOrderItems_CNO.SelectedItem;

            DialogResult result = MessageBox.Show(
                $"Remove {itemSelected.Quantity}x {itemSelected.Title}?",
                "Confirm Remove", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                currentOrder.Remove(itemSelected);
                RefreshOrderList();
                UpdateOrderSummary();
            }
        }

        // Refresh lboOrderItems_CNO
        private void RefreshOrderList()
        {
            lboOrderItems_CNO.Items.Clear();

            foreach(OrderItem item in currentOrder)
            {
                lboOrderItems_CNO.Items.Add(item);
            }
        }

        // Calculation for subtotal, tax rate, and total
        private void UpdateOrderSummary()
        {
            double subtotal = 0;

            foreach (OrderItem item in currentOrder)
            {
                subtotal += (double)item.TotalPrice;
            }

            double tax = subtotal * rate;
            double total = subtotal + tax;

            lblSubtotal_CNO.Text = $"Subtotal: {subtotal:C}";
            lblTax_CNO.Text = $"Tax (10%): {tax:C}";
            lblTotal_CNO.Text = $"Total: {total:C}";

            // Enable the buttons only if we have customer name & items
            btnPlaceOrder_CNO.Enabled = (currentOrder.Count > 0 && 
                !string.IsNullOrWhiteSpace(tboCustomerName_CNO.Text));
        }

        // Boolean to check if order is ready to be saved
        private bool ValidateOrder()
        {
            if (string.IsNullOrWhiteSpace(tboCustomerName_CNO.Text))
            {
                MessageBox.Show("Customer name is required.");
                tboCustomerName_CNO.Focus();
                return false;
            }

            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(tboCustomerEmail_CNO.Text))
            {
                string email = tboCustomerEmail_CNO.Text.Trim();
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Pease enter a valid email address.");
                    tboCustomerEmail_CNO.Focus();
                    return false;
                }
            }

            return true;
        }

        // Save the order
        private void SaveOrder()
        {
            try
            {
                Order order = new Order();
                order.CustomerName = tboCustomerName_CNO.Text.Trim();
                order.CustomerEmail = tboCustomerEmail_CNO.Text.Trim();
                order.OrderDateTime = DateTime.Now;

                // Copy current order items
                order.OrderItems = new List<OrderItem>();
                foreach (OrderItem item in currentOrder)
                {
                    order.OrderItems.Add(item);
                }

                // calculate total w/ tax
                double subtotal = 0;
                foreach (OrderItem item in order.OrderItems)
                {
                    subtotal += (double)item.TotalPrice;
                }
                order.TotalCost = (subtotal + (subtotal * rate));

                // save to db
                bool success = orderController.SaveOrder(order);

                if (success)
                {
                    MessageBox.Show($"Order placed successfully!\n\n" +
                        $"Customer: {order.CustomerName}\n" +
                        $"Total: {order.TotalCost:C}", "Success");

                    // Ask if user wants to add more
                    DialogResult addMore = MessageBox.Show(
                        "Create another order?", "Continue?", MessageBoxButtons.YesNo);

                    if (addMore == DialogResult.Yes)
                    {
                        ClearOrder();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}");
            }
        }

        // clear everything for new order
        private void ClearOrder()
        {
            currentOrder.Clear();
            tboCustomerName_CNO.Clear();
            tboCustomerEmail_CNO.Clear();
            lboOrderItems_CNO.Items.Clear();
            UpdateOrderSummary();

            if (cboMenuItem_CNO.Items.Count > 0)
            {
                cboMenuItem_CNO.SelectedIndex = 0;
            }

            nudQuantity_CNO.Value = 1;
            tboCustomerName_CNO.Focus();
        }

        private void cboMenuItem_CNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateItemPrice();
        }

        private void btnAddToOrder_CNO_Click(object sender, EventArgs e)
        {
            AddToOrder();
        }

        private void btnRemoveItem_CNO_Click(object sender, EventArgs e)
        {
            RemoveFromOrder();
        }

        private void lboOrderItems_CNO_DoubleClick(object sender, EventArgs e)
        {
            RemoveFromOrder();
        }

        private void tboCustomerName_CNO_TextChanged(object sender, EventArgs e)
        {
            btnPlaceOrder_CNO.Enabled = (currentOrder.Count > 0 &&
                                         !string.IsNullOrWhiteSpace(tboCustomerName_CNO.Text));
        }

        private void btnPlaceOrder_CNO_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                SaveOrder();
            }
        }

        private void btnCancelItem_CNO_Click(object sender, EventArgs e)
        {
            if (currentOrder.Count > 0 || !string.IsNullOrWhiteSpace(tboCustomerName_CNO.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Cancel this order?", "Confirm Cancel",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
