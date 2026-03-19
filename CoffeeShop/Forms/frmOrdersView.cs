using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Controllers;
using CoffeeShop.Classes;
using System.Data.OleDb;

namespace CoffeeShop
{
    public partial class frmOrdersView : Form
    {
        // CLASS LEVEL Variables
        private OrderController orderController = new OrderController();
        
        private List<Order> currentOrders = new List<Order>();

        private string currentSort = "Date";

        public frmOrdersView()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadOrders();
        }

        // ======== HELPER METHODS
        private void SetupDataGridView()
        {
            // Clearn any auto-generated columns
            dgvOrders_OV.AutoGenerateColumns = false;
            dgvOrderItems_OV.AutoGenerateColumns = false;

            // Clear existing columns
            dgvOrders_OV.Columns.Clear();
            dgvOrderItems_OV.Columns.Clear();

            // Set Up for the main orders grid (dgvOrders)

            // Order ID Column
            DataGridViewTextBoxColumn columnOrderID = new DataGridViewTextBoxColumn();
            columnOrderID.DataPropertyName = "OrderID";
            columnOrderID.HeaderText = "Order #";
            columnOrderID.Width = 80;
            dgvOrders_OV.Columns.Add(columnOrderID);

            // Date Time Column
            DataGridViewTextBoxColumn columnDateTime = new DataGridViewTextBoxColumn();
            columnDateTime.DataPropertyName = "OrderDateTime";
            columnDateTime.HeaderText = "Date & Time";
            columnDateTime.Width = 150;
            columnDateTime.DefaultCellStyle.Format = "g";
            dgvOrders_OV.Columns.Add(columnDateTime);

            // Customer Column
            DataGridViewTextBoxColumn columnCustomer = new DataGridViewTextBoxColumn();
            columnCustomer.DataPropertyName = "CustomerName";
            columnCustomer.HeaderText = "Customer";
            columnCustomer.Width = 200;
            dgvOrders_OV.Columns.Add(columnCustomer);

            // Total Column
            DataGridViewTextBoxColumn columnTotal = new DataGridViewTextBoxColumn();
            columnTotal.DataPropertyName = "TotalCost";
            columnTotal.HeaderText = "Total";
            columnTotal.Width = 100;
            columnTotal.DefaultCellStyle.Format = "C2";
            columnTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrders_OV.Columns.Add(columnTotal);

            // ===== ORDER ITEMS grid (dgvOrderItems)

            // Item Column
            DataGridViewTextBoxColumn columnItemName = new DataGridViewTextBoxColumn();
            columnItemName.DataPropertyName = "Title";
            columnItemName.HeaderText = "Item";
            columnItemName.Width = 250;
            dgvOrderItems_OV.Columns.Add(columnItemName);

            // Quantity Column
            DataGridViewTextBoxColumn columnQuantity = new DataGridViewTextBoxColumn();
            columnQuantity.DataPropertyName = "Quantity";
            columnQuantity.HeaderText = "Qty";
            columnQuantity.Width = 50;
            columnQuantity.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrderItems_OV.Columns.Add(columnQuantity);

            // Price Column
            DataGridViewTextBoxColumn columnPrice = new DataGridViewTextBoxColumn();
            columnPrice.DataPropertyName = "ItemPrice";
            columnPrice.HeaderText = "Price";
            columnPrice.Width = 80;
            columnPrice.DefaultCellStyle.Format = "C2";
            columnPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrderItems_OV.Columns.Add(columnPrice);

            // Subtotal Column (calculated)
            DataGridViewTextBoxColumn columnSubtotal = new DataGridViewTextBoxColumn();
            columnSubtotal.DataPropertyName = "Subtotal";
            columnSubtotal.HeaderText = "Subtotal";
            columnSubtotal.Width = 50;
            columnSubtotal.DefaultCellStyle.Format = "C2";
            columnSubtotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvOrderItems_OV.Columns.Add(columnSubtotal);
        }

        // Load all orders from DB
        private void LoadOrders()
        {
            try
            {
                currentOrders = orderController.GetAllOrders();
                dgvOrders_OV.DataSource = null;
                dgvOrders_OV.DataSource = currentOrders;

                ClearOrderDetails();
            } catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }

        // Loading orders sorted by price or date
        private void LoadSortedOrders(string sortBy)
        {
            try
            {
                currentSort = sortBy;
                currentOrders = orderController.GetOrdersSorted(sortBy);
                dgvOrders_OV.DataSource = null;
                dgvOrders_OV.DataSource = currentOrders;

                ClearOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }

        // Clear the order details panel
        private void ClearOrderDetails()
        {
            lblOrderheader.Text = "Select an order to view details";
            dgvOrderItems_OV.DataSource = null;
            lblOrderTotal_OV.Text = "Total: $0.00";
            lblCustomerEmailInsert.Text = "[Cust. Email]";
        }

        // Load items for a specific order
        private void LoadOrderItems(int orderID)
        {
            try
            {
                List<OrderItem> items = orderController.GetOrderItems(orderID);
                dgvOrderItems_OV.DataSource = null;
                dgvOrderItems_OV.DataSource = items;

                // calculation and display of order total
                decimal total = 0;
                foreach (OrderItem item in items)
                {
                    total += item.Subtotal;
                }

                lblOrderTotal_OV.Text = $"Total: {total:C}";

            } catch (Exception ex)
            {
                MessageBox.Show($"Error loading order items: {ex.Message}");
            }
        }


        // ======= EVENT HANDLERS
        private void dgvOrders_OV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure user clicked a valid row
            if (e.RowIndex >= 0)
            {
                Order selectedOrder = currentOrders[e.RowIndex];

                // Update header
                lblOrderheader.Text = $"Order #{selectedOrder.OrderID} - " +
                    $"{selectedOrder.CustomerName} - {selectedOrder.OrderDateTime:g}";

                LoadOrderItems(selectedOrder.OrderID);

                // Setting up the user's email
                if (!string.IsNullOrWhiteSpace(selectedOrder.CustomerEmail))
                {
                    lblCustomerEmailInsert.Text = selectedOrder.CustomerEmail;
                } else
                {
                    lblCustomerEmailInsert.Text = "[No Email Provided]";
                }

                LoadOrderItems(selectedOrder.OrderID);
            }
        }

        private void btnSortPrice_OV_Click(object sender, EventArgs e)
        {
            LoadSortedOrders("Price");

            btnSortPrice_OV.BackColor = System.Drawing.Color.FromArgb(90, 60, 50);
            btnSortDate_OV.BackColor = System.Drawing.Color.FromArgb(74, 44, 42);
        }

        private void btnSortDate_OV_Click(object sender, EventArgs e)
        {
            LoadSortedOrders("Date");

            btnSortPrice_OV.BackColor = System.Drawing.Color.FromArgb(90, 60, 50);
            btnSortDate_OV.BackColor = System.Drawing.Color.FromArgb(74, 44, 42);
        }

        private void btnRefresh_OV_Click(object sender, EventArgs e)
        {
            LoadSortedOrders(currentSort);
        }

        private void btnBack_OV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
