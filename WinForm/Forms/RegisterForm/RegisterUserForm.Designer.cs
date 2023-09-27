namespace WinForm.Forms.RegisterForm
{
    partial class RegisterUserForm
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
            lblHeaderInfo = new Label();
            lblUserName = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            txtUserName = new TextBox();
            txtFirstname = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            cmbGender = new ComboBox();
            btnRegister = new Button();
            lblCountry = new Label();
            txtCountry = new TextBox();
            label1 = new Label();
            cmbType = new ComboBox();
            SuspendLayout();
            // 
            // lblHeaderInfo
            // 
            lblHeaderInfo.AutoSize = true;
            lblHeaderInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderInfo.Location = new Point(38, 22);
            lblHeaderInfo.Name = "lblHeaderInfo";
            lblHeaderInfo.Size = new Size(127, 19);
            lblHeaderInfo.TabIndex = 0;
            lblHeaderInfo.Text = "Please insert data";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(39, 64);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(63, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(35, 89);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(39, 112);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(275, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(275, 148);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 6;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(39, 169);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(39, 194);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(280, 175);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(116, 59);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(110, 23);
            txtUserName.TabIndex = 11;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(116, 86);
            txtFirstname.Margin = new Padding(3, 2, 3, 2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(110, 23);
            txtFirstname.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(116, 109);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(110, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 134);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 118);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(123, 23);
            txtPassword.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(346, 145);
            txtCity.Margin = new Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(123, 23);
            txtCity.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(116, 161);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(110, 23);
            txtAddress.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(116, 191);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 18;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(346, 172);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(123, 23);
            cmbGender.TabIndex = 19;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Window;
            btnRegister.Location = new Point(264, 258);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 22);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(275, 62);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 21;
            lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(346, 61);
            txtCountry.Margin = new Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(123, 23);
            txtCountry.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 92);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 23;
            label1.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Admin", "Client" });
            cmbType.Location = new Point(346, 89);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(123, 23);
            cmbType.TabIndex = 24;
            // 
            // RegisterUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(cmbType);
            Controls.Add(label1);
            Controls.Add(txtCountry);
            Controls.Add(lblCountry);
            Controls.Add(btnRegister);
            Controls.Add(cmbGender);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstname);
            Controls.Add(txtUserName);
            Controls.Add(lblGender);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblCity);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblUserName);
            Controls.Add(lblHeaderInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterUserForm";
            Text = "Register ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeaderInfo;
        private Label lblUserName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblCity;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblGender;
        private TextBox txtUserName;
        private TextBox txtFirstname;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private ComboBox cmbGender;
        private Button btnRegister;
        private Label lblCountry;
        private TextBox txtCountry;
        private Label label1;
        private ComboBox cmbType;
    }
}