using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // View Menu Button
        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            // Open the Menu Display Form
            frmMenuDisplay menuForm = new frmMenuDisplay();
            menuForm.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Open the AddMenuItem form
            frmAddMenuItem addForm = new frmAddMenuItem();
            addForm.ShowDialog();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            // Open the CreateOrder form
            frmCreateOrder orderCreate = new frmCreateOrder();
            orderCreate.ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            // Open the OrdersView form
            frmOrdersView viewOrders = new frmOrdersView();
            viewOrders.ShowDialog();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            // Closing the application
            DialogResult resultMsg = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultMsg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
