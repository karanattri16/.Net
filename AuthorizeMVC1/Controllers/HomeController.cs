using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthorizeMVC1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewData["data"] = User.Identity.Name;
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            
            return Redirect("/Home/Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user, string ReturnUrl)  //If Formsauthentication is not set and controller is redirected to the the Index method again the authentication
        // page will appear as we have not set the session cookie yet and hence it will not save the session data, thus the authentication data will be lost.
        {
            if(IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, true);
                return View("Index");
            }
            else
            {
                return View(user);
            }
        }

        private bool IsValid(User user)
        {
            return user.UserName == "karan" && user.Password == "attri";
        }
    }
}