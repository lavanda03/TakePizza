using System.Globalization;
using DataManipulation.Repositories;
using Service.Services.User.Models;
using System.Text.RegularExpressions;

namespace Service.Services.User
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public GetUserResult? LogIn(string username, string password)
        {
            var userEntity = _userRepository.LogInUser(username, password);

            if (userEntity == null)
            {
                return null;
            }

            var result = new GetUserResult()
            {
                Id = userEntity.Id,
                UserName = userEntity.UserName,
                LastName = userEntity.LastName,
                Email = userEntity.Email,
                FirstName = userEntity.FirstName,
                Type = userEntity.Type,
            };

            return result;
        }

        private bool IsValidEmail(string email)
        {
            bool upperCase = Regex.IsMatch(email, "[A-Z]");
            bool lowerCase = Regex.IsMatch(email, "[a-z]");
            bool digits = Regex.IsMatch(email, "[0-9]");

            if (!upperCase || !lowerCase || !digits)
                return false;

            return true;
        }

        private bool IsValidPhone(string phoneNumber)
        {
            foreach (char digit in phoneNumber)
            {
                if (!char.IsDigit(digit) && !char.IsSymbol('+'))
                {
                    return false;
                }
            }

            return true;
        }

        public int AddUser(AddUserCommand command)
        {
            if (string.IsNullOrEmpty(command.UserName))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Username"));

            if (_userRepository.ExistUserByUserName(command.UserName))
                throw new Exception(ErrorHandlerService.ParameterAlreadyExistsError("Username"));

            if (string.IsNullOrEmpty(command.FirstName))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("First name"));

            if (string.IsNullOrEmpty(command.LastName))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Last name"));

            if (string.IsNullOrEmpty(command.City))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("City"));

            if (string.IsNullOrEmpty(command.Address))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Address"));

            if (string.IsNullOrEmpty(command.Password))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Password"));

            if (IsValidEmail(command.Email) || string.IsNullOrEmpty(command.Email))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Email"));

            if (_userRepository.ExistUserByEmail(command.Email))
                throw new Exception(ErrorHandlerService.ParameterAlreadyExistsError("Email"));

            if (!IsValidPhone(command.Phone))
            {
                throw new Exception(ErrorHandlerService.ParameterMustHaveError("Phone", new []{"digits"}));
            }

            if (string.IsNullOrEmpty(command.Gender))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Gender")); 

            var result = _userRepository.AddUser(new DataManipulation.Entities.UserEntity
            {
                UserName = command.UserName,
                FirstName = command.FirstName,
                LastName = command.LastName,
                City = command.City,
                Addrese = command.Address,
                Password = command.Password,
                Gender = command.Gender,
                Email = command.Email,
                Phone = command.Phone,
                Type = command.Type,
                CreatedAt = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                Country = command.Country,
            });

            return result;
        }

        public List<GetAllUsers> GetAllUsers()
        {
            var userEntity = _userRepository.GetAll();
            var result = new List<GetAllUsers>();

            foreach (var user in userEntity)
            {
                result.Add(new GetAllUsers
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    CreatedAt = user.CreatedAt,
                    Type = user.Type
                });
            }

            return result;
        }

        public GetUserResult GetUserById(int userId)
        {
            if (userId <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("User Id"));

            var userEntity = _userRepository.GetUserById(userId);

            if (userEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("User"));

            var result = new GetUserResult
            {
                Id = userEntity.Id,
                UserName = userEntity.UserName,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                City = userEntity.City,
                Addrese = userEntity.Addrese,
                Password = userEntity.Password,
                Email = userEntity.Email,
                Phone = userEntity.Phone
            };
            return result;
        }

        public void UpdateUser(UpdateUserCommand command)
        {
            if (command.Id <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("User Id"));

            if (string.IsNullOrEmpty(command.UserName))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Username"));

            if (_userRepository.ExistUserByUserName(command.UserName))
                throw new Exception(ErrorHandlerService.ParameterAlreadyExistsError("Username"));

            if (IsValidEmail(command.Email) || string.IsNullOrEmpty(command.Email))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Email"));

            if (string.IsNullOrEmpty(command.Address))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Address"));

            if (string.IsNullOrEmpty(command.Phone))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Phone"));

            if (!IsValidPhone(command.Phone))
            {
                throw new Exception(ErrorHandlerService.ParameterMustHaveError("Phone", new []{"digits"}));
            }

            if (string.IsNullOrEmpty(command.City))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("City"));

            var userEntity = _userRepository.GetUserById(command.Id);

            if (userEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("User"));

            if (command.UserName != userEntity.UserName)
                userEntity.UserName = command.UserName;

            if (command.Email != userEntity.Email)
                userEntity.Email = command.Email;

            if (command.Phone != userEntity.Phone)
                userEntity.Phone = command.Phone;

            if (command.City != userEntity.City)
                userEntity.City = command.City;

            if (command.Address != userEntity.Addrese)
                userEntity.Addrese = command.Address;

            _userRepository.UpdateUser(userEntity);
        }

        public void DeleteUser(int userId)
        {
            if (userId <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("User Id"));

            var userEntity = _userRepository.GetUserById(userId);
            
            if(userEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("User"));

            _userRepository.DeleteUser(userEntity);
        }
    }
}