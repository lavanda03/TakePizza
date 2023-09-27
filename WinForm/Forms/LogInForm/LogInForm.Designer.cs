namespace WinForm.Forms.LogInForm
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            lblHelloLogin = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            lblRegister = new Label();
            linkLabel1 = new LinkLabel();
            btnViewPassword = new Button();
            SuspendLayout();
            // 
            // lblHelloLogin
            // 
            lblHelloLogin.AutoSize = true;
            lblHelloLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHelloLogin.Location = new Point(286, 105);
            lblHelloLogin.Name = "lblHelloLogin";
            lblHelloLogin.Size = new Size(208, 25);
            lblHelloLogin.TabIndex = 0;
            lblHelloLogin.Text = "Hello its time to log in";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(221, 140);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(66, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(298, 138);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(224, 23);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(226, 177);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(298, 175);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(298, 212);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(224, 22);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Location = new Point(148, 244);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(287, 15);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "In case if you dont have account please click that link";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(466, 244);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "REGISTER";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnViewPassword
            // 
            btnViewPassword.FlatStyle = FlatStyle.Flat;
            btnViewPassword.Image = (Image)resources.GetObject("btnViewPassword.Image");
            btnViewPassword.Location = new Point(520, 175);
            btnViewPassword.Margin = new Padding(3, 2, 3, 2);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new Size(24, 20);
            btnViewPassword.TabIndex = 8;
            btnViewPassword.UseVisualStyleBackColor = true;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewPassword);
            Controls.Add(linkLabel1);
            Controls.Add(lblRegister);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblHelloLogin);
            Name = "LogInForm";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloLogin;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Label lblRegister;
        private LinkLabel linkLabel1;
        private Button btnViewPassword;
    }
}