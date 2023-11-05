using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.User;
using Service.Services.User.Models;
using WebApp.MethodRequest;

namespace WebApp.Controllers
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
               var users=_userService.GetAllUsers();
               return Ok(users);
            }
            catch (Exception ex) 
            {
                return BadRequest();  
            }
        }

        [HttpGet("User")]
        public IActionResult GetUserById(int id) 
        {
            try
            {
               var user=_userService.GetUserById(id);
               return Ok(user); 
            }
            catch(Exception ex) 
            {
                return BadRequest();   
            }
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody]CreateUserRequest request)
        {
            try 
            {
               _userService.AddUser(new Service.Services.User.Models.AddUserCommand
                {
                  UserName=request.UserName,
                  FirstName=request.FirstName,
                  LastName=request.LastName,    
                  Email=request.Email,  
                  Password=request.Password,
                  City=request.City,
                  Country=request.Country,
                  Address=request.Address,  
                  Phone=request.Phone,  
                  Type=request.Type,
                  Gender=request.Gender,    
                  CreatedAt=request.CreatedAt,  
                });
                return CreatedAtAction("GetUserById", new { categoryId = User},User);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] UpdateUserRequest request)
        {
            try
            {
                _userService.UpdateUser(new Service.Services.User.Models.UpdateUserCommand
                {
                    Id=request.Id,  
                    UserName=request.UserName,
                    Email=request.Email,
                    City=request.City,
                    Address=request.Address,
                    Phone=request.Phone
                });
                return Ok();
            }
            catch(Exception ex ) 
            {
                return NotFound();
            }
        }

        [HttpDelete("DeleteUser")]

        public IActionResult DeleteUser(int Id)
        {
            try 
            {
                _userService.DeleteUser(Id);
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet("LoginUser")]
        public IActionResult LoginUser(string username, string password)
        {
            try
            {
                var user=_userService.LogIn(username, password);

                return Ok(user);
               
            }
            catch (Exception ex) 
            {
                return NotFound();
            }
        }

        

    }

}
