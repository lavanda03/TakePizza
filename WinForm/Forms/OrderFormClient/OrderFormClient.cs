using System.Data;
using Service.Services.Category;
using Service.Services.Order;
using Service.Services.Order.Models;
using Service.Services.Product;
using Service.Services.Product.Models;
using WinForm.Forms.OrderFormClient.ViewModels;


namespace WinForm.Forms.OrderFormClient
{
    public partial class OrderFormClient : Form
    {
        private CategoryService categoryService = new CategoryService();
        private ProductService productService = new ProductService();
        private OrderService orderService = new OrderService();

        private OrderViewModel OrderViewModel = new OrderViewModel();

        private DataTable productDt;
        private DataTable orderDetailDt;

        public OrderFormClient()
        {
            InitializeComponent();

            txtTotalPrice.DataBindings
                .Add(new Binding("Text", OrderViewModel, nameof(OrderViewModel.OrderPrice), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtAddress.DataBindings
                .Add(new Binding("Text", OrderViewModel, nameof(OrderViewModel.OrderAddress), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtStatus.DataBindings
                .Add(new Binding("Text", OrderViewModel, nameof(OrderViewModel.Status), false,
                    DataSourceUpdateMode.OnValidation));
            txtDescription.DataBindings
                .Add(new Binding("Text", OrderViewModel, nameof(OrderViewModel.OrderDescription), false,
                    DataSourceUpdateMode.OnValidation));
            cmbPayment.DataBindings
                .Add(new Binding("SelectedItem", OrderViewModel, nameof(OrderViewModel.PaymentType), false,
                    DataSourceUpdateMode.OnPropertyChanged));

            InitializeProductDt();
            InitializeOrderDetailDt();
            InitializeCategoriesTreeView();
        }


        private void treeViewCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is int categoryId)
            {
                InitializeProductDtByCategoryId(categoryId);
            }
        }

        private List<GetAllProduct> GetAllProductByCategoryId(int id)
        {
            var product = productService.GetAllProductByCategoryId(id);
            return product;
        }

        private void InitializeProductDtByCategoryId(int categoryId)
        {
            var products = GetAllProductByCategoryId(categoryId);

            productDt.Rows.Clear();

            foreach (var product in products)
            {
                var newRow = productDt.NewRow();

                newRow["Id"] = product.Id;
                newRow["Name"] = product.Name;
                newRow["Description"] = product.Description;
                newRow["Price"] = product.Price;
                newRow["Weight"] = product.Weight;

                productDt.Rows.Add(newRow);
            }
        }

        private void InitializeProductDt()
        {
            productDt = new DataTable();
            productDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Price", typeof(decimal)),
                new DataColumn("Weight", typeof(double))
            });

            grdProductList.DataSource = productDt;
        }

        private void InitializeCategoriesTreeView()
        {
            var categories = categoryService.GetAllCategories();

            foreach (var category in categories)
            {
                TreeNode treeNode = new TreeNode
                {
                    Text = category.Name,
                    Tag = category.Id
                };
                treeViewCategory.Nodes.Add(treeNode);
            }
        }

        private void InitializeOrderDetailDt()
        {
            orderDetailDt = new DataTable();
            orderDetailDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("OrderId", typeof(int)),
                new DataColumn("ProductId", typeof(int)),
                new DataColumn("ProductName", typeof(string)),
                new DataColumn("Amount", typeof(int)),
                new DataColumn("Price", typeof(decimal)),
            });
            orderDetailDt.Columns["Id"].ColumnMapping = MappingType.Hidden;
            orderDetailDt.Columns["OrderId"].ColumnMapping = MappingType.Hidden;

            grdOrderDetail.DataSource = orderDetailDt;
        }


        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdProductList.SelectedRows.Count <= 0)
                {
                    throw new Exception("Select a row");
                }

                int rowIndex = grdProductList.SelectedRows[0].Index;
                var productRow = grdProductList.Rows[rowIndex];

                var productId = Convert.ToInt32(productRow.Cells["Id"].Value);

                if (orderDetailDt.Rows.Cast<DataRow>().Any(r => Convert.ToInt32(r["ProductId"]) == productId))
                {
                    var orderDetailRow = orderDetailDt.Rows.Cast<DataRow>()
                        .FirstOrDefault(r => Convert.ToInt32(r["ProductId"]) == productId);

                    if (orderDetailRow == null)
                        return;

                    orderDetailRow["Amount"] = Convert.ToInt32(orderDetailRow["Amount"]) + 1;
                    orderDetailRow["Price"] = Convert.ToDecimal(orderDetailRow["Price"]) +
                                              Convert.ToDecimal(productRow.Cells["Price"].Value);
                }
                else
                {
                    var newRow = orderDetailDt.NewRow();
                    newRow["ProductId"] = productRow.Cells["Id"].Value;
                    newRow["ProductName"] = productRow.Cells["Name"].Value;
                    newRow["Amount"] = 1;
                    newRow["Price"] = productRow.Cells["Price"].Value;
                    orderDetailDt.Rows.Add(newRow);
                }

                OrderCalculatePrice();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderCalculatePrice()
        {
            decimal sum = 0;
            foreach (DataRow row in orderDetailDt.Rows)
            {
                sum += Convert.ToDecimal(row["Price"]);
            }

            OrderViewModel.OrderPrice = sum;
            txtTotalPrice.Text = sum.ToString();
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdOrderDetail.SelectedRows.Count > 0)
                {
                    var productId = Convert.ToInt32(grdOrderDetail.SelectedRows[0].Cells["ProductId"].Value.ToString());

                    var product = orderDetailDt.Rows.Cast<DataRow>()
                        .FirstOrDefault(r => (int)r["ProductId"] == productId);

                    if (product != null)
                    {
                        orderDetailDt.Rows.Remove(product);
                        OrderCalculatePrice();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (orderDetailDt.Rows.Count > 0)
            {
                orderService.AddOrder(new AddOrderCommand
                {
                    OrderAddress = OrderViewModel.OrderAddress,
                    OrderDescription = OrderViewModel.OrderDescription,
                    OrderPrice = OrderViewModel.OrderPrice,
                    PaymentType = OrderViewModel.PaymentType,
                    Status = OrderViewModel.Status,
                    UserId = OrderViewModel.UserId,
                    OrderDetails = new List<AddOrderDetailCommand>(orderDetailDt.Rows.Cast<DataRow>().Select(x =>
                        new AddOrderDetailCommand
                        {
                            ProductId = (int)x["ProductId"],
                            TotalPrice = (decimal)x["Price"],
                            TotalQuantity = (int)x["Amount"]
                        }))
                });
                MessageBox.Show("Order successfully registered");
            }
            else
            {
                MessageBox.Show("Please select products and complete the order info!");
            }

            orderDetailDt.Rows.Clear();
        }
    }
}