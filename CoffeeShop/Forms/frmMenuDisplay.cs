using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Controllers;
using CoffeeShop.Classes;
using System.Linq.Expressions;
using MenuItem = CoffeeShop.Classes.MenuItem;

namespace CoffeeShop
{
    public partial class frmMenuDisplay : Form
    {
        private MenuItemController controller = new MenuItemController();

        private MenuItem currentItem = null;

        public frmMenuDisplay()
        {
            InitializeComponent();
        }

        private void frmMenuDisplay_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMenuItems();
            ClearDetails();
        }

        // Methods for Load event
        private void LoadCategories()
        {
            try
            {
                List<string> categories = controller.GetCategories();
                categories.Insert(0, "All Categories");
                cboCategory.DataSource = categories;
                cboCategory.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error loading categories: {e.Message}" );
            }
        }

        private void LoadMenuItems()
        {
            try
            {
                List<MenuItem> items = controller.GetMenuItems();
                dvgMenuItems.DataSource = null;
                dvgMenuItems.DataSource = items;

                currentItem = null;
                ClearDetails();

                // Formatting the dvg
                dvgMenuItems.Columns["MenuItemID"].Visible = false;
                dvgMenuItems.Columns["Description"].Visible = false;
                dvgMenuItems.Columns["ImageUrl"].Visible = false;
                dvgMenuItems.Columns["Calories"].Visible = false;
                dvgMenuItems.Columns["Fat"].Visible = false;
                dvgMenuItems.Columns["Carbs"].Visible = false;
                dvgMenuItems.Columns["Sugar"].Visible = false;
                dvgMenuItems.Columns["Ingredients"].Visible = false;
                dvgMenuItems.Columns["TotalQuantitySold"].Visible = false;

                // Formatting the price
                dvgMenuItems.Columns["RetailPrice"].DefaultCellStyle.Format = "C2";

                // Headers
                dvgMenuItems.Columns["Title"].HeaderText = "Menu Item";
                dvgMenuItems.Columns["Category"].HeaderText = "Category";
                dvgMenuItems.Columns["RetailPrice"].HeaderText = "Price";
            }

            catch (Exception e )
            {
                MessageBox.Show($"Error loading menuItems: {e.Message}");
            }

        } // end of LoadMenu

        private void ClearDetails()
        {
            lblTitle.Text = "Select an item.";
            lblDescription.Text = "";
            lblPrice.Text = "Price:";
            lblCategory_DI.Text = "Category:";
            lblCalories_DI.Text = "Calories:";
            lblCarbs_DI.Text = "Carbs:";
            lblFats_DI.Text = "Fats:";
            lblSugar_DI.Text = "Sugar:";
            lblIngredients_DI.Text = "Ingredients:";
            lblTotalSold_DI.Text = "Total Sold:";
            pboItem.Image = null;
            pboItem.BackColor = Color.White;
            currentItem = null;
        }

        private void DisplayItemDetails(MenuItem item)
        {
            if (item == null) return;
            currentItem = item;

            // Labels
            lblTitle.Text = item.Title;
            lblDescription.Text = item.Description;
            lblPrice.Text = $"Price: {item.RetailPrice:C}";
            lblCategory_DI.Text = $"Category: {item.Category}";
            lblCalories_DI.Text = $"Cal: {item.Calories}";
            lblFats_DI.Text = $"Fat: {item.Fat}g";
            lblCarbs_DI.Text = $"Carbs: {item.Carbs}g";
            lblSugar_DI.Text = $"Sugar: {item.Sugar}g";
            lblIngredients_DI.Text = $"Ingredients: {item.Ingredients}";
            lblTotalSold_DI.Text = $"Total Sold: {item.TotalQuantitySold}";

            // Image Url
            if (!string.IsNullOrEmpty(item.ImageUrl))
            {
                try
                {
                    pboItem.Load(item.ImageUrl);
                } catch {
                    pboItem.Image = null;
                    pboItem.BackColor = Color.White;
                }
            }
            else
            {
                pboItem.Image = null;
                pboItem.BackColor = Color.White;
            }

        }

