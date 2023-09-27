namespace WinForm.Forms.OrderFormClient
{
    partial class AllOrdersByClientIdForm
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
            grdAllOrders = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdAllOrders).BeginInit();
            SuspendLayout();
            // 
            // grdAllOrders
            // 
            grdAllOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAllOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            grdAllOrders.BackgroundColor = SystemColors.ButtonHighlight;
            grdAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAllOrders.Location = new Point(32, 107);
            grdAllOrders.Name = "grdAllOrders";
            grdAllOrders.RowTemplate.Height = 25;
            grdAllOrders.Size = new Size(444, 129);
            grdAllOrders.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 41);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "All My Orders";
            // 
            // AllOrdersByClientIdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(518, 315);
            Controls.Add(label1);
            Controls.Add(grdAllOrders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllOrdersByClientIdForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AllOrdersByClientIdForm";
            ((System.ComponentModel.ISupportInitialize)grdAllOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdAllOrders;
        private Label label1;
    }
}