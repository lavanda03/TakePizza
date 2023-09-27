using Service.Services.User;
using WinForm.Common;
using WinForm.Forms.LogInForm.ViewModel;
using WinForm.Forms.MainMenuAdmin;
using WinForm.Forms.MainMenuClient;
using WinForm.Forms.RegisterForm;

namespace WinForm.Forms.LogInForm
{
    public partial class LogInForm : Form
    {
        private LogInViewModel logInViewModel = new LogInViewModel();
        private UserService userService = new UserService();

        public LogInForm()
        {
            InitializeComponent();

            txtPassword.DataBindings
                .Add(new Binding("Text", logInViewModel, "Password", false, DataSourceUpdateMode.OnPropertyChanged));
            txtUserName.DataBindings
                .Add(new Binding("Text", logInViewModel, "UserName", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            var userResult = userService.LogIn(logInViewModel.UserName, logInViewModel.Password);

            if (userResult == null)
            {
                MessageBox.Show(MessageTexts.NotValidOperationMessageText);

                logInViewModel.UserName = string.Empty;
                logInViewModel.Password = string.Empty;
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;

                return;
            }

            MessageBox.Show(MessageTexts.SuccesfullMessageText);

            Form menuForm;

            if (userResult.Type.ToLower() == Common.Constants.AdminUserType)
            {
                menuForm = new MainMenuFormAdmin();
            }
            else
            {
                menuForm = new MainMenuClientForm();
            }

            this.Hide();
            menuForm.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterUserForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '*')
            {
                txtPassword.PasswordChar = '*';
            }
            else { txtPassword.PasswordChar = '\0'; }
        }

        private void order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var orderForm = new OrderFormClient.OrderFormClient();
            this.Hide();
            orderForm.ShowDialog();
            this.Show();


        }

        private void linkLabelAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuForm;
            menuForm = new MainMenuFormAdmin();

            this.Hide();
            menuForm.ShowDialog();
            this.Show();
        }

        private void linkLabelClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuForm;


            menuForm = new MainMenuClientForm();


            this.Hide();
            menuForm.ShowDialog();
            this.Show();
        }
    }
}