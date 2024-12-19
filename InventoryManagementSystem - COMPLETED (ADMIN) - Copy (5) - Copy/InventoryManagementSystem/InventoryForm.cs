using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class InventoryForm : Form
    {
        private QuantityManagementForm quantityManagementForm;
        private OleDbConnection conn;
        private PrintDocument printDocument;

        public InventoryForm()
        {
            InitializeComponent();
            LoadStock();  // Load all products initially
            quantityManagementForm = new QuantityManagementForm();
            // Pass the reference to the QuantityManagementForm
            quantityManagementForm.SetInventoryFormReference(this);
        }

        public static class Session
        {
            public static string LoggedInUser { get; set; } = "Employee";
        }

        private void LoadStock(string productId = "", string productName = "")
        {
            try
            {
                using (conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, Category, Quantity, Price FROM Products WHERE Quantity > 0";

                    // Add filtering conditions
                    if (!string.IsNullOrEmpty(productId))
                    {
                        query += " AND ProductID = ?";
                    }
                    if (!string.IsNullOrEmpty(productName))
                    {
                        query += " AND ProductName LIKE ?";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(productId))
                        {
                            cmd.Parameters.AddWithValue("?", productId);
                        }
                        if (!string.IsNullOrEmpty(productName))
                        {
                            cmd.Parameters.AddWithValue("?", "%" + productName + "%");
                        }

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStock.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string productId = tbProductID.Text.Trim();
            string productName = tbProductName.Text.Trim();
            LoadStock(productId, productName);  // Reload the data with filters
        }

        // Print Button Click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to print the whole product inventory?",
                                          "Print Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed with printing if user confirms
                printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                // If user clicks "No", do nothing or cancel the printing
                MessageBox.Show("Printing canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Print the content of the DataGridView
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float lineHeight = font.GetHeight();
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Printing headers
            graphics.DrawString("Product Inventory", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight + 10;

            graphics.DrawString("Product ID\tProduct Name\tCategory\tQuantity\tPrice", font, Brushes.Black, x, y);
            y += lineHeight + 5;

            // Print each row from the DataGridView
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.IsNewRow) continue;
                string productId = row.Cells["ProductID"].Value.ToString();
                string productName = row.Cells["ProductName"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                string quantity = row.Cells["Quantity"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();

                graphics.DrawString($"{productId}\t{productName}\t{category}\t{quantity}\t{price}", font, Brushes.Black, x, y);
                y += lineHeight;

                // If the page is full, print a new page
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }


        private void InventoryForm_Load(object sender, EventArgs e)
        {
            cbStatus.Items.AddRange(new string[] { "Low Stock", "Out of Stock" });
            //this.productsTableAdapter.Fill(this.inventoryDatabaseDataSet.Products);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to report.");
                return;
            }

            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int productId;
            if (!int.TryParse(dgvStock.SelectedRows[0].Cells["ProductID"].Value.ToString(), out productId))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }

            string productName = dgvStock.SelectedRows[0].Cells["ProductName"].Value?.ToString();
            string status = cbStatus.SelectedItem?.ToString();
            string reportedBy = Session.LoggedInUser;
            DateTime reportDate = DateTime.Now;

            // Create a new ProductReport object
            ProductReport report = new ProductReport
            {
                ProductID = productId,
                ProductName = productName,
                ReportStatus = status,
                ReportedBy = reportedBy,
                ReportDate = reportDate
            };

            // Add the report to the shared collection
            ReportManager.AddReport(report);

            MessageBox.Show("Product report sent to Admin successfully.");
        }

        public class ProductReport
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string ReportStatus { get; set; }
            public string ReportedBy { get; set; }
            public DateTime ReportDate { get; set; }
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
    }
}