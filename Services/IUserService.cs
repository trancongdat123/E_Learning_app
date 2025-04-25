using E_Learning_API.Models;
using System.Collections.Generic;

namespace E_Learning_API.Services {
    
    public interface IUserService
    {
        List<User> GetAllUsers();
        void CreateUser(User user);
    } 
}