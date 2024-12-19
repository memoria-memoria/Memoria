using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductSellingForm : Form
    {
        OleDbConnection conn;
        DataTable cartTable;

        public ProductSellingForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
            InitializeCart();

            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;


            tbCash.TextChanged += tbCash_TextChanged_1;
        }

        public static class Session
        {
            public static string LoggedInUser { get; set; } = "Employee";
        }



        private void LoadCategories()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
                string query = "SELECT ProductID, ProductName, Category, Price, Quantity FROM Products WHERE Quantity > 0";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Check and handle null values for each row
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Price"] == DBNull.Value)
                    {
                        row["Price"] = 0; // Handle null price by setting it to 0
                    }
                    if (row["Quantity"] == DBNull.Value)
                    {
                        row["Quantity"] = 0; // Handle null quantity by setting it to 0
                    }
                }

                dgvProducts.DataSource = dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}\nError Code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = cbCategory.SelectedValue?.ToString() ?? string.Empty;
            string productName = tbProductID.Text.Trim();

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT ProductID, ProductName, Category, Price, Quantity FROM Products WHERE Quantity > 0";

            if (!string.IsNullOrEmpty(category))
            {
                query += " AND Category = ?";
            }
            if (!string.IsNullOrEmpty(productName))
            {
                query += " AND ProductName = ?";
            }

            OleDbCommand cmd = new OleDbCommand(query, conn);
            if (!string.IsNullOrEmpty(category))
            {
                cmd.Parameters.AddWithValue("?", category);
            }
            if (!string.IsNullOrEmpty(productName))
            {
                cmd.Parameters.AddWithValue("?", productName);
            }

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                lblProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                lblPrice.Text = Convert.ToDecimal(selectedRow.Cells["Price"].Value).ToString("C");
                UpdateTotalPrice();
            }
        }

        private void UpdateTotalPrice()
        {
            decimal totalAmount = 0;

            // Calculate the total amount from the items in the cart
            foreach (DataRow row in cartTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }

            // Update the label with the total price
            lblTotalPrice.Text = totalAmount.ToString("C");
        }


        private void btnPayOrders_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart to pay.");
                return;
            }

            decimal totalAmount = 0;

            // Calculate total amount from the cart
            foreach (DataRow row in cartTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }

            // Ask for confirmation
            var result = MessageBox.Show($"Total Purchase: {totalAmount:C}\nWould you like to save this to the database?", "Confirm Purchase", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                    {
                        conn.Open();

                        foreach (DataRow row in cartTable.Rows)
                        {
                            string productName = row["ProductName"].ToString();
                            int quantitySold = Convert.ToInt32(row["Quantity"]);
                            decimal totalPrice = Convert.ToDecimal(row["Total"]);

                            // Use the logged-in user's full name as the seller
                            string soldBy = Session.LoggedInUser ?? "Unknown";

                            // Insert into Sales table
                            string query = "INSERT INTO Sales (ProductName, QuantitySold, SaleDate, TotalPrice, SoldBy) VALUES (?, ?, ?, ?, ?)";

                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.Add("ProductName", OleDbType.VarChar).Value = productName;
                                cmd.Parameters.Add("QuantitySold", OleDbType.Integer).Value = quantitySold;
                                cmd.Parameters.Add("SaleDate", OleDbType.Date).Value = DateTime.Now;
                                cmd.Parameters.Add("TotalPrice", OleDbType.Currency).Value = totalPrice;
                                cmd.Parameters.Add("SoldBy", OleDbType.VarChar).Value = soldBy; // Use the logged-in user's name
                                cmd.ExecuteNonQuery();
                            }

                            // Update the Products table to reduce the quantity
                            string updateQuery = "UPDATE Products SET Quantity = Quantity - ? WHERE ProductName = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("?", quantitySold);
                                updateCmd.Parameters.AddWithValue("?", productName);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Purchase saved successfully!", "Success");
                    cartTable.Clear(); // Clear the cart after successful purchase
                    LoadProducts(); // Reload products to reflect updated quantities
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General error: {ex.Message}");
                }
            }
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells["Price"].Value);
            int availableQuantity = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["Quantity"].Value);
            int quantity = (int)numericUpDownQuantity.Value;

            if (quantity <= 0 || quantity > availableQuantity)
            {
                MessageBox.Show($"Enter a valid quantity (1-{availableQuantity}).");
                return;
            }

            // Add the item to the cart
            DataRow row = cartTable.NewRow();
            row["ProductID"] = productId;
            row["ProductName"] = productName;
            row["Quantity"] = quantity;
            row["Price"] = price;
            row["Total"] = price * quantity; // Calculate total for this row
            cartTable.Rows.Add(row);

            // Update the displayed quantity in the DataGridView
            dgvProducts.SelectedRows[0].Cells["Quantity"].Value = availableQuantity - quantity;

            // Update the total price in lblTotalPrice
            UpdateTotalPrice();

            // Reset quantity in NumericUpDown
            numericUpDownQuantity.Value = 1;
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart to generate a receipt.");
                return;
            }

            string receipt = "Receipt\n";
            receipt += "-----------------------------\n";
            receipt += "Product Name\tQty\tPrice\tTotal\n";

            decimal totalAmount = 0;

            foreach (DataRow row in cartTable.Rows)
            {
                decimal total = Convert.ToDecimal(row["Total"]);
                totalAmount += total;
                receipt += $"{row["ProductName"]}\t{row["Quantity"]}\t{row["Price"]:C}\t{total:C}\n";
            }

            receipt += "-----------------------------\n";
            receipt += $"Total Amount: {totalAmount:C}\n";
            receipt += $"Date: {DateTime.Now}\n";


            string filePath = "Receipt.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(receipt);
            }

            MessageBox.Show($"Receipt generated successfully and saved to {filePath}!", "Receipt");
        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ProductID", typeof(int));
            cartTable.Columns.Add("ProductName", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Total", typeof(decimal), "Quantity * Price");
            dgvCart.DataSource = cartTable;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item from the cart?",
                                                     "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Get the index of the selected row
                    int rowIndex = dgvCart.SelectedRows[0].Index;

                    // Retrieve necessary data *before* removing the row
                    int productId = Convert.ToInt32(cartTable.Rows[rowIndex]["ProductID"]);
                    int quantityDeleted = Convert.ToInt32(cartTable.Rows[rowIndex]["Quantity"]);

                    // Remove the selected row from the cart
                    cartTable.Rows.RemoveAt(rowIndex);

                    // Update the total price label to reflect the remaining items in the cart
                    UpdateTotalPrice();

                    // Update the product quantity in the product list
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["ProductID"].Value) == productId)
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            row.Cells["Quantity"].Value = currentQuantity + quantityDeleted;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void tbCash_TextChanged_1(object sender, EventArgs e)
        {
            decimal cash = 0;
            decimal total = 0;

            bool isCashValid = decimal.TryParse(tbCash.Text, out cash);
            bool isTotalValid = decimal.TryParse(lblTotalPrice.Text.Replace("₱", "").Replace(",", "").Trim(), out total);

            if (isCashValid && isTotalValid)
            {
                decimal change = cash - total;
                lblChange.Text = change.ToString("C");
            }
            else
            {
                lblChange.Text = "$0.00";
            }
        }
    }   
}