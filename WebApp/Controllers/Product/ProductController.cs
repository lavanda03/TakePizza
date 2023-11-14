using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Product;
using WebApp.Controllers.Product.Models;

namespace WebApp.Controllers.Product
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService = new ProductService();

        [HttpGet("products")]
        public IActionResult GetAllProducts()
        {
            try
            {
                var product = _productService.GetAllProduct();
                return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var productById = _productService.GetProductById(id);
                return Ok(productById);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("products/category/{id}")]
        public IActionResult GetAllProductByCategoryId(int id)
        {
            try
            {
                var products = _productService.GetAllProductByCategoryId(id);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost()]
        public IActionResult AddProduct([FromBody] CreateProductRequest request)
        {
            try
            {
                var product = _productService.AddProduct(new Service.Services.Product.Models.AddProductCommand
                {
                    Name = request.Name,
                    Description = request.Description,
                    Weight = request.Weight,
                    Price = request.Price,
                    CategoryId = request.CategoryId
                });
                return CreatedAtAction("AddProduct", new { prodcutid = product }, product);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message  );
            }
        }

        [HttpPut()]
        public IActionResult UpdateProduct([FromBody] UpdateProductRequest request)
        {
            try
            {
                _productService.UpdateProduct(new Service.Services.Product.Models.UpdateProductCommand
                {
                    Id = request.Id,
                    Name = request.Name,
                    Description = request.Description,
                    Weight = request.Weight,
                    Price = request.Price,
                    CategoryId = request.CategoryId
                });
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("{id}")]

        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _productService.DeleteProduct(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message  );
            }
        }

    }
}
