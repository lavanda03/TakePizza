﻿namespace WebApp.Controllers.User.Models
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
