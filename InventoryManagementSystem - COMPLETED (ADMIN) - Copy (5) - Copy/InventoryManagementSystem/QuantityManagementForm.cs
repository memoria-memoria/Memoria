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

namespace InventoryManagementSystem
{
    public partial class QuantityManagementForm : Form
    {
        private OleDbConnection conn;

        public QuantityManagementForm()
        {
            InitializeComponent();
            LoadProducts(); // Load products into the DataGridView
            SetupQuantityReportGrid();
            SetupStockReportsGrid(); // Setup the new DataGridView for stock reports
        }

        private void SetupQuantityReportGrid()
        {
            dgvQuantityReport.Columns.Add("ProductName", "Product Name");
            dgvQuantityReport.Columns.Add("QuantityAdded", "Quantity Added");
            dgvQuantityReport.Columns.Add("ReportDate", "Report Date");
            dgvQuantityReport.ReadOnly = true;
        }

        private void SetupStockReportsGrid()
        {
            dgvStockReports.Columns.Clear();
            dgvStockReports.Columns.Add("ProductName", "Product Name");
            dgvStockReports.Columns.Add("ReportStatus", "Status");
            dgvStockReports.Columns.Add("ReportDate", "Report Date");
        }


        public void SetInventoryFormReference(InventoryForm inventoryForm)
        {
            
        }

        public void AddStockReport(string productName, string status, DateTime reportDate)
        {
            var report = new ProductReport(productName, status, reportDate);

            // Add the report to ReportManager and database
            ReportManager.AddReport(report);
            SaveReportToDatabase("Sample Product", "Low Stock", DateTime.Now);

            // Reload the reports into the DataGridView to reflect the new data
            LoadReports();
        }


