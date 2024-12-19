namespace InventoryManagementSystem
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSet = new InventoryManagementSystem.InventoryDatabaseDataSet();
            this.productsTableAdapter = new InventoryManagementSystem.InventoryDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecentProducts = new System.Windows.Forms.DataGridView();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentProducts)).BeginInit();
            this.gbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.inventoryDatabaseDataSetBindingSource;
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
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvRecentProducts);
            this.panel1.Controls.Add(this.gbStats);
            this.panel1.Location = new System.Drawing.Point(26, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 457);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvRecentProducts
            // 
            this.dgvRecentProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvRecentProducts.Location = new System.Drawing.Point(289, 21);
            this.dgvRecentProducts.Name = "dgvRecentProducts";
            this.dgvRecentProducts.Size = new System.Drawing.Size(421, 191);
            this.dgvRecentProducts.TabIndex = 6;
            // 
            // gbStats
            // 
            this.gbStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.gbStats.Controls.Add(this.pictureBox3);
            this.gbStats.Controls.Add(this.lblTotalStock);
            this.gbStats.Controls.Add(this.pictureBox2);
            this.gbStats.Controls.Add(this.pictureBox1);
            this.gbStats.Controls.Add(this.lblTotalProducts);
            this.gbStats.Controls.Add(this.lblTotalUsers);
            this.gbStats.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStats.ForeColor = System.Drawing.Color.White;
            this.gbStats.Location = new System.Drawing.Point(42, 21);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(215, 412);
            this.gbStats.TabIndex = 0;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Status";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(35, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStock.ForeColor = System.Drawing.Color.White;
            this.lblTotalStock.Location = new System.Drawing.Point(49, 285);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(15, 16);
            this.lblTotalStock.TabIndex = 4;
            this.lblTotalStock.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(35, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.White;
            this.lblTotalProducts.Location = new System.Drawing.Point(46, 149);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(15, 16);
            this.lblTotalProducts.TabIndex = 1;
            this.lblTotalProducts.Text = "0";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsers.Location = new System.Drawing.Point(32, 16);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(15, 16);
            this.lblTotalUsers.TabIndex = 0;
            this.lblTotalUsers.Text = "0";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentProducts)).EndInit();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource inventoryDatabaseDataSetBindingSource;
        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private InventoryDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRecentProducts;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblTotalUsers;
    }
}