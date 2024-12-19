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
    public partial class ManageCategoriesForm : Form
    {
        OleDbConnection conn;

        public ManageCategoriesForm()
        {
            InitializeComponent();
            LoadCategories(); // Load categories into DataGridView
        }



        private void LoadCategories()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT * FROM Categories";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCategories.DataSource = dt;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            conn.Open();
            string query = "INSERT INTO Categories (CategoryName) VALUES (?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", categoryName);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully.");
                LoadCategories(); // Refresh DataGridView with the updated list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ManageCategoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.inventoryDatabaseDataSet.Categories);

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to update.");
                return;
            }

            string categoryName = tbCategoryName.Text.Trim();
            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            conn.Open();
            string query = "UPDATE Categories SET CategoryName = ? WHERE CategoryID = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", categoryName);
            cmd.Parameters.AddWithValue("?", categoryId);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category updated successfully.");
                LoadCategories(); // Refresh DataGridView with the updated list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            int categoryId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);

            // Dependency check: Ensure no products are associated with the selected category
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb"))
            {
                conn.Open();

                string dependencyQuery = "SELECT COUNT(*) FROM Products WHERE Category = ?";
                OleDbCommand dependencyCmd = new OleDbCommand(dependencyQuery, conn);
                dependencyCmd.Parameters.AddWithValue("?", categoryId);

                int dependentProducts = (int)dependencyCmd.ExecuteScalar();
                if (dependentProducts > 0)
                {
                    MessageBox.Show("Cannot delete this category because it is associated with existing products.");
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?",
                    "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Categories WHERE CategoryID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", categoryId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category deleted successfully.");
                        LoadCategories(); // Refresh DataGridView with the updated list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}