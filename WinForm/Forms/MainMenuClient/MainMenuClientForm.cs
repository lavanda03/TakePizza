using WinForm.Forms.OrderFormClient;

namespace WinForm.Forms.MainMenuClient
{
    public partial class MainMenuClientForm : Form
    {
        public MainMenuClientForm()
        {
            InitializeComponent();
        }

        private void linkLabelMakingOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var orderFormClient = new OrderFormClient.OrderFormClient();
            this.Hide();
            orderFormClient.ShowDialog();
            this.Close();
        }

        private void linkLabelViewingOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var allOrderFormm = new AllOrdersByClientIdForm();
            this.Hide();
            allOrderFormm.ShowDialog();
            this.Close();
        }
    }
}