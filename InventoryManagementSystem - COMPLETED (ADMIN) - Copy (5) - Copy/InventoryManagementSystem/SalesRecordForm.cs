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
    public partial class SalesRecordForm : Form
    {
        OleDbConnection conn;

        public SalesRecordForm()
        {
            InitializeComponent();
            LoadSalesRecord();
        }


        private void SalesRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadSalesRecord(string startDate = "", string endDate = "")
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = @"
        SELECT Sales.SaleID, Products.ProductName, Sales.QuantitySold, Sales.SaleDate, Sales.TotalPrice
        FROM Sales
        INNER JOIN Products ON Sales.ProductName = Products.ProductName";


            if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
            {
                query += " WHERE Sales.SaleDate BETWEEN ? AND ?";
            }

            query += " ORDER BY Sales.SaleDate DESC";

            OleDbCommand cmd = new OleDbCommand(query, conn);


            if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
            {
                cmd.Parameters.AddWithValue("?", DateTime.Parse(startDate).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?", DateTime.Parse(endDate).ToString("yyyy-MM-dd"));
            }

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                adapter.Fill(dt);
                dgvSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            CalculateTotalSales(dt);
        }



        private void CalculateTotalSales(DataTable dt)
        {
            decimal totalSales = 0;

            foreach (DataRow row in dt.Rows)
            {
                int quantity = Convert.ToInt32(row["QuantitySold"]);
                decimal price = Convert.ToDecimal(row["TotalPrice"]);
                totalSales += quantity * price;
            }

            lblTotalSales.Text = "Total Sales: " + totalSales.ToString("C");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");

            LoadSalesRecord(startDate, endDate);
        }
    }
}