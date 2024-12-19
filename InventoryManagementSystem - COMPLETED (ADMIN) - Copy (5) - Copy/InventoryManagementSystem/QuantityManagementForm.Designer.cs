namespace InventoryManagementSystem
{
    partial class QuantityManagementForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dgvStockReports = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnRestock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvQuantityReport = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReports)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnApprove);
            this.panel3.Controls.Add(this.dgvStockReports);
            this.panel3.Location = new System.Drawing.Point(498, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 221);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reported Stocks";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(197, 177);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(80, 29);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approved";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // dgvStockReports
            // 
            this.dgvStockReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockReports.Location = new System.Drawing.Point(13, 36);
            this.dgvStockReports.Name = "dgvStockReports";
            this.dgvStockReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockReports.Size = new System.Drawing.Size(264, 125);
            this.dgvStockReports.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSelectedProduct);
            this.panel2.Controls.Add(this.numericUpDownQuantity);
            this.panel2.Controls.Add(this.btnRestock);
            this.panel2.Location = new System.Drawing.Point(498, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 236);
            this.panel2.TabIndex = 4;
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProduct.Location = new System.Drawing.Point(57, 58);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(95, 13);
            this.lblSelectedProduct.TabIndex = 2;
            this.lblSelectedProduct.Text = "Quantity to Add";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(60, 74);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(178, 20);
            this.numericUpDownQuantity.TabIndex = 1;
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.Color.White;
            this.btnRestock.Location = new System.Drawing.Point(57, 128);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(181, 29);
            this.btnRestock.TabIndex = 0;
            this.btnRestock.Text = "Restock";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNotification);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvQuantityReport);
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 463);
            this.panel1.TabIndex = 3;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(152, 314);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(34, 13);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "- - - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Updated Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prodcut List";
            // 
            // dgvQuantityReport
            // 
            this.dgvQuantityReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantityReport.Location = new System.Drawing.Point(15, 335);
            this.dgvQuantityReport.Name = "dgvQuantityReport";
            this.dgvQuantityReport.Size = new System.Drawing.Size(451, 114);
            this.dgvQuantityReport.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(15, 36);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(451, 265);
            this.dgvProducts.TabIndex = 0;
            // 
            // QuantityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuantityManagementForm";
            this.Text = "QuantityManagementForm";
            this.Load += new System.EventHandler(this.QuantityManagementForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReports)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridView dgvStockReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectedProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvQuantityReport;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}