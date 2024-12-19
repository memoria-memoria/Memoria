namespace InventoryManagementSystem
{
    partial class EmployeeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecentSales = new System.Windows.Forms.DataGridView();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSales)).BeginInit();
            this.gbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvRecentSales);
            this.panel1.Controls.Add(this.gbStats);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 467);
            this.panel1.TabIndex = 1;
            // 
            // dgvRecentSales
            // 
            this.dgvRecentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentSales.Location = new System.Drawing.Point(258, 19);
            this.dgvRecentSales.Name = "dgvRecentSales";
            this.dgvRecentSales.Size = new System.Drawing.Size(486, 427);
            this.dgvRecentSales.TabIndex = 2;
            // 
            // gbStats
            // 
            this.gbStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.gbStats.Controls.Add(this.pictureBox1);
            this.gbStats.Controls.Add(this.lblTodaySales);
            this.gbStats.Controls.Add(this.pictureBox3);
            this.gbStats.Controls.Add(this.lblTotalStock);
            this.gbStats.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStats.ForeColor = System.Drawing.Color.White;
            this.gbStats.Location = new System.Drawing.Point(29, 19);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(205, 353);
            this.gbStats.TabIndex = 1;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(65, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.White;
            this.lblTodaySales.Location = new System.Drawing.Point(33, 156);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(15, 16);
            this.lblTodaySales.TabIndex = 6;
            this.lblTodaySales.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(65, 43);
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
            this.lblTotalStock.Location = new System.Drawing.Point(33, 24);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(15, 16);
            this.lblTotalStock.TabIndex = 4;
            this.lblTotalStock.Text = "0";
            // 
            // EmployeeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboardForm";
            this.Text = "EmployeeDashboardForm";
            this.Load += new System.EventHandler(this.EmployeeDashboardForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSales)).EndInit();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRecentSales;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotalStock;
    }
}