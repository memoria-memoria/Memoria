namespace InventoryManagementSystem
{
    partial class SalesReportForm
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
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.inventoryDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSet = new InventoryManagementSystem.InventoryDatabaseDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrintReport);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvSalesReport);
            this.panel1.Location = new System.Drawing.Point(19, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 463);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.Location = new System.Drawing.Point(629, 11);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(107, 29);
            this.btnPrintReport.TabIndex = 11;
            this.btnPrintReport.Text = "Print Out";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sales Report";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(21, 46);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(726, 398);
            this.dgvSalesReport.TabIndex = 0;
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
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.BindingSource inventoryDatabaseDataSetBindingSource;
        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrintReport;
    }
}