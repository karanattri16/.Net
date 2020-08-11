using JwtToken.Models;
using JwtToken.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;

namespace JwtToken.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(User user)
        {
            var output = UserRepository.Authenticate(user);
            if(output!=null)
            {
                var token= TokenManager.GenerateToken(output.username);
                return token;
            }
            return "user not found";
        }
        
        //[HttpGet]
        //public HttpResponseMessage Validate(string token, string username)
        //{
           
        //}
    }
}
