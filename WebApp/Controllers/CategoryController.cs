
using Microsoft.AspNetCore.Mvc;
using Service.Services.Category;
using System.Linq.Expressions;
using WebApp.MethodRequest;

namespace WebApp.Controllers
{

    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryService _categoryService = new CategoryService();


        [HttpGet("categories")]
        public IActionResult GetAllCategories()
        {
            var categories = _categoryService.GetAllCategories();

            if (categories == null)
            {
                return NotFound();
            }
            else return Ok(categories);
        }

        [HttpGet("categories/categoryId")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = _categoryService.GetCategoryById(id);
                return Ok(category);
            }

            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpPost("category/addCategory")]

        public IActionResult AddCategory([FromBody] CreateCategoryRequest request)
        {
            try
            {
                var result = _categoryService.AddCategory(new Service.Services.Category.Models.AddCategoryCommand
                {
                    Name = request.Name,
                    Description = request.Description
                });
                return CreatedAtAction("GetCategoryByID", new { categoryId = result }, result);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }
        [HttpPut("category/updateCategory")]
        public IActionResult UpdateCategory([FromBody] UpdateCategoryRequest update)
        {
            try
            {
                var existingUpdat = _categoryService.GetCategoryById(update.Id);

                _categoryService.UpdateCategory(new Service.Services.Category.Models.UpdateCategoryCommand
                {
                    Id = update.Id,
                    Name = update.Name,
                    Description = update.Description
                });
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }

        [HttpDelete("category/deleteCategory")]
        public IActionResult Delete(int id) 
        {
            try
            {
                _categoryService.DeleteCategory(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
            

        }
    }   
}
