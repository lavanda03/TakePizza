using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using Service.Services.Category;
using Service.Services.Product;
using WinForm.Forms.CategoryForm.ViewModel;

namespace WinForm.Forms.CategoryForm
{
    public partial class CategoryForm : Form
    {
        private AddProductViewModel productViewModel = new AddProductViewModel();
        private AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();

        private CategoryService categoryService = new CategoryService();
        private ProductService productService = new ProductService();


        private DataTable grdCategoriesDt;
        private DataTable productDt;
        private DataTable cmbCategoryDt;

        public CategoryForm()
        {
            InitializeComponent();
            txtCategoryName.DataBindings
                .Add(new Binding("Text", addCategoryViewModel, nameof(addCategoryViewModel.Name), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtDescription.DataBindings
                .Add(new Binding("Text", addCategoryViewModel, nameof(addCategoryViewModel.Description), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtNameProduct.DataBindings
                .Add(new Binding("Text", productViewModel, nameof(productViewModel.Name), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtDescriptProduct.DataBindings
                .Add(new Binding("Text", productViewModel, nameof(productViewModel.Description), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtWeigthProduct.DataBindings
                .Add(new Binding("Text", productViewModel, nameof(productViewModel.Weight), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            txtPriceProduct.DataBindings
                .Add(new Binding("Text", productViewModel, nameof(productViewModel.Price), false,
                    DataSourceUpdateMode.OnPropertyChanged));
            cmbCategories.DataBindings
                .Add(new Binding("SelectedValue", productViewModel, nameof(productViewModel.CategoryId), false,
                    DataSourceUpdateMode.OnPropertyChanged));

            InitializeCategoriesDataTables();
            InitializeProductDataTable();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var newCategoryId = categoryService.AddCategory(
                    new Service.Services.Category.Models.AddCategoryCommand()
                    {
                        Name = addCategoryViewModel.Name,
                        Description = addCategoryViewModel.Description
                    });

                MessageBox.Show("Registered successfully");

                var newRow = grdCategoriesDt.NewRow();

                newRow["Id"] = newCategoryId;
                newRow["Name"] = addCategoryViewModel.Name;
                newRow["Description"] = addCategoryViewModel.Description;

                grdCategoriesDt.Rows.Add(newRow);

                grdCategoriesDt.Columns["Id"].ColumnMapping = MappingType.Hidden;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = grdCategory.SelectedRows[0].Index;

                int categoryId = Convert.ToInt32(grdCategoriesDt.Rows[rowIndex]["Id"]);
                categoryService.DeleteCategory(categoryId);
                GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnGetAllCategory_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdCategory.SelectedRows.Count <= 0)
                {
                    throw new Exception("Selected a row from category table");
                }

                int rowIndex = grdCategory.SelectedRows[0].Index;
                int categoryId = Convert.ToInt32(grdCategoriesDt.Rows[rowIndex]["Id"]);

                var updateCategoryForm = new UpdateCategoryForm(categoryService, categoryId);

                updateCategoryForm.ShowDialog();

                GetAllCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var productId = productService.AddProduct(new Service.Services.Product.Models.AddProductCommand()
                {
                    Name = productViewModel.Name,
                    Description = productViewModel.Description,
                    Weight = productViewModel.Weight,
                    Price = productViewModel.Price,
                    CategoryId = productViewModel.CategoryId
                });

                MessageBox.Show("Registered successfully");

                var newRows = productDt.NewRow();

                newRows["Id"] = productId;
                newRows["Name"] = productViewModel.Name;
                newRows["Description"] = productViewModel.Description;
                newRows["Weigth"] = productViewModel.Weight;
                newRows["Price"] = productViewModel.Price;
                newRows["CategoryId"] = productViewModel.CategoryId;

                productDt.Rows.Add(newRows);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = grdProduct.SelectedRows[0].Index;
                int productId = Convert.ToInt32(productDt.Rows[rowIndex]["Id"]);
                productService.DeleteProduct(productId);
                GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllCategories()
        {
            InitializeCategoriesDataTables();
        }

        private void GetAllProducts()
        {
            InitializeProductDataTable();
        }

        private void btnGetAllProduct_Click(object sender, EventArgs e)
        {
            try
            {
                GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdProduct.SelectedRows.Count <= 0)
                {
                    throw new Exception("Select a row");
                }

                int rowIndex = grdProduct.SelectedRows[0].Index;
                int productId = Convert.ToInt32(productDt.Rows[rowIndex]["Id"]);

                var UpdateProduct = new UpdateProductForm(productService, categoryService, productId);
                UpdateProduct.ShowDialog();

                GetAllProducts();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeCategoriesDataTables()
        {
            grdCategoriesDt = new DataTable();

            grdCategoriesDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string))
            });

            var categoryValues = categoryService.GetAllCategories();

            foreach (var categoryValue in categoryValues)
            {
                var row = grdCategoriesDt.NewRow();
                row["Id"] = categoryValue.Id;
                row["Name"] = categoryValue.Name;
                row["Description"] = categoryValue.Description;

                grdCategoriesDt.Rows.Add(row);
            }
            grdCategoriesDt.Columns["Id"].ColumnMapping = MappingType.Hidden;
            cmbCategoryDt = grdCategoriesDt.Copy();

            grdCategory.DataSource = grdCategoriesDt;
            cmbCategories.DataSource = cmbCategoryDt;

            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
        }

        private void InitializeProductDataTable()
        {
            productDt = new DataTable();

            productDt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Weigth", typeof(decimal)),
                new DataColumn("Price", typeof(double)),
                new DataColumn("CategoryId", typeof(int))
            });

            var productValues = productService.GetAllProduct();

            foreach (var productValue in productValues)
            {
                var row = productDt.NewRow();
                row["Id"] = productValue.Id;
                row["Name"] = productValue.Name;
                row["Description"] = productValue.Description;
                row["Weigth"] = productValue.Weight;
                row["Price"] = productValue.Price;
                row["CategoryId"] = productValue.CategoryId;

                productDt.Rows.Add(row);
            }

            productDt.Columns["Id"].ColumnMapping = MappingType.Hidden;
            grdProduct.DataSource = productDt;
        }

        
    }
}