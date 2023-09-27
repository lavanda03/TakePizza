using Service.Services.Order;
using System.Data;


namespace WinForm.Forms.OrderFormAdmin
{
    public partial class OrderFromAdmin : Form
    {
        private OrderService orderService = new OrderService();
        private DataTable orderDt;

        public OrderFromAdmin()
        {
            InitializeComponent();
            InitializeOrderDataTable();
        }

        private void InitializeOrderDataTable()
        {
            orderDt = new DataTable();

            orderDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("OrderPrice", typeof(decimal)),
                new DataColumn("OrderAddress", typeof(string)),
                new DataColumn("OrderDescription", typeof(string)),
                new DataColumn("PaymentType", typeof(string)),
                new DataColumn("Status", typeof(string)),
                new DataColumn("UserId", typeof(int)),
            });

            QueryOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QueryOrders();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            orderDt.Rows.Clear();
            this.cmbPaymentType.SelectedItem = null;
            this.cmbStatusType.SelectedItem = null;
        }

        private void QueryOrders()
        {
            orderDt.Rows.Clear();

            var orderValue = orderService.QueryOrders(new Service.Services.Order.Models.QueryOrdersCriteria
            {
                StatusType = cmbStatusType.SelectedItem != null ? cmbStatusType.SelectedItem.ToString() : "",
                PaymentType = cmbPaymentType.SelectedItem != null ? cmbPaymentType.SelectedItem.ToString() : ""
            });

            foreach (var order in orderValue)
            {
                var row = orderDt.NewRow();
                row["Id"] = order.Id;
                row["OrderPrice"] = order.OrderPrice;
                row["OrderAddress"] = order.OrderAddress;
                row["OrderDescription"] = order.OrderDescription;
                row["PaymentType"] = order.PaymentType;
                row["Status"] = order.Status;
                row["UserId"] = order.UserId;

                orderDt.Rows.Add(row);
                orderDt.Columns["Id"].ColumnMapping = MappingType.Hidden;
            }

            grdOrderList.DataSource = orderDt;
        }
    }
}