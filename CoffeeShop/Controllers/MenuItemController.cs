using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Classes;
using System.Data.OleDb;

namespace CoffeeShop.Controllers
{
    public class MenuItemController
    {
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> list = new List<MenuItem>();
            string query = "SELECT * FROM MenuItems";

            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.MenuItemID = Convert.ToInt32(reader["MenuItemID"]);
                    menuItem.Title = reader["Title"].ToString();
                    menuItem.Description = reader["Description"].ToString();
                    menuItem.Category = reader["Category"].ToString();
                    menuItem.RetailPrice = Convert.ToDecimal(reader["RetailPrice"]);
                    menuItem.ImageUrl = reader["ImageUrl"].ToString();
                    menuItem.Calories = Convert.ToInt32(reader["Calories"]);
                    menuItem.Fat = Convert.ToInt32(reader["Fat"]);
                    menuItem.Carbs = Convert.ToInt32(reader["Carbs"]);
                    menuItem.Sugar = Convert.ToInt32(reader["Sugar"]);
                    menuItem.Ingredients = reader["Ingredients"].ToString();
                    menuItem.TotalQuantitySold = Convert.ToInt32(reader["TotalQuantitySold"]);

                    list.Add(menuItem);
                }
                reader.Close();
            }
            return list;
        }

        // Additional methods for adding, updating, and deleting menu items can be implemented here
        // Category-based retrieval, price range filtering, etc. can also be added as needed
        public List<MenuItem> GetByCategory(string category)
        {
            List<MenuItem> list = new List<MenuItem>();
            string query = "SELECT * FROM MenuItems WHERE Category = @Category";

            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@Category", category);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.MenuItemID = Convert.ToInt32(reader["MenuItemID"]);
                    menuItem.Title = reader["Title"].ToString();
                    menuItem.Category = reader["Category"].ToString();
                    menuItem.RetailPrice = Convert.ToDecimal(reader["RetailPrice"]);

                    list.Add(menuItem);
                }
                reader.Close();
            }
            return list;
        }

        // Retrieving a specific item by ID
        public MenuItem GetByID(int id)
        {
            string query = "SELECT * FROM MenuItems WHERE MenuItemID = @ID";
            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.MenuItemID = Convert.ToInt32(reader["MenuItemID"]);
                    menuItem.Title = reader["Title"].ToString();
                    menuItem.Description = reader["Description"].ToString();
                    menuItem.Category = reader["Category"].ToString();
                    menuItem.RetailPrice = Convert.ToDecimal(reader["RetailPrice"]);
                    menuItem.ImageUrl = reader["ImageUrl"].ToString();
                    menuItem.Calories = Convert.ToInt32(reader["Calories"]);
                    menuItem.Fat = Convert.ToInt32(reader["Fat"]);
                    menuItem.Carbs = Convert.ToInt32(reader["Carbs"]);
                    menuItem.Sugar = Convert.ToInt32(reader["Sugar"]);
                    menuItem.Ingredients = reader["Ingredients"].ToString();
                    menuItem.TotalQuantitySold = Convert.ToInt32(reader["TotalQuantitySold"]);

                    reader.Close();
                    return menuItem;

                }
                reader.Close();
                return null;
            }
        }

        // Adding a new menu item
        public bool add(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems " +
                           "(Title, Description, Category, RetailPrice, ImageUrl, Calories, Fat, Carbs, Sugar, Ingredients, TotalQuantitySold) " +
                           "VALUES (@title, @desc, @cat, @price, @image, @cal, @fat, @carbs, @sugar, @ing, @qty)";

            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);

                cmd.Parameters.AddWithValue("@title", menuItem.Title);
                cmd.Parameters.AddWithValue("@desc", menuItem.Description);
                cmd.Parameters.AddWithValue("@cat", menuItem.Category);
                cmd.Parameters.AddWithValue("@price", menuItem.RetailPrice);
                cmd.Parameters.AddWithValue("@image", menuItem.ImageUrl);
                cmd.Parameters.AddWithValue("@cal", menuItem.Calories);
                cmd.Parameters.AddWithValue("@fat", menuItem.Fat);
                cmd.Parameters.AddWithValue("@carbs", menuItem.Carbs);
                cmd.Parameters.AddWithValue("@sugar", menuItem.Sugar);
                cmd.Parameters.AddWithValue("@ing", menuItem.Ingredients);
                cmd.Parameters.AddWithValue("@qty", menuItem.TotalQuantitySold);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Updating an existing menu item
        public bool update(MenuItem menuItem)
        {
            string query = "UPDATE MenuItems SET Title = @title, Description = @desc, Category = @cat, RetailPrice = @price, " +
                           "ImageUrl = @image, Calories = @cal, Fat = @fat, Carbs = @carbs, Sugar = @sugar, Ingredients = @ing, " +
                           "TotalQuantitySold = @qty WHERE MenuItemID = @id";
            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", menuItem.Title);
                cmd.Parameters.AddWithValue("@desc", menuItem.Description);
                cmd.Parameters.AddWithValue("@cat", menuItem.Category);
                cmd.Parameters.AddWithValue("@price", menuItem.RetailPrice);
                cmd.Parameters.AddWithValue("@image", menuItem.ImageUrl);
                cmd.Parameters.AddWithValue("@cal", menuItem.Calories);
                cmd.Parameters.AddWithValue("@fat", menuItem.Fat);
                cmd.Parameters.AddWithValue("@carbs", menuItem.Carbs);
                cmd.Parameters.AddWithValue("@sugar", menuItem.Sugar);
                cmd.Parameters.AddWithValue("@ing", menuItem.Ingredients);
                cmd.Parameters.AddWithValue("@qty", menuItem.TotalQuantitySold);
                cmd.Parameters.AddWithValue("@id", menuItem.MenuItemID);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        // Deleting a menu item by ID
        public bool delete(int id)
        {
            string query = "DELETE FROM MenuItems WHERE MenuItemID = @id";
            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        
        // Categories from drop down
        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            string query = "SELECT DISTINCT Category FROM MenuItems";
            using (OleDbConnection connection = DBHelper.GetConnection())
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(reader["Category"].ToString());
                }
                reader.Close();
            }
            return categories;
        }
    }
}
