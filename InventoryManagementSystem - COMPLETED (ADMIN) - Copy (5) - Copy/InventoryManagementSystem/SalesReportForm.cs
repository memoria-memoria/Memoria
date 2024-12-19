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
    public partial class SalesReportForm : Form
    {
        OleDbConnection conn;

        public SalesReportForm()
        {
            InitializeComponent();
            LoadSalesReport();
        }

        private void LoadSalesReport()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT * FROM Sales WHERE SaleDate >= ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", DateTime.Now.Date);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSalesReport.DataSource = dt;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            // Code to print the sales report (can be implemented using PrintDialog or a library)
            MessageBox.Show("Printing sales report...");
        }
    }
}
