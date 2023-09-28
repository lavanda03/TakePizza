using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Service.Services.User;
using Service.Services.User.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinForm.Common
{
    public static class UserInfoViewModels
    {
        public static int Id { get; set; }
        public static string UserName { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string City { get; set; }
        public static string Address { get; set; }
        public static string Phone { get; set; }
        public static string Type { get; set; }
        public static string Gender { get; set; }
       
    

        public static void SetUpUserInfo(GetUserResult userResult)
        {

            Id = userResult.Id;
            UserName = userResult.UserName;
            FirstName= userResult.FirstName;
            LastName = userResult.LastName;
            Email = userResult.Email;
            Password = userResult.Password;
            City = userResult.City;
            Address = userResult.Address;
            Phone = userResult.Phone;
            Type = userResult.Type;
            Gender = userResult.Gender;
 
        }

   
    }
}
