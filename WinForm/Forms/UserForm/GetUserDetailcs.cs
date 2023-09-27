using Service.Services.User;

namespace WinForm.Forms.UserForm
{
    public partial class GetUserDetailcs : Form
    {
        private UserService userService = new UserService();

        public GetUserDetailcs(int userId)
        {
            InitializeComponent();
            LoadUserDetail(userId);
        }

        private void LoadUserDetail(int userId)
        {
            var user = userService.GetUserById(userId);
            txtUserName.Text = user.UserName;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtPhone.Text = user.Phone;
            txtCity.Text = user.City;
            txtAddress.Text = user.Addrese;
            txtGender.Text = user.Gender;
        }
    }
}