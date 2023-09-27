using DataManipulation.Entities;

namespace DataManipulation.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<UserEntity> GetAll()
        {
            return _context.Users.ToList();
        }

        public int AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public UserEntity? LogInUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower()
                                                      && u.Password.ToLower() == password.ToLower());
        }


        public bool ExistUserByUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName.ToLower() == userName.ToLower());
        }

        public bool ExistUserByEmail(string email)
        {
            return _context.Users.Any(u => u.Email.ToLower() == email.ToLower());
        }

        public UserEntity? GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateUser(UserEntity user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(UserEntity user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}