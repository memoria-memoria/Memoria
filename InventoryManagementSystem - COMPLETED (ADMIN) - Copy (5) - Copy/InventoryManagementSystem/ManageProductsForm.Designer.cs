namespace InventoryManagementSystem
{
    partial class ManageProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.inventoryDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSet = new InventoryManagementSystem.InventoryDatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 293);
            this.panel1.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(28, 42);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(723, 227);
            this.dgvProducts.TabIndex = 16;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Product List";
            // 
            // inventoryDatabaseDataSetBindingSource
            // 
            this.inventoryDatabaseDataSetBindingSource.DataSource = this.inventoryDatabaseDataSet;
            this.inventoryDatabaseDataSetBindingSource.Position = 0;
            // 
            // inventoryDatabaseDataSet
            // 
            this.inventoryDatabaseDataSet.DataSetName = "InventoryDatabaseDataSet";
            this.inventoryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnUpdateProduct);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.tbPrice);
            this.panel2.Controls.Add(this.tbProductName);
            this.panel2.Location = new System.Drawing.Point(10, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 167);
            this.panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(630, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Add Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Name";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(173, 41);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(107, 33);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(43, 41);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(107, 33);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(553, 41);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(187, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(466, 94);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(117, 20);
            this.tbQuantity.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(344, 94);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(99, 20);
            this.tbPrice.TabIndex = 1;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(344, 42);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(187, 20);
            this.tbProductName.TabIndex = 0;
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource inventoryDatabaseDataSetBindingSource;
        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClear;
        //private System.Windows.Forms.BindingSource productsBindingSource; //ere dinagdag ko
        //private InventoryDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter; // tas to
    }
}