using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.User;
using Service.Services.User.Models;
using WebApp.Controllers.User.Models;

namespace WebApp.Controllers.User
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService = new UserService();

        [HttpGet("Users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _userService.GetUserById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("")]
        public IActionResult AddUser([FromBody] CreateUserRequest request)
        {
            try
            {
                _userService.AddUser(new AddUserCommand
                {
                    UserName = request.UserName,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Password = request.Password,
                    City = request.City,
                    Country = request.Country,
                    Address = request.Address,
                    Phone = request.Phone,
                    Type = request.Type,
                    Gender = request.Gender,
                    CreatedAt = request.CreatedAt,
                });
                return CreatedAtAction("AddUser", new { categoryId = User }, User);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("")]
        public IActionResult UpdateUser([FromBody] UpdateUserRequest request)
        {
            try
            {
                _userService.UpdateUser(new UpdateUserCommand
                {
                    Id = request.Id,
                    UserName = request.UserName,
                    Email = request.Email,
                    City = request.City,
                    Address = request.Address,
                    Phone = request.Phone
                });
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteUser(int Id)
        {
            try
            {
                _userService.DeleteUser(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("login/{username}/{password}")]
        public IActionResult LoginUser(string username, string password)
        {
            try
            {
                var user = _userService.LogIn(username, password);

                return Ok(user);

            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }



    }

}
