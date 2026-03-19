using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Classes;

namespace CoffeeShop.Controllers
{
    class OrderController
    {
        public bool SaveOrder(Order order)
        {
            try
            {
                using (OleDbConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    int orderID = 0;

                    using (OleDbTransaction transCommit = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertOrderQuery = @"INSERT INTO Orders (OrderDateTime, CustomerName, CustomerEmail, TotalCost) VALUES (@OrderDateTime, @CustomerName, @CustomerEmail, @TotalCost)";

                            using (OleDbCommand cmd = new OleDbCommand(insertOrderQuery, conn, transCommit))
                            {
                                // Order Date Time Handle
                                if (order.OrderDateTime == null || order.OrderDateTime == DateTime.MinValue)
                                {
                                    cmd.Parameters.Add("@OrderDateTime", OleDbType.Date).Value = DateTime.Now;
                                }
                                else
                                {
                                    cmd.Parameters.Add("@OrderDateTime", OleDbType.Date).Value = order.OrderDateTime;
                                }

                                // Customer Info Handle
                                if (string.IsNullOrWhiteSpace(order.CustomerName))
                                {
                                    cmd.Parameters.Add("@CustomerName", OleDbType.VarWChar).Value = "GUEST";
                                }
                                else
                                {
                                    cmd.Parameters.Add("@CustomerName", OleDbType.VarWChar).Value = order.CustomerName;
                                }

                                cmd.Parameters.Add("@CustomerEmail", OleDbType.VarWChar).Value = order.CustomerEmail ?? "";
                                cmd.Parameters.Add("@TotalCost", OleDbType.Double).Value = Convert.ToDouble(order.TotalCost);

                                cmd.ExecuteNonQuery();

                                // Retreive New Order ID
                                cmd.CommandText = "SELECT @@IDENTITY";
                                orderID = Convert.ToInt32(cmd.ExecuteScalar());

                            }

                            transCommit.Commit();
                        }
                        catch
                        {
                            transCommit.Rollback();
                            throw;
                        }
                    }

                    // Step 1 for inserting the order after committing
                    using (OleDbTransaction postTrans = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (OrderItem item in order.OrderItems)
                            {
                                // Insert OrderItem
                                string itemQuery = @"INSERT INTO OrderItems (OrderID, MenuItemID, Quantity, ItemPrice) VALUES (@OrderID, @MenuItemID, @Quantity, @ItemPrice)";

                                using (OleDbCommand cmd = new OleDbCommand(itemQuery, conn, postTrans))
                                {
                                    cmd.Parameters.Add("@OrderID", OleDbType.Integer).Value = orderID;
                                    cmd.Parameters.Add("@MenuItemID", OleDbType.Integer).Value = item.MenuItemID;
                                    cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = item.Quantity;
                                    cmd.Parameters.Add("@ItemPrice", OleDbType.Double).Value = Convert.ToDouble(item.ItemPrice);

                                    cmd.ExecuteNonQuery();
                                }

                                // Update quantity sold
                                string updateQuery = @"UPDATE MenuItems SET TotalQuantitySold = TotalQuantitySold + @Quantity WHERE MenuItemID = @MenuItemID";

                                using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn, postTrans))
                                {
                                    cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = item.Quantity;
                                    cmd.Parameters.Add("@MenuItemID", OleDbType.Integer).Value = item.MenuItemID;

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Commit all OrderItems together
                            postTrans.Commit();
                        }
                        catch
                        {
                            postTrans.Rollback();
                            throw;
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SaveOrder_ERROR: {ex.Message}");
            }
        }


        public List<Order> GetAllOrders() {
            List<Order> orders = new List<Order>();

            try
            {
                string query = "SELECT * FROM Orders ORDER BY OrderDateTime DESC";

                using (OleDbConnection conn = DBHelper.GetConnection())
                {
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    conn.Open();
                    
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.OrderID = reader["OrderID"] != DBNull.Value ?
                            Convert.ToInt32(reader["OrderID"]) : 0;

                        order.OrderDateTime = reader["OrderDateTime"] != DBNull.Value ?
                            Convert.ToDateTime(reader["OrderDateTime"]) : DateTime.Now;

                        order.CustomerName = reader["CustomerName"]?.ToString() ?? "";
                        order.CustomerEmail = reader["CustomerEmail"]?.ToString() ?? "";

                        order.TotalCost = (reader["TotalCost"] != DBNull.Value ?
                            Convert.ToDouble(reader["TotalCost"]) : 0);

                        orders.Add(order);
                    }
                    reader.Close();
                }
            } catch (Exception ex) {
                throw new Exception($"GetAllOrders_ERROR: {ex.Message}");
            } 
            return orders;
        }
            
        public List<Order> GetOrdersSorted(String sortBy) { 
            List<Order> ordersSorted = new List<Order>();

            try
            {
                string query;
                if (sortBy == "Price")
                {
                    query = "SELECT * FROM Orders ORDER by TotalCost DESC";
                }
                else
                {
                    query = "SELECT * FROM Orders ORDER by OrderDateTime DESC";
                }

                using (OleDbConnection conn = DBHelper.GetConnection())
                {
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        OleDbDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Order order = new Order();
                            order.OrderID = reader["OrderID"] != DBNull.Value ?
                                Convert.ToInt32(reader["OrderID"]) : 0;

                            order.OrderDateTime = reader["OrderDateTime"] != DBNull.Value ?
                                Convert.ToDateTime(reader["OrderDateTime"]) : DateTime.Now;

                            order.CustomerName = reader["CustomerName"]?.ToString() ?? "";
                            order.CustomerEmail = reader["CustomerEmail"]?.ToString() ?? "";

                            order.TotalCost = (reader["TotalCost"] != DBNull.Value ?
                                Convert.ToDouble(reader["TotalCost"]) : 0);

                            ordersSorted.Add(order);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting sorted: {ex.Message}");
            }

            return ordersSorted;
        }

        public List<OrderItem> GetOrderItems(int orderID)
        {
            List<OrderItem> items = new List<OrderItem>();

            try
            {
                string query = @"SELECT oi.*, m.Title 
                                 FROM OrderItems oi
                                 INNER JOIN MenuItems m ON oi.MenuItemID = m.MenuItemID
                                 WHERE oi.OrderID = @orderID";

                using (OleDbConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderID);

                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        OrderItem item = new OrderItem();

                        // read values from OrderItems table
                        item.Title = reader["Title"]?.ToString() ?? "Unknown";

                        item.OrderItemID = reader["OrderItemID"] != DBNull.Value ?
                            Convert.ToInt32(reader["OrderItemID"]) : 0;

                        item.OrderID = reader["OrderID"] != DBNull.Value ?
                            Convert.ToInt32(reader["OrderID"]) : 0;

                        item.MenuItemID = reader["MenuItemID"] != DBNull.Value ?
                            Convert.ToInt32(reader["MenuItemID"]) : 0;

                        item.Quantity = reader["Quantity"] != DBNull.Value ?
                            Convert.ToInt32(reader["Quantity"]) : 0;

                        item.ItemPrice = reader["ItemPrice"] != DBNull.Value ?
                            Convert.ToDecimal(reader["ItemPrice"]) : 0;

                        item.Subtotal = item.Quantity * item.ItemPrice;

                        items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting order items: {ex.Message}");
            }

            return items;
        } 
    }
}
