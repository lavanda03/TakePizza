namespace DataManipulation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Addrese { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; } //Admin & Client
        public string Gender { get; set; }
        public string CreatedAt { get; set; }
        public List<OrderEntity> Orders { get; set; }
    }
}