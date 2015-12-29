using Newtonsoft.Json;
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
            var userId = Convert.ToInt32(Session["userId"]);

            var packageService = new PackageWebService.PackageWSClient();
            var result = packageService.getClientPackage(userId);
            var packages = new List<PackageModel>();
            if (!result.Equals("no element"))
            {
                packages = JsonConvert.DeserializeObject<List<PackageModel>>(result);
            }
            else
            {
                ViewBag.Mess = "You don't have any package!";
            }

            return View(packages);
        }

        public ActionResult Route(int id)
        {
            var packageService = new PackageWebService.PackageWSClient();
            var result = packageService.verifyStatus(id);
            var routes = new List<RouteModel>();
            if (!result.Equals("no element"))
            {
                routes = JsonConvert.DeserializeObject<List<RouteModel>>(result);
            }
            else
            {
                ViewBag.Mess = "This package don't have any route";
            }
            return View(routes);
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