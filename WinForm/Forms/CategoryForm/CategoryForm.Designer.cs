namespace WinForm.Forms.CategoryForm
{
    partial class CategoryForm
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
            lblCategoryName = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnAddCategory = new Button();
            btnDeleteCategory = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnUpdateCategory = new Button();
            grdCategory = new DataGridView();
            btnGetAllCategory = new Button();
            txtCategoryName = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblCategory = new Label();
            cmbCategories = new ComboBox();
            btnUpdateProduct = new Button();
            btnGetAllProduct = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            grdProduct = new DataGridView();
            txtWeigthProduct = new TextBox();
            txtPriceProduct = new TextBox();
            txtDescriptProduct = new TextBox();
            txtNameProduct = new TextBox();
            lblPriceProduct = new Label();
            label3 = new Label();
            label4 = new Label();
            lblNameProduct = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCategory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProduct).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoryName.Location = new Point(13, 113);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(45, 16);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Name:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(122, 139);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(116, 23);
            txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(13, 146);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 16);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = SystemColors.Window;
            btnAddCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCategory.Location = new Point(0, 192);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(101, 23);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = SystemColors.Window;
            btnDeleteCategory.Location = new Point(107, 192);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 23);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnUpdateCategory);
            panel1.Controls.Add(grdCategory);
            panel1.Controls.Add(btnGetAllCategory);
            panel1.Controls.Add(txtCategoryName);
            panel1.Controls.Add(lblCategoryName);
            panel1.Controls.Add(btnDeleteCategory);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(txtDescription);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 505);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(133, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 12;
            label1.Text = "Categories ";
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = SystemColors.Window;
            btnUpdateCategory.Location = new Point(303, 192);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(85, 23);
            btnUpdateCategory.TabIndex = 11;
            btnUpdateCategory.Text = "Update";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // grdCategory
            // 
            grdCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdCategory.BackgroundColor = SystemColors.ControlLight;
            grdCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCategory.Location = new Point(3, 221);
            grdCategory.Name = "grdCategory";
            grdCategory.RowHeadersWidth = 51;
            grdCategory.RowTemplate.Height = 25;
            grdCategory.Size = new Size(402, 225);
            grdCategory.TabIndex = 10;
            // 
            // btnGetAllCategory
            // 
            btnGetAllCategory.BackColor = SystemColors.Window;
            btnGetAllCategory.Location = new Point(188, 192);
            btnGetAllCategory.Name = "btnGetAllCategory";
            btnGetAllCategory.Size = new Size(109, 23);
            btnGetAllCategory.TabIndex = 9;
            btnGetAllCategory.Text = "GetAllCategory";
            btnGetAllCategory.UseVisualStyleBackColor = false;
            btnGetAllCategory.Click += btnGetAllCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(122, 106);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(116, 23);
            txtCategoryName.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(cmbCategories);
            panel2.Controls.Add(btnUpdateProduct);
            panel2.Controls.Add(btnGetAllProduct);
            panel2.Controls.Add(btnDeleteProduct);
            panel2.Controls.Add(btnAddProduct);
            panel2.Controls.Add(grdProduct);
            panel2.Controls.Add(txtWeigthProduct);
            panel2.Controls.Add(txtPriceProduct);
            panel2.Controls.Add(txtDescriptProduct);
            panel2.Controls.Add(txtNameProduct);
            panel2.Controls.Add(lblPriceProduct);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblNameProduct);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(412, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 502);
            panel2.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(181, 140);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 17);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Categories ";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(259, 137);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(100, 23);
            cmbCategories.TabIndex = 16;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = SystemColors.Window;
            btnUpdateProduct.Location = new Point(415, 192);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(101, 23);
            btnUpdateProduct.TabIndex = 15;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnGetAllProduct
            // 
            btnGetAllProduct.BackColor = SystemColors.Window;
            btnGetAllProduct.Location = new Point(271, 192);
            btnGetAllProduct.Name = "btnGetAllProduct";
            btnGetAllProduct.Size = new Size(106, 23);
            btnGetAllProduct.TabIndex = 14;
            btnGetAllProduct.Text = "GetAllProduct";
            btnGetAllProduct.UseVisualStyleBackColor = false;
            btnGetAllProduct.Click += btnGetAllProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = SystemColors.Window;
            btnDeleteProduct.Location = new Point(145, 192);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(93, 23);
            btnDeleteProduct.TabIndex = 13;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.Window;
            btnAddProduct.Location = new Point(18, 192);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(102, 23);
            btnAddProduct.TabIndex = 12;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // grdProduct
            // 
            grdProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdProduct.BackgroundColor = SystemColors.ControlLight;
            grdProduct.ColumnHeadersHeight = 20;
            grdProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdProduct.Location = new Point(6, 221);
            grdProduct.Name = "grdProduct";
            grdProduct.RowHeadersWidth = 51;
            grdProduct.RowTemplate.Height = 25;
            grdProduct.Size = new Size(541, 225);
            grdProduct.TabIndex = 11;
          
            // 
            // txtWeigthProduct
            // 
            txtWeigthProduct.Location = new Point(416, 101);
            txtWeigthProduct.Name = "txtWeigthProduct";
            txtWeigthProduct.Size = new Size(100, 23);
            txtWeigthProduct.TabIndex = 10;
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.Location = new Point(75, 137);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(100, 23);
            txtPriceProduct.TabIndex = 9;
            // 
            // txtDescriptProduct
            // 
            txtDescriptProduct.Location = new Point(259, 101);
            txtDescriptProduct.Name = "txtDescriptProduct";
            txtDescriptProduct.Size = new Size(100, 23);
            txtDescriptProduct.TabIndex = 8;
            // 
            // txtNameProduct
            // 
            txtNameProduct.Location = new Point(75, 101);
            txtNameProduct.Name = "txtNameProduct";
            txtNameProduct.Size = new Size(100, 23);
            txtNameProduct.TabIndex = 7;
            // 
            // lblPriceProduct
            // 
            lblPriceProduct.AutoSize = true;
            lblPriceProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPriceProduct.Location = new Point(18, 140);
            lblPriceProduct.Name = "lblPriceProduct";
            lblPriceProduct.Size = new Size(36, 17);
            lblPriceProduct.TabIndex = 5;
            lblPriceProduct.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(365, 104);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 4;
            label3.Text = "Weigth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(181, 104);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // lblNameProduct
            // 
            lblNameProduct.AutoSize = true;
            lblNameProduct.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameProduct.Location = new Point(18, 106);
            lblNameProduct.Name = "lblNameProduct";
            lblNameProduct.Size = new Size(42, 16);
            lblNameProduct.TabIndex = 1;
            lblNameProduct.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(223, 30);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 0;
            label2.Text = "Products";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 479);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCategory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCategoryName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnAddCategory;
        private Button btnDeleteCategory;
        private Panel panel1;
        private TextBox txtCategoryName;
        private Button btnGetAllCategory;
        private DataGridView grdCategory;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel2;
        private Button btnUpdateCategory;
        private Label label1;
        private Label label2;
        private Label lblNameProduct;
        private Label label3;
        private Label label4;
        private Label lblPriceProduct;
        private TextBox txtWeigthProduct;
        private TextBox txtPriceProduct;
        private TextBox txtDescriptProduct;
        private TextBox txtNameProduct;
        private Button btnUpdateProduct;
        private Button btnGetAllProduct;
        private Button btnDeleteProduct;
        private Button btnAddProduct;
        private ComboBox cmbCategories;
        private ComboBox comboBox1;
        private Label lblCategory;
        private DataGridView grdProduct;
    }
}