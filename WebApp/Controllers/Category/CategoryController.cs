
using Microsoft.AspNetCore.Mvc;
using Service.Services.Category;
using System.Linq.Expressions;
using WebApp.Controllers.Category.Models;

namespace WebApp.Controllers.Category
{

    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryService _categoryService = new CategoryService();


        [HttpGet("categories")]
        public IActionResult GetAllCategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = _categoryService.GetCategoryById(id);
                return Ok(category);
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpPost()]

        public IActionResult AddCategory([FromBody] CreateCategoryRequest request)
        {
            try
            {
                var result = _categoryService.AddCategory(new Service.Services.Category.Models.AddCategoryCommand
                {
                    Name = request.Name,
                    Description = request.Description
                });
                return CreatedAtAction("AddCategory", new { categoryId = result }, result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
        [HttpPut()]
        public IActionResult UpdateCategory([FromBody] UpdateCategoryRequest update)
        {
            try
            {
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
                return NotFound(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                _categoryService.DeleteCategory(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }


        }
    }
}
