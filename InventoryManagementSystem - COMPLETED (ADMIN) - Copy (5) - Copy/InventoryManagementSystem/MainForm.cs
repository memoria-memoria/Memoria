using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadDashboard(); // Load AdminDashboardForm by default

        }


        private void LoadDashboard()
        {
            LoadForm(new AdminDashboardForm());
        }

        private void LoadForm(Form form)
        {
            pnlMainContent.Controls.Clear(); // Clear the main content area
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminDashboardForm());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageUsersForm());
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageProductsForm());
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            LoadForm(new SalesReportForm());
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageCategoriesForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                // Open the LoginForm
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            LoadForm(new QuantityManagementForm());
        }
    }
}