using CoffeeShop.Controllers;
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
using MenuItem = CoffeeShop.Classes.MenuItem;

namespace CoffeeShop
{
    public partial class frmAddMenuItem : Form
    {
        // ====== Variables on CLASS level
        private MenuItemController controller = new MenuItemController();

        // Constructor
        public frmAddMenuItem()
        {
            InitializeComponent();
            LoadCategories();
            SetDefaultValues();
        }

        // ====== Helper Methods

        // Load Categories Method
        public void LoadCategories()
        {
            try
            {
                var categories = controller.GetCategories();

                if (categories == null || categories.Count == 0)
                {
                    categories = new System.Collections.Generic.List<string>
                    {
                        "Coffee", "Tea", "Pastry", "Sandwich", "Smoothie", "Other"
                    };
                }

                // Connecting the list to cboCategory
                cboCategory_AMI.DataSource = categories;

                if (categories.Count > 0)
                {
                    cboCategory_AMI.SelectedIndex = 0;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");

                // In case DB fails, we add in default categories manually
                cboCategory_AMI.Items.AddRange(new string[]
                {
                    "Coffee", "Tea", "Pastry", "Sandwich", "Smoothie", "Other"
                });
                cboCategory_AMI.SelectedIndex = 0;
            }
        }

        // Set default values for all fields
        private void SetDefaultValues()
        {
            txtPrice_AMI.Text = "0.00";
            txtCalories_AMI.Text = "0";
            txtFat_AMI.Text = "0.0";
            txtCarbs_AMI.Text = "0.0";
            txtSugar_AMI.Text = "0.0";
            txtImageURL_AMI.Text = null;
        }

        // Required fields are correctly inputted
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle_AMI.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error");
                txtTitle_AMI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription_AMI.Text))
            {
                MessageBox.Show("Description is required.", "Validation Error");
                txtDescription_AMI.Focus();
                return false;
            }

            if (cboCategory_AMI.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error");
                cboCategory_AMI.Focus();
                return false;
            }

            if (!double.TryParse(txtPrice_AMI.Text, out double price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error");
                txtPrice_AMI.Focus();
                return false;
            }

            if (!int.TryParse(txtCalories_AMI.Text, out int calories) || calories < 0) 
            {
                MessageBox.Show("Calories must be a positive whole number.", "Validation Error");
                txtCalories_AMI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIngredients_AMI.Text))
            {
                MessageBox.Show("Ingredients are required.", "Validation Error");
                txtIngredients_AMI.Focus();
                return false;
            }

            return true;
        }

        private MenuItem CreateMenuItemFromForm()
        {
            MenuItem newMenuItem = new MenuItem();

            newMenuItem.Title = txtTitle_AMI.Text.Trim();
            newMenuItem.Description = txtDescription_AMI.Text.Trim();
            newMenuItem.Category = cboCategory_AMI.SelectedItem.ToString();
            newMenuItem.RetailPrice = Convert.ToDecimal(txtPrice_AMI.Text);
            newMenuItem.ImageUrl = txtImageURL_AMI.Text.Trim();
            newMenuItem.Calories = Convert.ToInt32(txtCalories_AMI.Text);
            newMenuItem.Fat = (int)Convert.ToDouble(txtFat_AMI.Text);
            newMenuItem.Carbs = (int)Convert.ToDouble(txtCarbs_AMI.Text);
            newMenuItem.Sugar = (int)Convert.ToDouble(txtSugar_AMI.Text);
            newMenuItem.Ingredients = txtIngredients_AMI.Text.Trim();
            newMenuItem.TotalQuantitySold = 0;

            return newMenuItem;
        }

        // Clearing form
        private void ClearForm()
        {
            txtTitle_AMI.Clear();
            txtDescription_AMI.Clear() ;
            txtPrice_AMI.Text = "0.00";
            txtImageURL_AMI.Text = null;
            txtCalories_AMI.Text = "0";
            txtFat_AMI.Text = "0.0";
            txtCarbs_AMI.Text = "0.0";
            txtSugar_AMI.Text = "0.0";
            txtIngredients_AMI.Clear();

            if (cboCategory_AMI.Items.Count > 0)
            {
                cboCategory_AMI.SelectedIndex = 0;
            }

            txtTitle_AMI.Focus();
        }


        // ======== Event Handlers
        private void btnSave_AMI_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                MenuItem newItem = CreateMenuItemFromForm();

                // save to DB
                bool success = controller.add(newItem);

                if (success)
                {
                    MessageBox.Show("Menu Item has been successfully added!", "Success");

                    // Prompt if user wants to add more
                    DialogResult addMore = MessageBox.Show(
                        "Add another item?", "Continue?", MessageBoxButtons.YesNo);

                    if (addMore == DialogResult.Yes)
                    {
                        ClearForm();
                    } else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add item. Try again.", "Error");
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
        private void btnCancel_AMI_Click(object sender, EventArgs e)
        {
            // Did the user enter any data??
            if (!string.IsNullOrWhiteSpace(txtTitle_AMI.Text) ||
                !string.IsNullOrWhiteSpace(txtDescription_AMI.Text))
            {
                DialogResult resultCancel = MessageBox.Show(
                    "Discard changes and cancel?", "Confirm cancel",
                    MessageBoxButtons.YesNo);

                if (resultCancel == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        // ========== Input Validation
        private void txtPrice_AMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (i.e., backspace, delete, etc..)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled= true;
            }
        }

        private void txtCalories_AMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFat_AMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCarbs_AMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtSugar_AMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }


    }
}
