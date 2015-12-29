using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema4MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var role = Session["role"];

            if(role == null)
                return RedirectToAction("Index", "Login");

            if (role.Equals("Administrator"))
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Client");
            }

            return View();
        }

       
    }
}