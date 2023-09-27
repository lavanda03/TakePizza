namespace WinForm.Forms.CategoryForm
{
    partial class UpdateProductForm
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
            lblName = new Label();
            lblDescripttion = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnUpdate = new Button();
            txtWeigth = new TextBox();
            txtPrice = new TextBox();
            lblWeigth = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.UseWaitCursor = true;
            // 
            // lblDescripttion
            // 
            lblDescripttion.AutoSize = true;
            lblDescripttion.Location = new Point(25, 69);
            lblDescripttion.Name = "lblDescripttion";
            lblDescripttion.Size = new Size(67, 15);
            lblDescripttion.TabIndex = 1;
            lblDescripttion.Text = "Description";
            lblDescripttion.UseWaitCursor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            txtName.UseWaitCursor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(106, 66);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 3;
            txtDescription.UseWaitCursor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.Location = new Point(203, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.UseWaitCursor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtWeigth
            // 
            txtWeigth.Location = new Point(106, 107);
            txtWeigth.Name = "txtWeigth";
            txtWeigth.Size = new Size(100, 23);
            txtWeigth.TabIndex = 5;
            txtWeigth.UseWaitCursor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(314, 31);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 6;
            txtPrice.UseWaitCursor = true;
            // 
            // lblWeigth
            // 
            lblWeigth.AutoSize = true;
            lblWeigth.Location = new Point(26, 110);
            lblWeigth.Name = "lblWeigth";
            lblWeigth.Size = new Size(45, 15);
            lblWeigth.TabIndex = 8;
            lblWeigth.Text = "Weigth";
            lblWeigth.UseWaitCursor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(244, 39);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            lblPrice.UseWaitCursor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(245, 74);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category ";
            lblCategory.UseWaitCursor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(314, 74);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 11;
            cmbCategory.UseWaitCursor = true;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(476, 210);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblWeigth);
            Controls.Add(txtPrice);
            Controls.Add(txtWeigth);
            Controls.Add(btnUpdate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblDescripttion);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDescripttion;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnUpdate;
        private TextBox txtWeigth;
        private TextBox txtPrice;
        private Label lblWeigth;
        private Label lblPrice;
        private Label lblCategory;
        private ComboBox cmbCategory;
    }
}