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
        public ActionResult Index(string searchString)
        {
            var userId = Convert.ToInt32(Session["userId"]);
            var packageService = new PackageWebService.PackageWSClient();
            var packages = new List<PackageModel>();
            var packagesV = new List<PackageModelV>();

            if (string.IsNullOrEmpty(searchString))
            {
                var result = packageService.getClientPackage(userId);
               
                if (!result.Equals("no element"))
                {
                    packages = JsonConvert.DeserializeObject<List<PackageModel>>(result);
                    foreach(var p in packages)
                    {
                        var pack = new PackageModelV
                        {
                            id = p.id,
                            description = p.description,
                            destinationCity = p.destinationCity,
                            name = p.name,
                            senderCity = p.senderCity,
                            tracking = p.tracking,
                            Sender = packageService.getClientNameById(p.idSender),
                            Receiver = packageService.getClientNameById(p.idReceiver)
                        };

                        packagesV.Add(pack);
                    }
                }
                else
                {
                    ViewBag.Mess = "You don't have any package!";
                }

               
            }
            else
            {
                var result = packageService.search(searchString, userId);
               
                if (!result.Equals("no element"))
                {
                    packages = JsonConvert.DeserializeObject<List<PackageModel>>(result);
                    foreach (var p in packages)
                    {
                        var pack = new PackageModelV
                        {
                            id = p.id,
                            description = p.description,
                            destinationCity = p.destinationCity,
                            name = p.name,
                            senderCity = p.senderCity,
                            tracking = p.tracking,
                            Sender = packageService.getClientNameById(p.idSender),
                            Receiver = packageService.getClientNameById(p.idReceiver)
                        };

                        packagesV.Add(pack);
                    }
                }
                else
                {
                    ViewBag.Mess = "You don't have any package!";
                }

                
            }

            return View(packagesV);
        }

        public ActionResult Route(int id)
        {
            var packageService = new PackageWebService.PackageWSClient();
            var result = packageService.verifyStatus(id);
            var routes = new List<RouteModel>();
            var routesV = new List<RouteModelV>();
            if (!result.Equals("no element"))
            {
                routes = JsonConvert.DeserializeObject<List<RouteModel>>(result);
                foreach (var r in routes)
                {
                    var route = new RouteModelV()
                    {
                        id = r.id,
                        city = r.city,
                        Package = packageService.getPackageNameById(r.idPackage),
                        time = r.time
                    };
                    routesV.Add(route);
                }
            }
            else
            {
                ViewBag.Mess = "This package don't have any route";
            }
            return View(routesV);
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