using Service.Services.Category;
using WinForm.Forms.CategoryForm.ViewModel;

namespace WinForm.Forms.CategoryForm;

public partial class UpdateCategoryForm : Form
{
    private readonly CategoryService categoryService;
    private CategoryViewModel categoryViewModel = new CategoryViewModel();

    public UpdateCategoryForm(CategoryService categoryService, int id)
    {
        InitializeComponent();

        this.categoryService = categoryService;


        var category = categoryService.GetCategoryById(id);

        categoryViewModel.Id = id;
        categoryViewModel.Name = category.Name;
        categoryViewModel.Description = category.Description;

        txtName.DataBindings
        .Add(new Binding("Text", categoryViewModel, nameof(categoryViewModel.Name), false, DataSourceUpdateMode.OnPropertyChanged));
        txtDescription.DataBindings
        .Add(new Binding("Text", categoryViewModel, nameof(categoryViewModel.Description), false, DataSourceUpdateMode.OnPropertyChanged));
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            categoryService.UpdateCategory(new Service.Services.Category.Models.UpdateCategoryCommand
            {
                Id = categoryViewModel.Id,
                Name = categoryViewModel.Name,
                Description = categoryViewModel.Description,
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