﻿using Microsoft.AspNetCore.Mvc;
using LoginPageCreation.Models;
using System.Collections.Generic;
using System.Linq;

namespace LoginPageCreation.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,username="naveen",password="kumar"},
                new UserModel{id=2,username="sathish",password="kumar"}
            };
            return users;
        }
        [HttpPost]
        public IActionResult Verify(UserModel usr)
        {
            var u= PutValue();
            var ue = u.Where(u => u.username.Equals(usr.username));

            var up = ue.Where(p => p.password.Equals(usr.password));

            if (up.Count()==1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}
