﻿namespace SaleWinApp
{
    partial class frmProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ReloadData = new System.Windows.Forms.Button();
            this.tB_SearchProduct = new System.Windows.Forms.TextBox();
            this.label_SearchProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.CategoryId,
            this.ProductName,
            this.Weight,
            this.UnitPrice,
            this.UnitsInStock});
            this.dgv_Product.Location = new System.Drawing.Point(12, 199);
            this.dgv_Product.MultiSelect = false;
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersWidth = 62;
            this.dgv_Product.RowTemplate.Height = 33;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(1066, 432);
            this.dgv_Product.TabIndex = 0;
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
            this.dgv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Category Name";
            this.CategoryId.MinimumWidth = 8;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight (gram)";
            this.Weight.MinimumWidth = 8;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 150;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 150;
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.HeaderText = "Units In Stock";
            this.UnitsInStock.MinimumWidth = 8;
            this.UnitsInStock.Name = "UnitsInStock";
            this.UnitsInStock.ReadOnly = true;
            this.UnitsInStock.Width = 150;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(176, 34);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add a new Product";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(925, 63);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 34);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete Product";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(12, 63);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(176, 34);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update Product";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_ReloadData
            // 
            this.btn_ReloadData.Location = new System.Drawing.Point(925, 159);
            this.btn_ReloadData.Name = "btn_ReloadData";
            this.btn_ReloadData.Size = new System.Drawing.Size(152, 34);
            this.btn_ReloadData.TabIndex = 4;
            this.btn_ReloadData.Text = "Reload Data";
            this.btn_ReloadData.UseVisualStyleBackColor = true;
            this.btn_ReloadData.Click += new System.EventHandler(this.btn_ReloadData_Click);
            // 
            // tB_SearchProduct
            // 
            this.tB_SearchProduct.Location = new System.Drawing.Point(12, 159);
            this.tB_SearchProduct.Name = "tB_SearchProduct";
            this.tB_SearchProduct.Size = new System.Drawing.Size(211, 31);
            this.tB_SearchProduct.TabIndex = 5;
            this.tB_SearchProduct.TextChanged += new System.EventHandler(this.tB_SearchProduct_TextChanged);
            // 
            // label_SearchProduct
            // 
            this.label_SearchProduct.AutoSize = true;
            this.label_SearchProduct.Location = new System.Drawing.Point(229, 164);
            this.label_SearchProduct.Name = "label_SearchProduct";
            this.label_SearchProduct.Size = new System.Drawing.Size(131, 25);
            this.label_SearchProduct.TabIndex = 6;
            this.label_SearchProduct.Text = "Search Product";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 643);
            this.Controls.Add(this.label_SearchProduct);
            this.Controls.Add(this.tB_SearchProduct);
            this.Controls.Add(this.btn_ReloadData);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Product);
            this.Name = "frmProductManagement";
            this.Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsInStock;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_ReloadData;
        private System.Windows.Forms.TextBox tB_SearchProduct;
        private System.Windows.Forms.Label label_SearchProduct;
    }
}