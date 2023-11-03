using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Product;
using WebApp.Controllers;
using WebApp.MethodRequest;

namespace WebApp.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService = new ProductService();

        [HttpGet("categories")]
        public IActionResult GetAllProducts()
        {
            try
            {
               var product=_productService.GetAllProduct();
               return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [HttpGet("productId")]
        public IActionResult GetProductById(int id) 
        {
            try 
            {
                var productById=_productService.GetProductById(id);
                return Ok(productById); 
            }
            catch(Exception ex) 
            {
                return NotFound();
            }
        }

        [HttpGet("allProductByCategoryId")]
        public IActionResult GetAllProductByCategoryId(int categoryId) 
        {
            try 
            {
              var products=_productService.GetAllProductByCategoryId(categoryId);   
              return Ok(products);  
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost("addProduct")]
        public IActionResult AddCategory([FromBody]CreateProductRequest request)
        {
            try
            {
                var product = _productService.AddProduct(new Service.Services.Product.Models.AddProductCommand
                {
                    Name=request.Name,
                    Description=request.Description,
                    Weight=request.Weight,
                    Price=request.Price,   
                    CategoryId=request.CategoryId
                });
                return CreatedAtAction("GetProductById", new { categoryid = product }, product);
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct([FromBody]UpdateProductRequest request)
        {
            try 
            {
                  _productService.UpdateProduct(new Service.Services.Product.Models.UpdateProductCommand
                {
                    Id=request.Id,  
                    Name=request.Name,
                    Description=request.Description,    
                    Weight=request.Weight,  
                    Price=request.Price,    
                    CategoryId=request.CategoryId   
                });
                return NoContent();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }
        [HttpDelete("deleteProduct")]

        public IActionResult DeleteProduct(int id) 
        {
            try
            {
                _productService.DeleteProduct(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

    }
}
