using Service.Services.Order;
using Service.Services.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Common;
using WinForm.Forms.OrderFormClient.ViewModels;

namespace WinForm.Forms.OrderFormClient
{
    public partial class AllOrdersByClientIdForm : Form
    {
        private readonly OrderService orderService = new OrderService();
        private readonly OrderViewModel orderViewModel = new OrderViewModel();
        DataTable allOrdersDt;
        public AllOrdersByClientIdForm()
        {
            InitializeComponent();
            InitializeAllOrdersDt();

        }
        public void InitializeAllOrdersDt()
        {
            allOrdersDt = new DataTable();

            allOrdersDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id",typeof(int)),
                new DataColumn("OrderPrice",typeof(decimal)),
                new DataColumn("OrderAddres",typeof(string)),
                new DataColumn("Description",typeof(string)),
                new DataColumn("PaymentType",typeof(string))

            });


            GetAllOrdersbyUserId();
        }

        public void GetAllOrdersbyUserId()
        {
            var allOrders = orderService.GetAllOrdersByUserId(UserInfoViewModels.Id);

            foreach (var order in allOrders)
            {
                DataRow row = allOrdersDt.NewRow();
                row["Id"] = order.Id;
                row["OrderPrice"] = order.OrderPrice;
                row["OrderAddres"] = order.OrderAddress;
                row["Description"] = order.OrderDescription;
                row["PaymentType"] = order.PaymentType;


                allOrdersDt.Rows.Add(row);
                allOrdersDt.Columns["Id"].ColumnMapping = MappingType.Hidden;


            }
            grdAllOrders.DataSource = allOrdersDt;
        }
    }
}
