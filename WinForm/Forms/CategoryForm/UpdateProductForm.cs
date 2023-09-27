using Service.Services.Category;
using Service.Services.Product;
using WinForm.Forms.CategoryForm.ViewModel;

namespace WinForm.Forms.CategoryForm
{
    public partial class UpdateProductForm : Form
    {
        private ProductService productService;
        private UpdateProductViewModel updateProductViewModel = new UpdateProductViewModel();

        public UpdateProductForm(ProductService productService, CategoryService categoryService, int Id)
        {

            InitializeComponent();
            this.productService = productService;

            var product = productService.GetProductById(Id);

            updateProductViewModel.Id = Id;
            updateProductViewModel.Name = product.Name;
            updateProductViewModel.Description = product.Description;
            updateProductViewModel.Weight = product.Weight;
            updateProductViewModel.Price = product.Price;
            updateProductViewModel.CategoryId = product.CategoryId;



            txtName.DataBindings
                .Add(new Binding("text", updateProductViewModel, nameof(updateProductViewModel.Name), false, DataSourceUpdateMode.OnPropertyChanged));
            txtDescription.DataBindings
                .Add(new Binding("text", updateProductViewModel, nameof(updateProductViewModel.Description), false, DataSourceUpdateMode.OnPropertyChanged));
            txtWeigth.DataBindings
               .Add(new Binding("text", updateProductViewModel, nameof(updateProductViewModel.Weight), false, DataSourceUpdateMode.OnPropertyChanged));
            txtPrice.DataBindings
               .Add(new Binding("text", updateProductViewModel, nameof(updateProductViewModel.Price), false, DataSourceUpdateMode.OnPropertyChanged));
            cmbCategory.DataBindings
               .Add(new Binding("SelectedValue", updateProductViewModel, nameof(updateProductViewModel.CategoryId), false, DataSourceUpdateMode.OnPropertyChanged));

            var categories = categoryService.GetAllCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                productService.UpdateProduct(new Service.Services.Product.Models.UpdateProductCommand
                {
                    Name = updateProductViewModel.Name,
                    Description = updateProductViewModel.Description,
                    Weight = updateProductViewModel.Weight,
                    Price = updateProductViewModel.Price,
                    CategoryId = updateProductViewModel.CategoryId,
                    Id = updateProductViewModel.Id
                });
                MessageBox.Show("Updated category");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

}


