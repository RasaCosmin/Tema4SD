using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tema4MvcApp.Models;

namespace Tema4MvcApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            var login = new LoginWebService.LoginWSClient();
            var result = login.Register(user.username, user.password);
            if(!result.Equals("failed"))
            return RedirectToAction("Index", "Login");

            ViewBag.Mess = "Registration problem! Please try again!";
            return View(user);
        }
    }
}