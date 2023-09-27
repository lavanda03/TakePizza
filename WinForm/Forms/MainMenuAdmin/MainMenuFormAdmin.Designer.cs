namespace WinForm.Forms.MainMenuAdmin
{
    partial class MainMenuFormAdmin
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
            label1 = new Label();
            panel1 = new Panel();
            linkLblOrders = new LinkLabel();
            linkLblUsers = new LinkLabel();
            linkLblProduct = new LinkLabel();
            linklblCategory = new LinkLabel();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 67);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(linkLblOrders);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLblUsers);
            panel1.Controls.Add(linkLblProduct);
            panel1.Controls.Add(linklblCategory);
            panel1.Location = new Point(-8, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 469);
            panel1.TabIndex = 1;
            // 
            // linkLblOrders
            // 
            linkLblOrders.AutoSize = true;
            linkLblOrders.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblOrders.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblOrders.LinkColor = Color.Black;
            linkLblOrders.Location = new Point(98, 319);
            linkLblOrders.Name = "linkLblOrders";
            linkLblOrders.Size = new Size(95, 20);
            linkLblOrders.TabIndex = 3;
            linkLblOrders.TabStop = true;
            linkLblOrders.Text = "View Orders";
            linkLblOrders.LinkClicked += linkLblOrders_LinkClicked;
            // 
            // linkLblUsers
            // 
            linkLblUsers.AutoSize = true;
            linkLblUsers.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblUsers.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblUsers.LinkColor = Color.Black;
            linkLblUsers.Location = new Point(98, 259);
            linkLblUsers.Name = "linkLblUsers";
            linkLblUsers.Size = new Size(89, 20);
            linkLblUsers.TabIndex = 2;
            linkLblUsers.TabStop = true;
            linkLblUsers.Text = "View Users";
            linkLblUsers.TextAlign = ContentAlignment.MiddleCenter;
            linkLblUsers.VisitedLinkColor = Color.Black;
            linkLblUsers.LinkClicked += linkLblUsers_LinkClicked_1;
            // 
            // linkLblProduct
            // 
            linkLblProduct.AutoSize = true;
            linkLblProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblProduct.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblProduct.LinkColor = Color.Black;
            linkLblProduct.Location = new Point(98, 199);
            linkLblProduct.Name = "linkLblProduct";
            linkLblProduct.Size = new Size(97, 20);
            linkLblProduct.TabIndex = 1;
            linkLblProduct.TabStop = true;
            linkLblProduct.Text = "Add Product";
            linkLblProduct.LinkClicked += linkLblProduct_LinkClicked;
            // 
            // linklblCategory
            // 
            linklblCategory.AutoSize = true;
            linklblCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linklblCategory.LinkBehavior = LinkBehavior.NeverUnderline;
            linklblCategory.LinkColor = Color.Black;
            linklblCategory.Location = new Point(98, 140);
            linklblCategory.Name = "linklblCategory";
            linklblCategory.Size = new Size(106, 20);
            linklblCategory.TabIndex = 0;
            linklblCategory.TabStop = true;
            linklblCategory.Text = "Add Category";
            linklblCategory.LinkClicked += linklblCategory_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(308, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 451);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 213);
            label2.Name = "label2";
            label2.Size = new Size(243, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome to the main page";
            // 
            // MainMenuFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenuFormAdmin";
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private LinkLabel linkLblOrders;
        private LinkLabel linkLblUsers;
        private LinkLabel linkLblProduct;
        private LinkLabel linklblCategory;
        private Panel panel2;
        private Label label2;
    }
}