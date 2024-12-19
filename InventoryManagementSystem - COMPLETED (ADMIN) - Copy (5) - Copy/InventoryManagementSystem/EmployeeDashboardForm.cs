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
    public partial class EmployeeDashboardForm : Form
    {
        private OleDbConnection conn;

        public EmployeeDashboardForm()
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


                lblTotalStock.Text = $"Total Products in Stock: {GetTotalStock()}";

                lblTodaySales.Text = $"Today's Sales: {GetTodaysSales()}";


                dgvRecentSales.DataSource = GetRecentSales();
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
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }



        private DataTable GetRecentSales()
        {
            string query = "SELECT TOP 5 ProductName, QuantitySold, TotalPrice, SaleDate FROM Sales ORDER BY SaleDate DESC";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        private decimal GetTodaysSales()
        {

            string query = "SELECT SUM(TotalPrice) FROM Sales WHERE SaleDate = ?";

            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", DateTime.Today.ToString("yyyy-MM-dd"));

            object result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
        }

        private void EmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}
