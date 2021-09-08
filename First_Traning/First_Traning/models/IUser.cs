using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testone.Controllers.model;

namespace First_Traning.models
{
    public interface IUser
    {
        Users getUser(int id);
        List<Users> GetAllUsers();
        void deleteUser(int id);
        void addUser(Users user);
    }
}
