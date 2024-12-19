namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnManageCategories = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(68)))));
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.btnStocks);
            this.pnlSidebar.Controls.Add(this.btnManageCategories);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSalesReport);
            this.pnlSidebar.Controls.Add(this.btnManageProducts);
            this.pnlSidebar.Controls.Add(this.btnManageUsers);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(153, 558);
            this.pnlSidebar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnStocks.FlatAppearance.BorderSize = 0;
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.White;
            this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocks.Location = new System.Drawing.Point(0, 273);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(135, 33);
            this.btnStocks.TabIndex = 6;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnManageCategories
            // 
            this.btnManageCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnManageCategories.FlatAppearance.BorderSize = 0;
            this.btnManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCategories.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategories.ForeColor = System.Drawing.Color.White;
            this.btnManageCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCategories.Location = new System.Drawing.Point(0, 312);
            this.btnManageCategories.Name = "btnManageCategories";
            this.btnManageCategories.Size = new System.Drawing.Size(135, 33);
            this.btnManageCategories.TabIndex = 5;
            this.btnManageCategories.Text = "Categories";
            this.btnManageCategories.UseVisualStyleBackColor = false;
            this.btnManageCategories.Click += new System.EventHandler(this.btnManageCategories_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(8, 521);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 25);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 351);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(135, 33);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.Color.White;
            this.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProducts.Location = new System.Drawing.Point(0, 234);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(135, 33);
            this.btnManageProducts.TabIndex = 2;
            this.btnManageProducts.Text = "Products";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 195);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(135, 33);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 156);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(135, 33);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(153, 35);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(828, 523);
            this.pnlMainContent.TabIndex = 2;
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(68)))));
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(153, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(828, 35);
            this.pnlTopbar.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 558);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageCategories;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}