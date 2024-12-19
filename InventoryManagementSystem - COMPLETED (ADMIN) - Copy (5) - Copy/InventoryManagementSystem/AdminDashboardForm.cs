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
    public partial class AdminDashboardForm : Form
    {
        private OleDbConnection conn;

        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
                conn.Open();

                // Fetch Total Users
                lblTotalUsers.Text = $"Total Users: {GetCount("Users")}";

                // Fetch Total Products
                lblTotalProducts.Text = $"Total Products: {GetCount("Products")}";

                // Fetch Total Stock of Products
                lblTotalStock.Text = $"Total Stock: {GetTotalStock()}";

                // Fetch Recent Products
                dgvRecentProducts.DataSource = GetRecentProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}");
            }
            finally
            {
                conn?.Close();
            }
        }


        private int GetTotalStock()
        {
            string query = "SELECT SUM(Quantity) FROM Products";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            object result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToInt32(result) : 0; // Handle null values
        }


        private int GetCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private DataTable GetRecentProducts(int topCount = 5)
        {
            DataTable dt = new DataTable();

            try
            {
                // Construct the SQL query to fetch the top recent products
                string query = $"SELECT TOP {topCount} ProductName, DateAdded FROM Products ORDER BY DateAdded DESC";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                // Fill the DataTable with the query result
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching recent products: {ex.Message}");
            }

            return dt;
        }


        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventoryDatabaseDataSet.Products);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}