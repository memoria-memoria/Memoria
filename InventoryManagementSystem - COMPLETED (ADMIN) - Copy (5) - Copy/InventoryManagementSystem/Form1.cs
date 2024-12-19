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
    public partial class LoginForm : Form
    {
        private OleDbConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }

        public static class Session
        {
            public static string LoggedInUser { get; set; } // Make the set accessor public
            public static bool IsLoggedIn => !string.IsNullOrEmpty(LoggedInUser);

            public static void Login(string username)
            {
                LoggedInUser = username;
            }

            public static void Logout()
            {
                LoggedInUser = string.Empty;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string query = "SELECT Role FROM Users WHERE Username = ? AND Password = ?";
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", password);

                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    Session.Login(username); // Store the logged-in username
                    MessageBox.Show($"Logged in as: {Session.LoggedInUser}");

                    this.Hide(); // Hide the login form

                    if (role.ToString() == "Admin")
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                    }
                    else if (role.ToString() == "Employee")
                    {
                        EmployeeMainForm employeeForm = new EmployeeMainForm();
                        employeeForm.ShowDialog();
                    }

                    Session.Logout(); // Clear session after closing the main form
                    this.Show(); // Show the login form again for next user
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
      
        private void cbShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                // Show password by changing the password box to normal text
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                // Hide password by setting the PasswordChar
                tbPassword.PasswordChar = '*';
            }

        }
    }
}

