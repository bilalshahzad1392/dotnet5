using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        IConfiguration myconfig;
        public UserController(IConfiguration config)
        {
            myconfig = config;
        }
        public IActionResult Login()
        {
            var a = myconfig["AllowedHosts"];
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginInfo userObj)
        {
            if(UserModel.ValidateUser(userObj.Login, userObj.Password) == true)
            {
                this.HttpContext.Session.SetString("Login", userObj.Login); 
                return Redirect("~/Home/Index");
            }
            else
            {
                ViewBag.Error = "Invalid Login/Password";
                return View("Login");
            }
            
        }
        public IActionResult AllUsers()
        {
            var users = UserModel.GetUsers();
            return View(users);
        }
    }
}
