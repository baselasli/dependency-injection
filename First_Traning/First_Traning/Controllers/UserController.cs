using First_Traning.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testone.Controllers.model;

namespace First_Traning.Controllers
{
    [Controller]
    [ApiController]
    [Route("api/[controller]")]
    
    public class UserController : ControllerBase
    {
        IUser FirstUser = null;
        public UserController(IUser firstUser)
        {
            FirstUser = firstUser;
        }

        [HttpPost]
        public void addUser( Users user)
        {
            FirstUser.addUser(user);
        }
        [HttpDelete("{id}")]
        public void deleteUser(int id)
        {
            FirstUser.deleteUser(id);
        }
        [HttpGet]
        public List<Users> GetAllUsers()
        {
            return FirstUser.GetAllUsers();
        }
        [HttpGet("{id}")]
        public Users getUser(int id)
        {
            return FirstUser.getUser(id);
        }



    }
}




