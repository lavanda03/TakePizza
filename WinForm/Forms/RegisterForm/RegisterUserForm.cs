using Service.Services.User;
using WinForm.Forms.RegisterForm.ViewModels;

namespace WinForm.Forms.RegisterForm
{
    public partial class RegisterUserForm : Form
    {
        private RegisterViewModel registerViewModel = new RegisterViewModel();
        private UserService userService = new UserService();

        public RegisterUserForm()
        {
            InitializeComponent();

            txtUserName.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.UserName), false, DataSourceUpdateMode.OnPropertyChanged));
            txtFirstname.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.FirstName), false, DataSourceUpdateMode.OnPropertyChanged));
            txtLastName.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.LastName), false, DataSourceUpdateMode.OnPropertyChanged));
            txtEmail.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged));
            txtPassword.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged));
            txtCity.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.City), false, DataSourceUpdateMode.OnPropertyChanged));
            txtAddress.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.Address), false, DataSourceUpdateMode.OnPropertyChanged));
            txtPhone.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.Phone), false, DataSourceUpdateMode.OnPropertyChanged));
            txtCountry.DataBindings
                .Add(new Binding("Text", registerViewModel, nameof(registerViewModel.Country), false, DataSourceUpdateMode.OnPropertyChanged));
            cmbGender.DataBindings
                .Add(new Binding("SelectedItem", registerViewModel, nameof(registerViewModel.Gender), false, DataSourceUpdateMode.OnPropertyChanged));
            cmbType.DataBindings
                .Add(new Binding("SelectedItem", registerViewModel, nameof(registerViewModel.Type), false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                userService.AddUser(new Service.Services.User.Models.AddUserCommand()
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    Password = registerViewModel.Password,
                    City = registerViewModel.City,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Country = registerViewModel.Country,
                    Gender = registerViewModel.Gender,
                    Address = registerViewModel.Address,
                    Phone = registerViewModel.Phone,
                    Type = registerViewModel.Type
                });

                MessageBox.Show("Registered successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
