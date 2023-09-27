namespace WinForm.Forms.MainMenuClient
{
    partial class MainMenuClientForm
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
            linkLabelMakingOrder = new LinkLabel();
            linkLabelViewingOrders = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 75);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            // 
            // linkLabelMakingOrder
            // 
            linkLabelMakingOrder.AutoSize = true;
            linkLabelMakingOrder.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelMakingOrder.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelMakingOrder.LinkColor = Color.Black;
            linkLabelMakingOrder.Location = new Point(75, 180);
            linkLabelMakingOrder.Name = "linkLabelMakingOrder";
            linkLabelMakingOrder.Size = new Size(128, 20);
            linkLabelMakingOrder.TabIndex = 1;
            linkLabelMakingOrder.TabStop = true;
            linkLabelMakingOrder.Text = "Making The Order";
            linkLabelMakingOrder.LinkClicked += linkLabelMakingOrder_LinkClicked;
            // 
            // linkLabelViewingOrders
            // 
            linkLabelViewingOrders.AutoSize = true;
            linkLabelViewingOrders.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelViewingOrders.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelViewingOrders.LinkColor = Color.Black;
            linkLabelViewingOrders.Location = new Point(75, 255);
            linkLabelViewingOrders.Name = "linkLabelViewingOrders";
            linkLabelViewingOrders.Size = new Size(110, 20);
            linkLabelViewingOrders.TabIndex = 2;
            linkLabelViewingOrders.TabStop = true;
            linkLabelViewingOrders.Text = "Viewing Orders";
            linkLabelViewingOrders.LinkClicked += linkLabelViewingOrders_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabelViewingOrders);
            panel1.Controls.Add(linkLabelMakingOrder);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 449);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(315, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 449);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(149, 208);
            label2.Name = "label2";
            label2.Size = new Size(243, 25);
            label2.TabIndex = 0;
            label2.Text = "Welcome to the main page";
            // 
            // MainMenuClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainMenuClientForm";
            Text = "MainMenuClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabelMakingOrder;
        private LinkLabel linkLabelViewingOrders;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}