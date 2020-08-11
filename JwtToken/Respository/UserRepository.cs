using JwtToken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JwtToken.Respository
{
    public class UserRepository
    {
        public static List<User> userList = new List<User>()
        {
            new User{username="Karan",password="karan123"},
            new User{username="Rupali",password="rupali123"},
            new User{username="Gunjan",password="gunjan123"}
        };

        public static User Authenticate(User user)
        {
           var User= userList.First(x => x.username == user.username && x.password == user.password);
           return User;
        }
    }
}