        private void SaveReportToDatabase(string productName, string status, DateTime reportDate)
        {
            try
            {
                using (var conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();
                    string query = "INSERT INTO StockReports (ProductName, ReportStatus, ReportDate) VALUES (?, ?, ?)";

                    using (var cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", productName);
                        cmd.Parameters.AddWithValue("?", status);
                        cmd.Parameters.AddWithValue("?", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Report saved successfully to the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public static class ReportManager
        {
            private static List<ProductReport> reports = new List<ProductReport>();

            public static void AddReport(ProductReport report)
            {
                reports.Add(report);
            }

            public static List<ProductReport> GetReports()
            {
                return new List<ProductReport>(reports);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, Quantity, Category FROM Products";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;

                    // Optionally show a notification that products are loaded
                    ShowNotification("Products loaded. Check stock levels manually.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void LoadReports()
        {
            try
            {
                // Clear existing rows before reloading
                dgvStockReports.Rows.Clear();

                // Open the connection to the database
                using (var conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();

                    // Query to fetch reports
                    string query = "SELECT ProductName, ReportStatus, ReportDate FROM StockReports";

                    using (var cmd = new OleDbCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Read the data and add rows to dgvStockReports
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            string reportStatus = reader["ReportStatus"].ToString();
                            DateTime reportDate = Convert.ToDateTime(reader["ReportDate"]);

                            // Add the row to the DataGridView
                            dgvStockReports.Rows.Add(productName, reportStatus, reportDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                string productName = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                lblNotification.Text = $"Selected Product: {productName}";
                lblNotification.ForeColor = Color.Black;
            }
            else
            {
                lblNotification.Text = "No product selected.";
                lblNotification.ForeColor = Color.Black;
            }
        }

        private void LogRestockReport(string productName, int quantityAdded)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = productName });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = quantityAdded });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            dgvQuantityReport.Rows.Add(row);
            dgvQuantityReport.FirstDisplayedScrollingRowIndex = dgvQuantityReport.RowCount - 1;
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to restock.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
            int quantityToAdd = (int)numericUpDownQuantity.Value;

            if (quantityToAdd <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.");
                return;
            }

            try
            {
                using (conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();
                    string query = "UPDATE Products SET Quantity = Quantity + ? WHERE ProductID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", quantityToAdd);
                        cmd.Parameters.AddWithValue("?", productId);
                        cmd.ExecuteNonQuery();
                    }

                    // Log the restock in dgvQuantityReport
                    LogRestockReport(productName, quantityToAdd);
                    LoadProducts(); // Refresh the product list

                    // Notify user
                    ShowNotification($"Restocked {quantityToAdd} units of {productName} successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restocking product: {ex.Message}");
            }
        }

        private void ShowNotification(string message)
        {
            lblNotification.Text = message;
            lblNotification.ForeColor = Color.Green; // Change text color for success

            // Optionally auto-hide the notification after 5 seconds
            Timer timer = new Timer
            {
                Interval = 5000 // 5 seconds
            };
            timer.Tick += (sender, e) =>
            {
                lblNotification.Text = "Select a product and restock.";
                lblNotification.ForeColor = Color.Black;
                timer.Stop();
            };
            timer.Start();
        }

        private void QuantityManagementForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Validate that at least one row is selected
            if (dgvStockReports.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one report to approve.");
                return;
            }

            // Confirmation before proceeding
            var confirmationResult = MessageBox.Show(
                "Are you sure you want to approve and delete the selected reports?",
                "Approve and Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmationResult != DialogResult.Yes) return;

            // Iterate through each selected row
            foreach (DataGridViewRow selectedRow in dgvStockReports.SelectedRows)
            {
                try
                {
                    string productName = selectedRow.Cells["ProductName"].Value as string;
                    string reportStatus = selectedRow.Cells["ReportStatus"].Value as string;
                    object reportDateValue = selectedRow.Cells["ReportDate"].Value;

                    if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(reportStatus) || reportDateValue == null)
                    {
                        MessageBox.Show("Invalid report data. Cannot delete.");
                        continue;
                    }

                    DateTime reportDate = Convert.ToDateTime(reportDateValue);

                    // Debugging step: Confirm values
                    MessageBox.Show($"Deleting Report:\nProductName: {productName}\nStatus: {reportStatus}\nDate: {reportDate}");

                    // Perform the DELETE operation
                    using (var conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                    {
                        conn.Open();
                        string query = "DELETE FROM StockReports WHERE ProductName = ? AND ReportStatus = ? AND ReportDate = ?";
                        using (var cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", productName);
                            cmd.Parameters.AddWithValue("?", reportStatus);
                            cmd.Parameters.AddWithValue("?", reportDate);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Report deleted successfully from database.");
                            }
                            else
                            {
                                MessageBox.Show("No matching report found in the database.");
                            }
                        }
                    }

                    // Remove the row from the DataGridView
                    dgvStockReports.Rows.Remove(selectedRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error approving and deleting the report: {ex.Message}");
                }
            }
        }




        private void QuantityManagementForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet1.StockReports' table. You can move, or remove it, as needed.
            //this.stockReportsTableAdapter.Fill(this.inventoryDatabaseDataSet1.StockReports);
            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();
                    string query = "SELECT ProductName, ReportStatus, ReportDate FROM StockReports";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing rows in the DataGridView
                            dgvStockReports.Rows.Clear();

                            // Loop through the result set and populate the DataGridView
                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString();
                                string status = reader["ReportStatus"].ToString();
                                DateTime reportDate = Convert.ToDateTime(reader["ReportDate"]);

                                // Add data to the DataGridView
                                dgvStockReports.Rows.Add(productName, status, reportDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading stock reports:\n{ex.Message}");
            }
        }

        public class ProductReport
        {
            public string ProductName { get; set; }
            public string ReportStatus { get; set; }
            public DateTime ReportDate { get; set; }

            public ProductReport(string productName, string reportStatus, DateTime reportDate)
            {
                ProductName = productName;
                ReportStatus = reportStatus;
                ReportDate = reportDate;
            }
        }
    }
}