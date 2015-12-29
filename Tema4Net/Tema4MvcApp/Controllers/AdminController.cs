using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tema4MvcApp.Models;

namespace Tema4MvcApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.GetAllPackages();
            var packages = new List<PackageModel>();
            if (!result.Equals("no elements"))
            {
                packages = JsonConvert.DeserializeObject<List<PackageModel>>(result);
            }
            else
            {
                ViewBag.Mess = "There isn't any package";
            }
            return View(packages);
        }

        public ActionResult StartTracking(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageResult = adminService.GetPackgeById(id);
            if (!packageResult.Equals("no element"))
            {
                var package = JsonConvert.DeserializeObject<PackageModel>(packageResult);
                var result = adminService.TrackPackage(id, package.senderCity, DateTime.Now.ToString("HH:mm"), true);
            }
            else
            {
                ViewBag.Mess = "There isn't any package";
            }

            return RedirectToAction("Index");
        }

        public ActionResult StopTracking(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var packageResult = adminService.GetPackgeById(id);
            if (!packageResult.Equals("no element"))
            {
                var package = JsonConvert.DeserializeObject<PackageModel>(packageResult);
                var result = adminService.TrackPackage(id, package.destinationCity, DateTime.Now.ToString("HH:mm"), false);
            }
            else
            {
                ViewBag.Mess = "There isn't any package";
            }

            return RedirectToAction("Index");
        }

        public ActionResult UpdateStatus(int Id)
        {
            var route = new RouteModel()
            {
                idPackage = Id,
                time = DateTime.Now.ToString("HH:mm")
            };
            return View(route);
        }

        [HttpPost]
        public ActionResult UpdateStatus(RouteModel route)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.UpdatePackageStatus(route.idPackage, route.city, route.time);
            if (result.Equals("failed"))
            {
                ViewBag.Mess = "Can't update the status";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.RemovePackage(id);
            if (result.Equals("failed"))
            {
                ViewBag.Mess = "There isn't any package";
            }
            return RedirectToAction("Index");
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
            ViewBag.PackageId = id;
            return View(routes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PackageModel package)
        {
            var adminService = new AdminService.AdminServiceSoapClient();
            var result = adminService.AddPackage(package.idSender.ToString(), package.idReceiver.ToString(), package.name, package.description, package.senderCity, package.destinationCity);
            if (result.Equals("failed"))
            {
                ViewBag.Mess = "There isn't any package";
                return View(package);
            }
            return RedirectToAction("Index");
        }
    }
}