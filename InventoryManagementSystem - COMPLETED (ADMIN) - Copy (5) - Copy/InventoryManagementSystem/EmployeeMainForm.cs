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
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
            LoadDashboard(); // Load AdminDashboardForm by default
        }


        private void LoadDashboard()
        {
            LoadForm(new EmployeeDashboardForm());
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
            LoadForm(new EmployeeDashboardForm());
        }

        private void btnProductSelling_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductSellingForm());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadForm(new InventoryForm());
        }

        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            LoadForm(new SalesRecordForm());
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
    }
}