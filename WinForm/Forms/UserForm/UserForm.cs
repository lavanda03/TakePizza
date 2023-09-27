using Service.Services.User;
using System.Data;

namespace WinForm.Forms.UserForm
{
    public partial class UserForm : Form
    {
        private UserService userService = new UserService();

        private DataTable userDt;

        public UserForm()
        {
            InitializeComponent();
            InitializeOrderDataTable();
        }

        private void dgvUser_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvUser.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count <= 0)
            {
                throw new Exception("Select a row");
            }

            int rowIndex = dgvUser.SelectedRows[0].Index;
            int categoryId = Convert.ToInt32(userDt.Rows[rowIndex]["Id"]);

            var userDetail = new GetUserDetailcs(categoryId);
            this.Hide();
            userDetail.ShowDialog();
            this.Show();
        }

        private void InitializeOrderDataTable()
        {
            userDt = new DataTable();

            userDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("UserName", typeof(string)),
                new DataColumn("FirstName", typeof(string)),
                new DataColumn("LastName", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("CreatedAt", typeof(string))
            });

            var userValues = userService.GetAllUsers();
            foreach (var user in userValues)
            {
                var row = userDt.NewRow();
                row["Id"] = user.Id;
                row["UserName"] = user.UserName;
                row["FirstName"] = user.FirstName;
                row["LastName"] = user.LastName;
                row["Email"] = user.Email;
                row["CreatedAt"] = user.CreatedAt;

                userDt.Rows.Add(row);
            }

            userDt.Columns["Id"].ColumnMapping = MappingType.Hidden;

            dgvUser.DataSource = userDt;
        }
    }
}