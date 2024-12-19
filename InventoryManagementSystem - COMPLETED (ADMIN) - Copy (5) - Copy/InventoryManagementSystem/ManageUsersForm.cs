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
    public partial class ManageUsersForm : Form
    {
        OleDbConnection conn;

        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsers();
            // Removed PopulateRoleComboBox() as the ComboBox for role is deleted
        }

        private void LoadUsers()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
                conn.Open();

                // SQL query to select only employees
                string query = "SELECT UserID, Username, Role FROM Users WHERE Role = 'Employee'";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the filtered data to the DataGridView
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }


        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            string role = "Employee"; // Default role

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            conn.Open();
            string query = "INSERT INTO Users (Username, [Password], Role) VALUES (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", username);
            cmd.Parameters.AddWithValue("?", password);
            cmd.Parameters.AddWithValue("?", role); // Assign the default role

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully.");
                LoadUsers();
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

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            Form miniTab = new Form
            {
                Text = "Update User",
                Size = new Size(400, 200),  // Adjust size for fewer controls
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblUsername = new Label { Text = "Username:", Location = new Point(20, 40), AutoSize = true };
            TextBox tbUsername = new TextBox { Location = new Point(20, 70), Size = new Size(340, 30) };

            Label lblPassword = new Label { Text = "Password:", Location = new Point(20, 110), AutoSize = true };
            TextBox tbPassword = new TextBox { Location = new Point(20, 140), Size = new Size(340, 30) };

            LoadUserDetails(userId, tbUsername, tbPassword);

            Button btnSave = new Button
            {
                Text = "Save Changes",
                Location = new Point(20, 190),
                Size = new Size(340, 40)
            };

            btnSave.Click += (s, args) =>
            {
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                conn.Open();
                string query = "UPDATE Users SET Username = ?, [Password] = ? WHERE UserID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);
                cmd.Parameters.AddWithValue("?", userId);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully.");
                    LoadUsers();
                    miniTab.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            };

            miniTab.Controls.Add(lblUsername);
            miniTab.Controls.Add(tbUsername);
            miniTab.Controls.Add(lblPassword);
            miniTab.Controls.Add(tbPassword);
            miniTab.Controls.Add(btnSave);

            miniTab.ShowDialog();
        }

        private void LoadUserDetails(int userId, TextBox tbUsername, TextBox tbPassword)
        {
            conn.Open();
            string query = "SELECT * FROM Users WHERE UserID = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", userId);

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbUsername.Text = reader["Username"].ToString();
                tbPassword.Text = reader["Password"].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Get the selected user's name
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

            // Ask for confirmation
            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to remove '{username}' permanently?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return; // Do nothing if the user cancels
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            conn.Open();
            string query = "DELETE FROM Users WHERE UserID = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", userId);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully.");
                LoadUsers();
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
    }
}