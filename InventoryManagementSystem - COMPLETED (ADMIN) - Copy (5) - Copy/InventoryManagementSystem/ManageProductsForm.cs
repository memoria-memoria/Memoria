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
    public partial class ManageProductsForm : Form
    {
        OleDbConnection conn;

        public ManageProductsForm()
        {
            InitializeComponent();
            LoadProducts();  // Load products into DataGridView
            LoadCategories(); // Load categories into ComboBox when form loads
        }

        // Load products into DataGridView
        private void LoadProducts()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT ProductID, ProductName, Category, Quantity, DateAdded, LastMOdified, Price FROM Products";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProducts.DataSource = dt; // Refresh the DataGridView
        }

        // Load categories into ComboBox (cbCategory)
        private void LoadCategories()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbCategory.DataSource = dt;              
            cbCategory.DisplayMember = "CategoryName"; 
            cbCategory.ValueMember = "CategoryID";    
        }

        // Button click to open ManageCategoriesForm and reload categories after closing
        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            // Open ManageCategoriesForm as a modal dialog
            ManageCategoriesForm manageCategoriesForm = new ManageCategoriesForm();
            manageCategoriesForm.ShowDialog();  // Open the form as a dialog

            LoadCategories();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                try
                {
                    // Get the selected row's data
                    string productName = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value?.ToString();
                    DateTime dateAdded = Convert.ToDateTime(dgvProducts.Rows[e.RowIndex].Cells["DateAdded"].Value);
                    DateTime lastModified = Convert.ToDateTime(dgvProducts.Rows[e.RowIndex].Cells["LastModified"].Value);
                    decimal price = Convert.ToDecimal(dgvProducts.Rows[e.RowIndex].Cells["Price"].Value);
                    int quantity = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["Quantity"].Value);
                    string category = dgvProducts.Rows[e.RowIndex].Cells["Category"].Value?.ToString();

                    // Create a mini-tab dynamically
                    Form miniTab = new Form();
                    miniTab.Text = "Product Details";
                    miniTab.Size = new Size(300, 250);
                    miniTab.StartPosition = FormStartPosition.CenterParent;
                    miniTab.FormBorderStyle = FormBorderStyle.FixedDialog; // Prevent resizing
                    miniTab.MaximizeBox = false; // Disable maximize button
                    miniTab.MinimizeBox = false; // Disable minimize button

                    // Add Labels for product details
                    Label lblName = new Label { Text = $"Name: {productName}", Location = new Point(20, 20), AutoSize = true };
                    Label lblDateAdded = new Label { Text = $"Date Added: {dateAdded.ToShortDateString()}", Location = new Point(20, 50), AutoSize = true };
                    Label lblLastModified = new Label { Text = $"Last Modified: {lastModified.ToShortDateString()}", Location = new Point(20, 80), AutoSize = true };
                    Label lblPrice = new Label { Text = $"Price: {price:C}", Location = new Point(20, 110), AutoSize = true };
                    Label lblQuantity = new Label { Text = $"Quantity: {quantity}", Location = new Point(20, 140), AutoSize = true };
                    Label lblCategory = new Label { Text = $"Category: {category}", Location = new Point(20, 170), AutoSize = true };

                    // Add Close Button
                    Button btnClose = new Button
                    {
                        Text = "Close",
                        Location = new Point(200, 180),
                        AutoSize = true
                    };
                    btnClose.Click += (s, args) => miniTab.Close();

                    // Add controls to the mini window
                    miniTab.Controls.Add(lblName);
                    miniTab.Controls.Add(lblDateAdded);
                    miniTab.Controls.Add(lblLastModified);
                    miniTab.Controls.Add(lblPrice);
                    miniTab.Controls.Add(lblQuantity);
                    miniTab.Controls.Add(lblCategory);
                    miniTab.Controls.Add(btnClose);

                    // Show the mini window
                    miniTab.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }




        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = tbProductName.Text.Trim();
            object selectedCategory = cbCategory.SelectedValue;  // Use SelectedValue to get CategoryID

            // Validate inputs
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(tbPrice.Text) ||
                string.IsNullOrWhiteSpace(tbQuantity.Text) || selectedCategory == null)
            {
                MessageBox.Show("Please fill in all fields and select a category.");
                return;
            }

            // Validate Price
            decimal price;
            if (!decimal.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate Quantity
            int quantity;
            if (!int.TryParse(tbQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            DateTime dateAdded = DateTime.Now;
            DateTime lastModified = DateTime.Now;  // Add the LastModified timestamp

            // Show confirmation dialog
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to add this product to the inventory?",
                "Confirm Product Creation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Insert the product into the database, including DateAdded and LastModified fields
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
                string query = "INSERT INTO products (ProductName, DateAdded, Price, Quantity, Category, LastModified) " +
                               "VALUES (?, ?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = productName;
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now; // Add the DateAdded value
                cmd.Parameters.Add("?", OleDbType.Currency).Value = price;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedCategory;  // Pass CategoryID (SelectedValue)
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;  // Add the LastModified value

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product created successfully!");

                    // Refresh the DataGridView to show the newly created product
                    LoadProducts();  // This will load all products including the one just created
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
            else
            {
                // If No is selected, do nothing
                MessageBox.Show("Product creation canceled.");
            }
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Create a new "mini-tab" form for updating the product
            Form miniTab = new Form
            {
                Text = "Update Product",  // Set the title of the mini-tab form
                Size = new Size(400, 500),  // Set the size of the form
                StartPosition = FormStartPosition.CenterParent, // Center the form on the parent window
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false, // Disable maximize button
                MinimizeBox = false // Disable minimize button
            };





            // Label and ComboBox for selecting the product to update
            Label lblSelectProduct = new Label
            {
                Text = "Select Product:",
                Location = new Point(20, 20),
                AutoSize = true
            };
            ComboBox cbProducts = new ComboBox
            {
                Location = new Point(20, 50),
                Size = new Size(340, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            // TextBoxes for updating details
            Label lblProductName = new Label { Text = "Name:", Location = new Point(20, 90), AutoSize = true };
            TextBox tbProductName = new TextBox { Location = new Point(20, 120), Size = new Size(340, 30) };

            Label lblPrice = new Label { Text = "Price:", Location = new Point(20, 160), AutoSize = true };
            TextBox tbPrice = new TextBox { Location = new Point(20, 190), Size = new Size(340, 30) };

            Label lblQuantity = new Label { Text = "Quantity:", Location = new Point(20, 230), AutoSize = true };
            TextBox tbQuantity = new TextBox { Location = new Point(20, 260), Size = new Size(340, 30) };

            Label lblCategory = new Label { Text = "Category:", Location = new Point(20, 300), AutoSize = true };
            ComboBox cbCategory = new ComboBox { Location = new Point(20, 330), Size = new Size(340, 30), DropDownStyle = ComboBoxStyle.DropDownList };

            // Button to save changes
            Button btnSave = new Button
            {
                Text = "Save Changes",
                Location = new Point(20, 400),
                Size = new Size(340, 40)
            };

            // Load products into ComboBox
            LoadProductsIntoComboBox(cbProducts);  // Load products into ComboBox

            // Load categories into ComboBox
            LoadCategoriesIntoComboBox(cbCategory); // Load categories into ComboBox

            // Add the event to load the selected product's details when a product is chosen
            cbProducts.SelectedIndexChanged += (s, args) =>
            {
                if (cbProducts.SelectedIndex >= 0)
                {
                    int selectedProductId = (int)cbProducts.SelectedValue;

                    // Populate fields by passing the controls directly
                    PopulateFieldsForSelectedProduct(
                        selectedProductId,
                        tbProductName, // Pass the TextBox for Product Name
                        tbPrice,       // Pass the TextBox for Price
                        tbQuantity,    // Pass the TextBox for Quantity
                        cbCategory     // Pass the ComboBox for Category
                    );
                }
            };

            // Save button click event
            btnSave.Click += (s, args) =>
            {
                // Ensure a product is selected
                if (cbProducts.SelectedValue == null)
                {
                    MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected product ID
                int selectedProductId = (int)cbProducts.SelectedValue;

                // Validate and get updated values
                string updatedName = tbProductName.Text.Trim();
                if (string.IsNullOrEmpty(updatedName))
                {
                    MessageBox.Show("Product name cannot be empty.");
                    return;
                }

                decimal updatedPrice;
                if (!decimal.TryParse(tbPrice.Text, out updatedPrice)) // Parse the price
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                int updatedQuantity;
                if (!int.TryParse(tbQuantity.Text, out updatedQuantity)) // Parse the quantity
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                string updatedCategory = cbCategory.SelectedItem.ToString(); // Get selected category

                // Confirm the update action
                DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Update the product details, including the LastModified field
                        UpdateProductInDatabase(selectedProductId, updatedName, updatedPrice, updatedQuantity, updatedCategory);
                        // Refresh the product list/grid after updating
                        LoadProducts();

                        MessageBox.Show("Product updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating product: {ex.Message}");
                    }
                    miniTab.Close();
                }
            };

            // Add controls to the mini-tab form
            miniTab.Controls.Add(lblSelectProduct);
            miniTab.Controls.Add(cbProducts);
            miniTab.Controls.Add(lblProductName);
            miniTab.Controls.Add(tbProductName);
            miniTab.Controls.Add(lblPrice);
            miniTab.Controls.Add(tbPrice);
            miniTab.Controls.Add(lblQuantity);
            miniTab.Controls.Add(tbQuantity);
            miniTab.Controls.Add(lblCategory);
            miniTab.Controls.Add(cbCategory);
            miniTab.Controls.Add(btnSave);

            // Show the mini-tab form as a modal dialog (prevents interaction with the main window until closed)
            miniTab.ShowDialog();
        }

        private void LoadProductsIntoComboBox(ComboBox comboBox)
        {
            conn.Open();
            string query = "SELECT ProductID, ProductName FROM Products";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "ProductName";
            comboBox.ValueMember = "ProductID";
            conn.Close();
        }

        // Helper method to load categories into ComboBox for the mini-tab
        private void LoadCategoriesIntoComboBox(ComboBox comboBox)
        {
            conn.Open();
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
            conn.Close();
        }

        // Helper method to populate fields for the selected product
        private void PopulateFieldsForSelectedProduct(int productId, TextBox tbName, TextBox tbPrice, TextBox tbQuantity, ComboBox cbCategory)
        {
            conn.Open();
            string query = "SELECT ProductName, Price, Quantity, Category FROM Products WHERE ProductID = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("?", productId);

            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbName.Text = reader["ProductName"].ToString();
                tbPrice.Text = reader["Price"].ToString();
                tbQuantity.Text = reader["Quantity"].ToString();
                cbCategory.SelectedItem = reader["Category"].ToString();
            }
            conn.Close();
        }

        // Helper method to update the product in the database
        private void UpdateProductInDatabase(int productId, string name, decimal price, int quantity, string category)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDatabase.accdb");
            string query = "UPDATE Products SET ProductName = ?, Price = ?, Quantity = ?, Category = ?, LastModified = ? WHERE ProductID = ?";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = name;
            cmd.Parameters.Add("?", OleDbType.Currency).Value = price;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = quantity;
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = category;
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;  // Set the LastModified field to current time
            cmd.Parameters.Add("?", OleDbType.Integer).Value = productId;  // Update product by its ID

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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



        private void ManageProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.inventoryDatabaseDataSet.Products);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbProductName.Clear();  
            tbPrice.Clear();       
            tbQuantity.Clear();    
            cbCategory.SelectedIndex = -1;
        }
    }
}