namespace InventoryManagementSystem
{
    partial class ManageCategoriesForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDatabaseDataSet = new InventoryManagementSystem.InventoryDatabaseDataSet();
            this.categoriesTableAdapter = new InventoryManagementSystem.InventoryDatabaseDataSetTableAdapters.CategoriesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvCategories);
            this.panel1.Controls.Add(this.btnDeleteCategory);
            this.panel1.Controls.Add(this.btnUpdateCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.tbCategoryName);
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 459);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Add Categories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(340, 41);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(403, 402);
            this.dgvCategories.TabIndex = 11;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(58, 222);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(107, 33);
            this.btnDeleteCategory.TabIndex = 10;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(203, 168);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(107, 33);
            this.btnUpdateCategory.TabIndex = 9;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(56)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(58, 168);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(107, 33);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(58, 123);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(252, 20);
            this.tbCategoryName.TabIndex = 1;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.inventoryDatabaseDataSetBindingSource;
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
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategoriesForm";
            this.Text = "ManageCategoriesForm";
            this.Load += new System.EventHandler(this.ManageCategoriesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.BindingSource inventoryDatabaseDataSetBindingSource;
        private InventoryDatabaseDataSet inventoryDatabaseDataSet;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private InventoryDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Label label5;
    }
}