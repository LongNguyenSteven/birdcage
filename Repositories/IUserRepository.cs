﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Repositories;
public interface IUserRepository
{
    List<User> GetUsers();
    User GetUserByEmailAndPassword(String email, String password);
    User GetUserById(string id);
    User GetUserByEmail(string email);
    public void AddUser(User user);
    string GetMaxUserId();
}
