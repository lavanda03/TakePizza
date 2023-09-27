using DataManipulation.Entities;
using DataManipulation.Repositories;
using Service.Services.Category.Models;

namespace Service.Services.Category;

public class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService()
    {
        _categoryRepository = new CategoryRepository();  
    }

    public int AddCategory(AddCategoryCommand command)
    {
        if (string.IsNullOrEmpty(command.Name))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Name"));

        if (_categoryRepository.ExistCategoryByName(command.Name))
            throw new Exception(ErrorHandlerService.ParameterAlreadyExistsError("Category Name"));

        if (string.IsNullOrEmpty(command.Description))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Description"));
        
        var result = _categoryRepository.AddCategory(new CategoryEntity
        {
            Name = command.Name,
            Description = command.Description,

        });
        return result;
    }
    public List<GetCategoryResult> GetAllCategories()
    {
        var categoryEntity = _categoryRepository.GetAll();
        var result= new List<GetCategoryResult>();

        foreach (var category in categoryEntity)
        {
            result.Add(new GetCategoryResult
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            });
        }
        return result;
    }


    public GetCategoryResult GetCategoryById(int  categoryId)
    {
        if (categoryId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Id"));

        var categoryEntity = _categoryRepository.GetCategoryById(categoryId);

        if (categoryEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Category"));

        var result = new GetCategoryResult
        {
            Id = categoryEntity.Id,
            Name = categoryEntity.Name,
            Description = categoryEntity.Description
        };

        return result;
    }

    public void UpdateCategory(UpdateCategoryCommand command)
    {
        if (command.Id <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Id"));

        if (string.IsNullOrEmpty(command.Name))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Name"));

        if (string.IsNullOrEmpty(command.Description))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Description"));


        var categoryEntity=_categoryRepository.GetCategoryById(command.Id);

        if (categoryEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Category"));

        if (command.Name != categoryEntity.Name)
            categoryEntity.Name = command.Name;

        if (command.Description != categoryEntity.Description)  
            categoryEntity.Description = command.Description;   

        _categoryRepository.UpdateCategory(categoryEntity);  
    }

    public void DeleteCategory(int categoryId) 
    {
        if (categoryId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Id"));

        var categoryEntity= _categoryRepository.GetCategoryById(categoryId);

        if (categoryEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Category"));

        _categoryRepository.DeleteCategory(categoryEntity);

            
    }

}