        private void LoadItemsByCategory(string category)
        {
            try
            {
                List<MenuItem> items;

                if (category == "All Categories")
                {
                    items = controller.GetMenuItems();
                }
                else
                {
                    items = controller.GetByCategory(category);
                }

                dvgMenuItems.DataSource = null;
                dvgMenuItems.DataSource = items;

                currentItem = null;
                ClearDetails();

                // Formatting similar to LoadMenuItem()
                dvgMenuItems.Columns["MenuItemID"].Visible = false;
                dvgMenuItems.Columns["Description"].Visible = false;
                dvgMenuItems.Columns["ImageUrl"].Visible = false;
                dvgMenuItems.Columns["Calories"].Visible = false;
                dvgMenuItems.Columns["Fat"].Visible = false;
                dvgMenuItems.Columns["Carbs"].Visible = false;
                dvgMenuItems.Columns["Sugar"].Visible = false;
                dvgMenuItems.Columns["Ingredients"].Visible = false;
                dvgMenuItems.Columns["TotalQuantitySold"].Visible = false;

                // Formatting the price
                dvgMenuItems.Columns["RetailPrice"].DefaultCellStyle.Format = "C2";

                // Headers
                dvgMenuItems.Columns["Title"].HeaderText = "Menu Item";
                dvgMenuItems.Columns["Category"].HeaderText = "Category";
                dvgMenuItems.Columns["RetailPrice"].HeaderText = "Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error obtaining items: {ex.Message}");
            }
        }

        // ========== EVENT HANDLERS ============== //

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filteredCategory = cboCategory.SelectedItem.ToString();
            LoadItemsByCategory( filteredCategory );
            ClearDetails();
        }

        private void dvgMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
        
            DataGridViewRow row = dvgMenuItems.Rows[e.RowIndex];

            int rowIndex = (int)row.Cells["MenuItemID"].Value;
            MenuItem item = controller.GetByID(rowIndex);

            if (item != null)
            {
                DisplayItemDetails(item);
            }
        }

        private void btnAddNew_MD_Click(object sender, EventArgs e)
        {
            frmAddMenuItem addForm = new frmAddMenuItem();
            addForm.ShowDialog();
            LoadMenuItems();
            LoadCategories();
        }

        private void btnModify_MD_Click(object sender, EventArgs e)
        {
            if (dvgMenuItems.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Please select an item to modify.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dvgMenuItems.SelectedRows[0];

                if (selectedRow.Cells["MenuItemID"].Value == null)
                {
                    MessageBox.Show("Cannot identify selected item.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int itemId = Convert.ToInt32(selectedRow.Cells["MenuItemID"].Value);

                MenuItem selectedItem = controller.GetByID(itemId);

                if (selectedItem == null)
                {
                    MessageBox.Show("Selected item could not be found in database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                frmModifyMenuItem modifyForm = new frmModifyMenuItem(currentItem);
                modifyForm.ShowDialog();
                LoadMenuItems();
                LoadCategories();
                DisplayItemDetails(currentItem);

                // This will find and reselect the item to show details
                foreach (DataGridViewRow row in dvgMenuItems.Rows)
                {
                    if (row.Cells["MenuItemID"].Value != null &&
                        Convert.ToInt32(row.Cells["MenuItemID"].Value) == itemId)
                    {
                        row.Selected = true;

                        // Refresh the details display
                        MenuItem refreshedItem = controller.GetByID(itemId);
                        if (refreshedItem != null)
                        {
                            DisplayItemDetails(refreshedItem);
                        }
                        break;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_MD_Click(object sender, EventArgs e)
        {
            if (currentItem == null)
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {currentItem.Title}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = controller.delete(currentItem.MenuItemID);
                    if (success)
                    {
                        MessageBox.Show("Item deleted successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadMenuItems();
                        LoadCategories();
                        ClearDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting item: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_MD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_MD_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
            LoadCategories();
            ClearDetails();
        }
    }
}
