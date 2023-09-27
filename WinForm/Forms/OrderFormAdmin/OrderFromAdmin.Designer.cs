namespace WinForm.Forms.OrderFormAdmin
{
    partial class OrderFromAdmin
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
            grdOrderList = new DataGridView();
            cmbPaymentType = new ComboBox();
            label1 = new Label();
            lblStatusType = new Label();
            cmbStatusType = new ComboBox();
            btnRefresh = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)grdOrderList).BeginInit();
            SuspendLayout();
            // 
            // grdOrderList
            // 
            grdOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdOrderList.BackgroundColor = SystemColors.ButtonFace;
            grdOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrderList.Location = new Point(25, 69);
            grdOrderList.Name = "grdOrderList";
            grdOrderList.RowHeadersWidth = 51;
            grdOrderList.RowTemplate.Height = 25;
            grdOrderList.Size = new Size(704, 286);
            grdOrderList.TabIndex = 0;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Cash", "Card" });
            cmbPaymentType.Location = new Point(130, 26);
            cmbPaymentType.Margin = new Padding(3, 2, 3, 2);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(133, 23);
            cmbPaymentType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Payment Type:";
            // 
            // lblStatusType
            // 
            lblStatusType.AutoSize = true;
            lblStatusType.Location = new Point(284, 28);
            lblStatusType.Name = "lblStatusType";
            lblStatusType.Size = new Size(69, 15);
            lblStatusType.TabIndex = 3;
            lblStatusType.Text = "Status Type:";
            // 
            // cmbStatusType
            // 
            cmbStatusType.FormattingEnabled = true;
            cmbStatusType.Items.AddRange(new object[] { "Pending", "Approved", "Rejected" });
            cmbStatusType.Location = new Point(366, 26);
            cmbStatusType.Margin = new Padding(3, 2, 3, 2);
            cmbStatusType.Name = "cmbStatusType";
            cmbStatusType.Size = new Size(133, 23);
            cmbStatusType.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Window;
            btnRefresh.Location = new Point(536, 26);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Window;
            btnClear.Location = new Point(623, 26);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // OrderFromAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(766, 367);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(cmbStatusType);
            Controls.Add(lblStatusType);
            Controls.Add(label1);
            Controls.Add(cmbPaymentType);
            Controls.Add(grdOrderList);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderFromAdmin";
            Text = "OrderFromAdmin";
            ((System.ComponentModel.ISupportInitialize)grdOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdOrderList;
        private ComboBox cmbPaymentType;
        private Label label1;
        private Label lblStatusType;
        private ComboBox cmbStatusType;
        private Button btnRefresh;
        private Button btnClear;
    }
}