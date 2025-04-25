using E_Learning_API.Models;
using System.Collections.Generic;

namespace E_Learning_API.Services
{
    public class UserService : IUserService {
        private readonly List<User> _users = new();

        public List<User> GetAllUser() {
            return _users;
        }
        public void CreateUser(User user) {
            _users.Add(user);
        }
    }
}