using CoffeeShop.Controllers;
using CoffeeShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = CoffeeShop.Classes.MenuItem;


namespace CoffeeShop
{
    public partial class frmModifyMenuItem : Form
    {
        private MenuItemController controller = new MenuItemController();
        private MenuItem currentItem = null;

        // Constructor w/ no params
        public frmModifyMenuItem()
        {
            InitializeComponent();
            LoadCategories();
            LoadItems();
        }

        public frmModifyMenuItem(MenuItem modifiedItem)
        {
            InitializeComponent();
            LoadCategories();
            LoadItems();

            if (modifiedItem != null)
            {
                currentItem = modifiedItem;

                cboItem.SelectedValue = modifiedItem.MenuItemID;

                txtTitle_MMI.Text = modifiedItem.Title;
                txtPrice.Text = modifiedItem.RetailPrice.ToString("0.00");
                txtImageUrl.Text = modifiedItem.ImageUrl;
                txtCalories_MMI.Text = modifiedItem.Calories.ToString();
                txtFat_MMI.Text = modifiedItem.Fat.ToString();
                txtCarbs_MMI.Text = modifiedItem.Carbs.ToString();
                txtSugar_MMI.Text = modifiedItem.Sugar.ToString();
                txtIngredients_MMI.Text = modifiedItem.Ingredients;
                txtQuantitySold.Text = modifiedItem.TotalQuantitySold.ToString();

                cboCategory.SelectedItem = modifiedItem.Category;

                gboEditItemDetails.Enabled = true;
                btnUpdate_MMI.Enabled = true;
                btnDelete_MMI.Enabled = true;
            }
        }

        private void LoadItems()
        {
            List<MenuItem> menuItems = controller.GetMenuItems();
            cboItem.DisplayMember = "Title";
            cboItem.ValueMember = "menuItemID";
            cboItem.DataSource = menuItems;

        }

        private void LoadCategories()
        {
            List<string> menuCategories = controller.GetCategories();
            cboCategory.DataSource = menuCategories;
        }

        // Event Clicks
        private void btnConfirmItem_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem == null)
            {
                return;
            }

            int selectedID = Convert.ToInt32(cboItem.SelectedValue);
            currentItem = controller.GetByID(selectedID);

            if (currentItem !=  null)
            {
                txtTitle_MMI.Text = currentItem.Title;
                txtPrice.Text = currentItem.RetailPrice.ToString("0.00");
                txtImageUrl.Text = currentItem.ImageUrl;
                txtCalories_MMI.Text = currentItem.Calories.ToString();
                txtFat_MMI.Text = currentItem.Fat.ToString();
                txtCarbs_MMI.Text = currentItem.Carbs.ToString();
                txtSugar_MMI.Text = currentItem.Sugar.ToString();
                txtIngredients_MMI.Text = currentItem.Ingredients;
                txtQuantitySold.Text = currentItem.TotalQuantitySold.ToString();

                // Select Category
                cboCategory.SelectedItem = currentItem.Category;

                // Enabling Controls
                gboEditItemDetails.Enabled = true;
                btnUpdate_MMI.Enabled = true;
                btnDelete_MMI.Enabled = true;
            }
        }

        private void btnUpdate_MMI_Click(object sender, EventArgs e)
        {
            if (currentItem == null) { return; }

            if (string.IsNullOrWhiteSpace(txtTitle_MMI.Text))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            try
            {
                currentItem.Title = txtTitle_MMI.Text;
                currentItem.Category = cboCategory.SelectedItem.ToString();
                currentItem.RetailPrice = (decimal)Convert.ToDouble(txtPrice.Text);
                currentItem.ImageUrl = txtImageUrl.Text;
                currentItem.Calories = Convert.ToInt32(txtCalories_MMI.Text);
                currentItem.Fat = (int)Convert.ToDouble(txtFat_MMI.Text);
                currentItem.Carbs = (int)Convert.ToDouble(txtCarbs_MMI.Text);
                currentItem.Sugar = (int)Convert.ToDouble(txtSugar_MMI.Text);
                currentItem.Ingredients = txtIngredients_MMI.Text;


                bool success = controller.update(currentItem);

                if (success)
                {
                    MessageBox.Show("Item updated successfully!");

                    DialogResult result = MessageBox.Show(
                        "Update another item?", "Continue?",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnCancel_MMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtTitle_MMI.Clear();
            txtPrice.Text = "0.00";
            txtImageUrl.Clear();
            txtCalories_MMI.Text = "0";
            txtFat_MMI.Text = "0.0";
            txtCarbs_MMI.Text = "0.0";
            txtSugar_MMI.Text = "0.0";
            txtIngredients_MMI.Clear();
            txtQuantitySold.Clear();

            gboEditItemDetails.Enabled = false;
            btnUpdate_MMI.Enabled = false;
            btnDelete_MMI.Enabled = false;
            currentItem = null;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            } if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
