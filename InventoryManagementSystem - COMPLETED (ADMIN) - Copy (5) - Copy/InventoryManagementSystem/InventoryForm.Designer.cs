namespace InventoryManagementSystem
{
    partial class InventoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.tbProductID);
            this.panel1.Controls.Add(this.tbProductName);
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 458);
            this.panel1.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(483, 409);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(631, 409);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(90, 26);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(381, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 19);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(643, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 32);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(483, 27);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(111, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(299, 27);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(76, 20);
            this.tbProductID.TabIndex = 2;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(156, 27);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(127, 20);
            this.tbProductName.TabIndex = 1;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(17, 65);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(723, 314);
            this.dgvStock.TabIndex = 0;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.DataGridView dgvStock;
        //private InventoryDatabaseDataSet inventoryDatabaseDataSet; //hererererere
        //private InventoryDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter; // addeddededed
    }
}