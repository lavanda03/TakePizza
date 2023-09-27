using WinForm.Forms.OrderFormAdmin;

namespace WinForm.Forms.MainMenuAdmin
{
    public partial class MainMenuFormAdmin : Form
    {
        public MainMenuFormAdmin()
        {
            InitializeComponent();
        }

        private void linklblCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var categoryForm = new CategoryForm.CategoryForm();
            this.Hide();
            categoryForm.ShowDialog();
            this.Show();
        }

        private void linkLblProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var categoryForm = new CategoryForm.CategoryForm();
            this.Hide();
            categoryForm.ShowDialog();
            this.Show();
        }

        private void linkLblUsers_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var userForm = new UserForm.UserForm();
            this.Hide();
            userForm.ShowDialog();
            this.Show();

        }

        private void linkLblOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var orderForm = new OrderFromAdmin();
            this.Hide();
            orderForm.ShowDialog();
            this.Show();
        }
    }
}


