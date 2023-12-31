﻿namespace Service.Services.User.Models
{
    public class GetAllUsers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CreatedAt { get; set; }
        public string Type { get; set; }
    }
}