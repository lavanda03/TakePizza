namespace WinForm.Forms.OrderFormClient
{
    partial class OrderFormClient
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
            panel1 = new Panel();
            treeViewCategory = new TreeView();
            panel2 = new Panel();
            grdProductList = new DataGridView();
            AddProduct = new Button();
            panel3 = new Panel();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnAddOrder = new Button();
            btnDeleteOrderDetail = new Button();
            cmbPayment = new ComboBox();
            txtStatus = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            txtTotalPrice = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grdOrderDetail = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProductList).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(treeViewCategory);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 433);
            panel1.TabIndex = 0;
            // 
            // treeViewCategory
            // 
            treeViewCategory.Location = new Point(3, 0);
            treeViewCategory.Name = "treeViewCategory";
            treeViewCategory.Size = new Size(217, 441);
            treeViewCategory.TabIndex = 0;
            treeViewCategory.NodeMouseClick += treeViewCategory_NodeMouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(grdProductList);
            panel2.Controls.Add(AddProduct);
            panel2.Location = new Point(244, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 186);
            panel2.TabIndex = 1;
            // 
            // grdProductList
            // 
            grdProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdProductList.BackgroundColor = SystemColors.ButtonHighlight;
            grdProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProductList.Location = new Point(3, 3);
            grdProductList.Name = "grdProductList";
            grdProductList.RowTemplate.Height = 25;
            grdProductList.Size = new Size(534, 180);
            grdProductList.TabIndex = 2;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = SystemColors.Window;
            AddProduct.Location = new Point(543, 27);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(97, 32);
            AddProduct.TabIndex = 1;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(lblDescription);
            panel3.Controls.Add(btnAddOrder);
            panel3.Controls.Add(btnDeleteOrderDetail);
            panel3.Controls.Add(cmbPayment);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(grdOrderDetail);
            panel3.Location = new Point(238, 203);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 242);
            panel3.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(532, 149);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 14;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(459, 152);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = SystemColors.Window;
            btnAddOrder.Location = new Point(549, 65);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(97, 34);
            btnAddOrder.TabIndex = 12;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnDeleteOrderDetail
            // 
            btnDeleteOrderDetail.BackColor = SystemColors.Window;
            btnDeleteOrderDetail.Location = new Point(549, 20);
            btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            btnDeleteOrderDetail.Size = new Size(97, 39);
            btnDeleteOrderDetail.TabIndex = 11;
            btnDeleteOrderDetail.Text = "Delete OrderDetail";
            btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            btnDeleteOrderDetail.Click += btnDeleteOrderDetail_Click;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Items.AddRange(new object[] { "Card", "Cash" });
            cmbPayment.Location = new Point(320, 148);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(121, 23);
            cmbPayment.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(320, 181);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(121, 23);
            txtStatus.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(90, 183);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 191);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(88, 142);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(100, 23);
            txtTotalPrice.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(28, 392);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(275, 22);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 148);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Payment type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 184);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 148);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Total Price";
            // 
            // grdOrderDetail
            // 
            grdOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdOrderDetail.BackgroundColor = SystemColors.Window;
            grdOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrderDetail.Location = new Point(9, 2);
            grdOrderDetail.Margin = new Padding(3, 2, 3, 2);
            grdOrderDetail.Name = "grdOrderDetail";
            grdOrderDetail.RowHeadersWidth = 51;
            grdOrderDetail.RowTemplate.Height = 29;
            grdOrderDetail.Size = new Size(534, 117);
            grdOrderDetail.TabIndex = 0;
            // 
            // OrderFormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(904, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OrderFormClient";
            Text = "Order ";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdProductList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TreeView treeViewCategory;
        private Panel panel2;
        private Button AddProduct;
        private Panel panel3;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView grdOrderDetail;
        private DataGridView grdProductList;
        private TextBox txtStatus;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtTotalPrice;
        private ComboBox cmbPayment;
        private Button btnAddOrder;
        private Button btnDeleteOrderDetail;
        private TextBox txtDescription;
        private Label lblDescription;
    }
}