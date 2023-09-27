using System.ComponentModel;

namespace WinForm.Forms.CategoryForm;

partial class UpdateCategoryForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        llbName = new Label();
        lblDescription = new Label();
        txtName = new TextBox();
        txtDescription = new TextBox();
        btnUpdate = new Button();
        SuspendLayout();
        // 
        // llbName
        // 
        llbName.AutoSize = true;
        llbName.Location = new Point(60, 28);
        llbName.Name = "llbName";
        llbName.Size = new Size(42, 15);
        llbName.TabIndex = 0;
        llbName.Text = "Name:";
        llbName.UseWaitCursor = true;
        // 
        // lblDescription
        // 
        lblDescription.AutoSize = true;
        lblDescription.Location = new Point(24, 59);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(73, 15);
        lblDescription.TabIndex = 1;
        lblDescription.Text = "Description: ";
        lblDescription.UseWaitCursor = true;
        // 
        // txtName
        // 
        txtName.Location = new Point(110, 26);
        txtName.Margin = new Padding(3, 2, 3, 2);
        txtName.Name = "txtName";
        txtName.Size = new Size(110, 23);
        txtName.TabIndex = 2;
        txtName.UseWaitCursor = true;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(110, 59);
        txtDescription.Margin = new Padding(3, 2, 3, 2);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(110, 23);
        txtDescription.TabIndex = 3;
        txtDescription.UseWaitCursor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = SystemColors.Window;
        btnUpdate.Location = new Point(110, 101);
        btnUpdate.Margin = new Padding(3, 2, 3, 2);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(109, 22);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.UseWaitCursor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // UpdateCategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSteelBlue;
        ClientSize = new Size(353, 168);
        Controls.Add(btnUpdate);
        Controls.Add(txtDescription);
        Controls.Add(txtName);
        Controls.Add(lblDescription);
        Controls.Add(llbName);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "UpdateCategoryForm";
        Text = "Update";
        UseWaitCursor = true;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label llbName;
    private Label lblDescription;
    private TextBox txtName;
    private TextBox txtDescription;
    private Button btnUpdate;
}