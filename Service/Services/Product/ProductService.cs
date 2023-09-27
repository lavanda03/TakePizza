using DataManipulation.Entities;
using DataManipulation.Repositories;
using Service.Services.Product.Models;

namespace Service.Services.Product;

public class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryRepository _categoryRepository;

    public ProductService()
    {
        _productRepository = new ProductRepository();
        _categoryRepository = new CategoryRepository();
    }

    public int AddProduct(AddProductCommand command)
    {
        if (string.IsNullOrEmpty(command.Name))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Name"));

        if (string.IsNullOrEmpty(command.Description))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Description"));

        if (command.Weight <= 0)
            throw new Exception(ErrorHandlerService.ParameterLessThanError("Weight", default));

        if (command.Price <= 0)
            throw new Exception(ErrorHandlerService.ParameterLessThanError("Price", default));

        if (_productRepository.ExistProductByCode(command.Name))
            throw new Exception(ErrorHandlerService.ParameterAlreadyExistsError("Product"));

        if (command.CategoryId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Id"));

        if (!_categoryRepository.ExistCategoryById(command.CategoryId))
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Category"));

        var result = new ProductEntity
        {
            Name = command.Name,
            Description = command.Description,
            Weight = command.Weight,
            Price = command.Price,
            CategoryId = command.CategoryId,
        };

        _productRepository.AddProduct(result);
        return result.Id;
    }

    public List<GetAllProduct> GetAllProductByCategoryId(int categoryId)
    {
        var productEntity = _productRepository.GetAllProductsByCategoryId(categoryId);
        var result = new List<GetAllProduct>();

        foreach (var product in productEntity)
        {
            result.Add(new GetAllProduct
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Weight = product.Weight,
                Price = product.Price,
                CategoryId = product.CategoryId
            });
        }

        return result;
    }

    public List<GetAllProduct> GetAllProduct()
    {
        var productEntity = _productRepository.GetAllProducts();
        var result = new List<GetAllProduct>();

        foreach (var product in productEntity)
        {
            result.Add(new GetAllProduct
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Weight = product.Weight,
                Price = product.Price,
                CategoryId = product.CategoryId
            });
        }

        return result;
    }

    public GetProductResult GetProductById(int productId)
    {
        if (productId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Id"));

        var productEntity = _productRepository.GetProductById(productId);


        if (productEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Product"));

        var result = new GetProductResult
        {
            Id = productEntity.Id,
            Name = productEntity.Name,
            Description = productEntity.Description,
            Weight = productEntity.Weight,
            Price = productEntity.Price,
            Category = new CategoryData
            {
                Id = productEntity.Category.Id,
                Name = productEntity.Category.Name,
                Description = productEntity.Category.Description
            }
        };

        return result;
    }

    public void UpdateProduct(UpdateProductCommand command)
    {
        if (command.Id <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Id"));

        if (string.IsNullOrEmpty(command.Name))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Name"));

        if (string.IsNullOrEmpty(command.Description))
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Description"));

        if (command.Weight <= 0)
            throw new Exception(ErrorHandlerService.ParameterLessThanError("Weight", default));

        if (command.Price <= 0)
            throw new Exception(ErrorHandlerService.ParameterLessThanError("Price", default));

        if (command.CategoryId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Category Id"));

        var productEntity = _productRepository.GetProductById(command.Id);

        if (productEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Product"));

        if (command.Name != productEntity.Description)
            productEntity.Name = command.Name;

        if (command.Description != productEntity.Description)
            productEntity.Description = command.Description;

        if (command.Weight != productEntity.Weight)
            productEntity.Weight = command.Weight;

        if (command.Price != productEntity.Price)
            productEntity.Price = command.Price;

        if (command.CategoryId != productEntity.CategoryId)
            productEntity.CategoryId = command.CategoryId;

        _productRepository.UpdateProduct(productEntity);
    }

    public void DeleteProduct(int productId)
    {
        if (productId <= 0)
            throw new Exception(ErrorHandlerService.ParameterNotValidError("Product Id"));

        var productEntity = _productRepository.GetProductById(productId);

        if (productEntity == null)
            throw new Exception(ErrorHandlerService.ParameterNotFoundError("Product"));

        _productRepository.DeleteProduct(productEntity);
    }
}