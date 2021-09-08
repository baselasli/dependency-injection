using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testone.Controllers.model;

namespace First_Traning.models
{
    public class UserServices : IUser
    {
        public List<Users> MyList = new List<Users>
        {
            //new user{1,"basel",new DateTime(1997/6/17),"0507966332","baselasli48@hotmail.com"}

            new Users(1, "basel", new DateTime(1997,12,12), "0507966332", "baselasli48@hotmail.com"),
            new Users(2, "basel", new DateTime(1997,12,12), "0507966332", "baselasli48@hotmail.com"),
            new Users(3, "basel", new DateTime(1997,12,12), "0507966332", "baselasli48@hotmail.com"),
            new Users(4, "basel", new DateTime(1997,12,12), "0507966332", "baselasli48@hotmail.com"),
            new Users(5, "basel", new DateTime(1997,12,12), "0507966332", "baselasli48@hotmail.com")
        };
        public void addUser(Users user)
        {
            MyList.Add(user);
        }
        [HttpDelete("{id}")]
        public void deleteUser(int id)
        {
            var filteredUsers = MyList.FirstOrDefault(user => user.id.Equals(id));
            if (filteredUsers != null)
                MyList.Remove(filteredUsers);
        }

        [HttpGet]
        public List<Users> GetAllUsers()
        {
            return MyList;
        }

        [HttpGet("{id}")]
        public Users getUser(int id)
        {
            return MyList.FirstOrDefault(user => user.id.Equals(id));
        }
    }
}
