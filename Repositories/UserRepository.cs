using System.Collections.Generic;
using System.Linq;
using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, Username = "batman", Password = "batman", Role = "manager"},
                new User { Id = 1, Username = "robin", Password = "robin", Role = "employee"}
            };

            return users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password.ToLower());
        }
    }
}