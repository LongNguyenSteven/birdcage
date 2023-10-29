using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Services;
public interface IUserService
{
    List<User> GetUsers();
    User GetUserByEmailAndPassword(String email, String password);
    User GetUserById(string id);
    User GetUserByEmail(string email);
    public void AddUser(User user);
    string GetMaxUserId();
}
