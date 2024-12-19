namespace InventoryManagementSystem
{
    partial class ProductSellingForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPayOrders = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnPayOrders);
            this.panel2.Controls.Add(this.lblChange);
            this.panel2.Controls.Add(this.tbCash);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.btnGenerateReceipt);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Location = new System.Drawing.Point(461, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 459);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cart";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(236, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 22);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPayOrders
            // 
            this.btnPayOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnPayOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOrders.ForeColor = System.Drawing.Color.White;
            this.btnPayOrders.Location = new System.Drawing.Point(90, 379);
            this.btnPayOrders.Name = "btnPayOrders";
            this.btnPayOrders.Size = new System.Drawing.Size(145, 30);
            this.btnPayOrders.TabIndex = 9;
            this.btnPayOrders.Text = "Pay Order";
            this.btnPayOrders.UseVisualStyleBackColor = false;
            this.btnPayOrders.Click += new System.EventHandler(this.btnPayOrders_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(148, 335);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(43, 16);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "₱0.00";
            this.tbCash.TextChanged += new System.EventHandler(this.tbCash_TextChanged_1);
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(119, 311);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(91, 20);
            this.tbCash.TabIndex = 7;
            this.tbCash.TextChanged += new System.EventHandler(this.tbCash_TextChanged_1);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(148, 292);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(43, 16);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "₱0.00";
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.Location = new System.Drawing.Point(90, 415);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(145, 30);
            this.btnGenerateReceipt.TabIndex = 2;
            this.btnGenerateReceipt.Text = "Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(14, 43);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(290, 235);
            this.dgvCart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownQuantity);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Controls.Add(this.tbProductID);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 459);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prodcut List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Name: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(69, 406);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "₱0.00";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(69, 346);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(31, 16);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "- - -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product ID";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(244, 335);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(145, 20);
            this.numericUpDownQuantity.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(308, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 22);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(244, 378);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(145, 30);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(211, 39);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(77, 20);
            this.tbProductID.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(75, 38);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(117, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(17, 65);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(399, 228);
            this.dgvProducts.TabIndex = 0;
            // 
            // ProductSellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductSellingForm";
            this.Text = "ProductSellingForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPayOrders;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}